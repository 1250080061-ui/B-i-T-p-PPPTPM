namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDenBu;
        private System.Windows.Forms.TabPage tabHoaDon;

        // Đền bù
        private System.Windows.Forms.ComboBox cboDat;
        private System.Windows.Forms.ComboBox cboNV;

        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.TextBox txtMucDo;

        private System.Windows.Forms.NumericUpDown numDenBu;

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.DataGridView dgvDBChon;

        private System.Windows.Forms.Button btnThemDB;
        private System.Windows.Forms.Button btnLapDB;

        // Hóa đơn
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.TextBox txtHDChon;
        private System.Windows.Forms.TextBox txtMaTT;

        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.NumericUpDown numTienTT;

        private System.Windows.Forms.ComboBox cboNV2;
        private System.Windows.Forms.ComboBox cboHT;

        private System.Windows.Forms.DataGridView dgvHD;

        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabMain =
                new System.Windows.Forms.TabControl();

            this.tabDenBu =
                new System.Windows.Forms.TabPage();

            this.tabHoaDon =
                new System.Windows.Forms.TabPage();

            this.cboDat =
                new System.Windows.Forms.ComboBox();

            this.cboNV =
                new System.Windows.Forms.ComboBox();

            this.txtPhong =
                new System.Windows.Forms.TextBox();

            this.txtSoDB =
                new System.Windows.Forms.TextBox();

            this.txtMucDo =
                new System.Windows.Forms.TextBox();

            this.numDenBu =
                new System.Windows.Forms.NumericUpDown();

            this.dgvPhong =
                new System.Windows.Forms.DataGridView();

            this.dgvTN =
                new System.Windows.Forms.DataGridView();

            this.dgvDBChon =
                new System.Windows.Forms.DataGridView();

            this.btnThemDB =
                new System.Windows.Forms.Button();

            this.btnLapDB =
                new System.Windows.Forms.Button();

            this.txtSoHD =
                new System.Windows.Forms.TextBox();

            this.txtHDChon =
                new System.Windows.Forms.TextBox();

            this.txtMaTT =
                new System.Windows.Forms.TextBox();

            this.numSoNgay =
                new System.Windows.Forms.NumericUpDown();

            this.numTienTT =
                new System.Windows.Forms.NumericUpDown();

            this.cboNV2 =
                new System.Windows.Forms.ComboBox();

            this.cboHT =
                new System.Windows.Forms.ComboBox();

            this.dgvHD =
                new System.Windows.Forms.DataGridView();

            this.btnLapHD =
                new System.Windows.Forms.Button();

            this.btnThanhToan =
                new System.Windows.Forms.Button();

            this.btnTraPhong =
                new System.Windows.Forms.Button();

            this.btnDong =
                new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.numDenBu)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPhong)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTN)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvDBChon)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numSoNgay)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numTienTT)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvHD)).BeginInit();

            this.tabMain.SuspendLayout();
            this.tabDenBu.SuspendLayout();
            this.tabHoaDon.SuspendLayout();

            this.SuspendLayout();

            // ==========================================
            // TAB CONTROL
            // ==========================================
            this.tabMain.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.tabMain.Controls.Add(this.tabDenBu);
            this.tabMain.Controls.Add(this.tabHoaDon);

            this.tabMain.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.tabMain.Location =
                new System.Drawing.Point(
                    15,
                    15);

            this.tabMain.Size =
                new System.Drawing.Size(
                    1270,
                    700);

            this.tabMain.SelectedIndex = 0;

            // ==========================================
            // TAB ĐỀN BÙ
            // ==========================================
            this.tabDenBu.Text =
                "Kiểm tra - Đền bù";

            this.tabDenBu.UseVisualStyleBackColor =
                true;

            // Phiếu đang ở
            System.Windows.Forms.Label lblDat =
                new System.Windows.Forms.Label();

            lblDat.Text = "Phiếu đang ở:";
            lblDat.AutoSize = true;
            lblDat.Location =
                new System.Drawing.Point(20, 25);

            this.cboDat.Location =
                new System.Drawing.Point(135, 21);

            this.cboDat.Size =
                new System.Drawing.Size(210, 30);

            this.cboDat.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboDat.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cboDat_SelectedIndexChanged);

            // Grid phòng
            this.dgvPhong.Location =
                new System.Drawing.Point(20, 70);

            this.dgvPhong.Size =
                new System.Drawing.Size(560, 150);

            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.RowHeadersVisible = false;

            this.dgvPhong.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvPhong.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvPhong.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvPhong.SelectionChanged +=
                new System.EventHandler(
                    this.dgvPhong_SelectionChanged);

            // Phòng chọn
            System.Windows.Forms.Label lblPhong =
                new System.Windows.Forms.Label();

            lblPhong.Text = "Phòng chọn:";
            lblPhong.AutoSize = true;

            lblPhong.Location =
                new System.Drawing.Point(620, 25);

            this.txtPhong.Location =
                new System.Drawing.Point(720, 21);

            this.txtPhong.Size =
                new System.Drawing.Size(140, 30);

            this.txtPhong.ReadOnly = true;

            // Tiện nghi
            System.Windows.Forms.Label lblTN =
                new System.Windows.Forms.Label();

            lblTN.Text = "Tiện nghi trong phòng";
            lblTN.AutoSize = true;
            lblTN.Location =
                new System.Drawing.Point(620, 70);

            this.dgvTN.Location =
                new System.Drawing.Point(620, 100);

            this.dgvTN.Size =
                new System.Drawing.Size(595, 120);

            this.dgvTN.ReadOnly = true;
            this.dgvTN.AllowUserToAddRows = false;
            this.dgvTN.AllowUserToDeleteRows = false;
            this.dgvTN.RowHeadersVisible = false;

            this.dgvTN.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvTN.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvTN.ScrollBars =
                System.Windows.Forms.ScrollBars.Both;

            this.dgvTN.BackgroundColor =
                System.Drawing.Color.White;

            // Số phiếu đền bù
            System.Windows.Forms.Label lblSoDB =
                new System.Windows.Forms.Label();

            lblSoDB.Text = "Số phiếu ĐB:";
            lblSoDB.AutoSize = true;
            lblSoDB.Location =
                new System.Drawing.Point(20, 260);

            this.txtSoDB.Location =
                new System.Drawing.Point(135, 256);

            this.txtSoDB.Size =
                new System.Drawing.Size(160, 30);

            // Mức độ
            System.Windows.Forms.Label lblMuc =
                new System.Windows.Forms.Label();

            lblMuc.Text = "Mức độ:";
            lblMuc.AutoSize = true;
            lblMuc.Location =
                new System.Drawing.Point(330, 260);

            this.txtMucDo.Location =
                new System.Drawing.Point(400, 256);

            this.txtMucDo.Size =
                new System.Drawing.Size(180, 30);

            // Tiền đền bù
            System.Windows.Forms.Label lblTien =
                new System.Windows.Forms.Label();

            lblTien.Text = "Số tiền:";
            lblTien.AutoSize = true;
            lblTien.Location =
                new System.Drawing.Point(620, 260);

            this.numDenBu.Location =
                new System.Drawing.Point(690, 256);

            this.numDenBu.Size =
                new System.Drawing.Size(170, 30);

            this.numDenBu.Maximum = 1000000000M;
            this.numDenBu.ThousandsSeparator = true;

            // Nhân viên
            System.Windows.Forms.Label lblNV =
                new System.Windows.Forms.Label();

            lblNV.Text = "Nhân viên:";
            lblNV.AutoSize = true;
            lblNV.Location =
                new System.Drawing.Point(895, 260);

            this.cboNV.Location =
                new System.Drawing.Point(980, 256);

            this.cboNV.Size =
                new System.Drawing.Size(220, 30);

            this.cboNV.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Buttons
            this.btnThemDB.Location =
                new System.Drawing.Point(400, 310);

            this.btnThemDB.Size =
                new System.Drawing.Size(140, 40);

            this.btnThemDB.Text =
                "Thêm đền bù";

            this.btnThemDB.Click +=
                new System.EventHandler(
                    this.btnThemDB_Click);

            this.btnLapDB.Location =
                new System.Drawing.Point(560, 310);

            this.btnLapDB.Size =
                new System.Drawing.Size(160, 40);

            this.btnLapDB.Text =
                "Lập phiếu đền bù";

            this.btnLapDB.Click +=
                new System.EventHandler(
                    this.btnLapDB_Click);

            // Danh sách đền bù
            System.Windows.Forms.Label lblDSDB =
                new System.Windows.Forms.Label();

            lblDSDB.Text =
                "Danh sách tiện nghi phải đền bù";

            lblDSDB.AutoSize = true;

            lblDSDB.Location =
                new System.Drawing.Point(20, 375);

            this.dgvDBChon.Location =
                new System.Drawing.Point(20, 405);

            this.dgvDBChon.Size =
                new System.Drawing.Size(1195, 215);

            this.dgvDBChon.ReadOnly = true;
            this.dgvDBChon.AllowUserToAddRows = false;
            this.dgvDBChon.AllowUserToDeleteRows = false;
            this.dgvDBChon.RowHeadersVisible = false;

            this.dgvDBChon.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvDBChon.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvDBChon.BackgroundColor =
                System.Drawing.Color.White;

            this.tabDenBu.Controls.Add(lblDat);
            this.tabDenBu.Controls.Add(this.cboDat);
            this.tabDenBu.Controls.Add(this.dgvPhong);

            this.tabDenBu.Controls.Add(lblPhong);
            this.tabDenBu.Controls.Add(this.txtPhong);

            this.tabDenBu.Controls.Add(lblTN);
            this.tabDenBu.Controls.Add(this.dgvTN);

            this.tabDenBu.Controls.Add(lblSoDB);
            this.tabDenBu.Controls.Add(this.txtSoDB);

            this.tabDenBu.Controls.Add(lblMuc);
            this.tabDenBu.Controls.Add(this.txtMucDo);

            this.tabDenBu.Controls.Add(lblTien);
            this.tabDenBu.Controls.Add(this.numDenBu);

            this.tabDenBu.Controls.Add(lblNV);
            this.tabDenBu.Controls.Add(this.cboNV);

            this.tabDenBu.Controls.Add(this.btnThemDB);
            this.tabDenBu.Controls.Add(this.btnLapDB);

            this.tabDenBu.Controls.Add(lblDSDB);
            this.tabDenBu.Controls.Add(this.dgvDBChon);

            // ==========================================
            // TAB HÓA ĐƠN - THANH TOÁN
            // ==========================================
            this.tabHoaDon.Text =
                "Hóa đơn - Thanh toán";

            this.tabHoaDon.UseVisualStyleBackColor =
                true;

            // Số hóa đơn
            System.Windows.Forms.Label lblHD =
                new System.Windows.Forms.Label();

            lblHD.Text = "Số hóa đơn:";
            lblHD.AutoSize = true;
            lblHD.Location =
                new System.Drawing.Point(25, 30);

            this.txtSoHD.Location =
                new System.Drawing.Point(130, 26);

            this.txtSoHD.Size =
                new System.Drawing.Size(170, 30);

            // Số ngày
            System.Windows.Forms.Label lblNgay =
                new System.Windows.Forms.Label();

            lblNgay.Text = "Số ngày:";
            lblNgay.AutoSize = true;
            lblNgay.Location =
                new System.Drawing.Point(340, 30);

            this.numSoNgay.Location =
                new System.Drawing.Point(415, 26);

            this.numSoNgay.Size =
                new System.Drawing.Size(100, 30);

            this.numSoNgay.Minimum = 1;
            this.numSoNgay.Maximum = 3650;
            this.numSoNgay.Value = 1;

            // Nhân viên
            System.Windows.Forms.Label lblNV2 =
                new System.Windows.Forms.Label();

            lblNV2.Text = "Nhân viên:";
            lblNV2.AutoSize = true;
            lblNV2.Location =
                new System.Drawing.Point(550, 30);

            this.cboNV2.Location =
                new System.Drawing.Point(635, 26);

            this.cboNV2.Size =
                new System.Drawing.Size(220, 30);

            this.cboNV2.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Lập hóa đơn
            this.btnLapHD.Location =
                new System.Drawing.Point(900, 22);

            this.btnLapHD.Size =
                new System.Drawing.Size(150, 40);

            this.btnLapHD.Text =
                "Lập hóa đơn";

            this.btnLapHD.Click +=
                new System.EventHandler(
                    this.btnLapHD_Click);

            // Grid hóa đơn
            this.dgvHD.Location =
                new System.Drawing.Point(25, 90);

            this.dgvHD.Size =
                new System.Drawing.Size(1190, 260);

            this.dgvHD.ReadOnly = true;
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AllowUserToDeleteRows = false;
            this.dgvHD.RowHeadersVisible = false;

            this.dgvHD.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvHD.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvHD.ScrollBars =
                System.Windows.Forms.ScrollBars.Both;

            this.dgvHD.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvHD.SelectionChanged +=
                new System.EventHandler(
                    this.dgvHD_SelectionChanged);

            // Hóa đơn chọn
            System.Windows.Forms.Label lblHDChon =
                new System.Windows.Forms.Label();

            lblHDChon.Text = "Hóa đơn chọn:";
            lblHDChon.AutoSize = true;
            lblHDChon.Location =
                new System.Drawing.Point(25, 390);

            this.txtHDChon.Location =
                new System.Drawing.Point(140, 386);

            this.txtHDChon.Size =
                new System.Drawing.Size(170, 30);

            this.txtHDChon.ReadOnly = true;

            // Mã thanh toán
            System.Windows.Forms.Label lblMaTT =
                new System.Windows.Forms.Label();

            lblMaTT.Text = "Mã TT:";
            lblMaTT.AutoSize = true;
            lblMaTT.Location =
                new System.Drawing.Point(345, 390);

            this.txtMaTT.Location =
                new System.Drawing.Point(410, 386);

            this.txtMaTT.Size =
                new System.Drawing.Size(150, 30);

            // Hình thức
            System.Windows.Forms.Label lblHT =
                new System.Windows.Forms.Label();

            lblHT.Text = "Hình thức:";
            lblHT.AutoSize = true;
            lblHT.Location =
                new System.Drawing.Point(595, 390);

            this.cboHT.Location =
                new System.Drawing.Point(680, 386);

            this.cboHT.Size =
                new System.Drawing.Size(175, 30);

            this.cboHT.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Số tiền
            System.Windows.Forms.Label lblTienTT =
                new System.Windows.Forms.Label();

            lblTienTT.Text = "Số tiền:";
            lblTienTT.AutoSize = true;
            lblTienTT.Location =
                new System.Drawing.Point(890, 390);

            this.numTienTT.Location =
                new System.Drawing.Point(960, 386);

            this.numTienTT.Size =
                new System.Drawing.Size(190, 30);

            this.numTienTT.Maximum =
                1000000000M;

            this.numTienTT.ThousandsSeparator =
                true;

            // Thanh toán
            this.btnThanhToan.Location =
                new System.Drawing.Point(445, 455);

            this.btnThanhToan.Size =
                new System.Drawing.Size(150, 42);

            this.btnThanhToan.Text =
                "Thanh toán";

            this.btnThanhToan.Click +=
                new System.EventHandler(
                    this.btnThanhToan_Click);

            // Trả phòng
            this.btnTraPhong.Location =
                new System.Drawing.Point(625, 455);

            this.btnTraPhong.Size =
                new System.Drawing.Size(180, 42);

            this.btnTraPhong.Text =
                "Hoàn tất trả phòng";

            this.btnTraPhong.Click +=
                new System.EventHandler(
                    this.btnTraPhong_Click);

            this.tabHoaDon.Controls.Add(lblHD);
            this.tabHoaDon.Controls.Add(this.txtSoHD);

            this.tabHoaDon.Controls.Add(lblNgay);
            this.tabHoaDon.Controls.Add(this.numSoNgay);

            this.tabHoaDon.Controls.Add(lblNV2);
            this.tabHoaDon.Controls.Add(this.cboNV2);

            this.tabHoaDon.Controls.Add(this.btnLapHD);

            this.tabHoaDon.Controls.Add(this.dgvHD);

            this.tabHoaDon.Controls.Add(lblHDChon);
            this.tabHoaDon.Controls.Add(this.txtHDChon);

            this.tabHoaDon.Controls.Add(lblMaTT);
            this.tabHoaDon.Controls.Add(this.txtMaTT);

            this.tabHoaDon.Controls.Add(lblHT);
            this.tabHoaDon.Controls.Add(this.cboHT);

            this.tabHoaDon.Controls.Add(lblTienTT);
            this.tabHoaDon.Controls.Add(this.numTienTT);

            this.tabHoaDon.Controls.Add(this.btnThanhToan);
            this.tabHoaDon.Controls.Add(this.btnTraPhong);

            // ==========================================
            // ĐÓNG
            // ==========================================
            this.btnDong.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnDong.Location =
                new System.Drawing.Point(1175, 730);

            this.btnDong.Size =
                new System.Drawing.Size(110, 40);

            this.btnDong.Text = "Đóng";

            this.btnDong.Click +=
                new System.EventHandler(
                    this.btnDong_Click);

            // ==========================================
            // FORM
            // ==========================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1300, 790);

            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.Name = "FrmTraPhong";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Trả phòng - Thanh toán";

            this.Load +=
                new System.EventHandler(
                    this.FrmTraPhong_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.numDenBu)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPhong)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTN)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvDBChon)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numSoNgay)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numTienTT)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvHD)).EndInit();

            this.tabMain.ResumeLayout(false);

            this.tabDenBu.ResumeLayout(false);
            this.tabDenBu.PerformLayout();

            this.tabHoaDon.ResumeLayout(false);
            this.tabHoaDon.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}