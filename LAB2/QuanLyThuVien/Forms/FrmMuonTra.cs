using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmMuonTra : Form
    {
        private readonly MuonTraService service =
            new MuonTraService();

        private readonly SachService sachService =
            new SachService();

        private readonly DocGiaService docGiaService =
            new DocGiaService();

        private readonly DanhMucService danhMuc =
            new DanhMucService();

        private DataTable selectedBooks;

        public FrmMuonTra()
        {
            InitializeComponent();
            GanSuKien();
        }

        private void GanSuKien()
        {
            Load -= FrmMuonTra_Load;
            Load += FrmMuonTra_Load;

            btnKiemTra.Click -= btnKiemTra_Click;
            btnKiemTra.Click += btnKiemTra_Click;

            btnThemSach.Click -= btnThemSach_Click;
            btnThemSach.Click += btnThemSach_Click;

            btnBoSach.Click -= btnBoSach_Click;
            btnBoSach.Click += btnBoSach_Click;

            btnLapPhieu.Click -= btnLapPhieu_Click;
            btnLapPhieu.Click += btnLapPhieu_Click;

            btnTaiSachMuon.Click -=
                btnTaiSachMuon_Click;

            btnTaiSachMuon.Click +=
                btnTaiSachMuon_Click;

            btnTraSach.Click -= btnTraSach_Click;
            btnTraSach.Click += btnTraSach_Click;

            cboDocGiaTra.SelectedIndexChanged -=
                cboDocGiaTra_SelectedIndexChanged;

            cboDocGiaTra.SelectedIndexChanged +=
                cboDocGiaTra_SelectedIndexChanged;

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

        private void FrmMuonTra_Load(
            object sender,
            EventArgs e)
        {
            DataTable readers =
                docGiaService.LayComboDocGia();

            cboDocGia.DataSource =
                readers.Copy();

            cboDocGia.DisplayMember =
                "HoTen";

            cboDocGia.ValueMember =
                "MaDocGia";

            cboDocGiaTra.DataSource =
                readers.Copy();

            cboDocGiaTra.DisplayMember =
                "HoTen";

            cboDocGiaTra.ValueMember =
                "MaDocGia";

            DataTable staff =
                danhMuc.LayNhanVien();

            cboNhanVienMuon.DataSource =
                staff.Copy();

            cboNhanVienMuon.DisplayMember =
                "MaNhanVien";

            cboNhanVienMuon.ValueMember =
                "MaNhanVien";

            cboNhanVienTra.DataSource =
                staff.Copy();

            cboNhanVienTra.DisplayMember =
                "MaNhanVien";

            cboNhanVienTra.ValueMember =
                "MaNhanVien";

            cboTinhTrang.Items.Clear();

            cboTinhTrang.Items.AddRange(
                new object[]
                {
                    "Bình thường",
                    "Rách/Hư hỏng",
                    "Mất"
                });

            if (cboTinhTrang.Items.Count > 0)
            {
                cboTinhTrang.SelectedIndex = 0;
            }

            dtNgayMuon.Value =
                DateTime.Today;

            dtHenTra.Value =
                DateTime.Today.AddDays(7);

            dtNgayTra.Value =
                DateTime.Today;

            TaoBangChon();
            TaiSachCon();
            TaiSachDangMuon();
        }

        private void TaoBangChon()
        {
            selectedBooks = new DataTable();

            selectedBooks.Columns.Add(
                "MaDauSach",
                typeof(string));

            selectedBooks.Columns.Add(
                "TenSach",
                typeof(string));

            dgvSachChon.DataSource =
                selectedBooks;

            dgvSachChon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private string MaDocGiaMuon
        {
            get
            {
                return cboDocGia.SelectedValue == null
                    ? ""
                    : cboDocGia.SelectedValue.ToString();
            }
        }

        private string MaDocGiaTra
        {
            get
            {
                return cboDocGiaTra.SelectedValue == null
                    ? ""
                    : cboDocGiaTra.SelectedValue.ToString();
            }
        }

        private string MaNhanVienMuon
        {
            get
            {
                return cboNhanVienMuon.SelectedValue == null
                    ? ""
                    : cboNhanVienMuon.SelectedValue.ToString();
            }
        }

        private string MaNhanVienTra
        {
            get
            {
                return cboNhanVienTra.SelectedValue == null
                    ? ""
                    : cboNhanVienTra.SelectedValue.ToString();
            }
        }

        private void TaiSachCon()
        {
            dgvSachCon.DataSource =
                sachService.LaySachConTrongKho();

            dgvSachCon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnKiemTra_Click(
            object sender,
            EventArgs e)
        {
            if (selectedBooks == null)
            {
                TaoBangChon();
            }

            KetQuaXuLy ketQua =
                service.KiemTraDieuKienMuon(
                    MaDocGiaMuon,
                    Math.Max(
                        1,
                        selectedBooks.Rows.Count));

            lblTrangThai.Text =
                ketQua.ThongBao;

            lblTrangThai.ForeColor =
                ketQua.ThanhCong
                    ? System.Drawing.Color.DarkGreen
                    : System.Drawing.Color.DarkRed;
        }

        private void btnThemSach_Click(
            object sender,
            EventArgs e)
        {
            if (dgvSachCon.CurrentRow == null ||
                dgvSachCon.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn đầu sách cần mượn.");
                return;
            }

            if (selectedBooks == null)
            {
                TaoBangChon();
            }

            if (selectedBooks.Rows.Count >= 3)
            {
                MessageBox.Show(
                    "Chỉ được chọn tối đa 3 đầu sách khác nhau.");
                return;
            }

            DataRowView row =
                dgvSachCon.CurrentRow.DataBoundItem
                as DataRowView;

            if (row == null)
            {
                return;
            }

            string maDauSach =
                Convert.ToString(row["MaDauSach"]);

            foreach (DataRow sachDaChon
                     in selectedBooks.Rows)
            {
                if (sachDaChon.RowState ==
                    DataRowState.Deleted)
                {
                    continue;
                }

                string maDaChon =
                    Convert.ToString(
                        sachDaChon["MaDauSach"]);

                if (string.Equals(
                    maDaChon,
                    maDauSach,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Đầu sách này đã có trong danh sách mượn.");
                    return;
                }
            }

            selectedBooks.Rows.Add(
                maDauSach,
                Convert.ToString(row["TenSach"]));
        }

        private void btnBoSach_Click(
            object sender,
            EventArgs e)
        {
            if (dgvSachChon.CurrentRow == null ||
                dgvSachChon.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            DataRowView row =
                dgvSachChon.CurrentRow.DataBoundItem
                as DataRowView;

            if (row != null)
            {
                row.Row.Delete();
            }
        }

        private void btnLapPhieu_Click(
            object sender,
            EventArgs e)
        {
            if (selectedBooks == null)
            {
                TaoBangChon();
            }

            List<string> danhSachMaSach =
                new List<string>();

            foreach (DataRow row in selectedBooks.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    danhSachMaSach.Add(
                        Convert.ToString(
                            row["MaDauSach"]));
                }
            }

            KetQuaXuLy ketQua =
                service.LapPhieuMuon(
                    MaDocGiaMuon,
                    MaNhanVienMuon,
                    danhSachMaSach,
                    dtNgayMuon.Value,
                    dtHenTra.Value);

            MessageBox.Show(
                ketQua.ThongBao,
                ketQua.ThanhCong ? "Thông báo" : "Lỗi",
                MessageBoxButtons.OK,
                ketQua.ThanhCong
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (ketQua.ThanhCong)
            {
                selectedBooks.Rows.Clear();

                TaiSachCon();
                TaiSachDangMuon();

                lblTrangThai.Text = "";
            }
        }

        private void TaiSachDangMuon()
        {
            if (string.IsNullOrWhiteSpace(MaDocGiaTra))
            {
                dgvDangMuon.DataSource = null;
                return;
            }

            dgvDangMuon.DataSource =
                service.LaySachDangMuon(
                    MaDocGiaTra);

            dgvDangMuon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTaiSachMuon_Click(
            object sender,
            EventArgs e)
        {
            TaiSachDangMuon();
        }

        private void cboDocGiaTra_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            TaiSachDangMuon();
        }

        private void btnTraSach_Click(
            object sender,
            EventArgs e)
        {
            if (dgvDangMuon.CurrentRow == null ||
                dgvDangMuon.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sách cần trả.");
                return;
            }

            DataRowView row =
                dgvDangMuon.CurrentRow.DataBoundItem
                as DataRowView;

            if (row == null)
            {
                return;
            }

            string maChiTiet =
                Convert.ToString(row["MaChiTiet"]);

            KetQuaXuLy ketQua =
                service.TraSach(
                    maChiTiet,
                    MaNhanVienTra,
                    dtNgayTra.Value,
                    Convert.ToString(
                        cboTinhTrang.SelectedItem),
                    numPhiPhat.Value);

            MessageBox.Show(
                ketQua.ThongBao,
                ketQua.ThanhCong ? "Thông báo" : "Lỗi",
                MessageBoxButtons.OK,
                ketQua.ThanhCong
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (ketQua.ThanhCong)
            {
                TaiSachDangMuon();
                TaiSachCon();

                numPhiPhat.Value = 0;

                if (cboTinhTrang.Items.Count > 0)
                {
                    cboTinhTrang.SelectedIndex = 0;
                }
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