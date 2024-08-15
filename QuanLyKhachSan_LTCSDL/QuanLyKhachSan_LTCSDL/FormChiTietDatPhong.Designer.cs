namespace QuanLyKhachSan_LTCSDL
{
    partial class FormChiTietDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietDatPhong));
            this.QLKS = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuuThayDoi = new System.Windows.Forms.Button();
            this.txtSoDem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDDatPhong = new System.Windows.Forms.TextBox();
            this.dpkNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dpkNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatKH = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaPhieuDP = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QLKS
            // 
            this.QLKS.AutoSize = true;
            this.QLKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLKS.ForeColor = System.Drawing.Color.HotPink;
            this.QLKS.Location = new System.Drawing.Point(12, 13);
            this.QLKS.Name = "QLKS";
            this.QLKS.Size = new System.Drawing.Size(376, 38);
            this.QLKS.TabIndex = 7;
            this.QLKS.Text = "CHI TIẾT ĐẶT PHÒNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuuThayDoi);
            this.groupBox2.Controls.Add(this.txtSoDem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIDDatPhong);
            this.groupBox2.Controls.Add(this.dpkNgayTra);
            this.groupBox2.Controls.Add(this.dpkNgayNhan);
            this.groupBox2.Controls.Add(this.cbLoaiPhong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox2.Location = new System.Drawing.Point(19, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 485);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhận phòng";
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.BackColor = System.Drawing.Color.HotPink;
            this.btnLuuThayDoi.FlatAppearance.BorderSize = 0;
            this.btnLuuThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(25, 426);
            this.btnLuuThayDoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(258, 40);
            this.btnLuuThayDoi.TabIndex = 56;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.UseVisualStyleBackColor = false;
            this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
            // 
            // txtSoDem
            // 
            this.txtSoDem.Location = new System.Drawing.Point(25, 367);
            this.txtSoDem.Name = "txtSoDem";
            this.txtSoDem.Size = new System.Drawing.Size(258, 34);
            this.txtSoDem.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Số đêm:";
            // 
            // txtIDDatPhong
            // 
            this.txtIDDatPhong.Location = new System.Drawing.Point(25, 66);
            this.txtIDDatPhong.Name = "txtIDDatPhong";
            this.txtIDDatPhong.Size = new System.Drawing.Size(258, 34);
            this.txtIDDatPhong.TabIndex = 55;
            // 
            // dpkNgayTra
            // 
            this.dpkNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgayTra.Location = new System.Drawing.Point(25, 291);
            this.dpkNgayTra.Name = "dpkNgayTra";
            this.dpkNgayTra.Size = new System.Drawing.Size(258, 34);
            this.dpkNgayTra.TabIndex = 53;
            this.dpkNgayTra.ValueChanged += new System.EventHandler(this.dpkNgayTra_ValueChanged);
            // 
            // dpkNgayNhan
            // 
            this.dpkNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgayNhan.Location = new System.Drawing.Point(24, 216);
            this.dpkNgayNhan.Name = "dpkNgayNhan";
            this.dpkNgayNhan.Size = new System.Drawing.Size(259, 34);
            this.dpkNgayNhan.TabIndex = 53;
            this.dpkNgayNhan.ValueChanged += new System.EventHandler(this.dpkNgayNhan_ValueChanged);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(24, 140);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(259, 36);
            this.cbLoaiPhong.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tên loại phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ngày trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Mã đặt phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ngày nhận:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhatKH);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.dpkNgaySinh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox1.Location = new System.Drawing.Point(365, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 346);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnCapNhatKH
            // 
            this.btnCapNhatKH.BackColor = System.Drawing.Color.HotPink;
            this.btnCapNhatKH.FlatAppearance.BorderSize = 0;
            this.btnCapNhatKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatKH.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatKH.Location = new System.Drawing.Point(183, 285);
            this.btnCapNhatKH.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapNhatKH.Name = "btnCapNhatKH";
            this.btnCapNhatKH.Size = new System.Drawing.Size(258, 40);
            this.btnCapNhatKH.TabIndex = 56;
            this.btnCapNhatKH.Text = "Cập nhật khách hàng";
            this.btnCapNhatKH.UseVisualStyleBackColor = false;
            this.btnCapNhatKH.Click += new System.EventHandler(this.btnCapNhatKH_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(347, 142);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(258, 34);
            this.txtDiaChi.TabIndex = 55;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(26, 142);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(258, 34);
            this.txtCCCD.TabIndex = 55;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(25, 66);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(258, 34);
            this.txtHoTen.TabIndex = 55;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(26, 216);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(258, 34);
            this.txtSDT.TabIndex = 55;
            // 
            // dpkNgaySinh
            // 
            this.dpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgaySinh.Location = new System.Drawing.Point(345, 64);
            this.dpkNgaySinh.Name = "dpkNgaySinh";
            this.dpkNgaySinh.Size = new System.Drawing.Size(259, 34);
            this.dpkNgaySinh.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 54;
            this.label10.Text = "Số điện thoại:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(346, 216);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(259, 36);
            this.cbGioiTinh.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(342, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Căn cước công dân:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(342, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(341, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ngày sinh:";
            // 
            // btnXoaPhieuDP
            // 
            this.btnXoaPhieuDP.BackColor = System.Drawing.Color.HotPink;
            this.btnXoaPhieuDP.FlatAppearance.BorderSize = 0;
            this.btnXoaPhieuDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhieuDP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuDP.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhieuDP.Location = new System.Drawing.Point(421, 491);
            this.btnXoaPhieuDP.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaPhieuDP.Name = "btnXoaPhieuDP";
            this.btnXoaPhieuDP.Size = new System.Drawing.Size(258, 40);
            this.btnXoaPhieuDP.TabIndex = 56;
            this.btnXoaPhieuDP.Text = "Xóa phiếu đặt phòng";
            this.btnXoaPhieuDP.UseVisualStyleBackColor = false;
            this.btnXoaPhieuDP.Click += new System.EventHandler(this.btnXoaPhieuDP_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.HotPink;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(722, 491);
            this.btnDong.Margin = new System.Windows.Forms.Padding(0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(258, 40);
            this.btnDong.TabIndex = 56;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormChiTietDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1029, 568);
            this.Controls.Add(this.btnXoaPhieuDP);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.QLKS);
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChiTietDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTietDatPhong";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QLKS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.DateTimePicker dpkNgayTra;
        private System.Windows.Forms.DateTimePicker dpkNgayNhan;
        private System.Windows.Forms.TextBox txtSoDem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuThayDoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhatKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dpkNgaySinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtIDDatPhong;
        private System.Windows.Forms.Button btnXoaPhieuDP;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}