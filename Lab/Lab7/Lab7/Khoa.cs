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
	public partial class Khoa : Form
	{
		public Khoa()
		{
			InitializeComponent();
		}

		private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.khoaBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.qLSV_3DataSet);

		}

		private void Khoa_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'qLSV_3DataSet.Khoa' table. You can move, or remove it, as needed.
			this.khoaTableAdapter.Fill(this.qLSV_3DataSet.Khoa);
			// TODO: This line of code loads data into the 'qLSV_3DataSet.Khoa' table. You can move, or remove it, as needed.
			this.khoaTableAdapter.Fill(this.qLSV_3DataSet.Khoa);

		}

		private void khoaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.khoaBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.qLSV_3DataSet);

		}
	}
}
