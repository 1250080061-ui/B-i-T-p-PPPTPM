using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDatPhong : Form
    {
        private readonly DatPhongService s =
            new DatPhongService();

        private readonly DanhMucService dm =
            new DanhMucService();

        private readonly BindingList<PhongDatItem> dsPhongChon =
            new BindingList<PhongDatItem>();

        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            cboKenh.Items.Clear();
            cboKenh.Items.AddRange(new object[]
            {
                "Điện thoại",
                "Website",
                "Trực tiếp"
            });

            if (cboKenh.Items.Count > 0)
                cboKenh.SelectedIndex = 0;

            dgvChon.DataSource = dsPhongChon;

            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            dgvKhach.DataSource = s.LayKhach();
            dgvPhong.DataSource = s.LayPhong();
            dgvPhieu.DataSource = s.LayPhieuDat();

            cboKhach.DataSource = s.LayKhach();
            cboKhach.DisplayMember = "HoTen";
            cboKhach.ValueMember = "MaKhach";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";
        }

        private string V(ComboBox cbo)
        {
            return cbo.SelectedValue == null
                ? ""
                : cbo.SelectedValue.ToString();
        }

        private void XuLyKetQua(KetQuaXuLy kq)
        {
            MessageBox.Show(
                kq.ThongBao,
                "Thông báo",
                MessageBoxButtons.OK,
                kq.ThanhCong
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
                TaiDuLieu();
        }

        // =====================================
        // THÊM KHÁCH HÀNG
        // =====================================
        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            XuLyKetQua(
                s.ThemKhach(
                    txtMaKH.Text.Trim(),
                    txtTenKH.Text.Trim(),
                    txtCMND.Text.Trim(),
                    txtQT.Text.Trim(),
                    txtSDT.Text.Trim()
                )
            );
        }

        // =====================================
        // THÊM PHÒNG VÀO PHIẾU
        // =====================================
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một phòng.");
                return;
            }

            string soPhong =
                Convert.ToString(
                    dgvPhong.CurrentRow.Cells["SoPhong"].Value);

            decimal donGia =
                Convert.ToDecimal(
                    dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value);

            foreach (PhongDatItem item in dsPhongChon)
            {
                if (item.SoPhong == soPhong)
                {
                    MessageBox.Show(
                        "Phòng này đã có trong danh sách chọn.");

                    return;
                }
            }

            dsPhongChon.Add(
                new PhongDatItem
                {
                    SoPhong = soPhong,
                    SoNguoi = (int)numSoNguoi.Value,
                    DonGiaNgay = donGia
                });
        }

        private void btnBoPhong_Click(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow == null)
                return;

            int i = dgvChon.CurrentRow.Index;

            if (i >= 0 && i < dsPhongChon.Count)
                dsPhongChon.RemoveAt(i);
        }

        // =====================================
        // LẬP PHIẾU ĐẶT PHÒNG
        // =====================================
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            var kq = s.TaoDatPhong(
                txtSoPhieu.Text.Trim(),
                V(cboKhach),
                V(cboNV),
                dtLap.Value,
                dtNhan.Value,
                dtTra.Value,
                numCoc.Value,
                cboKenh.Text,
                new List<PhongDatItem>(dsPhongChon)
            );

            XuLyKetQua(kq);

            if (kq.ThanhCong)
                dsPhongChon.Clear();
        }

        // =====================================
        // CHỌN PHIẾU
        // =====================================
        private void dgvPhieu_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvPhieu.CurrentRow == null)
                return;

            if (!dgvPhieu.Columns.Contains("SoPhieuDat"))
                return;

            string soPhieu =
                Convert.ToString(
                    dgvPhieu.CurrentRow
                    .Cells["SoPhieuDat"].Value);

            txtPhieuChon.Text = soPhieu;

            dgvCT.DataSource =
                s.LayChiTiet(soPhieu);

            dgvNguoi.DataSource =
                s.LayNguoiLuuTru(soPhieu);
        }

        // Click một phòng trong chi tiết
        private void dgvCT_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvCT.CurrentRow == null)
                return;

            if (dgvCT.Columns.Contains("SoPhong"))
            {
                txtNguoiPhong.Text =
                    Convert.ToString(
                        dgvCT.CurrentRow
                        .Cells["SoPhong"].Value);
            }
        }

        // =====================================
        // THÊM NGƯỜI LƯU TRÚ
        // =====================================
        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            XuLyKetQua(
                s.ThemNguoiLuuTru(
                    txtPhieuChon.Text.Trim(),
                    txtNguoiPhong.Text.Trim(),
                    txtNguoiTen.Text.Trim(),
                    txtNguoiCMND.Text.Trim(),
                    txtNguoiQT.Text.Trim()
                )
            );

            if (!string.IsNullOrWhiteSpace(txtPhieuChon.Text))
            {
                dgvNguoi.DataSource =
                    s.LayNguoiLuuTru(
                        txtPhieuChon.Text.Trim());
            }
        }

        // =====================================
        // NHẬN PHÒNG
        // =====================================
        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            XuLyKetQua(
                s.NhanPhong(
                    txtPhieuChon.Text.Trim(),
                    DateTime.Now
                )
            );
        }

        // =====================================
        // NO-SHOW
        // =====================================
        private void btnNoShow_Click(object sender, EventArgs e)
        {
            XuLyKetQua(
                s.DanhDauNoShow(
                    txtPhieuChon.Text.Trim()
                )
            );
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}