namespace Lab7
{
	partial class Khoa
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
			System.Windows.Forms.Label maKhoaLabel;
			System.Windows.Forms.Label tenKhoaLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khoa));
			this.qLSV_3DataSet = new Lab7.QLSV_3DataSet();
			this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.khoaTableAdapter = new Lab7.QLSV_3DataSetTableAdapters.KhoaTableAdapter();
			this.tableAdapterManager = new Lab7.QLSV_3DataSetTableAdapters.TableAdapterManager();
			this.khoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.khoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.khoaDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.maKhoaTextBox = new System.Windows.Forms.TextBox();
			this.tenKhoaTextBox = new System.Windows.Forms.TextBox();
			maKhoaLabel = new System.Windows.Forms.Label();
			tenKhoaLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingNavigator)).BeginInit();
			this.khoaBindingNavigator.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoaDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// maKhoaLabel
			// 
			maKhoaLabel.AutoSize = true;
			maKhoaLabel.Location = new System.Drawing.Point(27, 44);
			maKhoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			maKhoaLabel.Name = "maKhoaLabel";
			maKhoaLabel.Size = new System.Drawing.Size(66, 17);
			maKhoaLabel.TabIndex = 5;
			maKhoaLabel.Text = "Mã khoa:";
			// 
			// tenKhoaLabel
			// 
			tenKhoaLabel.AutoSize = true;
			tenKhoaLabel.Location = new System.Drawing.Point(27, 78);
			tenKhoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			tenKhoaLabel.Name = "tenKhoaLabel";
			tenKhoaLabel.Size = new System.Drawing.Size(72, 17);
			tenKhoaLabel.TabIndex = 7;
			tenKhoaLabel.Text = "Tên khoa:";
			// 
			// qLSV_3DataSet
			// 
			this.qLSV_3DataSet.DataSetName = "QLSV_3DataSet";
			this.qLSV_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// khoaBindingSource
			// 
			this.khoaBindingSource.DataMember = "Khoa";
			this.khoaBindingSource.DataSource = this.qLSV_3DataSet;
			// 
			// khoaTableAdapter
			// 
			this.khoaTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.KetQuaTableAdapter = null;
			this.tableAdapterManager.KhoaTableAdapter = this.khoaTableAdapter;
			this.tableAdapterManager.MonTableAdapter = null;
			this.tableAdapterManager.SinhVienTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Lab7.QLSV_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// khoaBindingNavigator
			// 
			this.khoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.khoaBindingNavigator.BindingSource = this.khoaBindingSource;
			this.khoaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.khoaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.khoaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.khoaBindingNavigatorSaveItem});
			this.khoaBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.khoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.khoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.khoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.khoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.khoaBindingNavigator.Name = "khoaBindingNavigator";
			this.khoaBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.khoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.khoaBindingNavigator.Size = new System.Drawing.Size(784, 25);
			this.khoaBindingNavigator.TabIndex = 0;
			this.khoaBindingNavigator.Text = "bindingNavigator1";
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
			// khoaBindingNavigatorSaveItem
			// 
			this.khoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.khoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("khoaBindingNavigatorSaveItem.Image")));
			this.khoaBindingNavigatorSaveItem.Name = "khoaBindingNavigatorSaveItem";
			this.khoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.khoaBindingNavigatorSaveItem.Text = "Save Data";
			this.khoaBindingNavigatorSaveItem.Click += new System.EventHandler(this.khoaBindingNavigatorSaveItem_Click_1);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.khoaDataGridView, 0, 1);
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
			// khoaDataGridView
			// 
			this.khoaDataGridView.AutoGenerateColumns = false;
			this.khoaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.khoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.khoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.khoaDataGridView.DataSource = this.khoaBindingSource;
			this.khoaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.khoaDataGridView.Location = new System.Drawing.Point(4, 164);
			this.khoaDataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.khoaDataGridView.Name = "khoaDataGridView";
			this.khoaDataGridView.Size = new System.Drawing.Size(776, 368);
			this.khoaDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKhoa";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã khoa";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ToolTipText = "Mã khoa";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKhoa";
			this.dataGridViewTextBoxColumn2.HeaderText = "Tên khoa";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ToolTipText = "Tên khoa";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(maKhoaLabel);
			this.panel1.Controls.Add(this.maKhoaTextBox);
			this.panel1.Controls.Add(tenKhoaLabel);
			this.panel1.Controls.Add(this.tenKhoaTextBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 152);
			this.panel1.TabIndex = 0;
			// 
			// maKhoaTextBox
			// 
			this.maKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoaBindingSource, "MaKhoa", true));
			this.maKhoaTextBox.Location = new System.Drawing.Point(110, 41);
			this.maKhoaTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.maKhoaTextBox.Name = "maKhoaTextBox";
			this.maKhoaTextBox.Size = new System.Drawing.Size(132, 23);
			this.maKhoaTextBox.TabIndex = 6;
			// 
			// tenKhoaTextBox
			// 
			this.tenKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoaBindingSource, "TenKhoa", true));
			this.tenKhoaTextBox.Location = new System.Drawing.Point(110, 75);
			this.tenKhoaTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.tenKhoaTextBox.Name = "tenKhoaTextBox";
			this.tenKhoaTextBox.Size = new System.Drawing.Size(132, 23);
			this.tenKhoaTextBox.TabIndex = 8;
			// 
			// Khoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.khoaBindingNavigator);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Khoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Nhập thông tin khoa";
			this.Load += new System.EventHandler(this.Khoa_Load);
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingNavigator)).EndInit();
			this.khoaBindingNavigator.ResumeLayout(false);
			this.khoaBindingNavigator.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.khoaDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private QLSV_3DataSet qLSV_3DataSet;
		private System.Windows.Forms.BindingSource khoaBindingSource;
		private QLSV_3DataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
		private QLSV_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator khoaBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton khoaBindingNavigatorSaveItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView khoaDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox maKhoaTextBox;
		private System.Windows.Forms.TextBox tenKhoaTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}