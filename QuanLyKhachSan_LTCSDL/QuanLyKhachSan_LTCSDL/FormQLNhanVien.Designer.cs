namespace QuanLyKhachSan_LTCSDL
{
    partial class FormQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNhanVien));
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnCapNhatNV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnDatLaiMatKhau = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.QLKS = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDauLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNhanVien = new System.Windows.Forms.GroupBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateNgayBatDauLam = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.groupNhanVien.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.HotPink;
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(275, 53);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(207, 40);
            this.btnThemNV.TabIndex = 50;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.BackColor = System.Drawing.Color.HotPink;
            this.btnCapNhatNV.FlatAppearance.BorderSize = 0;
            this.btnCapNhatNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatNV.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatNV.Location = new System.Drawing.Point(22, 53);
            this.btnCapNhatNV.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(207, 40);
            this.btnCapNhatNV.TabIndex = 50;
            this.btnCapNhatNV.Text = "Cập nhật nhân viên";
            this.btnCapNhatNV.UseVisualStyleBackColor = false;
            this.btnCapNhatNV.Click += new System.EventHandler(this.btnCapNhatNV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.btnDatLaiMatKhau);
            this.groupBox1.Controls.Add(this.btnCapNhatNV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox1.Location = new System.Drawing.Point(19, 584);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 222);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.HotPink;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(279, 151);
            this.btnDong.Margin = new System.Windows.Forms.Padding(0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(207, 40);
            this.btnDong.TabIndex = 50;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDatLaiMatKhau
            // 
            this.btnDatLaiMatKhau.BackColor = System.Drawing.Color.HotPink;
            this.btnDatLaiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDatLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiMatKhau.Location = new System.Drawing.Point(22, 151);
            this.btnDatLaiMatKhau.Margin = new System.Windows.Forms.Padding(0);
            this.btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
            this.btnDatLaiMatKhau.Size = new System.Drawing.Size(207, 40);
            this.btnDatLaiMatKhau.TabIndex = 50;
            this.btnDatLaiMatKhau.Text = "Đặt lại mật khẩu";
            this.btnDatLaiMatKhau.UseVisualStyleBackColor = false;
            this.btnDatLaiMatKhau.Click += new System.EventHandler(this.btnDatLaiMatKhau_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox6.Controls.Add(this.btnTimKiem);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtTimKiem);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox6.Location = new System.Drawing.Point(21, 57);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 179);
            this.groupBox6.TabIndex = 63;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.HotPink;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(20, 122);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(207, 40);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(15, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "Tài khoản";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(20, 67);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 34);
            this.txtTimKiem.TabIndex = 53;
            // 
            // QLKS
            // 
            this.QLKS.AutoSize = true;
            this.QLKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.QLKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLKS.ForeColor = System.Drawing.Color.HotPink;
            this.QLKS.Location = new System.Drawing.Point(12, 9);
            this.QLKS.Name = "QLKS";
            this.QLKS.Size = new System.Drawing.Size(367, 38);
            this.QLKS.TabIndex = 62;
            this.QLKS.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGioiTinh.Location = new System.Drawing.Point(13, 226);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(207, 36);
            this.cbGioiTinh.TabIndex = 63;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox3.Controls.Add(this.dataGridViewNhanVien);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox3.Location = new System.Drawing.Point(566, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(914, 752);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng";
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.Ten,
            this.LoaiNhanVien,
            this.CCCD,
            this.NgaySinh,
            this.GioiTinh,
            this.SDT,
            this.NgayBatDauLam,
            this.DiaChi,
            this.IDLoaiNhanVien});
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(6, 65);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.RowHeadersWidth = 51;
            this.dataGridViewNhanVien.RowTemplate.Height = 24;
            this.dataGridViewNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(908, 681);
            this.dataGridViewNhanVien.TabIndex = 1;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellClick);
            this.dataGridViewNhanVien.SelectionChanged += new System.EventHandler(this.dataGridViewNhanVien_SelectionChanged);
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 125;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // LoaiNhanVien
            // 
            this.LoaiNhanVien.DataPropertyName = "TenLoai";
            this.LoaiNhanVien.HeaderText = "Loại Nhân Viên";
            this.LoaiNhanVien.MinimumWidth = 6;
            this.LoaiNhanVien.Name = "LoaiNhanVien";
            this.LoaiNhanVien.Width = 125;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // NgayBatDauLam
            // 
            this.NgayBatDauLam.DataPropertyName = "NgayBatDauLam";
            this.NgayBatDauLam.HeaderText = "Ngày bắt đầu làm";
            this.NgayBatDauLam.MinimumWidth = 6;
            this.NgayBatDauLam.Name = "NgayBatDauLam";
            this.NgayBatDauLam.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // IDLoaiNhanVien
            // 
            this.IDLoaiNhanVien.DataPropertyName = "IDLoaiNhanVien";
            this.IDLoaiNhanVien.HeaderText = "";
            this.IDLoaiNhanVien.MinimumWidth = 6;
            this.IDLoaiNhanVien.Name = "IDLoaiNhanVien";
            this.IDLoaiNhanVien.Width = 125;
            // 
            // groupNhanVien
            // 
            this.groupNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupNhanVien.Controls.Add(this.dateNgaySinh);
            this.groupNhanVien.Controls.Add(this.cbGioiTinh);
            this.groupNhanVien.Controls.Add(this.txtSDT);
            this.groupNhanVien.Controls.Add(this.txtDiaChi);
            this.groupNhanVien.Controls.Add(this.txtTen);
            this.groupNhanVien.Controls.Add(this.txtCCCD);
            this.groupNhanVien.Controls.Add(this.label6);
            this.groupNhanVien.Controls.Add(this.label11);
            this.groupNhanVien.Controls.Add(this.label1);
            this.groupNhanVien.Controls.Add(this.label13);
            this.groupNhanVien.Controls.Add(this.label14);
            this.groupNhanVien.Controls.Add(this.label15);
            this.groupNhanVien.Controls.Add(this.label16);
            this.groupNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupNhanVien.ForeColor = System.Drawing.Color.HotPink;
            this.groupNhanVien.Location = new System.Drawing.Point(285, 59);
            this.groupNhanVien.Name = "groupNhanVien";
            this.groupNhanVien.Size = new System.Drawing.Size(241, 519);
            this.groupNhanVien.TabIndex = 64;
            this.groupNhanVien.TabStop = false;
            this.groupNhanVien.Text = "Thông tin nhân viên";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(13, 302);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(207, 34);
            this.dateNgaySinh.TabIndex = 64;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(13, 388);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(207, 34);
            this.txtSDT.TabIndex = 57;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(10, 464);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(207, 34);
            this.txtDiaChi.TabIndex = 57;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(13, 81);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(207, 34);
            this.txtTen.TabIndex = 53;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(13, 154);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(207, 34);
            this.txtCCCD.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Số điện thoại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ngày sinh:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(237, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 28;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Giới tính:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Căn cước công dân:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(8, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox2.Controls.Add(this.dateNgayBatDauLam);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbLoaiNhanVien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenDangNhap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox2.Location = new System.Drawing.Point(21, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 291);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản nhân viên";
            // 
            // dateNgayBatDauLam
            // 
            this.dateNgayBatDauLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBatDauLam.Location = new System.Drawing.Point(20, 229);
            this.dateNgayBatDauLam.Name = "dateNgayBatDauLam";
            this.dateNgayBatDauLam.Size = new System.Drawing.Size(207, 34);
            this.dateNgayBatDauLam.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Loại nhân viên:";
            // 
            // cbLoaiNhanVien
            // 
            this.cbLoaiNhanVien.FormattingEnabled = true;
            this.cbLoaiNhanVien.Location = new System.Drawing.Point(20, 141);
            this.cbLoaiNhanVien.Name = "cbLoaiNhanVien";
            this.cbLoaiNhanVien.Size = new System.Drawing.Size(207, 36);
            this.cbLoaiNhanVien.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(20, 67);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(207, 34);
            this.txtTenDangNhap.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày vào làm";
            // 
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1557, 850);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.QLKS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupNhanVien);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLNhanVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.groupNhanVien.ResumeLayout(false);
            this.groupNhanVien.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnCapNhatNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatLaiMatKhau;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label QLKS;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.GroupBox groupNhanVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateNgayBatDauLam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoaiNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDauLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLoaiNhanVien;
    }
}