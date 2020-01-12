namespace Lab7
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStrip_SinhVien = new System.Windows.Forms.ToolStripButton();
			this.toolStrip_Khoa = new System.Windows.Forms.ToolStripButton();
			this.toolStrip_MonHoc = new System.Windows.Forms.ToolStripButton();
			this.toolStrip_NhapDiem = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip_XemDiem = new System.Windows.Forms.ToolStripButton();
			this.toolStrip_ThongKeKhoa = new System.Windows.Forms.ToolStripButton();
			this.toolStrip_Thoat = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4);
			this.menuStrip1.Size = new System.Drawing.Size(1067, 29);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
			this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
			// 
			// chứcNăngToolStripMenuItem
			// 
			this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
			this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
			this.chứcNăngToolStripMenuItem.Text = "&Chức năng";
			// 
			// hỗTrợToolStripMenuItem
			// 
			this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
			this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.hỗTrợToolStripMenuItem.Text = "&Hỗ trợ";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_SinhVien,
            this.toolStrip_Khoa,
            this.toolStrip_MonHoc,
            this.toolStrip_NhapDiem,
            this.toolStripSeparator1,
            this.toolStrip_XemDiem,
            this.toolStrip_ThongKeKhoa,
            this.toolStrip_Thoat});
			this.toolStrip1.Location = new System.Drawing.Point(0, 29);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(4);
			this.toolStrip1.Size = new System.Drawing.Size(1067, 35);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStrip_SinhVien
			// 
			this.toolStrip_SinhVien.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_SinhVien.Image")));
			this.toolStrip_SinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStrip_SinhVien.Name = "toolStrip_SinhVien";
			this.toolStrip_SinhVien.Size = new System.Drawing.Size(90, 24);
			this.toolStrip_SinhVien.Text = "&Sinh viên";
			this.toolStrip_SinhVien.Click += new System.EventHandler(this.toolStrip_SinhVien_Click);
			// 
			// toolStrip_Khoa
			// 
			this.toolStrip_Khoa.Image = global::Lab7.Properties.Resources.khoa;
			this.toolStrip_Khoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStrip_Khoa.Name = "toolStrip_Khoa";
			this.toolStrip_Khoa.Size = new System.Drawing.Size(65, 24);
			this.toolStrip_Khoa.Text = "&Khoa";
			this.toolStrip_Khoa.Click += new System.EventHandler(this.toolStrip_Khoa_Click);
			// 
			// toolStrip_MonHoc
			// 
			this.toolStrip_MonHoc.Image = global::Lab7.Properties.Resources.monhoc;
			this.toolStrip_MonHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStrip_MonHoc.Name = "toolStrip_MonHoc";
			this.toolStrip_MonHoc.Size = new System.Drawing.Size(86, 24);
			this.toolStrip_MonHoc.Text = "&Môn học";
			this.toolStrip_MonHoc.Click += new System.EventHandler(this.toolStrip_MonHoc_Click);
			// 
			// toolStrip_NhapDiem
			// 
			this.toolStrip_NhapDiem.Image = global::Lab7.Properties.Resources.nhapdiem;
			this.toolStrip_NhapDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStrip_NhapDiem.Name = "toolStrip_NhapDiem";
			this.toolStrip_NhapDiem.Size = new System.Drawing.Size(100, 24);
			this.toolStrip_NhapDiem.Text = "&Nhập điểm";
			this.toolStrip_NhapDiem.Click += new System.EventHandler(this.toolStrip_NhapDiem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStrip_XemDiem
			// 
			this.toolStrip_XemDiem.Image = global::Lab7.Properties.Resources.xemdiem;
			this.toolStrip_XemDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStrip_XemDiem.Name = "toolStrip_XemDiem";
			this.toolStrip_XemDiem.Size = new System.Drawing.Size(94, 24);
			this.toolStrip_XemDiem.Text = "&Xem điểm";
			this.toolStrip_XemDiem.Click += new System.EventHandler(this.toolStrip_XemDiem_Click);
			// 
			// toolStrip_ThongKeKhoa
			// 
			this.toolStrip_ThongKeKhoa.Image = global::Lab7.Properties.Resources.thongke;
			this.toolStrip_ThongKeKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStrip_ThongKeKhoa.Name = "toolStrip_ThongKeKhoa";
			this.toolStrip_ThongKeKhoa.Size = new System.Drawing.Size(129, 24);
			this.toolStrip_ThongKeKhoa.Text = "&Thống kê Khoa";
			this.toolStrip_ThongKeKhoa.Click += new System.EventHandler(this.toolStrip_ThongKeKhoa_Click);
			// 
			// toolStrip_Thoat
			// 
			this.toolStrip_Thoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStrip_Thoat.Image = global::Lab7.Properties.Resources.exit;
			this.toolStrip_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStrip_Thoat.Name = "toolStrip_Thoat";
			this.toolStrip_Thoat.Size = new System.Drawing.Size(69, 24);
			this.toolStrip_Thoat.Text = "&Thoát";
			this.toolStrip_Thoat.Click += new System.EventHandler(this.toolStrip_Thoat_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 566);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1067, 588);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Quản lý sinh viên";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStrip_SinhVien;
		private System.Windows.Forms.ToolStripButton toolStrip_Khoa;
		private System.Windows.Forms.ToolStripButton toolStrip_MonHoc;
		private System.Windows.Forms.ToolStripButton toolStrip_NhapDiem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStrip_XemDiem;
		private System.Windows.Forms.ToolStripButton toolStrip_ThongKeKhoa;
		private System.Windows.Forms.ToolStripButton toolStrip_Thoat;
		private System.Windows.Forms.StatusStrip statusStrip1;
	}
}

