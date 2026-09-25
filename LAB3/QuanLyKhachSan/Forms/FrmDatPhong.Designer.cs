namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKhach;
        private System.Windows.Forms.TabPage tabDatPhong;
        private System.Windows.Forms.TabPage tabNhanPhong;

        // ===== KHÁCH HÀNG =====
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.TextBox txtSDT;

        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.DataGridView dgvKhach;

        // ===== ĐẶT PHÒNG =====
        private System.Windows.Forms.TextBox txtSoPhieu;

        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.ComboBox cboKenh;

        private System.Windows.Forms.DateTimePicker dtLap;
        private System.Windows.Forms.DateTimePicker dtNhan;
        private System.Windows.Forms.DateTimePicker dtTra;

        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.NumericUpDown numSoNguoi;

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvChon;

        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnBoPhong;
        private System.Windows.Forms.Button btnLapPhieu;

        // ===== NHẬN PHÒNG =====
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.DataGridView dgvNguoi;

        private System.Windows.Forms.TextBox txtPhieuChon;
        private System.Windows.Forms.TextBox txtNguoiPhong;
        private System.Windows.Forms.TextBox txtNguoiTen;
        private System.Windows.Forms.TextBox txtNguoiCMND;
        private System.Windows.Forms.TextBox txtNguoiQT;

        private System.Windows.Forms.Button btnThemNguoi;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnNoShow;

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

            this.tabKhach =
                new System.Windows.Forms.TabPage();

            this.tabDatPhong =
                new System.Windows.Forms.TabPage();

            this.tabNhanPhong =
                new System.Windows.Forms.TabPage();

            // ==============================
            // KHÁCH HÀNG
            // ==============================
            this.txtMaKH =
                new System.Windows.Forms.TextBox();

            this.txtTenKH =
                new System.Windows.Forms.TextBox();

            this.txtCMND =
                new System.Windows.Forms.TextBox();

            this.txtQT =
                new System.Windows.Forms.TextBox();

            this.txtSDT =
                new System.Windows.Forms.TextBox();

            this.btnThemKhach =
                new System.Windows.Forms.Button();

            this.dgvKhach =
                new System.Windows.Forms.DataGridView();

            // ==============================
            // ĐẶT PHÒNG
            // ==============================
            this.txtSoPhieu =
                new System.Windows.Forms.TextBox();

            this.cboKhach =
                new System.Windows.Forms.ComboBox();

            this.cboNV =
                new System.Windows.Forms.ComboBox();

            this.cboKenh =
                new System.Windows.Forms.ComboBox();

            this.dtLap =
                new System.Windows.Forms.DateTimePicker();

            this.dtNhan =
                new System.Windows.Forms.DateTimePicker();

            this.dtTra =
                new System.Windows.Forms.DateTimePicker();

            this.numCoc =
                new System.Windows.Forms.NumericUpDown();

            this.numSoNguoi =
                new System.Windows.Forms.NumericUpDown();

            this.dgvPhong =
                new System.Windows.Forms.DataGridView();

            this.dgvChon =
                new System.Windows.Forms.DataGridView();

            this.btnThemPhong =
                new System.Windows.Forms.Button();

            this.btnBoPhong =
                new System.Windows.Forms.Button();

            this.btnLapPhieu =
                new System.Windows.Forms.Button();

            // ==============================
            // NHẬN PHÒNG
            // ==============================
            this.dgvPhieu =
                new System.Windows.Forms.DataGridView();

            this.dgvCT =
                new System.Windows.Forms.DataGridView();

            this.dgvNguoi =
                new System.Windows.Forms.DataGridView();

            this.txtPhieuChon =
                new System.Windows.Forms.TextBox();

            this.txtNguoiPhong =
                new System.Windows.Forms.TextBox();

            this.txtNguoiTen =
                new System.Windows.Forms.TextBox();

            this.txtNguoiCMND =
                new System.Windows.Forms.TextBox();

            this.txtNguoiQT =
                new System.Windows.Forms.TextBox();

            this.btnThemNguoi =
                new System.Windows.Forms.Button();

            this.btnNhanPhong =
                new System.Windows.Forms.Button();

            this.btnNoShow =
                new System.Windows.Forms.Button();

            this.btnDong =
                new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvKhach)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numCoc)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numSoNguoi)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPhong)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvChon)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPhieu)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCT)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvNguoi)).BeginInit();

            this.tabMain.SuspendLayout();
            this.tabKhach.SuspendLayout();
            this.tabDatPhong.SuspendLayout();
            this.tabNhanPhong.SuspendLayout();

            this.SuspendLayout();

            // =================================================
            // tabMain
            // =================================================
            this.tabMain.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.tabMain.Controls.Add(this.tabKhach);
            this.tabMain.Controls.Add(this.tabDatPhong);
            this.tabMain.Controls.Add(this.tabNhanPhong);

            this.tabMain.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.tabMain.Location =
                new System.Drawing.Point(15, 15);

            this.tabMain.Size =
                new System.Drawing.Size(1220, 690);

            this.tabMain.SelectedIndex = 0;

            // =================================================
            // TAB KHÁCH HÀNG
            // =================================================
            this.tabKhach.Text = "Khách hàng";
            this.tabKhach.UseVisualStyleBackColor = true;

            var lblMaKH =
                new System.Windows.Forms.Label();

            lblMaKH.Text = "Mã khách:";
            lblMaKH.AutoSize = true;
            lblMaKH.Location =
                new System.Drawing.Point(25, 30);

            this.txtMaKH.Location =
                new System.Drawing.Point(115, 26);

            this.txtMaKH.Size =
                new System.Drawing.Size(150, 30);


            var lblTenKH =
                new System.Windows.Forms.Label();

            lblTenKH.Text = "Họ tên:";
            lblTenKH.AutoSize = true;
            lblTenKH.Location =
                new System.Drawing.Point(300, 30);

            this.txtTenKH.Location =
                new System.Drawing.Point(370, 26);

            this.txtTenKH.Size =
                new System.Drawing.Size(220, 30);


            var lblCMND =
                new System.Windows.Forms.Label();

            lblCMND.Text = "CCCD/CMND:";
            lblCMND.AutoSize = true;
            lblCMND.Location =
                new System.Drawing.Point(625, 30);

            this.txtCMND.Location =
                new System.Drawing.Point(740, 26);

            this.txtCMND.Size =
                new System.Drawing.Size(180, 30);


            var lblQT =
                new System.Windows.Forms.Label();

            lblQT.Text = "Quốc tịch:";
            lblQT.AutoSize = true;
            lblQT.Location =
                new System.Drawing.Point(25, 80);

            this.txtQT.Location =
                new System.Drawing.Point(115, 76);

            this.txtQT.Size =
                new System.Drawing.Size(180, 30);


            var lblSDT =
                new System.Windows.Forms.Label();

            lblSDT.Text = "SĐT:";
            lblSDT.AutoSize = true;
            lblSDT.Location =
                new System.Drawing.Point(330, 80);

            this.txtSDT.Location =
                new System.Drawing.Point(385, 76);

            this.txtSDT.Size =
                new System.Drawing.Size(180, 30);


            this.btnThemKhach.Text =
                "Thêm khách";

            this.btnThemKhach.Location =
                new System.Drawing.Point(610, 72);

            this.btnThemKhach.Size =
                new System.Drawing.Size(130, 38);

            this.btnThemKhach.Click +=
                new System.EventHandler(
                    this.btnThemKhach_Click);


            this.dgvKhach.Location =
                new System.Drawing.Point(25, 135);

            this.dgvKhach.Size =
                new System.Drawing.Size(1150, 495);

            this.dgvKhach.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvKhach.ReadOnly = true;
            this.dgvKhach.AllowUserToAddRows = false;
            this.dgvKhach.AllowUserToDeleteRows = false;
            this.dgvKhach.MultiSelect = false;

            this.dgvKhach.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvKhach.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvKhach.BackgroundColor =
                System.Drawing.Color.White;

            this.tabKhach.Controls.Add(lblMaKH);
            this.tabKhach.Controls.Add(this.txtMaKH);

            this.tabKhach.Controls.Add(lblTenKH);
            this.tabKhach.Controls.Add(this.txtTenKH);

            this.tabKhach.Controls.Add(lblCMND);
            this.tabKhach.Controls.Add(this.txtCMND);

            this.tabKhach.Controls.Add(lblQT);
            this.tabKhach.Controls.Add(this.txtQT);

            this.tabKhach.Controls.Add(lblSDT);
            this.tabKhach.Controls.Add(this.txtSDT);

            this.tabKhach.Controls.Add(this.btnThemKhach);
            this.tabKhach.Controls.Add(this.dgvKhach);


            // =================================================
            // TAB ĐẶT PHÒNG
            // =================================================
            this.tabDatPhong.Text = "Đặt phòng";
            this.tabDatPhong.UseVisualStyleBackColor = true;

            var lblSoPhieu =
                new System.Windows.Forms.Label();

            lblSoPhieu.Text = "Số phiếu:";
            lblSoPhieu.AutoSize = true;
            lblSoPhieu.Location =
                new System.Drawing.Point(20, 25);

            this.txtSoPhieu.Location =
                new System.Drawing.Point(100, 21);

            this.txtSoPhieu.Size =
                new System.Drawing.Size(150, 30);


            var lblKhach =
                new System.Windows.Forms.Label();

            lblKhach.Text = "Khách:";
            lblKhach.AutoSize = true;
            lblKhach.Location =
                new System.Drawing.Point(280, 25);

            this.cboKhach.Location =
                new System.Drawing.Point(345, 21);

            this.cboKhach.Size =
                new System.Drawing.Size(210, 30);

            this.cboKhach.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            var lblNV =
                new System.Windows.Forms.Label();

            lblNV.Text = "Lễ tân:";
            lblNV.AutoSize = true;
            lblNV.Location =
                new System.Drawing.Point(585, 25);

            this.cboNV.Location =
                new System.Drawing.Point(650, 21);

            this.cboNV.Size =
                new System.Drawing.Size(200, 30);

            this.cboNV.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            var lblKenh =
                new System.Windows.Forms.Label();

            lblKenh.Text = "Kênh đặt:";
            lblKenh.AutoSize = true;
            lblKenh.Location =
                new System.Drawing.Point(20, 70);

            this.cboKenh.Location =
                new System.Drawing.Point(100, 66);

            this.cboKenh.Size =
                new System.Drawing.Size(150, 30);

            this.cboKenh.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;


            var lblLap =
                new System.Windows.Forms.Label();

            lblLap.Text = "Ngày lập:";
            lblLap.AutoSize = true;
            lblLap.Location =
                new System.Drawing.Point(280, 70);

            this.dtLap.Location =
                new System.Drawing.Point(355, 66);

            this.dtLap.Size =
                new System.Drawing.Size(145, 30);

            this.dtLap.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;


            var lblNhan =
                new System.Windows.Forms.Label();

            lblNhan.Text = "Ngày nhận:";
            lblNhan.AutoSize = true;
            lblNhan.Location =
                new System.Drawing.Point(530, 70);

            this.dtNhan.Location =
                new System.Drawing.Point(625, 66);

            this.dtNhan.Size =
                new System.Drawing.Size(145, 30);

            this.dtNhan.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;


            var lblTra =
                new System.Windows.Forms.Label();

            lblTra.Text = "Ngày trả:";
            lblTra.AutoSize = true;
            lblTra.Location =
                new System.Drawing.Point(800, 70);

            this.dtTra.Location =
                new System.Drawing.Point(880, 66);

            this.dtTra.Size =
                new System.Drawing.Size(145, 30);

            this.dtTra.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;


            var lblCoc =
                new System.Windows.Forms.Label();

            lblCoc.Text = "Tiền cọc:";
            lblCoc.AutoSize = true;
            lblCoc.Location =
                new System.Drawing.Point(20, 115);

            this.numCoc.Location =
                new System.Drawing.Point(100, 111);

            this.numCoc.Size =
                new System.Drawing.Size(180, 30);

            this.numCoc.Maximum = 1000000000M;
            this.numCoc.ThousandsSeparator = true;


            // GRID PHÒNG
            this.dgvPhong.Location =
                new System.Drawing.Point(20, 160);

            this.dgvPhong.Size =
                new System.Drawing.Size(565, 220);

            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.MultiSelect = false;

            this.dgvPhong.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvPhong.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvPhong.BackgroundColor =
                System.Drawing.Color.White;


            var lblSoNguoi =
                new System.Windows.Forms.Label();

            lblSoNguoi.Text = "Số người:";
            lblSoNguoi.AutoSize = true;
            lblSoNguoi.Location =
                new System.Drawing.Point(20, 400);

            this.numSoNguoi.Location =
                new System.Drawing.Point(100, 396);

            this.numSoNguoi.Size =
                new System.Drawing.Size(90, 30);

            this.numSoNguoi.Minimum = 1;
            this.numSoNguoi.Maximum = 100;


            this.btnThemPhong.Text =
                "Thêm phòng >>";

            this.btnThemPhong.Location =
                new System.Drawing.Point(220, 392);

            this.btnThemPhong.Size =
                new System.Drawing.Size(130, 38);

            this.btnThemPhong.Click +=
                new System.EventHandler(
                    this.btnThemPhong_Click);


            // GRID PHÒNG CHỌN
            this.dgvChon.Location =
                new System.Drawing.Point(610, 160);

            this.dgvChon.Size =
                new System.Drawing.Size(565, 220);

            this.dgvChon.ReadOnly = true;
            this.dgvChon.AllowUserToAddRows = false;
            this.dgvChon.AllowUserToDeleteRows = false;
            this.dgvChon.MultiSelect = false;

            this.dgvChon.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvChon.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvChon.BackgroundColor =
                System.Drawing.Color.White;


            this.btnBoPhong.Text =
                "Bỏ phòng";

            this.btnBoPhong.Location =
                new System.Drawing.Point(610, 392);

            this.btnBoPhong.Size =
                new System.Drawing.Size(110, 38);

            this.btnBoPhong.Click +=
                new System.EventHandler(
                    this.btnBoPhong_Click);


            this.btnLapPhieu.Text =
                "Lập phiếu đặt phòng";

            this.btnLapPhieu.Location =
                new System.Drawing.Point(490, 470);

            this.btnLapPhieu.Size =
                new System.Drawing.Size(190, 45);

            this.btnLapPhieu.Click +=
                new System.EventHandler(
                    this.btnLapPhieu_Click);


            this.tabDatPhong.Controls.Add(lblSoPhieu);
            this.tabDatPhong.Controls.Add(this.txtSoPhieu);

            this.tabDatPhong.Controls.Add(lblKhach);
            this.tabDatPhong.Controls.Add(this.cboKhach);

            this.tabDatPhong.Controls.Add(lblNV);
            this.tabDatPhong.Controls.Add(this.cboNV);

            this.tabDatPhong.Controls.Add(lblKenh);
            this.tabDatPhong.Controls.Add(this.cboKenh);

            this.tabDatPhong.Controls.Add(lblLap);
            this.tabDatPhong.Controls.Add(this.dtLap);

            this.tabDatPhong.Controls.Add(lblNhan);
            this.tabDatPhong.Controls.Add(this.dtNhan);

            this.tabDatPhong.Controls.Add(lblTra);
            this.tabDatPhong.Controls.Add(this.dtTra);

            this.tabDatPhong.Controls.Add(lblCoc);
            this.tabDatPhong.Controls.Add(this.numCoc);

            this.tabDatPhong.Controls.Add(this.dgvPhong);

            this.tabDatPhong.Controls.Add(lblSoNguoi);
            this.tabDatPhong.Controls.Add(this.numSoNguoi);

            this.tabDatPhong.Controls.Add(this.btnThemPhong);

            this.tabDatPhong.Controls.Add(this.dgvChon);

            this.tabDatPhong.Controls.Add(this.btnBoPhong);

            this.tabDatPhong.Controls.Add(this.btnLapPhieu);


            // =================================================
            // TAB NHẬN PHÒNG
            // =================================================
            this.tabNhanPhong.Text =
                "Nhận phòng";

            this.tabNhanPhong.UseVisualStyleBackColor =
                true;


            // PHIẾU
            this.dgvPhieu.Location =
                new System.Drawing.Point(20, 20);

            this.dgvPhieu.Size =
                new System.Drawing.Size(1155, 180);

            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AllowUserToDeleteRows = false;
            this.dgvPhieu.MultiSelect = false;

            this.dgvPhieu.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvPhieu.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvPhieu.ScrollBars =
                System.Windows.Forms.ScrollBars.Both;

            this.dgvPhieu.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvPhieu.SelectionChanged +=
                new System.EventHandler(
                    this.dgvPhieu_SelectionChanged);


            var lblPhieuChon =
                new System.Windows.Forms.Label();

            lblPhieuChon.Text =
                "Phiếu chọn:";

            lblPhieuChon.AutoSize = true;

            lblPhieuChon.Location =
                new System.Drawing.Point(20, 218);


            this.txtPhieuChon.Location =
                new System.Drawing.Point(115, 214);

            this.txtPhieuChon.Size =
                new System.Drawing.Size(170, 30);

            this.txtPhieuChon.ReadOnly = true;


            this.btnNhanPhong.Text =
                "Nhận phòng";

            this.btnNhanPhong.Location =
                new System.Drawing.Point(330, 210);

            this.btnNhanPhong.Size =
                new System.Drawing.Size(125, 38);

            this.btnNhanPhong.Click +=
                new System.EventHandler(
                    this.btnNhanPhong_Click);


            this.btnNoShow.Text =
                "No-show";

            this.btnNoShow.Location =
                new System.Drawing.Point(475, 210);

            this.btnNoShow.Size =
                new System.Drawing.Size(110, 38);

            this.btnNoShow.Click +=
                new System.EventHandler(
                    this.btnNoShow_Click);


            // CHI TIẾT PHÒNG
            this.dgvCT.Location =
                new System.Drawing.Point(20, 270);

            this.dgvCT.Size =
                new System.Drawing.Size(555, 155);

            this.dgvCT.ReadOnly = true;
            this.dgvCT.AllowUserToAddRows = false;
            this.dgvCT.AllowUserToDeleteRows = false;
            this.dgvCT.MultiSelect = false;

            this.dgvCT.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvCT.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvCT.BackgroundColor =
                System.Drawing.Color.White;

            this.dgvCT.SelectionChanged +=
                new System.EventHandler(
                    this.dgvCT_SelectionChanged);


            // NGƯỜI LƯU TRÚ
            this.dgvNguoi.Location =
                new System.Drawing.Point(610, 270);

            this.dgvNguoi.Size =
                new System.Drawing.Size(565, 155);

            this.dgvNguoi.ReadOnly = true;
            this.dgvNguoi.AllowUserToAddRows = false;
            this.dgvNguoi.AllowUserToDeleteRows = false;
            this.dgvNguoi.MultiSelect = false;

            this.dgvNguoi.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvNguoi.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvNguoi.ScrollBars =
                System.Windows.Forms.ScrollBars.Both;

            this.dgvNguoi.BackgroundColor =
                System.Drawing.Color.White;


            // INPUT NGƯỜI LƯU TRÚ
            var lblNguoiPhong =
                new System.Windows.Forms.Label();

            lblNguoiPhong.Text = "Phòng:";
            lblNguoiPhong.AutoSize = true;

            lblNguoiPhong.Location =
                new System.Drawing.Point(20, 455);

            this.txtNguoiPhong.Location =
                new System.Drawing.Point(90, 451);

            this.txtNguoiPhong.Size =
                new System.Drawing.Size(110, 30);

            this.txtNguoiPhong.ReadOnly = true;


            var lblNguoiTen =
                new System.Windows.Forms.Label();

            lblNguoiTen.Text = "Họ tên:";
            lblNguoiTen.AutoSize = true;

            lblNguoiTen.Location =
                new System.Drawing.Point(235, 455);

            this.txtNguoiTen.Location =
                new System.Drawing.Point(305, 451);

            this.txtNguoiTen.Size =
                new System.Drawing.Size(190, 30);


            var lblNguoiCMND =
                new System.Windows.Forms.Label();

            lblNguoiCMND.Text = "CCCD:";
            lblNguoiCMND.AutoSize = true;

            lblNguoiCMND.Location =
                new System.Drawing.Point(530, 455);

            this.txtNguoiCMND.Location =
                new System.Drawing.Point(600, 451);

            this.txtNguoiCMND.Size =
                new System.Drawing.Size(180, 30);


            var lblNguoiQT =
                new System.Windows.Forms.Label();

            lblNguoiQT.Text = "Quốc tịch:";
            lblNguoiQT.AutoSize = true;

            lblNguoiQT.Location =
                new System.Drawing.Point(815, 455);

            this.txtNguoiQT.Location =
                new System.Drawing.Point(900, 451);

            this.txtNguoiQT.Size =
                new System.Drawing.Size(170, 30);


            this.btnThemNguoi.Text =
                "Thêm người lưu trú";

            this.btnThemNguoi.Location =
                new System.Drawing.Point(490, 510);

            this.btnThemNguoi.Size =
                new System.Drawing.Size(180, 40);

            this.btnThemNguoi.Click +=
                new System.EventHandler(
                    this.btnThemNguoi_Click);


            this.tabNhanPhong.Controls.Add(
                this.dgvPhieu);

            this.tabNhanPhong.Controls.Add(
                lblPhieuChon);

            this.tabNhanPhong.Controls.Add(
                this.txtPhieuChon);

            this.tabNhanPhong.Controls.Add(
                this.btnNhanPhong);

            this.tabNhanPhong.Controls.Add(
                this.btnNoShow);

            this.tabNhanPhong.Controls.Add(
                this.dgvCT);

            this.tabNhanPhong.Controls.Add(
                this.dgvNguoi);

            this.tabNhanPhong.Controls.Add(
                lblNguoiPhong);

            this.tabNhanPhong.Controls.Add(
                this.txtNguoiPhong);

            this.tabNhanPhong.Controls.Add(
                lblNguoiTen);

            this.tabNhanPhong.Controls.Add(
                this.txtNguoiTen);

            this.tabNhanPhong.Controls.Add(
                lblNguoiCMND);

            this.tabNhanPhong.Controls.Add(
                this.txtNguoiCMND);

            this.tabNhanPhong.Controls.Add(
                lblNguoiQT);

            this.tabNhanPhong.Controls.Add(
                this.txtNguoiQT);

            this.tabNhanPhong.Controls.Add(
                this.btnThemNguoi);


            // =================================================
            // btnDong
            // =================================================
            this.btnDong.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnDong.Location =
                new System.Drawing.Point(1125, 720);

            this.btnDong.Size =
                new System.Drawing.Size(110, 38);

            this.btnDong.Text = "Đóng";

            this.btnDong.Click +=
                new System.EventHandler(
                    this.btnDong_Click);


            // =================================================
            // FrmDatPhong
            // =================================================
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1250, 775);

            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);

            this.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.Name =
                "FrmDatPhong";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            this.Text =
                "Đặt / Nhận phòng";

            this.Load +=
                new System.EventHandler(
                    this.FrmDatPhong_Load);


            ((System.ComponentModel.ISupportInitialize)
                (this.dgvKhach)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numCoc)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.numSoNguoi)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPhong)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvChon)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvPhieu)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCT)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvNguoi)).EndInit();


            this.tabMain.ResumeLayout(false);

            this.tabKhach.ResumeLayout(false);
            this.tabKhach.PerformLayout();

            this.tabDatPhong.ResumeLayout(false);
            this.tabDatPhong.PerformLayout();

            this.tabNhanPhong.ResumeLayout(false);
            this.tabNhanPhong.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}