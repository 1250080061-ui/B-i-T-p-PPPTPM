using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmPhongTienNghi : Form
    {
        private readonly PhongTienNghiService s =
            new PhongTienNghiService();

        private readonly DanhMucService dm =
            new DanhMucService();

        public FrmPhongTienNghi()
        {
            InitializeComponent();
        }

        private void FrmPhongTienNghi_Load(
            object sender,
            EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            // =========================
            // GRID
            // =========================
            dgvPhong.DataSource =
                s.LayPhong();

            dgvTN.DataSource =
                s.LayTienNghi();

            dgvLD.DataSource =
                s.LayLapDat();


            // =========================
            // KHU VỰC
            // =========================
            cboKhu.DataSource =
                dm.LayKhuVuc();

            cboKhu.DisplayMember =
                "TenKhuVuc";

            cboKhu.ValueMember =
                "MaKhuVuc";


            // =========================
            // LOẠI TIỆN NGHI
            // =========================
            cboLoai.DataSource =
                dm.LayLoaiTienNghi();

            cboLoai.DisplayMember =
                "TenLoaiTN";

            cboLoai.ValueMember =
                "MaLoaiTN";


            // =========================
            // TIỆN NGHI
            // =========================
            cboTN.DataSource =
                s.LayTienNghi();

            cboTN.DisplayMember =
                "MaTienNghi";

            cboTN.ValueMember =
                "MaTienNghi";


            // =========================
            // PHÒNG
            // =========================
            cboPhong.DataSource =
                s.LayPhong();

            cboPhong.DisplayMember =
                "SoPhong";

            cboPhong.ValueMember =
                "SoPhong";


            // =========================
            // NHÂN VIÊN
            // =========================
            cboNV.DataSource =
                dm.LayNhanVien();

            cboNV.DisplayMember =
                "HoTen";

            cboNV.ValueMember =
                "MaNV";
        }

        private string LayGiaTri(ComboBox cbo)
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
            {
                TaiDuLieu();
            }
        }

        // =================================
        // THÊM PHÒNG
        // =================================
        private void btnThemPhong_Click(
            object sender,
            EventArgs e)
        {
            XuLyKetQua(
                s.ThemPhong(
                    txtPhong.Text.Trim(),
                    LayGiaTri(cboKhu),
                    (int)numMax.Value,
                    numGia.Value
                )
            );
        }

        // =================================
        // THÊM TIỆN NGHI
        // =================================
        private void btnThemTN_Click(
            object sender,
            EventArgs e)
        {
            XuLyKetQua(
                s.ThemTienNghi(
                    txtMaTN.Text.Trim(),
                    LayGiaTri(cboLoai),
                    (int)numSTT.Value,
                    txtTinhTrang.Text.Trim()
                )
            );
        }

        // =================================
        // LẮP ĐẶT
        // =================================
        private void btnLapDat_Click(
            object sender,
            EventArgs e)
        {
            XuLyKetQua(
                s.LapDat(
                    txtSoLD.Text.Trim(),
                    LayGiaTri(cboTN),
                    LayGiaTri(cboPhong),
                    dtNgay.Value,
                    txtTTLD.Text.Trim(),
                    LayGiaTri(cboNV),
                    txtGhiChu.Text.Trim()
                )
            );
        }

        private void btnDong_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}