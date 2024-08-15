namespace QuanLyKhachSan_LTCSDL
{
    partial class FormQLKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLKhachHang));
            this.QLKS = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.IDKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_XoaKhachHang = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnCapNhatKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.groupQLKhachHang = new System.Windows.Forms.GroupBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbIDKhachHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbTimKiemKhachHang = new System.Windows.Forms.ComboBox();
            this.txtTimKhachHang = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupQLKhachHang.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // QLKS
            // 
            this.QLKS.AutoSize = true;
            this.QLKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.QLKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLKS.ForeColor = System.Drawing.Color.HotPink;
            this.QLKS.Location = new System.Drawing.Point(13, 9);
            this.QLKS.Name = "QLKS";
            this.QLKS.Size = new System.Drawing.Size(410, 38);
            this.QLKS.TabIndex = 67;
            this.QLKS.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox3.Controls.Add(this.dataGridViewKhachHang);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox3.Location = new System.Drawing.Point(541, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 752);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng";
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKhachHang,
            this.Ten,
            this.CCCD,
            this.GioiTinh,
            this.NgaySinh,
            this.SDT,
            this.DiaChi});
            this.dataGridViewKhachHang.GridColor = System.Drawing.Color.White;
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(6, 81);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.RowHeadersWidth = 51;
            this.dataGridViewKhachHang.RowTemplate.Height = 24;
            this.dataGridViewKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(945, 665);
            this.dataGridViewKhachHang.TabIndex = 1;
            this.dataGridViewKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachHang_CellClick);
            this.dataGridViewKhachHang.SelectionChanged += new System.EventHandler(this.dataGridViewKhachHang_SelectionChanged);
            // 
            // IDKhachHang
            // 
            this.IDKhachHang.DataPropertyName = "ID";
            this.IDKhachHang.HeaderText = "Mã";
            this.IDKhachHang.MinimumWidth = 6;
            this.IDKhachHang.Name = "IDKhachHang";
            this.IDKhachHang.Width = 125;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.btn_XoaKhachHang);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnCapNhatKH);
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox1.Location = new System.Drawing.Point(36, 610);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 167);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_XoaKhachHang
            // 
            this.btn_XoaKhachHang.BackColor = System.Drawing.Color.HotPink;
            this.btn_XoaKhachHang.FlatAppearance.BorderSize = 0;
            this.btn_XoaKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaKhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_XoaKhachHang.Location = new System.Drawing.Point(15, 103);
            this.btn_XoaKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XoaKhachHang.Name = "btn_XoaKhachHang";
            this.btn_XoaKhachHang.Size = new System.Drawing.Size(207, 40);
            this.btn_XoaKhachHang.TabIndex = 51;
            this.btn_XoaKhachHang.Text = "Xoá khách hàng";
            this.btn_XoaKhachHang.UseVisualStyleBackColor = false;
            this.btn_XoaKhachHang.Click += new System.EventHandler(this.btn_XoaKhachHang_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.HotPink;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(254, 103);
            this.btnDong.Margin = new System.Windows.Forms.Padding(0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(207, 40);
            this.btnDong.TabIndex = 50;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnCapNhatKH
            // 
            this.btnCapNhatKH.BackColor = System.Drawing.Color.HotPink;
            this.btnCapNhatKH.FlatAppearance.BorderSize = 0;
            this.btnCapNhatKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatKH.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatKH.Location = new System.Drawing.Point(15, 41);
            this.btnCapNhatKH.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapNhatKH.Name = "btnCapNhatKH";
            this.btnCapNhatKH.Size = new System.Drawing.Size(207, 40);
            this.btnCapNhatKH.TabIndex = 50;
            this.btnCapNhatKH.Text = "Cập nhật";
            this.btnCapNhatKH.UseVisualStyleBackColor = false;
            this.btnCapNhatKH.Click += new System.EventHandler(this.btnCapNhatKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.HotPink;
            this.btnThemKH.FlatAppearance.BorderSize = 0;
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.ForeColor = System.Drawing.Color.White;
            this.btnThemKH.Location = new System.Drawing.Point(254, 41);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(207, 40);
            this.btnThemKH.TabIndex = 50;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // groupQLKhachHang
            // 
            this.groupQLKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupQLKhachHang.Controls.Add(this.dateNgaySinh);
            this.groupQLKhachHang.Controls.Add(this.cbGioiTinh);
            this.groupQLKhachHang.Controls.Add(this.cbIDKhachHang);
            this.groupQLKhachHang.Controls.Add(this.label1);
            this.groupQLKhachHang.Controls.Add(this.txtCCCD);
            this.groupQLKhachHang.Controls.Add(this.txtDiaChi);
            this.groupQLKhachHang.Controls.Add(this.txtSDT);
            this.groupQLKhachHang.Controls.Add(this.txtHoTen);
            this.groupQLKhachHang.Controls.Add(this.label6);
            this.groupQLKhachHang.Controls.Add(this.label11);
            this.groupQLKhachHang.Controls.Add(this.label13);
            this.groupQLKhachHang.Controls.Add(this.label14);
            this.groupQLKhachHang.Controls.Add(this.label15);
            this.groupQLKhachHang.Controls.Add(this.label2);
            this.groupQLKhachHang.Controls.Add(this.label16);
            this.groupQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupQLKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupQLKhachHang.ForeColor = System.Drawing.Color.HotPink;
            this.groupQLKhachHang.Location = new System.Drawing.Point(36, 218);
            this.groupQLKhachHang.Name = "groupQLKhachHang";
            this.groupQLKhachHang.Size = new System.Drawing.Size(486, 371);
            this.groupQLKhachHang.TabIndex = 73;
            this.groupQLKhachHang.TabStop = false;
            this.groupQLKhachHang.Text = "Thông tin khách hàng";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(254, 68);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(207, 34);
            this.dateNgaySinh.TabIndex = 64;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(26, 290);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(207, 36);
            this.cbGioiTinh.TabIndex = 62;
            // 
            // cbIDKhachHang
            // 
            this.cbIDKhachHang.FormattingEnabled = true;
            this.cbIDKhachHang.Location = new System.Drawing.Point(26, 68);
            this.cbIDKhachHang.Name = "cbIDKhachHang";
            this.cbIDKhachHang.Size = new System.Drawing.Size(207, 36);
            this.cbIDKhachHang.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Địa chỉ:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(26, 211);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(207, 34);
            this.txtCCCD.TabIndex = 58;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(254, 211);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(207, 34);
            this.txtDiaChi.TabIndex = 58;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(254, 141);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(207, 34);
            this.txtSDT.TabIndex = 57;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(26, 141);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 34);
            this.txtHoTen.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(252, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ngày sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(250, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Số điện thoại:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(250, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(21, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "CCCD:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(21, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Giới tính:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(21, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã khách hàng:";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox6.Controls.Add(this.btnTimKiem);
            this.groupBox6.Controls.Add(this.cbTimKiemKhachHang);
            this.groupBox6.Controls.Add(this.txtTimKhachHang);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox6.Location = new System.Drawing.Point(36, 63);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(486, 149);
            this.groupBox6.TabIndex = 72;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.HotPink;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(255, 78);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(207, 40);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbTimKiemKhachHang
            // 
            this.cbTimKiemKhachHang.FormattingEnabled = true;
            this.cbTimKiemKhachHang.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Số CCCD",
            "Số điện thoại"});
            this.cbTimKiemKhachHang.Location = new System.Drawing.Point(26, 78);
            this.cbTimKiemKhachHang.Name = "cbTimKiemKhachHang";
            this.cbTimKiemKhachHang.Size = new System.Drawing.Size(200, 36);
            this.cbTimKiemKhachHang.TabIndex = 62;
            // 
            // txtTimKhachHang
            // 
            this.txtTimKhachHang.Location = new System.Drawing.Point(254, 29);
            this.txtTimKhachHang.Name = "txtTimKhachHang";
            this.txtTimKhachHang.Size = new System.Drawing.Size(207, 34);
            this.txtTimKhachHang.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(21, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "Tìm kiếm:";
            // 
            // FormQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1524, 862);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupQLKhachHang);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.QLKS);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.Pink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLKhachHang";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupQLKhachHang.ResumeLayout(false);
            this.groupQLKhachHang.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label QLKS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnCapNhatKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.GroupBox groupQLKhachHang;
        private System.Windows.Forms.ComboBox cbIDKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiemKhachHang;
        private System.Windows.Forms.TextBox txtTimKhachHang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XoaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}