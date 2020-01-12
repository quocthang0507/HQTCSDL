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
	public partial class SinhVien : Form
	{
		public SinhVien()
		{
			InitializeComponent();
		}

		private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.sinhVienBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.qLSV_3DataSet);

		}

		private void SinhVien_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'qLSV_3DataSet.SinhVien' table. You can move, or remove it, as needed.
			this.sinhVienTableAdapter.Fill(this.qLSV_3DataSet.SinhVien);
			// TODO: This line of code loads data into the 'qLSV_3DataSet.SinhVien' table. You can move, or remove it, as needed.
			this.sinhVienTableAdapter.Fill(this.qLSV_3DataSet.SinhVien);

		}

		private void sinhVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.sinhVienBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.qLSV_3DataSet);

		}
	}
}
