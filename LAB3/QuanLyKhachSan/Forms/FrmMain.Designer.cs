namespace QuanLyKhachSan.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;

        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe =
                new System.Windows.Forms.Label();

            this.btnDanhMuc =
                new System.Windows.Forms.Button();

            this.btnPhong =
                new System.Windows.Forms.Button();

            this.btnDatPhong =
                new System.Windows.Forms.Button();

            this.btnDichVu =
                new System.Windows.Forms.Button();

            this.btnTraPhong =
                new System.Windows.Forms.Button();

            this.btnThongKe =
                new System.Windows.Forms.Button();

            this.btnThoat =
                new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ====================================
            // lblTieuDe
            // ====================================
            this.lblTieuDe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(
                    29,
                    75,
                    130);

            this.lblTieuDe.Location =
                new System.Drawing.Point(0, 25);

            this.lblTieuDe.Name =
                "lblTieuDe";

            this.lblTieuDe.Size =
                new System.Drawing.Size(900, 55);

            this.lblTieuDe.TabIndex = 0;

            this.lblTieuDe.Text =
                "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";

            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // ====================================
            // btnDanhMuc
            // ====================================
            this.btnDanhMuc.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnDanhMuc.Location =
                new System.Drawing.Point(45, 110);

            this.btnDanhMuc.Name =
                "btnDanhMuc";

            this.btnDanhMuc.Size =
                new System.Drawing.Size(250, 65);

            this.btnDanhMuc.TabIndex = 1;

            this.btnDanhMuc.Text =
                "Danh mục";

            this.btnDanhMuc.UseVisualStyleBackColor = true;

            this.btnDanhMuc.Click +=
                new System.EventHandler(
                    this.btnDanhMuc_Click);

            // ====================================
            // btnPhong
            // ====================================
            this.btnPhong.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnPhong.Location =
                new System.Drawing.Point(325, 110);

            this.btnPhong.Name =
                "btnPhong";

            this.btnPhong.Size =
                new System.Drawing.Size(250, 65);

            this.btnPhong.TabIndex = 2;

            this.btnPhong.Text =
                "Phòng - Tiện nghi";

            this.btnPhong.UseVisualStyleBackColor = true;

            this.btnPhong.Click +=
                new System.EventHandler(
                    this.btnPhong_Click);

            // ====================================
            // btnDatPhong
            // ====================================
            this.btnDatPhong.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnDatPhong.Location =
                new System.Drawing.Point(605, 110);

            this.btnDatPhong.Name =
                "btnDatPhong";

            this.btnDatPhong.Size =
                new System.Drawing.Size(250, 65);

            this.btnDatPhong.TabIndex = 3;

            this.btnDatPhong.Text =
                "Đặt / Nhận phòng";

            this.btnDatPhong.UseVisualStyleBackColor = true;

            this.btnDatPhong.Click +=
                new System.EventHandler(
                    this.btnDatPhong_Click);

            // ====================================
            // btnDichVu
            // ====================================
            this.btnDichVu.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnDichVu.Location =
                new System.Drawing.Point(45, 200);

            this.btnDichVu.Name =
                "btnDichVu";

            this.btnDichVu.Size =
                new System.Drawing.Size(250, 65);

            this.btnDichVu.TabIndex = 4;

            this.btnDichVu.Text =
                "Sử dụng dịch vụ";

            this.btnDichVu.UseVisualStyleBackColor = true;

            this.btnDichVu.Click +=
                new System.EventHandler(
                    this.btnDichVu_Click);

            // ====================================
            // btnTraPhong
            // ====================================
            this.btnTraPhong.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnTraPhong.Location =
                new System.Drawing.Point(325, 200);

            this.btnTraPhong.Name =
                "btnTraPhong";

            this.btnTraPhong.Size =
                new System.Drawing.Size(250, 65);

            this.btnTraPhong.TabIndex = 5;

            this.btnTraPhong.Text =
                "Trả phòng - Thanh toán";

            this.btnTraPhong.UseVisualStyleBackColor = true;

            this.btnTraPhong.Click +=
                new System.EventHandler(
                    this.btnTraPhong_Click);

            // ====================================
            // btnThongKe
            // ====================================
            this.btnThongKe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnThongKe.Location =
                new System.Drawing.Point(605, 200);

            this.btnThongKe.Name =
                "btnThongKe";

            this.btnThongKe.Size =
                new System.Drawing.Size(250, 65);

            this.btnThongKe.TabIndex = 6;

            this.btnThongKe.Text =
                "Thống kê";

            this.btnThongKe.UseVisualStyleBackColor = true;

            this.btnThongKe.Click +=
                new System.EventHandler(
                    this.btnThongKe_Click);

            // ====================================
            // btnThoat
            // ====================================
            this.btnThoat.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.btnThoat.Location =
                new System.Drawing.Point(325, 290);

            this.btnThoat.Name =
                "btnThoat";

            this.btnThoat.Size =
                new System.Drawing.Size(250, 65);

            this.btnThoat.TabIndex = 7;

            this.btnThoat.Text =
                "Thoát";

            this.btnThoat.UseVisualStyleBackColor = true;

            this.btnThoat.Click +=
                new System.EventHandler(
                    this.btnThoat_Click);

            // ====================================
            // FrmMain
            // ====================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(900, 400);

            this.Controls.Add(this.lblTieuDe);

            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.btnDatPhong);

            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnThongKe);

            this.Controls.Add(this.btnThoat);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name =
                "FrmMain";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Quản lý khách sạn";

            this.ResumeLayout(false);
        }
    }
}