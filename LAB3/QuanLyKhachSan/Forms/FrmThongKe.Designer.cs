namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblDen;

        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.DateTimePicker dtDen;

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDong;

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTongHop;
        private System.Windows.Forms.TabPage tabDichVu;

        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.DataGridView dgvDichVu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe =
                new System.Windows.Forms.Label();

            this.lblTu =
                new System.Windows.Forms.Label();

            this.lblDen =
                new System.Windows.Forms.Label();

            this.dtTu =
                new System.Windows.Forms.DateTimePicker();

            this.dtDen =
                new System.Windows.Forms.DateTimePicker();

            this.btnThongKe =
                new System.Windows.Forms.Button();

            this.btnDong =
                new System.Windows.Forms.Button();

            this.tabMain =
                new System.Windows.Forms.TabControl();

            this.tabTongHop =
                new System.Windows.Forms.TabPage();

            this.tabDichVu =
                new System.Windows.Forms.TabPage();

            this.dgvTongHop =
                new System.Windows.Forms.DataGridView();

            this.dgvDichVu =
                new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTongHop)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvDichVu)).BeginInit();

            this.tabMain.SuspendLayout();
            this.tabTongHop.SuspendLayout();
            this.tabDichVu.SuspendLayout();

            this.SuspendLayout();

            // ==========================================
            // TIÊU ĐỀ
            // ==========================================
            this.lblTieuDe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(
                    29, 75, 130);

            this.lblTieuDe.Location =
                new System.Drawing.Point(
                    0,
                    20);

            this.lblTieuDe.Size =
                new System.Drawing.Size(
                    1100,
                    55);

            this.lblTieuDe.Text =
                "THỐNG KÊ";

            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ==========================================
            // TỪ NGÀY
            // ==========================================
            this.lblTu.AutoSize =
                true;

            this.lblTu.Location =
                new System.Drawing.Point(
                    230,
                    100);

            this.lblTu.Text =
                "Từ ngày:";

            this.dtTu.Location =
                new System.Drawing.Point(
                    310,
                    95);

            this.dtTu.Size =
                new System.Drawing.Size(
                    160,
                    30);

            this.dtTu.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            // ==========================================
            // ĐẾN NGÀY
            // ==========================================
            this.lblDen.AutoSize =
                true;

            this.lblDen.Location =
                new System.Drawing.Point(
                    510,
                    100);

            this.lblDen.Text =
                "Đến ngày:";

            this.dtDen.Location =
                new System.Drawing.Point(
                    600,
                    95);

            this.dtDen.Size =
                new System.Drawing.Size(
                    160,
                    30);

            this.dtDen.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            // ==========================================
            // BUTTON THỐNG KÊ
            // ==========================================
            this.btnThongKe.Location =
                new System.Drawing.Point(
                    800,
                    91);

            this.btnThongKe.Size =
                new System.Drawing.Size(
                    130,
                    38);

            this.btnThongKe.Text =
                "Thống kê";

            this.btnThongKe.Click +=
                new System.EventHandler(
                    this.btnThongKe_Click);

            // ==========================================
            // TAB CONTROL
            // ==========================================
            this.tabMain.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.tabMain.Controls.Add(
                this.tabTongHop);

            this.tabMain.Controls.Add(
                this.tabDichVu);

            this.tabMain.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.tabMain.Location =
                new System.Drawing.Point(
                    30,
                    155);

            this.tabMain.Size =
                new System.Drawing.Size(
                    1040,
                    470);

            this.tabMain.SelectedIndex =
                0;

            // ==========================================
            // TAB TỔNG HỢP
            // ==========================================
            this.tabTongHop.Text =
                "Tổng hợp";

            this.tabTongHop.UseVisualStyleBackColor =
                true;

            this.dgvTongHop.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvTongHop.ReadOnly =
                true;

            this.dgvTongHop.AllowUserToAddRows =
                false;

            this.dgvTongHop.AllowUserToDeleteRows =
                false;

            this.dgvTongHop.MultiSelect =
                false;

            this.dgvTongHop.RowHeadersVisible =
                false;

            this.dgvTongHop.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode
                    .FullRowSelect;

            this.dgvTongHop.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode
                    .Fill;

            this.dgvTongHop.BackgroundColor =
                System.Drawing.Color.White;

            this.tabTongHop.Controls.Add(
                this.dgvTongHop);

            // ==========================================
            // TAB DỊCH VỤ
            // ==========================================
            this.tabDichVu.Text =
                "Thống kê dịch vụ";

            this.tabDichVu.UseVisualStyleBackColor =
                true;

            this.dgvDichVu.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvDichVu.ReadOnly =
                true;

            this.dgvDichVu.AllowUserToAddRows =
                false;

            this.dgvDichVu.AllowUserToDeleteRows =
                false;

            this.dgvDichVu.MultiSelect =
                false;

            this.dgvDichVu.RowHeadersVisible =
                false;

            this.dgvDichVu.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode
                    .FullRowSelect;

            this.dgvDichVu.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode
                    .Fill;

            this.dgvDichVu.BackgroundColor =
                System.Drawing.Color.White;

            this.tabDichVu.Controls.Add(
                this.dgvDichVu);

            // ==========================================
            // ĐÓNG
            // ==========================================
            this.btnDong.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnDong.Location =
                new System.Drawing.Point(
                    960,
                    645);

            this.btnDong.Size =
                new System.Drawing.Size(
                    110,
                    40);

            this.btnDong.Text =
                "Đóng";

            this.btnDong.Click +=
                new System.EventHandler(
                    this.btnDong_Click);

            // ==========================================
            // FORM
            // ==========================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    8F,
                    16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(
                    1100,
                    705);

            this.Controls.Add(
                this.lblTieuDe);

            this.Controls.Add(
                this.lblTu);

            this.Controls.Add(
                this.dtTu);

            this.Controls.Add(
                this.lblDen);

            this.Controls.Add(
                this.dtDen);

            this.Controls.Add(
                this.btnThongKe);

            this.Controls.Add(
                this.tabMain);

            this.Controls.Add(
                this.btnDong);

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.Name =
                "FrmThongKe";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Thống kê";

            this.Load +=
                new System.EventHandler(
                    this.FrmThongKe_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTongHop)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvDichVu)).EndInit();

            this.tabMain.ResumeLayout(false);
            this.tabTongHop.ResumeLayout(false);
            this.tabDichVu.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}