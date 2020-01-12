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
	public partial class Diem : Form
	{
		private static Diem instance;

		public static Diem Instance()
		{
			if (instance == null)
				instance = new Diem();
			return instance;
		}

		public Diem()
		{
			InitializeComponent();
		}

		private void ketQuaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.ketQuaBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.qLSV_3DataSet);

		}

		private void Diem_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'qLSV_3DataSet.KetQua' table. You can move, or remove it, as needed.
			this.ketQuaTableAdapter.Fill(this.qLSV_3DataSet.KetQua);
			// TODO: This line of code loads data into the 'qLSV_3DataSet.KetQua' table. You can move, or remove it, as needed.
			this.ketQuaTableAdapter.Fill(this.qLSV_3DataSet.KetQua);

		}

		private void ketQuaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.ketQuaBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.qLSV_3DataSet);

		}
	}
}
