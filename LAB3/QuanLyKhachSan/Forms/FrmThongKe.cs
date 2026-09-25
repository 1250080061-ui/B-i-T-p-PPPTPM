using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService s =
            new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(
            object sender,
            EventArgs e)
        {
            // Mặc định thống kê từ đầu tháng đến hôm nay
            dtTu.Value =
                new DateTime(
                    DateTime.Today.Year,
                    DateTime.Today.Month,
                    1);

            dtDen.Value =
                DateTime.Today;

            TaiThongKe();
        }

        private void btnThongKe_Click(
            object sender,
            EventArgs e)
        {
            if (dtTu.Value.Date > dtDen.Value.Date)
            {
                MessageBox.Show(
                    "Ngày bắt đầu không được lớn hơn ngày kết thúc.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            TaiThongKe();
        }

        private void TaiThongKe()
        {
            try
            {
                dgvTongHop.DataSource =
                    s.TongHop(
                        dtTu.Value.Date,
                        dtDen.Value.Date);

                dgvDichVu.DataSource =
                    s.DichVu(
                        dtTu.Value.Date,
                        dtDen.Value.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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