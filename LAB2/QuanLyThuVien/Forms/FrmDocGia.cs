using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmDocGia : Form
    {
        private readonly DocGiaService service =
            new DocGiaService();

        public FrmDocGia()
        {
            InitializeComponent();
            GanSuKien();
        }

        private void GanSuKien()
        {
            Load -= FrmDocGia_Load;
            Load += FrmDocGia_Load;

            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnCapNhat.Click -= btnCapNhat_Click;
            btnCapNhat.Click += btnCapNhat_Click;

            btnCapThe.Click -= btnCapThe_Click;
            btnCapThe.Click += btnCapThe_Click;

            btnGiaHan.Click -= btnGiaHan_Click;
            btnGiaHan.Click += btnGiaHan_Click;

            btnLamMoi.Click -= btnLamMoi_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            dgvDocGia.SelectionChanged -=
                dgvDocGia_SelectionChanged;

            dgvDocGia.SelectionChanged +=
                dgvDocGia_SelectionChanged;

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

        private void FrmDocGia_Load(
            object sender,
            EventArgs e)
        {
            cboPhai.Items.Clear();

            cboPhai.Items.AddRange(
                new object[] { "Nam", "Nữ", "Khác" });

            if (cboPhai.Items.Count > 0)
            {
                cboPhai.SelectedIndex = 0;
            }

            dtNgayCap.Value = DateTime.Today;
            dtHan.Value = DateTime.Today.AddYears(1);

            TaiDuLieu();
            LamMoi();
        }

        private void TaiDuLieu()
        {
            dgvDocGia.DataSource =
                service.LayDanhSach();

            dgvDocGia.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode
                    .DisplayedCells;
        }

        private DocGia LayForm()
        {
            return new DocGia
            {
                MaDocGia = txtMa.Text.Trim(),
                Ho = txtHo.Text.Trim(),
                Ten = txtTen.Text.Trim(),
                NgaySinh = dtNgaySinh.Value.Date,
                Phai = Convert.ToString(
                    cboPhai.SelectedItem),
                SoDienThoai = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Anh3x4 = txtAnh.Text.Trim()
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
                    LayForm(),
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
                    LayForm(),
                    true)))
            {
                LamMoi();
            }
        }

        private void btnCapThe_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn độc giả.");
                return;
            }

            HienKetQua(
                service.CapThe(
                    txtMa.Text.Trim(),
                    dtNgayCap.Value,
                    dtHan.Value,
                    chkLePhi.Checked));
        }

        private void btnGiaHan_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn độc giả.");
                return;
            }

            HienKetQua(
                service.GiaHanThe(
                    txtMa.Text.Trim(),
                    dtHan.Value,
                    chkLePhi.Checked));
        }

        private void btnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMa.Clear();
            txtHo.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtAnh.Clear();

            dtNgaySinh.Value =
                DateTime.Today.AddYears(-18);

            dtNgayCap.Value =
                DateTime.Today;

            dtHan.Value =
                DateTime.Today.AddYears(1);

            chkLePhi.Checked = true;

            if (cboPhai.Items.Count > 0)
            {
                cboPhai.SelectedIndex = 0;
            }

            txtMa.ReadOnly = false;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;

            txtMa.Focus();
        }

        private void dgvDocGia_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvDocGia.CurrentRow == null ||
                dgvDocGia.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            DataRowView row =
                dgvDocGia.CurrentRow.DataBoundItem
                as DataRowView;

            if (row == null)
            {
                return;
            }

            txtMa.Text =
                Convert.ToString(row["MaDocGia"]);

            txtHo.Text =
                Convert.ToString(row["Ho"]);

            txtTen.Text =
                Convert.ToString(row["Ten"]);

            if (row["NgaySinh"] != DBNull.Value)
            {
                dtNgaySinh.Value =
                    Convert.ToDateTime(row["NgaySinh"]);
            }

            cboPhai.SelectedItem =
                Convert.ToString(row["Phai"]);

            txtSDT.Text =
                Convert.ToString(row["SoDienThoai"]);

            txtDiaChi.Text =
                Convert.ToString(row["DiaChi"]);

            txtEmail.Text =
                Convert.ToString(row["Email"]);

            txtAnh.Text =
                Convert.ToString(row["Anh3x4"]);

            if (row["NgayCap"] != DBNull.Value)
            {
                dtNgayCap.Value =
                    Convert.ToDateTime(row["NgayCap"]);
            }

            if (row["HanSuDung"] != DBNull.Value)
            {
                dtHan.Value =
                    Convert.ToDateTime(row["HanSuDung"]);
            }

            chkLePhi.Checked =
                row["DaDongLePhi"] != DBNull.Value &&
                Convert.ToBoolean(row["DaDongLePhi"]);

            txtMa.ReadOnly = true;

            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnDong_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}