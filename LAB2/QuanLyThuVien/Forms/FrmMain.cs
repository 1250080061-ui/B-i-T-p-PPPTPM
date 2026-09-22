using System;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            GanSuKien();
        }

        private void GanSuKien()
        {
            btnDanhMuc.Click -= btnDanhMuc_Click;
            btnDanhMuc.Click += btnDanhMuc_Click;

            btnSach.Click -= btnSach_Click;
            btnSach.Click += btnSach_Click;

            btnDocGia.Click -= btnDocGia_Click;
            btnDocGia.Click += btnDocGia_Click;

            btnMuonTra.Click -= btnMuonTra_Click;
            btnMuonTra.Click += btnMuonTra_Click;

            btnThongKe.Click -= btnThongKe_Click;
            btnThongKe.Click += btnThongKe_Click;

            btnThoat.Click -= btnThoat_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (FrmDanhMuc form = new FrmDanhMuc())
            {
                form.ShowDialog(this);
            }
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            using (FrmSach form = new FrmSach())
            {
                form.ShowDialog(this);
            }
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            using (FrmDocGia form = new FrmDocGia())
            {
                form.ShowDialog(this);
            }
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            using (FrmMuonTra form = new FrmMuonTra())
            {
                form.ShowDialog(this);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (FrmThongKe form = new FrmThongKe())
            {
                form.ShowDialog(this);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}