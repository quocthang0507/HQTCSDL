using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void toolStrip_SinhVien_Click(object sender, EventArgs e)
		{
			Form fSinhVien = new SinhVien();
			fSinhVien.MdiParent = this;
			fSinhVien.Show();
		}

		private void toolStrip_Khoa_Click(object sender, EventArgs e)
		{
			Form fKhoa = new Khoa();
			fKhoa.MdiParent = this;
			fKhoa.Show();
		}

		private void toolStrip_MonHoc_Click(object sender, EventArgs e)
		{
			Form fMonHoc = new MonHoc();
			fMonHoc.MdiParent = this;
			fMonHoc.Show();
		}

		private void toolStrip_NhapDiem_Click(object sender, EventArgs e)
		{
			Form fDiem = new Diem();
			fDiem.MdiParent = this;
			fDiem.Show();
		}

		private void toolStrip_Thoat_Click(object sender, EventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Bạn thật sự muốn thoát?", "Thoát khỏi chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialog == DialogResult.Yes)
				Application.Exit();
		}

		private void toolStrip_XemDiem_Click(object sender, EventArgs e)
		{
			Form fDiem = new XemDiem();
			fDiem.MdiParent = this;
			fDiem.Show();
		}

		private void toolStrip_ThongKeKhoa_Click(object sender, EventArgs e)
		{
			Form fDSSV = new SinhVienKhoa();
			fDSSV.MdiParent = this;
			fDSSV.Show();
		}
	}
}
