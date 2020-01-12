namespace Lab7
{
	partial class MonHoc
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
			System.Windows.Forms.Label maMHLabel;
			System.Windows.Forms.Label tenMHLabel;
			System.Windows.Forms.Label soTietLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHoc));
			this.qLSV_3DataSet = new Lab7.QLSV_3DataSet();
			this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.monTableAdapter = new Lab7.QLSV_3DataSetTableAdapters.MonTableAdapter();
			this.tableAdapterManager = new Lab7.QLSV_3DataSetTableAdapters.TableAdapterManager();
			this.monBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.monBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.monDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.maMHTextBox = new System.Windows.Forms.TextBox();
			this.tenMHTextBox = new System.Windows.Forms.TextBox();
			this.soTietTextBox = new System.Windows.Forms.TextBox();
			maMHLabel = new System.Windows.Forms.Label();
			tenMHLabel = new System.Windows.Forms.Label();
			soTietLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.monBindingNavigator)).BeginInit();
			this.monBindingNavigator.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.monDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// maMHLabel
			// 
			maMHLabel.AutoSize = true;
			maMHLabel.Location = new System.Drawing.Point(9, 25);
			maMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			maMHLabel.Name = "maMHLabel";
			maMHLabel.Size = new System.Drawing.Size(89, 17);
			maMHLabel.TabIndex = 7;
			maMHLabel.Text = "Mã môn học:";
			// 
			// tenMHLabel
			// 
			tenMHLabel.AutoSize = true;
			tenMHLabel.Location = new System.Drawing.Point(9, 59);
			tenMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			tenMHLabel.Name = "tenMHLabel";
			tenMHLabel.Size = new System.Drawing.Size(95, 17);
			tenMHLabel.TabIndex = 9;
			tenMHLabel.Text = "Tên môn học:";
			// 
			// soTietLabel
			// 
			soTietLabel.AutoSize = true;
			soTietLabel.Location = new System.Drawing.Point(9, 93);
			soTietLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			soTietLabel.Name = "soTietLabel";
			soTietLabel.Size = new System.Drawing.Size(52, 17);
			soTietLabel.TabIndex = 11;
			soTietLabel.Text = "Số tiết:";
			// 
			// qLSV_3DataSet
			// 
			this.qLSV_3DataSet.DataSetName = "QLSV_3DataSet";
			this.qLSV_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// monBindingSource
			// 
			this.monBindingSource.DataMember = "Mon";
			this.monBindingSource.DataSource = this.qLSV_3DataSet;
			// 
			// monTableAdapter
			// 
			this.monTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.KetQuaTableAdapter = null;
			this.tableAdapterManager.KhoaTableAdapter = null;
			this.tableAdapterManager.MonTableAdapter = this.monTableAdapter;
			this.tableAdapterManager.SinhVienTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Lab7.QLSV_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// monBindingNavigator
			// 
			this.monBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.monBindingNavigator.BindingSource = this.monBindingSource;
			this.monBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.monBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.monBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.monBindingNavigatorSaveItem});
			this.monBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.monBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.monBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.monBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.monBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.monBindingNavigator.Name = "monBindingNavigator";
			this.monBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.monBindingNavigator.Size = new System.Drawing.Size(784, 25);
			this.monBindingNavigator.TabIndex = 0;
			this.monBindingNavigator.Text = "bindingNavigator1";
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
			// monBindingNavigatorSaveItem
			// 
			this.monBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.monBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("monBindingNavigatorSaveItem.Image")));
			this.monBindingNavigatorSaveItem.Name = "monBindingNavigatorSaveItem";
			this.monBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.monBindingNavigatorSaveItem.Text = "Save Data";
			this.monBindingNavigatorSaveItem.Click += new System.EventHandler(this.monBindingNavigatorSaveItem_Click_1);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.monDataGridView, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 536);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// monDataGridView
			// 
			this.monDataGridView.AutoGenerateColumns = false;
			this.monDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.monDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.monDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.monDataGridView.DataSource = this.monBindingSource;
			this.monDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.monDataGridView.Location = new System.Drawing.Point(4, 164);
			this.monDataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.monDataGridView.Name = "monDataGridView";
			this.monDataGridView.Size = new System.Drawing.Size(776, 368);
			this.monDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMH";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã môn học";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ToolTipText = "Mã môn học";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "TenMH";
			this.dataGridViewTextBoxColumn2.HeaderText = "Tên môn học";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ToolTipText = "Tên môn học";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "SoTiet";
			this.dataGridViewTextBoxColumn3.HeaderText = "Số tiết";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ToolTipText = "Số tiết";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(maMHLabel);
			this.panel1.Controls.Add(this.maMHTextBox);
			this.panel1.Controls.Add(tenMHLabel);
			this.panel1.Controls.Add(this.tenMHTextBox);
			this.panel1.Controls.Add(soTietLabel);
			this.panel1.Controls.Add(this.soTietTextBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 152);
			this.panel1.TabIndex = 0;
			// 
			// maMHTextBox
			// 
			this.maMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "MaMH", true));
			this.maMHTextBox.Location = new System.Drawing.Point(126, 19);
			this.maMHTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.maMHTextBox.Name = "maMHTextBox";
			this.maMHTextBox.Size = new System.Drawing.Size(206, 23);
			this.maMHTextBox.TabIndex = 8;
			// 
			// tenMHTextBox
			// 
			this.tenMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "TenMH", true));
			this.tenMHTextBox.Location = new System.Drawing.Point(126, 53);
			this.tenMHTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.tenMHTextBox.Name = "tenMHTextBox";
			this.tenMHTextBox.Size = new System.Drawing.Size(206, 23);
			this.tenMHTextBox.TabIndex = 10;
			// 
			// soTietTextBox
			// 
			this.soTietTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "SoTiet", true));
			this.soTietTextBox.Location = new System.Drawing.Point(126, 87);
			this.soTietTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.soTietTextBox.Name = "soTietTextBox";
			this.soTietTextBox.Size = new System.Drawing.Size(206, 23);
			this.soTietTextBox.TabIndex = 12;
			// 
			// MonHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.monBindingNavigator);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MonHoc";
			this.Text = "Nhập thông tin môn học";
			this.Load += new System.EventHandler(this.MonHoc_Load);
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.monBindingNavigator)).EndInit();
			this.monBindingNavigator.ResumeLayout(false);
			this.monBindingNavigator.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.monDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private QLSV_3DataSet qLSV_3DataSet;
		private System.Windows.Forms.BindingSource monBindingSource;
		private QLSV_3DataSetTableAdapters.MonTableAdapter monTableAdapter;
		private QLSV_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator monBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton monBindingNavigatorSaveItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView monDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox maMHTextBox;
		private System.Windows.Forms.TextBox tenMHTextBox;
		private System.Windows.Forms.TextBox soTietTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}