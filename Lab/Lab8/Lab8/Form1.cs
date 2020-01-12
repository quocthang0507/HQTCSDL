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

namespace Lab8
{
	public partial class Form1 : Form
	{
		SqlConnection sqlConnection;
		SqlDataAdapter adapter;
		DataSet data = new DataSet();
		public string server = @"DESKTOP-G3SCN6I\SQLEXPRESS";
		public string database = "QLThuVien";

		public Form1()
		{
			InitializeComponent();
			dtp_NgaySinh.MaxDate = DateTime.Now;
			KetNoiCSDL();
			LoadListView();
		}

		void KetNoiCSDL()
		{
			string connection = "Data Source=" + server + ";Initial Catalog=" + database + ";integrated security=True";
			sqlConnection = new SqlConnection(connection);
		}

		DataTable LayDanhSachNhanVien()
		{
			string query = "select * from NhanVien";
			adapter = new SqlDataAdapter(query, sqlConnection);
			adapter.Fill(data);
			return data.Tables[0];
		}

		void LoadListView()
		{
			lv_NhanVien.FullRowSelect = true;
			DataTable table = LayDanhSachNhanVien();
			for (int i = 0; i < table.Rows.Count; i++)
			{
				ListViewItem item = new ListViewItem(table.Rows[i][1].ToString());
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, table.Rows[i][2].ToString()));
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, table.Rows[i][3].ToString()));
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, table.Rows[i][4].ToString()));
				lv_NhanVien.Items.Add(item);
			}
			lv_NhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			lv_NhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			string sql = string.Format("insert into NhanVien values(N'{0}',{1},N'{2}',{3},{4},N'{5}')",
				tbx_HoTen.Text, dtp_NgaySinh.Value.ToShortDateString(), tbx_DiaChi.Text, tbx_DienThoai.Text, 1, "");
			SqlCommand command = new SqlCommand(sql, sqlConnection);
			command.ExecuteNonQuery();
		}

		private void btn_Thoat_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
				Application.Exit();
		}
	}
}
