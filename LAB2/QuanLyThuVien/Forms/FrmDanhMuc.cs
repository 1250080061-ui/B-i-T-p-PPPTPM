using System;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService service =
            new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
            GanSuKien();
        }

        private void GanSuKien()
        {
            Load -= FrmDanhMuc_Load;
            Load += FrmDanhMuc_Load;

            // Nhân viên
            btnNVThem.Click -= btnNVThem_Click;
            btnNVThem.Click += btnNVThem_Click;

            btnNVCapNhat.Click -= btnNVCapNhat_Click;
            btnNVCapNhat.Click += btnNVCapNhat_Click;

            btnNVXoa.Click -= btnNVXoa_Click;
            btnNVXoa.Click += btnNVXoa_Click;

            btnNVMoi.Click -= btnNVMoi_Click;
            btnNVMoi.Click += btnNVMoi_Click;

            dgvNV.SelectionChanged -= dgvNV_SelectionChanged;
            dgvNV.SelectionChanged += dgvNV_SelectionChanged;

            // Thể loại
            btnTLThem.Click -= btnTLThem_Click;
            btnTLThem.Click += btnTLThem_Click;

            btnTLCapNhat.Click -= btnTLCapNhat_Click;
            btnTLCapNhat.Click += btnTLCapNhat_Click;

            btnTLXoa.Click -= btnTLXoa_Click;
            btnTLXoa.Click += btnTLXoa_Click;

            btnTLMoi.Click -= btnTLMoi_Click;
            btnTLMoi.Click += btnTLMoi_Click;

            dgvTL.SelectionChanged -= dgvTL_SelectionChanged;
            dgvTL.SelectionChanged += dgvTL_SelectionChanged;

            // Nhà xuất bản
            btnNXBThem.Click -= btnNXBThem_Click;
            btnNXBThem.Click += btnNXBThem_Click;

            btnNXBCapNhat.Click -= btnNXBCapNhat_Click;
            btnNXBCapNhat.Click += btnNXBCapNhat_Click;

            btnNXBXoa.Click -= btnNXBXoa_Click;
            btnNXBXoa.Click += btnNXBXoa_Click;

            btnNXBMoi.Click -= btnNXBMoi_Click;
            btnNXBMoi.Click += btnNXBMoi_Click;

            dgvNXB.SelectionChanged -= dgvNXB_SelectionChanged;
            dgvNXB.SelectionChanged += dgvNXB_SelectionChanged;

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

        private void FrmDanhMuc_Load(
            object sender,
            EventArgs e)
        {
            cboNVPhai.Items.Clear();

            cboNVPhai.Items.AddRange(
                new object[] { "Nam", "Nữ", "Khác" });

            if (cboNVPhai.Items.Count > 0)
            {
                cboNVPhai.SelectedIndex = 0;
            }

            TaiTatCa();
            LamMoiNV();
            LamMoiTL();
            LamMoiNXB();
        }

        private void TaiTatCa()
        {
            dgvNV.DataSource =
                service.LayNhanVien();

            dgvTL.DataSource =
                service.LayTheLoai();

            dgvNXB.DataSource =
                service.LayNhaXuatBan();

            dgvNV.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTL.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvNXB.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
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
                TaiTatCa();
                return true;
            }

            return false;
        }

        // ================= NHÂN VIÊN =================

        private NhanVien LayNhanVienTrenForm()
        {
            return new NhanVien
            {
                MaNhanVien = txtNVMa.Text.Trim(),
                Ho = txtNVHo.Text.Trim(),
                Ten = txtNVTen.Text.Trim(),
                Phai = Convert.ToString(
                    cboNVPhai.SelectedItem),
                NgaySinh = dtNVNgaySinh.Value.Date,
                ChucVu = txtNVChucVu.Text.Trim(),
                SoDienThoai = txtNVSDT.Text.Trim()
            };
        }

        private void btnNVThem_Click(
            object sender,
            EventArgs e)
        {
            KetQuaXuLy ketQua =
                service.LuuNhanVien(
                    LayNhanVienTrenForm(),
                    false);

            if (HienKetQua(ketQua))
            {
                LamMoiNV();
            }
        }

        private void btnNVCapNhat_Click(
            object sender,
            EventArgs e)
        {
            KetQuaXuLy ketQua =
                service.LuuNhanVien(
                    LayNhanVienTrenForm(),
                    true);

            if (HienKetQua(ketQua))
            {
                LamMoiNV();
            }
        }

        private void btnNVXoa_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNVMa.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            if (!XacNhanXoa("nhân viên"))
            {
                return;
            }

            KetQuaXuLy ketQua =
                service.Xoa(
                    "NhanVien",
                    "MaNhanVien",
                    txtNVMa.Text.Trim());

            if (HienKetQua(ketQua))
            {
                LamMoiNV();
            }
        }

        private void btnNVMoi_Click(
            object sender,
            EventArgs e)
        {
            LamMoiNV();
        }

        private void dgvNV_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvNV.CurrentRow == null ||
                dgvNV.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            DataRowView row =
                dgvNV.CurrentRow.DataBoundItem
                as DataRowView;

            if (row == null)
            {
                return;
            }

            txtNVMa.Text =
                Convert.ToString(row["MaNhanVien"]);

            txtNVHo.Text =
                Convert.ToString(row["Ho"]);

            txtNVTen.Text =
                Convert.ToString(row["Ten"]);

            cboNVPhai.SelectedItem =
                Convert.ToString(row["Phai"]);

            if (row["NgaySinh"] != DBNull.Value)
            {
                dtNVNgaySinh.Value =
                    Convert.ToDateTime(row["NgaySinh"]);
            }

            txtNVChucVu.Text =
                Convert.ToString(row["ChucVu"]);

            txtNVSDT.Text =
                Convert.ToString(row["SoDienThoai"]);

            txtNVMa.ReadOnly = true;

            btnNVThem.Enabled = false;
            btnNVCapNhat.Enabled = true;
            btnNVXoa.Enabled = true;
        }

        private void LamMoiNV()
        {
            txtNVMa.Clear();
            txtNVHo.Clear();
            txtNVTen.Clear();
            txtNVChucVu.Clear();
            txtNVSDT.Clear();

            dtNVNgaySinh.Value =
                DateTime.Today.AddYears(-25);

            if (cboNVPhai.Items.Count > 0)
            {
                cboNVPhai.SelectedIndex = 0;
            }

            txtNVMa.ReadOnly = false;

            btnNVThem.Enabled = true;
            btnNVCapNhat.Enabled = false;
            btnNVXoa.Enabled = false;

            txtNVMa.Focus();
        }

        // ================= THỂ LOẠI =================

        private void btnTLThem_Click(
            object sender,
            EventArgs e)
        {
            KetQuaXuLy ketQua =
                service.LuuTheLoai(
                    txtTLMa.Text.Trim(),
                    txtTLTen.Text.Trim(),
                    false);

            if (HienKetQua(ketQua))
            {
                LamMoiTL();
            }
        }

        private void btnTLCapNhat_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTLMa.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn thể loại cần cập nhật.");
                return;
            }

            KetQuaXuLy ketQua =
                service.LuuTheLoai(
                    txtTLMa.Text.Trim(),
                    txtTLTen.Text.Trim(),
                    true);

            if (HienKetQua(ketQua))
            {
                LamMoiTL();
            }
        }

        private void btnTLXoa_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTLMa.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn thể loại cần xóa.");
                return;
            }

            if (!XacNhanXoa("thể loại"))
            {
                return;
            }

            KetQuaXuLy ketQua =
                service.Xoa(
                    "TheLoai",
                    "MaTheLoai",
                    txtTLMa.Text.Trim());

            if (HienKetQua(ketQua))
            {
                LamMoiTL();
            }
        }

        private void btnTLMoi_Click(
            object sender,
            EventArgs e)
        {
            LamMoiTL();
        }

        private void dgvTL_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvTL.CurrentRow == null ||
                dgvTL.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            DataRowView row =
                dgvTL.CurrentRow.DataBoundItem
                as DataRowView;

            if (row == null)
            {
                return;
            }

            txtTLMa.Text =
                Convert.ToString(row["MaTheLoai"]);

            txtTLTen.Text =
                Convert.ToString(row["TenTheLoai"]);

            txtTLMa.ReadOnly = true;

            btnTLThem.Enabled = false;
            btnTLCapNhat.Enabled = true;
            btnTLXoa.Enabled = true;
        }

        private void LamMoiTL()
        {
            txtTLMa.Clear();
            txtTLTen.Clear();

            txtTLMa.ReadOnly = false;

            btnTLThem.Enabled = true;
            btnTLCapNhat.Enabled = false;
            btnTLXoa.Enabled = false;

            txtTLMa.Focus();
        }

        // ================= NHÀ XUẤT BẢN =================

        private void btnNXBThem_Click(
            object sender,
            EventArgs e)
        {
            KetQuaXuLy ketQua =
                service.LuuNhaXuatBan(
                    txtNXBMa.Text.Trim(),
                    txtNXBDiaChi.Text.Trim(),
                    txtNXBSDT.Text.Trim(),
                    false);

            if (HienKetQua(ketQua))
            {
                LamMoiNXB();
            }
        }

        private void btnNXBCapNhat_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNXBMa.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn nhà xuất bản cần cập nhật.");
                return;
            }

            KetQuaXuLy ketQua =
                service.LuuNhaXuatBan(
                    txtNXBMa.Text.Trim(),
                    txtNXBDiaChi.Text.Trim(),
                    txtNXBSDT.Text.Trim(),
                    true);

            if (HienKetQua(ketQua))
            {
                LamMoiNXB();
            }
        }

        private void btnNXBXoa_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNXBMa.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn nhà xuất bản cần xóa.");
                return;
            }

            if (!XacNhanXoa("nhà xuất bản"))
            {
                return;
            }

            KetQuaXuLy ketQua =
                service.Xoa(
                    "NhaXuatBan",
                    "MaNhaXuatBan",
                    txtNXBMa.Text.Trim());

            if (HienKetQua(ketQua))
            {
                LamMoiNXB();
            }
        }

        private void btnNXBMoi_Click(
            object sender,
            EventArgs e)
        {
            LamMoiNXB();
        }

        private void dgvNXB_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvNXB.CurrentRow == null ||
                dgvNXB.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            DataRowView row =
                dgvNXB.CurrentRow.DataBoundItem
                as DataRowView;

            if (row == null)
            {
                return;
            }

            txtNXBMa.Text =
                Convert.ToString(row["MaNhaXuatBan"]);

            txtNXBDiaChi.Text =
                Convert.ToString(row["DiaChi"]);

            txtNXBSDT.Text =
                Convert.ToString(row["SoDienThoai"]);

            txtNXBMa.ReadOnly = true;

            btnNXBThem.Enabled = false;
            btnNXBCapNhat.Enabled = true;
            btnNXBXoa.Enabled = true;
        }

        private void LamMoiNXB()
        {
            txtNXBMa.Clear();
            txtNXBDiaChi.Clear();
            txtNXBSDT.Clear();

            txtNXBMa.ReadOnly = false;

            btnNXBThem.Enabled = true;
            btnNXBCapNhat.Enabled = false;
            btnNXBXoa.Enabled = false;

            txtNXBMa.Focus();
        }

        private bool XacNhanXoa(string tenDuLieu)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa "
                + tenDuLieu
                + " đang chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        private void btnDong_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}