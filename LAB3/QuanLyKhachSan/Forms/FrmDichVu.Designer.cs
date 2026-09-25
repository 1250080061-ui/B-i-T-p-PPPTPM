namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;

        private System.Windows.Forms.Label lblLuot;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblLichSu;

        private System.Windows.Forms.ComboBox cboLuot;
        private System.Windows.Forms.ComboBox cboDV;
        private System.Windows.Forms.ComboBox cboNV;

        private System.Windows.Forms.TextBox txtPhong;

        private System.Windows.Forms.DateTimePicker dtNgay;

        private System.Windows.Forms.NumericUpDown numSL;

        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnDong;

        private System.Windows.Forms.DataGridView dgvLichSu;

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

            this.lblLuot =
                new System.Windows.Forms.Label();

            this.lblPhong =
                new System.Windows.Forms.Label();

            this.lblDV =
                new System.Windows.Forms.Label();

            this.lblNgay =
                new System.Windows.Forms.Label();

            this.lblNV =
                new System.Windows.Forms.Label();

            this.lblSL =
                new System.Windows.Forms.Label();

            this.lblLichSu =
                new System.Windows.Forms.Label();

            this.cboLuot =
                new System.Windows.Forms.ComboBox();

            this.cboDV =
                new System.Windows.Forms.ComboBox();

            this.cboNV =
                new System.Windows.Forms.ComboBox();

            this.txtPhong =
                new System.Windows.Forms.TextBox();

            this.dtNgay =
                new System.Windows.Forms.DateTimePicker();

            this.numSL =
                new System.Windows.Forms.NumericUpDown();

            this.btnGhi =
                new System.Windows.Forms.Button();

            this.btnDong =
                new System.Windows.Forms.Button();

            this.dgvLichSu =
                new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.numSL)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvLichSu)).BeginInit();

            this.SuspendLayout();

            // ====================================
            // TIÊU ĐỀ
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
                new System.Drawing.Point(
                    0,
                    20);

            this.lblTieuDe.Size =
                new System.Drawing.Size(
                    1100,
                    50);

            this.lblTieuDe.Text =
                "SỬ DỤNG DỊCH VỤ";

            this.lblTieuDe.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;


            // ====================================
            // PHIẾU ĐANG Ở
            // ====================================
            this.lblLuot.AutoSize = true;

            this.lblLuot.Location =
                new System.Drawing.Point(
                    40,
                    100);

            this.lblLuot.Text =
                "Phiếu đang ở:";


            this.cboLuot.Location =
                new System.Drawing.Point(
                    155,
                    95);

            this.cboLuot.Size =
                new System.Drawing.Size(
                    350,
                    30);

            this.cboLuot.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboLuot.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cboLuot_SelectedIndexChanged);


            // ====================================
            // PHÒNG
            // ====================================
            this.lblPhong.AutoSize = true;

            this.lblPhong.Location =
                new System.Drawing.Point(
                    550,
                    100);

            this.lblPhong.Text =
                "Phòng:";


            this.txtPhong.Location =
                new System.Drawing.Point(
                    620,
                    95);

            this.txtPhong.Size =
                new System.Drawing.Size(
                    160,
                    30);

            this.txtPhong.ReadOnly = true;

            this.txtPhong.BackColor =
                System.Drawing.Color.White;


            // ====================================
            // DỊCH VỤ
            // ====================================
            this.lblDV.AutoSize = true;

            this.lblDV.Location =
                new System.Drawing.Point(
                    40,
                    155);

            this.lblDV.Text =
                "Dịch vụ:";


            this.cboDV.Location =
                new System.Drawing.Point(
                    155,
                    150);

            this.cboDV.Size =
                new System.Drawing.Size(
                    250,
                    30);

            this.cboDV.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            // ====================================
            // NGÀY
            // ====================================
            this.lblNgay.AutoSize = true;

            this.lblNgay.Location =
                new System.Drawing.Point(
                    450,
                    155);

            this.lblNgay.Text =
                "Ngày:";


            this.dtNgay.Location =
                new System.Drawing.Point(
                    505,
                    150);

            this.dtNgay.Size =
                new System.Drawing.Size(
                    155,
                    30);

            this.dtNgay.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;


            // ====================================
            // NHÂN VIÊN
            // ====================================
            this.lblNV.AutoSize = true;

            this.lblNV.Location =
                new System.Drawing.Point(
                    700,
                    155);

            this.lblNV.Text =
                "Nhân viên:";


            this.cboNV.Location =
                new System.Drawing.Point(
                    790,
                    150);

            this.cboNV.Size =
                new System.Drawing.Size(
                    220,
                    30);

            this.cboNV.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            // ====================================
            // SỐ LƯỢNG
            // ====================================
            this.lblSL.AutoSize = true;

            this.lblSL.Location =
                new System.Drawing.Point(
                    40,
                    210);

            this.lblSL.Text =
                "Số lượng:";


            this.numSL.Location =
                new System.Drawing.Point(
                    155,
                    205);

            this.numSL.Size =
                new System.Drawing.Size(
                    120,
                    30);

            this.numSL.Minimum = 1;
            this.numSL.Maximum = 10000;
            this.numSL.Value = 1;


            // ====================================
            // BUTTON GHI NHẬN
            // ====================================
            this.btnGhi.Location =
                new System.Drawing.Point(
                    320,
                    201);

            this.btnGhi.Size =
                new System.Drawing.Size(
                    140,
                    40);

            this.btnGhi.Text =
                "Ghi nhận";

            this.btnGhi.Click +=
                new System.EventHandler(
                    this.btnGhi_Click);


            // ====================================
            // LỊCH SỬ
            // ====================================
            this.lblLichSu.AutoSize = true;

            this.lblLichSu.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblLichSu.Location =
                new System.Drawing.Point(
                    40,
                    275);

            this.lblLichSu.Text =
                "Lịch sử sử dụng dịch vụ";


            this.dgvLichSu.Location =
                new System.Drawing.Point(
                    40,
                    310);

            this.dgvLichSu.Size =
                new System.Drawing.Size(
                    1020,
                    330);

            this.dgvLichSu.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvLichSu.ReadOnly = true;

            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;

            this.dgvLichSu.MultiSelect = false;

            this.dgvLichSu.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode
                    .FullRowSelect;

            // Dùng DisplayedCells để không bị
            // cột cuối cùng ép mất như form trước
            this.dgvLichSu.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode
                    .DisplayedCells;

            this.dgvLichSu.ScrollBars =
                System.Windows.Forms.ScrollBars.Both;

            this.dgvLichSu.RowHeadersVisible = false;

            this.dgvLichSu.BackgroundColor =
                System.Drawing.Color.White;


            // ====================================
            // BUTTON ĐÓNG
            // ====================================
            this.btnDong.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnDong.Location =
                new System.Drawing.Point(
                    950,
                    665);

            this.btnDong.Size =
                new System.Drawing.Size(
                    110,
                    40);

            this.btnDong.Text =
                "Đóng";

            this.btnDong.Click +=
                new System.EventHandler(
                    this.btnDong_Click);


            // ====================================
            // FrmDichVu
            // ====================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    8F,
                    16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(
                    1100,
                    725);

            this.Controls.Add(this.lblTieuDe);

            this.Controls.Add(this.lblLuot);
            this.Controls.Add(this.cboLuot);

            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.txtPhong);

            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.cboDV);

            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.dtNgay);

            this.Controls.Add(this.lblNV);
            this.Controls.Add(this.cboNV);

            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.numSL);

            this.Controls.Add(this.btnGhi);

            this.Controls.Add(this.lblLichSu);
            this.Controls.Add(this.dgvLichSu);

            this.Controls.Add(this.btnDong);

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.Name =
                "FrmDichVu";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Sử dụng dịch vụ";

            this.Load +=
                new System.EventHandler(
                    this.FrmDichVu_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.numSL)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvLichSu)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}