namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKhu;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.TabPage tabLoaiTN;
        private System.Windows.Forms.TabPage tabDV;
        private System.Windows.Forms.TabPage tabQD;

        // Khu vực
        private System.Windows.Forms.Label lblKhuMa;
        private System.Windows.Forms.Label lblKhuTen;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.DataGridView dgvKhu;

        // Nhân viên
        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.Label lblNVVaiTro;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridView dgvNV;

        // Loại tiện nghi
        private System.Windows.Forms.Label lblLoaiMa;
        private System.Windows.Forms.Label lblLoaiTen;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.DataGridView dgvLoaiTN;

        // Dịch vụ
        private System.Windows.Forms.Label lblDVMa;
        private System.Windows.Forms.Label lblDVTen;
        private System.Windows.Forms.Label lblDVDVT;
        private System.Windows.Forms.Label lblDVGia;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.DataGridView dgvDV;

        // Quy định đền bù
        private System.Windows.Forms.Label lblQDMa;
        private System.Windows.Forms.Label lblQDLoai;
        private System.Windows.Forms.Label lblQDMucDo;
        private System.Windows.Forms.Label lblQDTien;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.DataGridView dgvQD;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();

            this.tabKhu = new System.Windows.Forms.TabPage();
            this.tabNV = new System.Windows.Forms.TabPage();
            this.tabLoaiTN = new System.Windows.Forms.TabPage();
            this.tabDV = new System.Windows.Forms.TabPage();
            this.tabQD = new System.Windows.Forms.TabPage();

            // =============================
            // KHU VỰC
            // =============================
            this.lblKhuMa = new System.Windows.Forms.Label();
            this.lblKhuTen = new System.Windows.Forms.Label();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.dgvKhu = new System.Windows.Forms.DataGridView();

            // =============================
            // NHÂN VIÊN
            // =============================
            this.lblNVMa = new System.Windows.Forms.Label();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.lblNVVaiTro = new System.Windows.Forms.Label();
            this.lblNVSDT = new System.Windows.Forms.Label();

            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.txtNVSDT = new System.Windows.Forms.TextBox();

            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();

            // =============================
            // LOẠI TIỆN NGHI
            // =============================
            this.lblLoaiMa = new System.Windows.Forms.Label();
            this.lblLoaiTen = new System.Windows.Forms.Label();

            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();

            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();

            // =============================
            // DỊCH VỤ
            // =============================
            this.lblDVMa = new System.Windows.Forms.Label();
            this.lblDVTen = new System.Windows.Forms.Label();
            this.lblDVDVT = new System.Windows.Forms.Label();
            this.lblDVGia = new System.Windows.Forms.Label();

            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.txtDVDVT = new System.Windows.Forms.TextBox();

            this.numDVGia = new System.Windows.Forms.NumericUpDown();

            this.btnThemDV = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();

            // =============================
            // QUY ĐỊNH
            // =============================
            this.lblQDMa = new System.Windows.Forms.Label();
            this.lblQDLoai = new System.Windows.Forms.Label();
            this.lblQDMucDo = new System.Windows.Forms.Label();
            this.lblQDTien = new System.Windows.Forms.Label();

            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();

            this.numQDTien = new System.Windows.Forms.NumericUpDown();

            this.btnThemQD = new System.Windows.Forms.Button();
            this.dgvQD = new System.Windows.Forms.DataGridView();

            this.btnDong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();

            this.tabMain.SuspendLayout();
            this.tabKhu.SuspendLayout();
            this.tabNV.SuspendLayout();
            this.tabLoaiTN.SuspendLayout();
            this.tabDV.SuspendLayout();
            this.tabQD.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // TAB CONTROL
            // =====================================================
            this.tabMain.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.tabMain.Controls.Add(this.tabKhu);
            this.tabMain.Controls.Add(this.tabNV);
            this.tabMain.Controls.Add(this.tabLoaiTN);
            this.tabMain.Controls.Add(this.tabDV);
            this.tabMain.Controls.Add(this.tabQD);

            this.tabMain.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.tabMain.Location =
                new System.Drawing.Point(15, 15);

            this.tabMain.Name = "tabMain";

            this.tabMain.SelectedIndex = 0;

            this.tabMain.Size =
                new System.Drawing.Size(1070, 590);

            // =====================================================
            // TAB KHU VỰC
            // =====================================================
            this.tabKhu.Text = "Khu vực";
            this.tabKhu.UseVisualStyleBackColor = true;

            this.lblKhuMa.AutoSize = true;
            this.lblKhuMa.Location =
                new System.Drawing.Point(30, 35);
            this.lblKhuMa.Text = "Mã khu:";

            this.txtKhuMa.Location =
                new System.Drawing.Point(110, 31);
            this.txtKhuMa.Size =
                new System.Drawing.Size(180, 30);

            this.lblKhuTen.AutoSize = true;
            this.lblKhuTen.Location =
                new System.Drawing.Point(330, 35);
            this.lblKhuTen.Text = "Tên khu:";

            this.txtKhuTen.Location =
                new System.Drawing.Point(415, 31);
            this.txtKhuTen.Size =
                new System.Drawing.Size(240, 30);

            this.btnThemKhu.Location =
                new System.Drawing.Point(700, 28);
            this.btnThemKhu.Size =
                new System.Drawing.Size(110, 38);
            this.btnThemKhu.Text = "Thêm";
            this.btnThemKhu.Click +=
                new System.EventHandler(this.btnThemKhu_Click);

            this.dgvKhu.ReadOnly = true;
            this.dgvKhu.AllowUserToAddRows = false;
            this.dgvKhu.AllowUserToDeleteRows = false;
            this.dgvKhu.MultiSelect = false;
            this.dgvKhu.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhu.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvKhu.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvKhu.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvKhu.Location =
                new System.Drawing.Point(30, 90);
            this.dgvKhu.Size =
                new System.Drawing.Size(990, 430);

            this.tabKhu.Controls.Add(this.lblKhuMa);
            this.tabKhu.Controls.Add(this.txtKhuMa);
            this.tabKhu.Controls.Add(this.lblKhuTen);
            this.tabKhu.Controls.Add(this.txtKhuTen);
            this.tabKhu.Controls.Add(this.btnThemKhu);
            this.tabKhu.Controls.Add(this.dgvKhu);

            // =====================================================
            // TAB NHÂN VIÊN
            // =====================================================
            this.tabNV.Text = "Nhân viên";
            this.tabNV.UseVisualStyleBackColor = true;

            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location =
                new System.Drawing.Point(25, 30);
            this.lblNVMa.Text = "Mã NV:";

            this.txtNVMa.Location =
                new System.Drawing.Point(100, 26);
            this.txtNVMa.Size =
                new System.Drawing.Size(150, 30);

            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Location =
                new System.Drawing.Point(285, 30);
            this.lblNVTen.Text = "Họ tên:";

            this.txtNVTen.Location =
                new System.Drawing.Point(360, 26);
            this.txtNVTen.Size =
                new System.Drawing.Size(210, 30);

            this.lblNVVaiTro.AutoSize = true;
            this.lblNVVaiTro.Location =
                new System.Drawing.Point(610, 30);
            this.lblNVVaiTro.Text = "Vai trò:";

            this.txtNVVaiTro.Location =
                new System.Drawing.Point(685, 26);
            this.txtNVVaiTro.Size =
                new System.Drawing.Size(180, 30);

            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location =
                new System.Drawing.Point(25, 82);
            this.lblNVSDT.Text = "SĐT:";

            this.txtNVSDT.Location =
                new System.Drawing.Point(100, 78);
            this.txtNVSDT.Size =
                new System.Drawing.Size(200, 30);

            this.btnThemNV.Location =
                new System.Drawing.Point(340, 75);
            this.btnThemNV.Size =
                new System.Drawing.Size(110, 38);
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.Click +=
                new System.EventHandler(this.btnThemNV_Click);

            this.dgvNV.ReadOnly = true;
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.MultiSelect = false;
            this.dgvNV.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvNV.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvNV.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvNV.Location =
                new System.Drawing.Point(25, 135);
            this.dgvNV.Size =
                new System.Drawing.Size(995, 385);

            this.tabNV.Controls.Add(this.lblNVMa);
            this.tabNV.Controls.Add(this.txtNVMa);
            this.tabNV.Controls.Add(this.lblNVTen);
            this.tabNV.Controls.Add(this.txtNVTen);
            this.tabNV.Controls.Add(this.lblNVVaiTro);
            this.tabNV.Controls.Add(this.txtNVVaiTro);
            this.tabNV.Controls.Add(this.lblNVSDT);
            this.tabNV.Controls.Add(this.txtNVSDT);
            this.tabNV.Controls.Add(this.btnThemNV);
            this.tabNV.Controls.Add(this.dgvNV);

            // =====================================================
            // TAB LOẠI TIỆN NGHI
            // =====================================================
            this.tabLoaiTN.Text = "Loại tiện nghi";
            this.tabLoaiTN.UseVisualStyleBackColor = true;

            this.lblLoaiMa.AutoSize = true;
            this.lblLoaiMa.Location =
                new System.Drawing.Point(30, 35);
            this.lblLoaiMa.Text = "Mã loại:";

            this.txtLoaiMa.Location =
                new System.Drawing.Point(115, 31);
            this.txtLoaiMa.Size =
                new System.Drawing.Size(180, 30);

            this.lblLoaiTen.AutoSize = true;
            this.lblLoaiTen.Location =
                new System.Drawing.Point(340, 35);
            this.lblLoaiTen.Text = "Tên loại:";

            this.txtLoaiTen.Location =
                new System.Drawing.Point(430, 31);
            this.txtLoaiTen.Size =
                new System.Drawing.Size(240, 30);

            this.btnThemLoaiTN.Location =
                new System.Drawing.Point(710, 28);
            this.btnThemLoaiTN.Size =
                new System.Drawing.Size(110, 38);
            this.btnThemLoaiTN.Text = "Thêm";
            this.btnThemLoaiTN.Click +=
                new System.EventHandler(this.btnThemLoaiTN_Click);

            this.dgvLoaiTN.ReadOnly = true;
            this.dgvLoaiTN.AllowUserToAddRows = false;
            this.dgvLoaiTN.AllowUserToDeleteRows = false;
            this.dgvLoaiTN.MultiSelect = false;
            this.dgvLoaiTN.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiTN.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvLoaiTN.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvLoaiTN.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvLoaiTN.Location =
                new System.Drawing.Point(30, 90);
            this.dgvLoaiTN.Size =
                new System.Drawing.Size(990, 430);

            this.tabLoaiTN.Controls.Add(this.lblLoaiMa);
            this.tabLoaiTN.Controls.Add(this.txtLoaiMa);
            this.tabLoaiTN.Controls.Add(this.lblLoaiTen);
            this.tabLoaiTN.Controls.Add(this.txtLoaiTen);
            this.tabLoaiTN.Controls.Add(this.btnThemLoaiTN);
            this.tabLoaiTN.Controls.Add(this.dgvLoaiTN);

            // =====================================================
            // TAB DỊCH VỤ
            // =====================================================
            this.tabDV.Text = "Dịch vụ";
            this.tabDV.UseVisualStyleBackColor = true;

            this.lblDVMa.AutoSize = true;
            this.lblDVMa.Location =
                new System.Drawing.Point(25, 30);
            this.lblDVMa.Text = "Mã DV:";

            this.txtDVMa.Location =
                new System.Drawing.Point(100, 26);
            this.txtDVMa.Size =
                new System.Drawing.Size(150, 30);

            this.lblDVTen.AutoSize = true;
            this.lblDVTen.Location =
                new System.Drawing.Point(285, 30);
            this.lblDVTen.Text = "Tên DV:";

            this.txtDVTen.Location =
                new System.Drawing.Point(365, 26);
            this.txtDVTen.Size =
                new System.Drawing.Size(210, 30);

            this.lblDVDVT.AutoSize = true;
            this.lblDVDVT.Location =
                new System.Drawing.Point(610, 30);
            this.lblDVDVT.Text = "Đơn vị:";

            this.txtDVDVT.Location =
                new System.Drawing.Point(685, 26);
            this.txtDVDVT.Size =
                new System.Drawing.Size(160, 30);

            this.lblDVGia.AutoSize = true;
            this.lblDVGia.Location =
                new System.Drawing.Point(25, 82);
            this.lblDVGia.Text = "Đơn giá:";

            this.numDVGia.Location =
                new System.Drawing.Point(100, 78);
            this.numDVGia.Size =
                new System.Drawing.Size(180, 30);
            this.numDVGia.Maximum = 1000000000M;
            this.numDVGia.ThousandsSeparator = true;

            this.btnThemDV.Location =
                new System.Drawing.Point(320, 75);
            this.btnThemDV.Size =
                new System.Drawing.Size(110, 38);
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.Click +=
                new System.EventHandler(this.btnThemDV_Click);

            this.dgvDV.ReadOnly = true;
            this.dgvDV.AllowUserToAddRows = false;
            this.dgvDV.AllowUserToDeleteRows = false;
            this.dgvDV.MultiSelect = false;
            this.dgvDV.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDV.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvDV.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvDV.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvDV.Location =
                new System.Drawing.Point(25, 135);
            this.dgvDV.Size =
                new System.Drawing.Size(995, 385);

            this.tabDV.Controls.Add(this.lblDVMa);
            this.tabDV.Controls.Add(this.txtDVMa);
            this.tabDV.Controls.Add(this.lblDVTen);
            this.tabDV.Controls.Add(this.txtDVTen);
            this.tabDV.Controls.Add(this.lblDVDVT);
            this.tabDV.Controls.Add(this.txtDVDVT);
            this.tabDV.Controls.Add(this.lblDVGia);
            this.tabDV.Controls.Add(this.numDVGia);
            this.tabDV.Controls.Add(this.btnThemDV);
            this.tabDV.Controls.Add(this.dgvDV);

            // =====================================================
            // TAB QUY ĐỊNH ĐỀN BÙ
            // =====================================================
            this.tabQD.Text = "Quy định đền bù";
            this.tabQD.UseVisualStyleBackColor = true;

            this.lblQDMa.AutoSize = true;
            this.lblQDMa.Location =
                new System.Drawing.Point(25, 30);
            this.lblQDMa.Text = "Mã QĐ:";

            this.txtQDMa.Location =
                new System.Drawing.Point(105, 26);
            this.txtQDMa.Size =
                new System.Drawing.Size(150, 30);

            this.lblQDLoai.AutoSize = true;
            this.lblQDLoai.Location =
                new System.Drawing.Point(290, 30);
            this.lblQDLoai.Text = "Loại TN:";

            this.cboQDLoai.Location =
                new System.Drawing.Point(375, 26);
            this.cboQDLoai.Size =
                new System.Drawing.Size(200, 30);
            this.cboQDLoai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblQDMucDo.AutoSize = true;
            this.lblQDMucDo.Location =
                new System.Drawing.Point(610, 30);
            this.lblQDMucDo.Text = "Mức độ:";

            this.txtQDMucDo.Location =
                new System.Drawing.Point(690, 26);
            this.txtQDMucDo.Size =
                new System.Drawing.Size(190, 30);

            this.lblQDTien.AutoSize = true;
            this.lblQDTien.Location =
                new System.Drawing.Point(25, 82);
            this.lblQDTien.Text = "Mức tiền:";

            this.numQDTien.Location =
                new System.Drawing.Point(105, 78);
            this.numQDTien.Size =
                new System.Drawing.Size(180, 30);
            this.numQDTien.Maximum = 1000000000M;
            this.numQDTien.ThousandsSeparator = true;

            this.btnThemQD.Location =
                new System.Drawing.Point(325, 75);
            this.btnThemQD.Size =
                new System.Drawing.Size(110, 38);
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.Click +=
                new System.EventHandler(this.btnThemQD_Click);

            this.dgvQD.ReadOnly = true;
            this.dgvQD.AllowUserToAddRows = false;
            this.dgvQD.AllowUserToDeleteRows = false;
            this.dgvQD.MultiSelect = false;
            this.dgvQD.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQD.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvQD.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvQD.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvQD.Location =
                new System.Drawing.Point(25, 135);
            this.dgvQD.Size =
                new System.Drawing.Size(995, 385);

            this.tabQD.Controls.Add(this.lblQDMa);
            this.tabQD.Controls.Add(this.txtQDMa);
            this.tabQD.Controls.Add(this.lblQDLoai);
            this.tabQD.Controls.Add(this.cboQDLoai);
            this.tabQD.Controls.Add(this.lblQDMucDo);
            this.tabQD.Controls.Add(this.txtQDMucDo);
            this.tabQD.Controls.Add(this.lblQDTien);
            this.tabQD.Controls.Add(this.numQDTien);
            this.tabQD.Controls.Add(this.btnThemQD);
            this.tabQD.Controls.Add(this.dgvQD);

            // =====================================================
            // BUTTON ĐÓNG
            // =====================================================
            this.btnDong.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnDong.Location =
                new System.Drawing.Point(975, 620);

            this.btnDong.Size =
                new System.Drawing.Size(110, 38);

            this.btnDong.Text = "Đóng";

            this.btnDong.Click +=
                new System.EventHandler(this.btnDong_Click);

            // =====================================================
            // FORM
            // =====================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1100, 675);

            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);

            this.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.Name = "FrmDanhMuc";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text = "Danh mục";

            this.Load +=
                new System.EventHandler(this.FrmDanhMuc_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();

            this.tabMain.ResumeLayout(false);
            this.tabKhu.ResumeLayout(false);
            this.tabKhu.PerformLayout();

            this.tabNV.ResumeLayout(false);
            this.tabNV.PerformLayout();

            this.tabLoaiTN.ResumeLayout(false);
            this.tabLoaiTN.PerformLayout();

            this.tabDV.ResumeLayout(false);
            this.tabDV.PerformLayout();

            this.tabQD.ResumeLayout(false);
            this.tabQD.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}