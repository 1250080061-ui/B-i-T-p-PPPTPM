using QuanLyKhachSan.Services;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDichVu : Form
    {
        private readonly DichVuService s =
            new DichVuService();

        private readonly DanhMucService dm =
            new DanhMucService();

        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            // ============================
            // PHIẾU ĐANG Ở
            // ============================
            DataTable dtLuot = s.LayPhieuDangO();

            // Thêm cột hiển thị để phân biệt
            // trường hợp 1 phiếu có nhiều phòng
            if (!dtLuot.Columns.Contains("HienThi"))
            {
                dtLuot.Columns.Add(
                    "HienThi",
                    typeof(string));

                foreach (DataRow r in dtLuot.Rows)
                {
                    r["HienThi"] =
                        r["SoPhieuDat"] +
                        " - Phòng " +
                        r["SoPhong"] +
                        " - " +
                        r["HoTen"];
                }
            }

            cboLuot.DataSource = dtLuot;
            cboLuot.DisplayMember = "HienThi";
            cboLuot.ValueMember = "SoPhieuDat";


            // ============================
            // DỊCH VỤ
            // ============================
            cboDV.DataSource =
                s.LayDichVu();

            cboDV.DisplayMember =
                "TenDV";

            cboDV.ValueMember =
                "MaDV";


            // ============================
            // NHÂN VIÊN
            // ============================
            cboNV.DataSource =
                dm.LayNhanVien();

            cboNV.DisplayMember =
                "HoTen";

            cboNV.ValueMember =
                "MaNV";


            CapNhatPhong();
            TaiLichSu();
        }

        private string V(ComboBox cbo)
        {
            return cbo.SelectedValue == null
                ? ""
                : cbo.SelectedValue.ToString();
        }

        // ==================================
        // CHỌN PHIẾU/LƯỢT
        // ==================================
        private void cboLuot_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            CapNhatPhong();
            TaiLichSu();
        }

        private void CapNhatPhong()
        {
            if (cboLuot.SelectedItem is DataRowView r)
            {
                txtPhong.Text =
                    Convert.ToString(
                        r["SoPhong"]);
            }
            else
            {
                txtPhong.Clear();
            }
        }

        // ==================================
        // LỊCH SỬ DỊCH VỤ
        // ==================================
        private void TaiLichSu()
        {
            if (cboLuot.SelectedValue == null)
            {
                dgvLichSu.DataSource = null;
                return;
            }

            string soPhieu =
                cboLuot.SelectedValue.ToString();

            dgvLichSu.DataSource =
                s.LayLichSu(soPhieu);
        }

        // ==================================
        // GHI NHẬN DỊCH VỤ
        // ==================================
        private void btnGhi_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(V(cboLuot)))
            {
                MessageBox.Show(
                    "Chưa chọn phiếu đang lưu trú.");

                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhong.Text))
            {
                MessageBox.Show(
                    "Chưa xác định phòng.");

                return;
            }

            if (string.IsNullOrWhiteSpace(V(cboDV)))
            {
                MessageBox.Show(
                    "Chưa chọn dịch vụ.");

                return;
            }

            if (string.IsNullOrWhiteSpace(V(cboNV)))
            {
                MessageBox.Show(
                    "Chưa chọn nhân viên.");

                return;
            }

            KetQuaXuLy kq =
                s.GhiNhan(
                    V(cboLuot),
                    txtPhong.Text.Trim(),
                    dtNgay.Value,
                    V(cboNV),
                    V(cboDV),
                    (int)numSL.Value
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
                TaiLichSu();
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