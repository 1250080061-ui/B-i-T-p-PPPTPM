using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmTraPhong : Form
    {
        private readonly TraPhongService s =
            new TraPhongService();

        private readonly DanhMucService dm =
            new DanhMucService();

        private readonly BindingList<DenBuItem> dsDenBu =
            new BindingList<DenBuItem>();

        public FrmTraPhong()
        {
            InitializeComponent();
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            dgvDBChon.DataSource = dsDenBu;

            cboHT.Items.Clear();
            cboHT.Items.AddRange(new object[]
            {
                "Tiền mặt",
                "Chuyển khoản",
                "Thẻ",
                "Ví điện tử"
            });

            if (cboHT.Items.Count > 0)
                cboHT.SelectedIndex = 0;

            TaiDuLieu();
        }

        private string V(ComboBox cbo)
        {
            return cbo.SelectedValue == null
                ? ""
                : cbo.SelectedValue.ToString();
        }

        private void TaiDuLieu()
        {
            // Phiếu đang ở
            cboDat.DataSource = s.LayPhieuDangO();
            cboDat.DisplayMember = "SoPhieuDat";
            cboDat.ValueMember = "SoPhieuDat";

            // Nhân viên lập đền bù
            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            // Nhân viên lập hóa đơn
            cboNV2.DataSource = dm.LayNhanVien();
            cboNV2.DisplayMember = "HoTen";
            cboNV2.ValueMember = "MaNV";

            // Hóa đơn
            dgvHD.DataSource = s.LayHoaDon();

            TaiPhong();
        }

        private void cboDat_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            TaiPhong();
        }

        private void TaiPhong()
        {
            if (cboDat.SelectedValue == null)
            {
                dgvPhong.DataSource = null;
                dgvTN.DataSource = null;
                txtPhong.Clear();
                return;
            }

            dgvPhong.DataSource =
                s.LayPhongTheoPhieu(
                    cboDat.SelectedValue.ToString());
        }

        private void dgvPhong_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvPhong.CurrentRow == null)
                return;

            if (!dgvPhong.Columns.Contains("SoPhong"))
                return;

            txtPhong.Text =
                Convert.ToString(
                    dgvPhong.CurrentRow
                    .Cells["SoPhong"].Value);

            if (!string.IsNullOrWhiteSpace(txtPhong.Text))
            {
                dgvTN.DataSource =
                    s.LayTienNghiPhong(
                        txtPhong.Text);
            }
        }

        // =========================================
        // THÊM TIỆN NGHI VÀO DS ĐỀN BÙ
        // =========================================
        private void btnThemDB_Click(
            object sender,
            EventArgs e)
        {
            if (dgvTN.CurrentRow == null)
            {
                MessageBox.Show(
                    "Hãy chọn tiện nghi bị hư hỏng.");

                return;
            }

            if (!dgvTN.Columns.Contains("MaTienNghi"))
            {
                MessageBox.Show(
                    "Không tìm thấy cột MaTienNghi.");

                return;
            }

            string maTN =
                Convert.ToString(
                    dgvTN.CurrentRow
                    .Cells["MaTienNghi"].Value);

            string tenLoai = "";

            if (dgvTN.Columns.Contains("TenLoaiTN"))
            {
                tenLoai =
                    Convert.ToString(
                        dgvTN.CurrentRow
                        .Cells["TenLoaiTN"].Value);
            }

            foreach (DenBuItem item in dsDenBu)
            {
                if (item.MaTienNghi == maTN)
                {
                    MessageBox.Show(
                        "Tiện nghi này đã có trong danh sách đền bù.");

                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtMucDo.Text))
            {
                MessageBox.Show(
                    "Hãy nhập mức độ thiệt hại.");

                return;
            }

            dsDenBu.Add(
                new DenBuItem
                {
                    MaTienNghi = maTN,
                    TenLoaiTN = tenLoai,
                    MucDoThietHai =
                        txtMucDo.Text.Trim(),
                    SoTien =
                        numDenBu.Value
                });
        }

        // =========================================
        // LẬP PHIẾU ĐỀN BÙ
        // =========================================
        private void btnLapDB_Click(
            object sender,
            EventArgs e)
        {
            KetQuaXuLy kq =
                s.LapPhieuDenBu(
                    txtSoDB.Text.Trim(),
                    V(cboDat),
                    txtPhong.Text.Trim(),
                    DateTime.Now,
                    V(cboNV),
                    new List<DenBuItem>(dsDenBu)
                );

            MessageBox.Show(
                kq.ThongBao,
                "Thông báo",
                MessageBoxButtons.OK,
                kq.ThanhCong
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                dsDenBu.Clear();
                txtSoDB.Clear();
                txtMucDo.Clear();
                numDenBu.Value = 0;
            }
        }

        // =========================================
        // LẬP HÓA ĐƠN
        // =========================================
        private void btnLapHD_Click(
            object sender,
            EventArgs e)
        {
            KetQuaXuLy kq =
                s.LapHoaDon(
                    txtSoHD.Text.Trim(),
                    V(cboDat),
                    DateTime.Now,
                    V(cboNV2),
                    (int)numSoNgay.Value
                );

            MessageBox.Show(
                kq.ThongBao,
                "Thông báo",
                MessageBoxButtons.OK,
                kq.ThanhCong
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                dgvHD.DataSource =
                    s.LayHoaDon();
            }
        }

        // =========================================
        // CHỌN HÓA ĐƠN
        // =========================================
        private void dgvHD_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvHD.CurrentRow == null)
                return;

            if (!dgvHD.Columns.Contains("SoHoaDon"))
                return;

            txtHDChon.Text =
                Convert.ToString(
                    dgvHD.CurrentRow
                    .Cells["SoHoaDon"].Value);
        }

        // =========================================
        // THANH TOÁN
        // =========================================
        private void btnThanhToan_Click(
            object sender,
            EventArgs e)
        {
            KetQuaXuLy kq =
                s.ThanhToan(
                    txtMaTT.Text.Trim(),
                    txtHDChon.Text.Trim(),
                    DateTime.Now,
                    cboHT.Text,
                    numTienTT.Value
                );

            MessageBox.Show(
                kq.ThongBao,
                "Thông báo",
                MessageBoxButtons.OK,
                kq.ThanhCong
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                dgvHD.DataSource =
                    s.LayHoaDon();
            }
        }

        // =========================================
        // HOÀN TẤT TRẢ PHÒNG
        // =========================================
        private void btnTraPhong_Click(
            object sender,
            EventArgs e)
        {
            if (MessageBox.Show(
                "Xác nhận hoàn tất trả phòng?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }

            KetQuaXuLy kq =
                s.TraPhong(
                    V(cboDat),
                    DateTime.Now
                );

            MessageBox.Show(
                kq.ThongBao,
                "Thông báo",
                MessageBoxButtons.OK,
                kq.ThanhCong
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                TaiDuLieu();
            }
        }

        private void btnDong_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}