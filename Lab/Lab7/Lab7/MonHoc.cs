﻿using System;
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
	public partial class MonHoc : Form
	{
		public MonHoc()
		{
			InitializeComponent();
		}

		private void monBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.monBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.qLSV_3DataSet);

		}

		private void MonHoc_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'qLSV_3DataSet.Mon' table. You can move, or remove it, as needed.
			this.monTableAdapter.Fill(this.qLSV_3DataSet.Mon);
			// TODO: This line of code loads data into the 'qLSV_3DataSet.Mon' table. You can move, or remove it, as needed.
			this.monTableAdapter.Fill(this.qLSV_3DataSet.Mon);

		}

		private void monBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.monBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.qLSV_3DataSet);

		}
	}
}
