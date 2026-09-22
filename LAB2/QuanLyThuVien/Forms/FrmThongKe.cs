using System;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService service =
            new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
            GanSuKien();
        }

        private void GanSuKien()
        {
            Load -= FrmThongKe_Load;
            Load += FrmThongKe_Load;

            btnThongKe.Click -= btnThongKe_Click;
            btnThongKe.Click += btnThongKe_Click;

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

        private void FrmThongKe_Load(
            object sender,
            EventArgs e)
        {
            dtTu.Value = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                1);

            dtDen.Value = DateTime.Today;

            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            // Dùng var để tránh xung đột
            // giữa hai lớp ThongKeTongHop.
            var thongKe =
                service.LayTongHop(
                    dtTu.Value,
                    dtDen.Value);

            lblMuon.Text =
                "Lượt sách mượn: "
                + thongKe.LuotSachMuon;

            lblQuaHan.Text =
                "Sách quá hạn: "
                + thongKe.SachQuaHan;

            lblMat.Text =
                "Sách mất: "
                + thongKe.SachMat;

            lblHuHong.Text =
                "Sách hư hỏng: "
                + thongKe.SachHuHong;

            lblPhiPhat.Text =
                "Tổng phí phạt: "
                + thongKe.TongPhiPhat.ToString("N0")
                + " đ";

            dgvPhat.DataSource =
                service.LayChiTietPhat(
                    dtTu.Value,
                    dtDen.Value);

            dgvPhat.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThongKe_Click(
            object sender,
            EventArgs e)
        {
            TaiDuLieu();
        }

        private void btnDong_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}