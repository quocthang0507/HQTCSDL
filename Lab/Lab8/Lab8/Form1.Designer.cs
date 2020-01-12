namespace Lab8
{
	partial class Form1
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
			this.tbx_DiaChi = new System.Windows.Forms.TextBox();
			this.tbx_DienThoai = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbx_HoTen = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Thoat = new System.Windows.Forms.Button();
			this.btn_Sua = new System.Windows.Forms.Button();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.btn_Them = new System.Windows.Forms.Button();
			this.lv_NhanVien = new System.Windows.Forms.ListView();
			this.MaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HoTenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MaBangCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(778, 56);
			this.label1.TabIndex = 1;
			this.label1.Text = "DANH MỤC NHÂN VIÊN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtp_NgaySinh);
			this.groupBox1.Controls.Add(this.tbx_DiaChi);
			this.groupBox1.Controls.Add(this.tbx_DienThoai);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbx_HoTen);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(778, 106);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết";
			// 
			// dtp_NgaySinh
			// 
			this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
			this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_NgaySinh.Location = new System.Drawing.Point(97, 58);
			this.dtp_NgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtp_NgaySinh.Name = "dtp_NgaySinh";
			this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 23);
			this.dtp_NgaySinh.TabIndex = 3;
			// 
			// tbx_DiaChi
			// 
			this.tbx_DiaChi.Location = new System.Drawing.Point(451, 58);
			this.tbx_DiaChi.Name = "tbx_DiaChi";
			this.tbx_DiaChi.Size = new System.Drawing.Size(200, 23);
			this.tbx_DiaChi.TabIndex = 4;
			// 
			// tbx_DienThoai
			// 
			this.tbx_DienThoai.Location = new System.Drawing.Point(451, 32);
			this.tbx_DienThoai.Name = "tbx_DienThoai";
			this.tbx_DienThoai.Size = new System.Drawing.Size(200, 23);
			this.tbx_DienThoai.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(364, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Địa chỉ:";
			// 
			// tbx_HoTen
			// 
			this.tbx_HoTen.Location = new System.Drawing.Point(97, 29);
			this.tbx_HoTen.Name = "tbx_HoTen";
			this.tbx_HoTen.Size = new System.Drawing.Size(200, 23);
			this.tbx_HoTen.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(364, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Điện thoại:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Ngày sinh:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ tên:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lv_NhanVien);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 227);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(778, 331);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin chung";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Thoat);
			this.panel1.Controls.Add(this.btn_Sua);
			this.panel1.Controls.Add(this.btn_Xoa);
			this.panel1.Controls.Add(this.btn_Them);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 171);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(778, 50);
			this.panel1.TabIndex = 4;
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Thoat.Location = new System.Drawing.Point(518, 10);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(100, 30);
			this.btn_Thoat.TabIndex = 8;
			this.btn_Thoat.Text = "Thoát";
			this.btn_Thoat.UseVisualStyleBackColor = true;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// btn_Sua
			// 
			this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btn_Sua.Location = new System.Drawing.Point(397, 10);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(100, 30);
			this.btn_Sua.TabIndex = 7;
			this.btn_Sua.Text = "Sửa";
			this.btn_Sua.UseVisualStyleBackColor = true;
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btn_Xoa.Location = new System.Drawing.Point(266, 10);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(100, 30);
			this.btn_Xoa.TabIndex = 6;
			this.btn_Xoa.Text = "Xóa";
			this.btn_Xoa.UseVisualStyleBackColor = true;
			// 
			// btn_Them
			// 
			this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btn_Them.Location = new System.Drawing.Point(153, 10);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(100, 30);
			this.btn_Them.TabIndex = 5;
			this.btn_Them.Text = "Thêm";
			this.btn_Them.UseVisualStyleBackColor = true;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// lv_NhanVien
			// 
			this.lv_NhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNhanVien,
            this.HoTenNhanVien,
            this.NgaySinh,
            this.DiaChi,
            this.DienThoai,
            this.MaBangCap});
			this.lv_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_NhanVien.HideSelection = false;
			this.lv_NhanVien.Location = new System.Drawing.Point(3, 19);
			this.lv_NhanVien.Name = "lv_NhanVien";
			this.lv_NhanVien.Size = new System.Drawing.Size(772, 309);
			this.lv_NhanVien.TabIndex = 0;
			this.lv_NhanVien.UseCompatibleStateImageBehavior = false;
			this.lv_NhanVien.View = System.Windows.Forms.View.Details;
			// 
			// MaNhanVien
			// 
			this.MaNhanVien.Text = "Mã nhân viên";
			// 
			// HoTenNhanVien
			// 
			this.HoTenNhanVien.Text = "Họ tên nhân viên";
			// 
			// NgaySinh
			// 
			this.NgaySinh.Text = "Ngày sinh";
			// 
			// DiaChi
			// 
			this.DiaChi.Text = "Địa chỉ";
			// 
			// DienThoai
			// 
			this.DienThoai.Text = "Điện thoại";
			// 
			// MaBangCap
			// 
			this.MaBangCap.Text = "Mã bằng cấp";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_Thoat;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Quản lý danh mục nhân viên";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Thoat;
		private System.Windows.Forms.Button btn_Sua;
		private System.Windows.Forms.Button btn_Xoa;
		private System.Windows.Forms.Button btn_Them;
		private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
		private System.Windows.Forms.TextBox tbx_HoTen;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbx_DiaChi;
		private System.Windows.Forms.TextBox tbx_DienThoai;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView lv_NhanVien;
		private System.Windows.Forms.ColumnHeader MaNhanVien;
		private System.Windows.Forms.ColumnHeader HoTenNhanVien;
		private System.Windows.Forms.ColumnHeader NgaySinh;
		private System.Windows.Forms.ColumnHeader DiaChi;
		private System.Windows.Forms.ColumnHeader DienThoai;
		private System.Windows.Forms.ColumnHeader MaBangCap;
	}
}

