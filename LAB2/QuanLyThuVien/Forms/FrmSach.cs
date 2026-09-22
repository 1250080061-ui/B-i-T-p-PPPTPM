using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmSach : Form
    {
        private readonly SachService service =
            new SachService();

        private readonly DanhMucService danhMuc =
            new DanhMucService();

        public FrmSach()
        {
            InitializeComponent();
            GanSuKien();
        }

        private void GanSuKien()
        {
            Load -= FrmSach_Load;
            Load += FrmSach_Load;

            btnTim.Click -= btnTim_Click;
            btnTim.Click += btnTim_Click;

            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnCapNhat.Click -= btnCapNhat_Click;
            btnCapNhat.Click += btnCapNhat_Click;

            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;

            btnLamMoi.Click -= btnLamMoi_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            dgvSach.SelectionChanged -=
                dgvSach_SelectionChanged;

            dgvSach.SelectionChanged +=
                dgvSach_SelectionChanged;

            GanClickNeuCo("btnDong", btnDong_Click);
        }

        private void GanClickNeuCo(
            string tenControl,
            EventHandler hamXuLy)
        {
            Control[] controls =
                Controls.Find(tenControl, true);

            if (controls.Length == 0)
            {
                return;
            }

            Button button = controls[0] as Button;

            if (button == null)
            {
                return;
            }

            button.Click -= hamXuLy;
            button.Click += hamXuLy;
        }

        private void FrmSach_Load(
            object sender,
            EventArgs e)
        {
            cboTheLoai.DataSource =
                danhMuc.LayTheLoai();

            cboTheLoai.DisplayMember =
                "TenTheLoai";

            cboTheLoai.ValueMember =
                "MaTheLoai";

            cboNXB.DataSource =
                danhMuc.LayNhaXuatBan();

            cboNXB.DisplayMember =
                "MaNhaXuatBan";

            cboNXB.ValueMember =
                "MaNhaXuatBan";

            TaiDuLieu();
            LamMoi();
        }

        private void TaiDuLieu()
        {
            dgvSach.DataSource =
                service.LayDanhSach(
                    txtTim.Text.Trim());

            dgvSach.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DauSach LayDuLieuForm()
        {
            return new DauSach
            {
                MaDauSach =
                    txtMa.Text.Trim(),

                TenSach =
                    txtTen.Text.Trim(),

                NamXuatBan =
                    (int)numNam.Value,

                SoLuongHienCo =
                    (int)numSoLuong.Value,

                MaTheLoai =
                    cboTheLoai.SelectedValue == null
                        ? ""
                        : cboTheLoai.SelectedValue.ToString(),

                MaNhaXuatBan =
                    cboNXB.SelectedValue == null
                        ? ""
                        : cboNXB.SelectedValue.ToString()
            };
        }

        private bool HienKetQua(KetQuaXuLy ketQua)
        {
            MessageBox.Show(
                ketQua.ThongBao,
                ketQua.ThanhCong ? "Thông báo" : "Lỗi",
                MessageBoxButtons.OK,
                ketQua.ThanhCong
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (ketQua.ThanhCong)
            {
                TaiDuLieu();
                return true;
            }

            return false;
        }

        private void btnThem_Click(
            object sender,
            EventArgs e)
        {
            if (HienKetQua(
                service.Luu(
                    LayDuLieuForm(),
                    false)))
            {
                LamMoi();
            }
        }

        private void btnCapNhat_Click(
            object sender,
            EventArgs e)
        {
            if (HienKetQua(
                service.Luu(
                    LayDuLieuForm(),
                    true)))
            {
                LamMoi();
            }
        }

        private void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn đầu sách cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa đầu sách này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (HienKetQua(
                service.Xoa(txtMa.Text.Trim())))
            {
                LamMoi();
            }
        }

        private void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            LamMoi();
        }

        private void btnTim_Click(
            object sender,
            EventArgs e)
        {
            TaiDuLieu();
        }

        private void LamMoi()
        {
            txtMa.Clear();
            txtTen.Clear();

            decimal namHienTai =
                DateTime.Today.Year;

            if (namHienTai >= numNam.Minimum &&
                namHienTai <= numNam.Maximum)
            {
                numNam.Value = namHienTai;
            }

            numSoLuong.Value = 0;

            txtMa.ReadOnly = false;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;

            txtMa.Focus();
        }

        private void dgvSach_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvSach.CurrentRow == null ||
                dgvSach.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            DataRowView row =
                dgvSach.CurrentRow.DataBoundItem
                as DataRowView;

            if (row == null)
            {
                return;
            }

            txtMa.Text =
                Convert.ToString(row["MaDauSach"]);

            txtTen.Text =
                Convert.ToString(row["TenSach"]);

            if (row["NamXuatBan"] != DBNull.Value)
            {
                decimal nam =
                    Convert.ToDecimal(
                        row["NamXuatBan"]);

                if (nam >= numNam.Minimum &&
                    nam <= numNam.Maximum)
                {
                    numNam.Value = nam;
                }
            }

            if (row["SoLuongHienCo"] != DBNull.Value)
            {
                decimal soLuong =
                    Convert.ToDecimal(
                        row["SoLuongHienCo"]);

                if (soLuong >= numSoLuong.Minimum &&
                    soLuong <= numSoLuong.Maximum)
                {
                    numSoLuong.Value = soLuong;
                }
            }

            cboTheLoai.SelectedValue =
                Convert.ToString(row["MaTheLoai"]);

            cboNXB.SelectedValue =
                Convert.ToString(row["MaNhaXuatBan"]);

            txtMa.ReadOnly = true;

            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnDong_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}