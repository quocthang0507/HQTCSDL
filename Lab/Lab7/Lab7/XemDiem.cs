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
	public partial class XemDiem : Form
	{
		public XemDiem()
		{
			InitializeComponent();
		}

		private void XemDiem_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'qLSV_3DataSet.SinhVien' table. You can move, or remove it, as needed.
			this.sinhVienTableAdapter.Fill(this.qLSV_3DataSet.SinhVien);

		}

		private void btn_Xem_Click(object sender, EventArgs e)
		{
			string connection = global::Lab7.Properties.Settings.Default.QLSV_3ConnectionString;
			string str = string.Format("select TenMH, Diem from KetQua, Mon where [KetQua].MaMH = [Mon].MaMH and MaSo = {0}", cbx_MSSV.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(str, connection);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			dgv_Diem.DataSource = ds.Tables[0];
		}

		private void cbx_MSSV_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void cbx_TenSV_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
