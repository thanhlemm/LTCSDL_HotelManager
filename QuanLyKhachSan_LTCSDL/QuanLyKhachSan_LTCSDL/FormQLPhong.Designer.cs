namespace QuanLyKhachSan_LTCSDL
{
    partial class FormQLPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLPhong));
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoNguoiToiDa = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTrangThaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTrangThaiPhong = new System.Windows.Forms.ComboBox();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimPhong = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.QLKS = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSuaLoaiPhong = new System.Windows.Forms.Button();
            this.btnCapNhatPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(254, 68);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(200, 36);
            this.cbLoaiPhong.TabIndex = 62;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Số người tối đa:";
            // 
            // txtSoNguoiToiDa
            // 
            this.txtSoNguoiToiDa.Location = new System.Drawing.Point(254, 211);
            this.txtSoNguoiToiDa.Name = "txtSoNguoiToiDa";
            this.txtSoNguoiToiDa.Size = new System.Drawing.Size(207, 34);
            this.txtSoNguoiToiDa.TabIndex = 58;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(254, 141);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(207, 34);
            this.txtGiaPhong.TabIndex = 57;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(26, 141);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(207, 34);
            this.txtTenPhong.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(252, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Loại phòng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(250, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Giá phòng";
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
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Trạng thái:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(21, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Tên phòng:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(21, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã phòng:";
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenPhong,
            this.TenLoaiPhong,
            this.GiaPhong,
            this.SoLuongNguoi,
            this.TrangThai,
            this.IDLoaiPhong,
            this.IDTrangThaiPhong});
            this.dataGridViewPhong.Location = new System.Drawing.Point(6, 52);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.RowHeadersWidth = 51;
            this.dataGridViewPhong.RowTemplate.Height = 24;
            this.dataGridViewPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhong.Size = new System.Drawing.Size(877, 617);
            this.dataGridViewPhong.TabIndex = 1;
            this.dataGridViewPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhong_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã phòng";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 140;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 140;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Loại phòng";
            this.TenLoaiPhong.MinimumWidth = 6;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.Width = 140;
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "GiaPhong";
            this.GiaPhong.HeaderText = "Giá";
            this.GiaPhong.MinimumWidth = 6;
            this.GiaPhong.Name = "GiaPhong";
            this.GiaPhong.Width = 125;
            // 
            // SoLuongNguoi
            // 
            this.SoLuongNguoi.DataPropertyName = "SoLuongNguoi";
            this.SoLuongNguoi.HeaderText = "Số người tối đa";
            this.SoLuongNguoi.MinimumWidth = 6;
            this.SoLuongNguoi.Name = "SoLuongNguoi";
            this.SoLuongNguoi.Width = 140;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 140;
            // 
            // IDLoaiPhong
            // 
            this.IDLoaiPhong.DataPropertyName = "IDLoaiPhong";
            this.IDLoaiPhong.HeaderText = "";
            this.IDLoaiPhong.MinimumWidth = 6;
            this.IDLoaiPhong.Name = "IDLoaiPhong";
            this.IDLoaiPhong.Width = 125;
            // 
            // IDTrangThaiPhong
            // 
            this.IDTrangThaiPhong.DataPropertyName = "IDTrangThaiPhong";
            this.IDTrangThaiPhong.HeaderText = "";
            this.IDTrangThaiPhong.MinimumWidth = 6;
            this.IDTrangThaiPhong.Name = "IDTrangThaiPhong";
            this.IDTrangThaiPhong.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox3.Controls.Add(this.dataGridViewPhong);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox3.Location = new System.Drawing.Point(543, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(894, 669);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox2.Controls.Add(this.cbTrangThaiPhong);
            this.groupBox2.Controls.Add(this.cbMaPhong);
            this.groupBox2.Controls.Add(this.cbLoaiPhong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSoNguoiToiDa);
            this.groupBox2.Controls.Add(this.txtGiaPhong);
            this.groupBox2.Controls.Add(this.txtTenPhong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox2.Location = new System.Drawing.Point(19, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 276);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng";
            // 
            // cbTrangThaiPhong
            // 
            this.cbTrangThaiPhong.FormattingEnabled = true;
            this.cbTrangThaiPhong.Location = new System.Drawing.Point(26, 222);
            this.cbTrangThaiPhong.Name = "cbTrangThaiPhong";
            this.cbTrangThaiPhong.Size = new System.Drawing.Size(200, 36);
            this.cbTrangThaiPhong.TabIndex = 63;
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(26, 68);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(200, 36);
            this.cbMaPhong.TabIndex = 62;
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
            // txtTimPhong
            // 
            this.txtTimPhong.Location = new System.Drawing.Point(26, 81);
            this.txtTimPhong.Name = "txtTimPhong";
            this.txtTimPhong.Size = new System.Drawing.Size(207, 34);
            this.txtTimPhong.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(21, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "Mã/ Tên phòng";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox6.Controls.Add(this.btnTimKiem);
            this.groupBox6.Controls.Add(this.txtTimPhong);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox6.Location = new System.Drawing.Point(19, 52);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(486, 149);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm kiếm";
            // 
            // QLKS
            // 
            this.QLKS.AutoSize = true;
            this.QLKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.QLKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLKS.ForeColor = System.Drawing.Color.HotPink;
            this.QLKS.Location = new System.Drawing.Point(12, 11);
            this.QLKS.Name = "QLKS";
            this.QLKS.Size = new System.Drawing.Size(306, 38);
            this.QLKS.TabIndex = 56;
            this.QLKS.Text = "QUẢN LÝ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnSuaLoaiPhong);
            this.groupBox1.Controls.Add(this.btnCapNhatPhong);
            this.groupBox1.Controls.Add(this.btnThemPhong);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox1.Location = new System.Drawing.Point(19, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 167);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.HotPink;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(254, 101);
            this.btnDong.Margin = new System.Windows.Forms.Padding(0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(207, 40);
            this.btnDong.TabIndex = 50;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSuaLoaiPhong
            // 
            this.btnSuaLoaiPhong.BackColor = System.Drawing.Color.HotPink;
            this.btnSuaLoaiPhong.FlatAppearance.BorderSize = 0;
            this.btnSuaLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.btnSuaLoaiPhong.Location = new System.Drawing.Point(254, 40);
            this.btnSuaLoaiPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            this.btnSuaLoaiPhong.Size = new System.Drawing.Size(207, 40);
            this.btnSuaLoaiPhong.TabIndex = 50;
            this.btnSuaLoaiPhong.Text = "Sửa loại phòng";
            this.btnSuaLoaiPhong.UseVisualStyleBackColor = false;
            this.btnSuaLoaiPhong.Click += new System.EventHandler(this.btnSuaLoaiPhong_Click);
            // 
            // btnCapNhatPhong
            // 
            this.btnCapNhatPhong.BackColor = System.Drawing.Color.HotPink;
            this.btnCapNhatPhong.FlatAppearance.BorderSize = 0;
            this.btnCapNhatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatPhong.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatPhong.Location = new System.Drawing.Point(26, 101);
            this.btnCapNhatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapNhatPhong.Name = "btnCapNhatPhong";
            this.btnCapNhatPhong.Size = new System.Drawing.Size(207, 40);
            this.btnCapNhatPhong.TabIndex = 50;
            this.btnCapNhatPhong.Text = "Cập nhật phòng";
            this.btnCapNhatPhong.UseVisualStyleBackColor = false;
            this.btnCapNhatPhong.Click += new System.EventHandler(this.btnCapNhatPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.HotPink;
            this.btnThemPhong.FlatAppearance.BorderSize = 0;
            this.btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhong.ForeColor = System.Drawing.Color.White;
            this.btnThemPhong.Location = new System.Drawing.Point(26, 40);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(207, 40);
            this.btnThemPhong.TabIndex = 50;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // FormQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1452, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.QLKS);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoNguoiToiDa;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimPhong;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label QLKS;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSuaLoaiPhong;
        private System.Windows.Forms.Button btnCapNhatPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.ComboBox cbTrangThaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTrangThaiPhong;
    }
}