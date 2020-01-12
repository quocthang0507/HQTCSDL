using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
	public partial class SinhVienKhoa : Form
	{
		public SinhVienKhoa()
		{
			InitializeComponent();
		}

		private void SinhVienKhoa_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'qLSV_3DataSet.Khoa' table. You can move, or remove it, as needed.
			this.khoaTableAdapter.Fill(this.qLSV_3DataSet.Khoa);
			// TODO: This line of code loads data into the 'qLSV_3DataSet.Khoa' table. You can move, or remove it, as needed.
			this.khoaTableAdapter.Fill(this.qLSV_3DataSet.Khoa);

		}

		private void btn_Xem_Click(object sender, EventArgs e)
		{
			string connection = global::Lab7.Properties.Settings.Default.QLSV_3ConnectionString;
			string str = string.Format("select * from Khoa, SinhVien where [Khoa].MaKhoa = [SinhVien].MaKhoa and Khoa.MaKhoa = '{0}'", cbx_MaKhoa.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(str, connection);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgv_SinhVienKhoa.DataSource = ds.Tables[0];
		}
	}
}
