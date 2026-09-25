namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabMain;

        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.TabPage tabTienNghi;
        private System.Windows.Forms.TabPage tabLapDat;

        // =========================
        // PHÒNG
        // =========================
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblKhu;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblGia;

        private System.Windows.Forms.TextBox txtPhong;

        private System.Windows.Forms.ComboBox cboKhu;

        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.NumericUpDown numGia;

        private System.Windows.Forms.Button btnThemPhong;

        private System.Windows.Forms.DataGridView dgvPhong;


        // =========================
        // TIỆN NGHI
        // =========================
        private System.Windows.Forms.Label lblMaTN;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblTinhTrang;

        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.TextBox txtTinhTrang;

        private System.Windows.Forms.ComboBox cboLoai;

        private System.Windows.Forms.NumericUpDown numSTT;

        private System.Windows.Forms.Button btnThemTN;

        private System.Windows.Forms.DataGridView dgvTN;


        // =========================
        // LẮP ĐẶT
        // =========================
        private System.Windows.Forms.Label lblSoLD;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.Label lblPhongLD;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTTLD;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Label lblGhiChu;

        private System.Windows.Forms.TextBox txtSoLD;
        private System.Windows.Forms.TextBox txtTTLD;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.ComboBox cboTN;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboNV;

        private System.Windows.Forms.DateTimePicker dtNgay;

        private System.Windows.Forms.Button btnLapDat;

        private System.Windows.Forms.DataGridView dgvLD;

        private System.Windows.Forms.Button btnDong;


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
            this.tabMain =
                new System.Windows.Forms.TabControl();

            this.tabPhong =
                new System.Windows.Forms.TabPage();

            this.tabTienNghi =
                new System.Windows.Forms.TabPage();

            this.tabLapDat =
                new System.Windows.Forms.TabPage();


            // ============================================
            // TAB PHÒNG
            // ============================================

            this.lblPhong =
                new System.Windows.Forms.Label();

            this.lblKhu =
                new System.Windows.Forms.Label();

            this.lblMax =
                new System.Windows.Forms.Label();

            this.lblGia =
                new System.Windows.Forms.Label();

            this.txtPhong =
                new System.Windows.Forms.TextBox();

            this.cboKhu =
                new System.Windows.Forms.ComboBox();

            this.numMax =
                new System.Windows.Forms.NumericUpDown();

            this.numGia =
                new System.Windows.Forms.NumericUpDown();

            this.btnThemPhong =
                new System.Windows.Forms.Button();

            this.dgvPhong =
                new System.Windows.Forms.DataGridView();


            // ============================================
            // TAB TIỆN NGHI
            // ============================================

            this.lblMaTN =
                new System.Windows.Forms.Label();

            this.lblLoai =
                new System.Windows.Forms.Label();

            this.lblSTT =
                new System.Windows.Forms.Label();

            this.lblTinhTrang =
                new System.Windows.Forms.Label();

            this.txtMaTN =
                new System.Windows.Forms.TextBox();

            this.txtTinhTrang =
                new System.Windows.Forms.TextBox();

            this.cboLoai =
                new System.Windows.Forms.ComboBox();

            this.numSTT =
                new System.Windows.Forms.NumericUpDown();

            this.btnThemTN =
                new System.Windows.Forms.Button();

            this.dgvTN =
                new System.Windows.Forms.DataGridView();


            // ============================================
            // TAB LẮP ĐẶT
            // ============================================

            this.lblSoLD =
                new System.Windows.Forms.Label();

            this.lblTN =
                new System.Windows.Forms.Label();

            this.lblPhongLD =
                new System.Windows.Forms.Label();

            this.lblNgay =
                new System.Windows.Forms.Label();

            this.lblTTLD =
                new System.Windows.Forms.Label();

            this.lblNV =
                new System.Windows.Forms.Label();

            this.lblGhiChu =
                new System.Windows.Forms.Label();

            this.txtSoLD =
                new System.Windows.Forms.TextBox();

            this.txtTTLD =
                new System.Windows.Forms.TextBox();

            this.txtGhiChu =
                new System.Windows.Forms.TextBox();

            this.cboTN =
                new System.Windows.Forms.ComboBox();

            this.cboPhong =
                new System.Windows.Forms.ComboBox();

            this.cboNV =
                new System.Windows.Forms.ComboBox();

            this.dtNgay =
                new System.Windows.Forms.DateTimePicker();

            this.btnLapDat =
                new System.Windows.Forms.Button();

            this.dgvLD =
                new System.Windows.Forms.DataGridView();

            this.btnDong =
                new System.Windows.Forms.Button();


            ((System.ComponentModel.ISupportInitialize)
                (this.numMax)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numGia)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPhong)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numSTT)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTN)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvLD)).BeginInit();


            this.tabMain.SuspendLayout();

            this.tabPhong.SuspendLayout();
            this.tabTienNghi.SuspendLayout();
            this.tabLapDat.SuspendLayout();

            this.SuspendLayout();


            // =====================================================
            // tabMain
            // =====================================================

            this.tabMain.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.tabMain.Controls.Add(
                this.tabPhong);

            this.tabMain.Controls.Add(
                this.tabTienNghi);

            this.tabMain.Controls.Add(
                this.tabLapDat);

            this.tabMain.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.tabMain.Location =
                new System.Drawing.Point(
                    15,
                    15);

            this.tabMain.Name =
                "tabMain";

            this.tabMain.SelectedIndex =
                0;

            this.tabMain.Size =
                new System.Drawing.Size(
                    1120,
                    620);


            // =====================================================
            // TAB PHÒNG
            // =====================================================

            this.tabPhong.Text =
                "Phòng";

            this.tabPhong.UseVisualStyleBackColor =
                true;


            // Số phòng
            this.lblPhong.AutoSize =
                true;

            this.lblPhong.Location =
                new System.Drawing.Point(
                    25,
                    30);

            this.lblPhong.Text =
                "Số phòng:";


            this.txtPhong.Location =
                new System.Drawing.Point(
                    115,
                    26);

            this.txtPhong.Size =
                new System.Drawing.Size(
                    160,
                    30);


            // Khu vực
            this.lblKhu.AutoSize =
                true;

            this.lblKhu.Location =
                new System.Drawing.Point(
                    310,
                    30);

            this.lblKhu.Text =
                "Khu vực:";


            this.cboKhu.Location =
                new System.Drawing.Point(
                    390,
                    26);

            this.cboKhu.Size =
                new System.Drawing.Size(
                    180,
                    30);

            this.cboKhu.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            // Sức chứa
            this.lblMax.AutoSize =
                true;

            this.lblMax.Location =
                new System.Drawing.Point(
                    605,
                    30);

            this.lblMax.Text =
                "Sức chứa:";


            this.numMax.Location =
                new System.Drawing.Point(
                    695,
                    26);

            this.numMax.Size =
                new System.Drawing.Size(
                    100,
                    30);

            this.numMax.Minimum =
                1;

            this.numMax.Maximum =
                100;


            // Đơn giá
            this.lblGia.AutoSize =
                true;

            this.lblGia.Location =
                new System.Drawing.Point(
                    25,
                    82);

            this.lblGia.Text =
                "Đơn giá:";


            this.numGia.Location =
                new System.Drawing.Point(
                    115,
                    78);

            this.numGia.Size =
                new System.Drawing.Size(
                    190,
                    30);

            this.numGia.Maximum =
                1000000000M;

            this.numGia.ThousandsSeparator =
                true;


            // Button thêm
            this.btnThemPhong.Location =
                new System.Drawing.Point(
                    345,
                    74);

            this.btnThemPhong.Size =
                new System.Drawing.Size(
                    120,
                    38);

            this.btnThemPhong.Text =
                "Thêm phòng";

            this.btnThemPhong.Click +=
                new System.EventHandler(
                    this.btnThemPhong_Click);


            // Grid phòng
            this.dgvPhong.Location =
                new System.Drawing.Point(
                    25,
                    135);

            this.dgvPhong.Size =
                new System.Drawing.Size(
                    1055,
                    420);

            this.dgvPhong.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvPhong.ReadOnly =
                true;

            this.dgvPhong.AllowUserToAddRows =
                false;

            this.dgvPhong.AllowUserToDeleteRows =
                false;

            this.dgvPhong.MultiSelect =
                false;

            this.dgvPhong.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode
                    .FullRowSelect;

            this.dgvPhong.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode
                    .DisplayedCells;

            this.dgvPhong.ScrollBars =
                System.Windows.Forms.ScrollBars.Both;

            this.dgvPhong.BackgroundColor =
                System.Drawing.Color.White;


            this.tabPhong.Controls.Add(
                this.lblPhong);

            this.tabPhong.Controls.Add(
                this.txtPhong);

            this.tabPhong.Controls.Add(
                this.lblKhu);

            this.tabPhong.Controls.Add(
                this.cboKhu);

            this.tabPhong.Controls.Add(
                this.lblMax);

            this.tabPhong.Controls.Add(
                this.numMax);

            this.tabPhong.Controls.Add(
                this.lblGia);

            this.tabPhong.Controls.Add(
                this.numGia);

            this.tabPhong.Controls.Add(
                this.btnThemPhong);

            this.tabPhong.Controls.Add(
                this.dgvPhong);


            // =====================================================
            // TAB TIỆN NGHI
            // =====================================================

            this.tabTienNghi.Text =
                "Tiện nghi";

            this.tabTienNghi.UseVisualStyleBackColor =
                true;


            // Mã tiện nghi
            this.lblMaTN.AutoSize =
                true;

            this.lblMaTN.Location =
                new System.Drawing.Point(
                    25,
                    30);

            this.lblMaTN.Text =
                "Mã tiện nghi:";


            this.txtMaTN.Location =
                new System.Drawing.Point(
                    145,
                    26);

            this.txtMaTN.Size =
                new System.Drawing.Size(
                    175,
                    30);


            // Loại
            this.lblLoai.AutoSize =
                true;

            this.lblLoai.Location =
                new System.Drawing.Point(
                    355,
                    30);

            this.lblLoai.Text =
                "Loại:";


            this.cboLoai.Location =
                new System.Drawing.Point(
                    415,
                    26);

            this.cboLoai.Size =
                new System.Drawing.Size(
                    200,
                    30);

            this.cboLoai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            // STT
            this.lblSTT.AutoSize =
                true;

            this.lblSTT.Location =
                new System.Drawing.Point(
                    650,
                    30);

            this.lblSTT.Text =
                "Số thứ tự:";


            this.numSTT.Location =
                new System.Drawing.Point(
                    740,
                    26);

            this.numSTT.Size =
                new System.Drawing.Size(
                    100,
                    30);

            this.numSTT.Minimum =
                1;

            this.numSTT.Maximum =
                10000;


            // Tình trạng
            this.lblTinhTrang.AutoSize =
                true;

            this.lblTinhTrang.Location =
                new System.Drawing.Point(
                    25,
                    82);

            this.lblTinhTrang.Text =
                "Tình trạng:";


            this.txtTinhTrang.Location =
                new System.Drawing.Point(
                    145,
                    78);

            this.txtTinhTrang.Size =
                new System.Drawing.Size(
                    250,
                    30);


            this.btnThemTN.Location =
                new System.Drawing.Point(
                    435,
                    74);

            this.btnThemTN.Size =
                new System.Drawing.Size(
                    140,
                    38);

            this.btnThemTN.Text =
                "Thêm tiện nghi";

            this.btnThemTN.Click +=
                new System.EventHandler(
                    this.btnThemTN_Click);


            this.dgvTN.Location =
                new System.Drawing.Point(
                    25,
                    135);

            this.dgvTN.Size =
                new System.Drawing.Size(
                    1055,
                    420);

            this.dgvTN.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvTN.ReadOnly =
                true;

            this.dgvTN.AllowUserToAddRows =
                false;

            this.dgvTN.AllowUserToDeleteRows =
                false;

            this.dgvTN.MultiSelect =
                false;

            this.dgvTN.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode
                    .FullRowSelect;

            this.dgvTN.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode
                    .DisplayedCells;

            this.dgvTN.ScrollBars =
                System.Windows.Forms.ScrollBars.Both;

            this.dgvTN.BackgroundColor =
                System.Drawing.Color.White;


            this.tabTienNghi.Controls.Add(
                this.lblMaTN);

            this.tabTienNghi.Controls.Add(
                this.txtMaTN);

            this.tabTienNghi.Controls.Add(
                this.lblLoai);

            this.tabTienNghi.Controls.Add(
                this.cboLoai);

            this.tabTienNghi.Controls.Add(
                this.lblSTT);

            this.tabTienNghi.Controls.Add(
                this.numSTT);

            this.tabTienNghi.Controls.Add(
                this.lblTinhTrang);

            this.tabTienNghi.Controls.Add(
                this.txtTinhTrang);

            this.tabTienNghi.Controls.Add(
                this.btnThemTN);

            this.tabTienNghi.Controls.Add(
                this.dgvTN);


            // =====================================================
            // TAB LẮP ĐẶT
            // =====================================================

            this.tabLapDat.Text =
                "Lắp đặt / Luân chuyển";

            this.tabLapDat.UseVisualStyleBackColor =
                true;


            // Số phiếu
            this.lblSoLD.AutoSize =
                true;

            this.lblSoLD.Location =
                new System.Drawing.Point(
                    25,
                    28);

            this.lblSoLD.Text =
                "Số phiếu:";


            this.txtSoLD.Location =
                new System.Drawing.Point(
                    115,
                    24);

            this.txtSoLD.Size =
                new System.Drawing.Size(
                    160,
                    30);


            // Tiện nghi
            this.lblTN.AutoSize =
                true;

            this.lblTN.Location =
                new System.Drawing.Point(
                    310,
                    28);

            this.lblTN.Text =
                "Tiện nghi:";


            this.cboTN.Location =
                new System.Drawing.Point(
                    400,
                    24);

            this.cboTN.Size =
                new System.Drawing.Size(
                    180,
                    30);

            this.cboTN.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            // Phòng
            this.lblPhongLD.AutoSize =
                true;

            this.lblPhongLD.Location =
                new System.Drawing.Point(
                    620,
                    28);

            this.lblPhongLD.Text =
                "Phòng:";


            this.cboPhong.Location =
                new System.Drawing.Point(
                    690,
                    24);

            this.cboPhong.Size =
                new System.Drawing.Size(
                    150,
                    30);

            this.cboPhong.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            // Ngày
            this.lblNgay.AutoSize =
                true;

            this.lblNgay.Location =
                new System.Drawing.Point(
                    25,
                    76);

            this.lblNgay.Text =
                "Ngày:";


            this.dtNgay.Location =
                new System.Drawing.Point(
                    115,
                    72);

            this.dtNgay.Size =
                new System.Drawing.Size(
                    210,
                    30);

            this.dtNgay.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;


            // Tình trạng
            this.lblTTLD.AutoSize =
                true;

            this.lblTTLD.Location =
                new System.Drawing.Point(
                    365,
                    76);

            this.lblTTLD.Text =
                "Tình trạng:";


            this.txtTTLD.Location =
                new System.Drawing.Point(
                    460,
                    72);

            this.txtTTLD.Size =
                new System.Drawing.Size(
                    210,
                    30);


            // Nhân viên
            this.lblNV.AutoSize =
                true;

            this.lblNV.Location =
                new System.Drawing.Point(
                    705,
                    76);

            this.lblNV.Text =
                "Nhân viên:";


            this.cboNV.Location =
                new System.Drawing.Point(
                    795,
                    72);

            this.cboNV.Size =
                new System.Drawing.Size(
                    200,
                    30);

            this.cboNV.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            // Ghi chú
            this.lblGhiChu.AutoSize =
                true;

            this.lblGhiChu.Location =
                new System.Drawing.Point(
                    25,
                    124);

            this.lblGhiChu.Text =
                "Ghi chú:";


            this.txtGhiChu.Location =
                new System.Drawing.Point(
                    115,
                    120);

            this.txtGhiChu.Size =
                new System.Drawing.Size(
                    400,
                    30);


            // Lập phiếu
            this.btnLapDat.Location =
                new System.Drawing.Point(
                    555,
                    116);

            this.btnLapDat.Size =
                new System.Drawing.Size(
                    130,
                    38);

            this.btnLapDat.Text =
                "Lập phiếu";

            this.btnLapDat.Click +=
                new System.EventHandler(
                    this.btnLapDat_Click);


            // Grid lắp đặt
            this.dgvLD.Location =
                new System.Drawing.Point(
                    25,
                    180);

            this.dgvLD.Size =
                new System.Drawing.Size(
                    1055,
                    375);

            this.dgvLD.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvLD.ReadOnly =
                true;

            this.dgvLD.AllowUserToAddRows =
                false;

            this.dgvLD.AllowUserToDeleteRows =
                false;

            this.dgvLD.MultiSelect =
                false;

            this.dgvLD.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode
                    .FullRowSelect;

            this.dgvLD.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode
                    .DisplayedCells;

            this.dgvLD.ScrollBars =
                System.Windows.Forms.ScrollBars.Both;

            this.dgvLD.BackgroundColor =
                System.Drawing.Color.White;


            this.tabLapDat.Controls.Add(
                this.lblSoLD);

            this.tabLapDat.Controls.Add(
                this.txtSoLD);

            this.tabLapDat.Controls.Add(
                this.lblTN);

            this.tabLapDat.Controls.Add(
                this.cboTN);

            this.tabLapDat.Controls.Add(
                this.lblPhongLD);

            this.tabLapDat.Controls.Add(
                this.cboPhong);

            this.tabLapDat.Controls.Add(
                this.lblNgay);

            this.tabLapDat.Controls.Add(
                this.dtNgay);

            this.tabLapDat.Controls.Add(
                this.lblTTLD);

            this.tabLapDat.Controls.Add(
                this.txtTTLD);

            this.tabLapDat.Controls.Add(
                this.lblNV);

            this.tabLapDat.Controls.Add(
                this.cboNV);

            this.tabLapDat.Controls.Add(
                this.lblGhiChu);

            this.tabLapDat.Controls.Add(
                this.txtGhiChu);

            this.tabLapDat.Controls.Add(
                this.btnLapDat);

            this.tabLapDat.Controls.Add(
                this.dgvLD);


            // =====================================================
            // btnDong
            // =====================================================

            this.btnDong.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnDong.Location =
                new System.Drawing.Point(
                    1025,
                    650);

            this.btnDong.Size =
                new System.Drawing.Size(
                    110,
                    38);

            this.btnDong.Text =
                "Đóng";

            this.btnDong.Click +=
                new System.EventHandler(
                    this.btnDong_Click);


            // =====================================================
            // FrmPhongTienNghi
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    8F,
                    16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(
                    1150,
                    705);

            this.Controls.Add(
                this.tabMain);

            this.Controls.Add(
                this.btnDong);

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.Name =
                "FrmPhongTienNghi";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Phòng - Tiện nghi";

            this.Load +=
                new System.EventHandler(
                    this.FrmPhongTienNghi_Load);


            ((System.ComponentModel.ISupportInitialize)
                (this.numMax)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numGia)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPhong)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numSTT)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTN)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvLD)).EndInit();


            this.tabMain.ResumeLayout(false);

            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();

            this.tabTienNghi.ResumeLayout(false);
            this.tabTienNghi.PerformLayout();

            this.tabLapDat.ResumeLayout(false);
            this.tabLapDat.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}