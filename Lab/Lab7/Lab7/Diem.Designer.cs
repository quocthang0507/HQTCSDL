namespace Lab7
{
	partial class Diem
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label maSoLabel;
			System.Windows.Forms.Label maMHLabel;
			System.Windows.Forms.Label diemLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diem));
			this.qLSV_3DataSet = new Lab7.QLSV_3DataSet();
			this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ketQuaTableAdapter = new Lab7.QLSV_3DataSetTableAdapters.KetQuaTableAdapter();
			this.tableAdapterManager = new Lab7.QLSV_3DataSetTableAdapters.TableAdapterManager();
			this.ketQuaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ketQuaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.maSoTextBox = new System.Windows.Forms.TextBox();
			this.maMHTextBox = new System.Windows.Forms.TextBox();
			this.diemTextBox = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ketQuaDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			maSoLabel = new System.Windows.Forms.Label();
			maMHLabel = new System.Windows.Forms.Label();
			diemLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingNavigator)).BeginInit();
			this.ketQuaBindingNavigator.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// maSoLabel
			// 
			maSoLabel.AutoSize = true;
			maSoLabel.Location = new System.Drawing.Point(21, 31);
			maSoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			maSoLabel.Name = "maSoLabel";
			maSoLabel.Size = new System.Drawing.Size(50, 17);
			maSoLabel.TabIndex = 7;
			maSoLabel.Text = "Mã số:";
			// 
			// maMHLabel
			// 
			maMHLabel.AutoSize = true;
			maMHLabel.Location = new System.Drawing.Point(21, 65);
			maMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			maMHLabel.Name = "maMHLabel";
			maMHLabel.Size = new System.Drawing.Size(89, 17);
			maMHLabel.TabIndex = 9;
			maMHLabel.Text = "Mã môn học:";
			// 
			// diemLabel
			// 
			diemLabel.AutoSize = true;
			diemLabel.Location = new System.Drawing.Point(21, 99);
			diemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			diemLabel.Name = "diemLabel";
			diemLabel.Size = new System.Drawing.Size(44, 17);
			diemLabel.TabIndex = 11;
			diemLabel.Text = "Điểm:";
			// 
			// qLSV_3DataSet
			// 
			this.qLSV_3DataSet.DataSetName = "QLSV_3DataSet";
			this.qLSV_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ketQuaBindingSource
			// 
			this.ketQuaBindingSource.DataMember = "KetQua";
			this.ketQuaBindingSource.DataSource = this.qLSV_3DataSet;
			// 
			// ketQuaTableAdapter
			// 
			this.ketQuaTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.KetQuaTableAdapter = this.ketQuaTableAdapter;
			this.tableAdapterManager.KhoaTableAdapter = null;
			this.tableAdapterManager.MonTableAdapter = null;
			this.tableAdapterManager.SinhVienTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Lab7.QLSV_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// ketQuaBindingNavigator
			// 
			this.ketQuaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.ketQuaBindingNavigator.BindingSource = this.ketQuaBindingSource;
			this.ketQuaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.ketQuaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.ketQuaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ketQuaBindingNavigatorSaveItem});
			this.ketQuaBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.ketQuaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.ketQuaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.ketQuaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.ketQuaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.ketQuaBindingNavigator.Name = "ketQuaBindingNavigator";
			this.ketQuaBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.ketQuaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.ketQuaBindingNavigator.Size = new System.Drawing.Size(784, 25);
			this.ketQuaBindingNavigator.TabIndex = 0;
			this.ketQuaBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// ketQuaBindingNavigatorSaveItem
			// 
			this.ketQuaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ketQuaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ketQuaBindingNavigatorSaveItem.Image")));
			this.ketQuaBindingNavigatorSaveItem.Name = "ketQuaBindingNavigatorSaveItem";
			this.ketQuaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.ketQuaBindingNavigatorSaveItem.Text = "Save Data";
			this.ketQuaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ketQuaBindingNavigatorSaveItem_Click_1);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 536);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(maSoLabel);
			this.panel1.Controls.Add(this.maSoTextBox);
			this.panel1.Controls.Add(maMHLabel);
			this.panel1.Controls.Add(this.maMHTextBox);
			this.panel1.Controls.Add(diemLabel);
			this.panel1.Controls.Add(this.diemTextBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 152);
			this.panel1.TabIndex = 0;
			// 
			// maSoTextBox
			// 
			this.maSoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "MaSo", true));
			this.maSoTextBox.Location = new System.Drawing.Point(117, 28);
			this.maSoTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.maSoTextBox.Name = "maSoTextBox";
			this.maSoTextBox.Size = new System.Drawing.Size(187, 23);
			this.maSoTextBox.TabIndex = 8;
			// 
			// maMHTextBox
			// 
			this.maMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "MaMH", true));
			this.maMHTextBox.Location = new System.Drawing.Point(117, 62);
			this.maMHTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.maMHTextBox.Name = "maMHTextBox";
			this.maMHTextBox.Size = new System.Drawing.Size(187, 23);
			this.maMHTextBox.TabIndex = 10;
			// 
			// diemTextBox
			// 
			this.diemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "Diem", true));
			this.diemTextBox.Location = new System.Drawing.Point(117, 96);
			this.diemTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.diemTextBox.Name = "diemTextBox";
			this.diemTextBox.Size = new System.Drawing.Size(187, 23);
			this.diemTextBox.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.ketQuaDataGridView);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(4, 164);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 368);
			this.panel2.TabIndex = 1;
			// 
			// ketQuaDataGridView
			// 
			this.ketQuaDataGridView.AutoGenerateColumns = false;
			this.ketQuaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.ketQuaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ketQuaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.ketQuaDataGridView.DataSource = this.ketQuaBindingSource;
			this.ketQuaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ketQuaDataGridView.Location = new System.Drawing.Point(0, 0);
			this.ketQuaDataGridView.Name = "ketQuaDataGridView";
			this.ketQuaDataGridView.Size = new System.Drawing.Size(776, 368);
			this.ketQuaDataGridView.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSo";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã số sinh viên";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ToolTipText = "Mã số sinh viên";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "MaMH";
			this.dataGridViewTextBoxColumn2.HeaderText = "Mã môn học";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ToolTipText = "Mã môn học";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Diem";
			this.dataGridViewTextBoxColumn3.HeaderText = "Điểm";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ToolTipText = "Điểm";
			// 
			// Diem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.ketQuaBindingNavigator);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Diem";
			this.Text = "Nhập thông tin điểm";
			this.Load += new System.EventHandler(this.Diem_Load);
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingNavigator)).EndInit();
			this.ketQuaBindingNavigator.ResumeLayout(false);
			this.ketQuaBindingNavigator.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ketQuaDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private QLSV_3DataSet qLSV_3DataSet;
		private System.Windows.Forms.BindingSource ketQuaBindingSource;
		private QLSV_3DataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
		private QLSV_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator ketQuaBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton ketQuaBindingNavigatorSaveItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox maSoTextBox;
		private System.Windows.Forms.TextBox maMHTextBox;
		private System.Windows.Forms.TextBox diemTextBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView ketQuaDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}