using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService s = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            dgvKhu.DataSource = s.LayKhuVuc();
            dgvNV.DataSource = s.LayNhanVien();
            dgvLoaiTN.DataSource = s.LayLoaiTienNghi();
            dgvDV.DataSource = s.LayDichVu();
            dgvQD.DataSource = s.LayQuyDinhDenBu();

            cboQDLoai.DataSource = s.LayLoaiTienNghi();
            cboQDLoai.DisplayMember = "TenLoaiTN";
            cboQDLoai.ValueMember = "MaLoaiTN";

            ChinhCot();
        }
        private void ChinhCot()
        {
            // =========================
            // KHU VỰC
            // =========================
            ResetGrid(dgvKhu);

            DatCot(dgvKhu, "MaKhuVuc", 30);
            DatCot(dgvKhu, "TenKhuVuc", 70);


            // =========================
            // NHÂN VIÊN
            // =========================
            ResetGrid(dgvNV);

            DatCot(dgvNV, "MaNV", 15);
            DatCot(dgvNV, "HoTen", 35);
            DatCot(dgvNV, "VaiTro", 25);
            DatCot(dgvNV, "SoDienThoai", 25);


            // =========================
            // LOẠI TIỆN NGHI
            // =========================
            ResetGrid(dgvLoaiTN);

            DatCot(dgvLoaiTN, "MaLoaiTN", 30);
            DatCot(dgvLoaiTN, "TenLoaiTN", 70);


            // =========================
            // DỊCH VỤ
            // =========================
            ResetGrid(dgvDV);

            DatCot(dgvDV, "MaDV", 15);
            DatCot(dgvDV, "TenDV", 35);
            DatCot(dgvDV, "DonViTinh", 20);
            DatCot(dgvDV, "DonGia", 30);


            // =========================
            // QUY ĐỊNH ĐỀN BÙ
            // =========================
            ResetGrid(dgvQD);

            DatCot(dgvQD, "MaQuyDinh", 15);
            DatCot(dgvQD, "MaLoaiTN", 15);
            DatCot(dgvQD, "MucDoThietHai", 25);
            DatCot(dgvQD, "MucDenBu", 20);
            DatCot(dgvQD, "TenLoaiTN", 25);
        }
        private void ResetGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.None;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                // Quan trọng:
                // xóa chế độ Fill cũ của từng cột
                col.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.None;

                col.MinimumWidth = 50;
            }
        }
        private void DatCot(DataGridView dgv, string tenCot, int phanTram)
        {
            if (!dgv.Columns.Contains(tenCot))
                return;

            int rong =
                dgv.ClientSize.Width - 4;

            dgv.Columns[tenCot].Width =
                rong * phanTram / 100;
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

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            XuLyKetQua(
                s.ThemKhu(
                    txtKhuMa.Text.Trim(),
                    txtKhuTen.Text.Trim()
                )
            );
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            XuLyKetQua(
                s.ThemNhanVien(
                    txtNVMa.Text.Trim(),
                    txtNVTen.Text.Trim(),
                    txtNVVaiTro.Text.Trim(),
                    txtNVSDT.Text.Trim()
                )
            );
        }

        private void btnThemLoaiTN_Click(object sender, EventArgs e)
        {
            XuLyKetQua(
                s.ThemLoaiTN(
                    txtLoaiMa.Text.Trim(),
                    txtLoaiTen.Text.Trim()
                )
            );
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            XuLyKetQua(
                s.ThemDichVu(
                    txtDVMa.Text.Trim(),
                    txtDVTen.Text.Trim(),
                    txtDVDVT.Text.Trim(),
                    numDVGia.Value
                )
            );
        }

        private void btnThemQD_Click(object sender, EventArgs e)
        {
            string maLoai =
                cboQDLoai.SelectedValue == null
                ? ""
                : cboQDLoai.SelectedValue.ToString();

            XuLyKetQua(
                s.ThemQuyDinh(
                    txtQDMa.Text.Trim(),
                    maLoai,
                    txtQDMucDo.Text.Trim(),
                    numQDTien.Value
                )
            );
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}