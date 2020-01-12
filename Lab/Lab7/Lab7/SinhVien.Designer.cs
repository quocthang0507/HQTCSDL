namespace Lab7
{
	partial class SinhVien
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
			System.Windows.Forms.Label hoTenLabel;
			System.Windows.Forms.Label ngaySinhLabel;
			System.Windows.Forms.Label gioiTinhLabel;
			System.Windows.Forms.Label diaChiLabel;
			System.Windows.Forms.Label dienThoaiLabel;
			System.Windows.Forms.Label maKhoaLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVien));
			this.qLSV_3DataSet = new Lab7.QLSV_3DataSet();
			this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sinhVienTableAdapter = new Lab7.QLSV_3DataSetTableAdapters.SinhVienTableAdapter();
			this.tableAdapterManager = new Lab7.QLSV_3DataSetTableAdapters.TableAdapterManager();
			this.sinhVienBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.sinhVienBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.maSoTextBox = new System.Windows.Forms.TextBox();
			this.hoTenTextBox = new System.Windows.Forms.TextBox();
			this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.gioiTinhCheckBox = new System.Windows.Forms.CheckBox();
			this.diaChiTextBox = new System.Windows.Forms.TextBox();
			this.dienThoaiTextBox = new System.Windows.Forms.TextBox();
			this.maKhoaTextBox = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.sinhVienDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			maSoLabel = new System.Windows.Forms.Label();
			hoTenLabel = new System.Windows.Forms.Label();
			ngaySinhLabel = new System.Windows.Forms.Label();
			gioiTinhLabel = new System.Windows.Forms.Label();
			diaChiLabel = new System.Windows.Forms.Label();
			dienThoaiLabel = new System.Windows.Forms.Label();
			maKhoaLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingNavigator)).BeginInit();
			this.sinhVienBindingNavigator.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// maSoLabel
			// 
			maSoLabel.AutoSize = true;
			maSoLabel.Location = new System.Drawing.Point(7, 13);
			maSoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			maSoLabel.Name = "maSoLabel";
			maSoLabel.Size = new System.Drawing.Size(50, 17);
			maSoLabel.TabIndex = 15;
			maSoLabel.Text = "Mã số:";
			// 
			// hoTenLabel
			// 
			hoTenLabel.AutoSize = true;
			hoTenLabel.Location = new System.Drawing.Point(7, 47);
			hoTenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			hoTenLabel.Name = "hoTenLabel";
			hoTenLabel.Size = new System.Drawing.Size(54, 17);
			hoTenLabel.TabIndex = 17;
			hoTenLabel.Text = "Họ tên:";
			// 
			// ngaySinhLabel
			// 
			ngaySinhLabel.AutoSize = true;
			ngaySinhLabel.Location = new System.Drawing.Point(7, 83);
			ngaySinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			ngaySinhLabel.Name = "ngaySinhLabel";
			ngaySinhLabel.Size = new System.Drawing.Size(75, 17);
			ngaySinhLabel.TabIndex = 19;
			ngaySinhLabel.Text = "Ngày sinh:";
			// 
			// gioiTinhLabel
			// 
			gioiTinhLabel.AutoSize = true;
			gioiTinhLabel.Location = new System.Drawing.Point(7, 112);
			gioiTinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			gioiTinhLabel.Name = "gioiTinhLabel";
			gioiTinhLabel.Size = new System.Drawing.Size(64, 17);
			gioiTinhLabel.TabIndex = 21;
			gioiTinhLabel.Text = "Giới tính:";
			// 
			// diaChiLabel
			// 
			diaChiLabel.AutoSize = true;
			diaChiLabel.Location = new System.Drawing.Point(380, 13);
			diaChiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			diaChiLabel.Name = "diaChiLabel";
			diaChiLabel.Size = new System.Drawing.Size(55, 17);
			diaChiLabel.TabIndex = 23;
			diaChiLabel.Text = "Địa chỉ:";
			// 
			// dienThoaiLabel
			// 
			dienThoaiLabel.AutoSize = true;
			dienThoaiLabel.Location = new System.Drawing.Point(380, 47);
			dienThoaiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			dienThoaiLabel.Name = "dienThoaiLabel";
			dienThoaiLabel.Size = new System.Drawing.Size(76, 17);
			dienThoaiLabel.TabIndex = 25;
			dienThoaiLabel.Text = "Điện thoại:";
			// 
			// maKhoaLabel
			// 
			maKhoaLabel.AutoSize = true;
			maKhoaLabel.Location = new System.Drawing.Point(380, 81);
			maKhoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			maKhoaLabel.Name = "maKhoaLabel";
			maKhoaLabel.Size = new System.Drawing.Size(66, 17);
			maKhoaLabel.TabIndex = 27;
			maKhoaLabel.Text = "Mã khoa:";
			// 
			// qLSV_3DataSet
			// 
			this.qLSV_3DataSet.DataSetName = "QLSV_3DataSet";
			this.qLSV_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sinhVienBindingSource
			// 
			this.sinhVienBindingSource.DataMember = "SinhVien";
			this.sinhVienBindingSource.DataSource = this.qLSV_3DataSet;
			// 
			// sinhVienTableAdapter
			// 
			this.sinhVienTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.KetQuaTableAdapter = null;
			this.tableAdapterManager.KhoaTableAdapter = null;
			this.tableAdapterManager.MonTableAdapter = null;
			this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
			this.tableAdapterManager.UpdateOrder = Lab7.QLSV_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// sinhVienBindingNavigator
			// 
			this.sinhVienBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.sinhVienBindingNavigator.BindingSource = this.sinhVienBindingSource;
			this.sinhVienBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.sinhVienBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.sinhVienBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sinhVienBindingNavigatorSaveItem});
			this.sinhVienBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.sinhVienBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.sinhVienBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.sinhVienBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.sinhVienBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.sinhVienBindingNavigator.Name = "sinhVienBindingNavigator";
			this.sinhVienBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.sinhVienBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.sinhVienBindingNavigator.Size = new System.Drawing.Size(784, 25);
			this.sinhVienBindingNavigator.TabIndex = 0;
			this.sinhVienBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
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
			// sinhVienBindingNavigatorSaveItem
			// 
			this.sinhVienBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.sinhVienBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sinhVienBindingNavigatorSaveItem.Image")));
			this.sinhVienBindingNavigatorSaveItem.Name = "sinhVienBindingNavigatorSaveItem";
			this.sinhVienBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.sinhVienBindingNavigatorSaveItem.Text = "Save Data";
			this.sinhVienBindingNavigatorSaveItem.Click += new System.EventHandler(this.sinhVienBindingNavigatorSaveItem_Click_1);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 536);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(maSoLabel);
			this.panel1.Controls.Add(this.maSoTextBox);
			this.panel1.Controls.Add(hoTenLabel);
			this.panel1.Controls.Add(this.hoTenTextBox);
			this.panel1.Controls.Add(ngaySinhLabel);
			this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
			this.panel1.Controls.Add(gioiTinhLabel);
			this.panel1.Controls.Add(this.gioiTinhCheckBox);
			this.panel1.Controls.Add(diaChiLabel);
			this.panel1.Controls.Add(this.diaChiTextBox);
			this.panel1.Controls.Add(dienThoaiLabel);
			this.panel1.Controls.Add(this.dienThoaiTextBox);
			this.panel1.Controls.Add(maKhoaLabel);
			this.panel1.Controls.Add(this.maKhoaTextBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 152);
			this.panel1.TabIndex = 0;
			// 
			// maSoTextBox
			// 
			this.maSoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaSo", true));
			this.maSoTextBox.Location = new System.Drawing.Point(97, 10);
			this.maSoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.maSoTextBox.Name = "maSoTextBox";
			this.maSoTextBox.Size = new System.Drawing.Size(246, 23);
			this.maSoTextBox.TabIndex = 16;
			// 
			// hoTenTextBox
			// 
			this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "HoTen", true));
			this.hoTenTextBox.Location = new System.Drawing.Point(97, 44);
			this.hoTenTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.hoTenTextBox.Name = "hoTenTextBox";
			this.hoTenTextBox.Size = new System.Drawing.Size(246, 23);
			this.hoTenTextBox.TabIndex = 18;
			// 
			// ngaySinhDateTimePicker
			// 
			this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sinhVienBindingSource, "NgaySinh", true));
			this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(97, 78);
			this.ngaySinhDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
			this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(246, 23);
			this.ngaySinhDateTimePicker.TabIndex = 20;
			// 
			// gioiTinhCheckBox
			// 
			this.gioiTinhCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sinhVienBindingSource, "GioiTinh", true));
			this.gioiTinhCheckBox.Location = new System.Drawing.Point(97, 105);
			this.gioiTinhCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gioiTinhCheckBox.Name = "gioiTinhCheckBox";
			this.gioiTinhCheckBox.Size = new System.Drawing.Size(248, 31);
			this.gioiTinhCheckBox.TabIndex = 22;
			this.gioiTinhCheckBox.Text = "Nữ";
			this.gioiTinhCheckBox.UseVisualStyleBackColor = true;
			// 
			// diaChiTextBox
			// 
			this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "DiaChi", true));
			this.diaChiTextBox.Location = new System.Drawing.Point(471, 10);
			this.diaChiTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.diaChiTextBox.Name = "diaChiTextBox";
			this.diaChiTextBox.Size = new System.Drawing.Size(210, 23);
			this.diaChiTextBox.TabIndex = 24;
			// 
			// dienThoaiTextBox
			// 
			this.dienThoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "DienThoai", true));
			this.dienThoaiTextBox.Location = new System.Drawing.Point(471, 44);
			this.dienThoaiTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dienThoaiTextBox.Name = "dienThoaiTextBox";
			this.dienThoaiTextBox.Size = new System.Drawing.Size(210, 23);
			this.dienThoaiTextBox.TabIndex = 26;
			// 
			// maKhoaTextBox
			// 
			this.maKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaKhoa", true));
			this.maKhoaTextBox.Location = new System.Drawing.Point(471, 78);
			this.maKhoaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.maKhoaTextBox.Name = "maKhoaTextBox";
			this.maKhoaTextBox.Size = new System.Drawing.Size(210, 23);
			this.maKhoaTextBox.TabIndex = 28;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.sinhVienDataGridView);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(4, 164);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 368);
			this.panel2.TabIndex = 1;
			// 
			// sinhVienDataGridView
			// 
			this.sinhVienDataGridView.AutoGenerateColumns = false;
			this.sinhVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sinhVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.sinhVienDataGridView.DataSource = this.sinhVienBindingSource;
			this.sinhVienDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sinhVienDataGridView.Location = new System.Drawing.Point(0, 0);
			this.sinhVienDataGridView.Name = "sinhVienDataGridView";
			this.sinhVienDataGridView.Size = new System.Drawing.Size(776, 368);
			this.sinhVienDataGridView.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSo";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã số";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ToolTipText = "Mã số sinh viên";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
			this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ToolTipText = "Họ và tên sinh viên";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "NgaySinh";
			this.dataGridViewTextBoxColumn3.HeaderText = "Ngày sinh";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ToolTipText = "Ngày tháng năm sinh";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "GioiTinh";
			this.dataGridViewCheckBoxColumn1.HeaderText = "Giới tính";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.ToolTipText = "0: Nam, 1: Nữ";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "DiaChi";
			this.dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ToolTipText = "Địa chỉ thường trú";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "DienThoai";
			this.dataGridViewTextBoxColumn5.HeaderText = "Điện thoại";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ToolTipText = "Số điện thoại liên lạc";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "MaKhoa";
			this.dataGridViewTextBoxColumn6.HeaderText = "Mã khoa";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ToolTipText = "Mã khoa";
			// 
			// SinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.sinhVienBindingNavigator);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "SinhVien";
			this.Text = "Nhập thông tin sinh viên";
			this.Load += new System.EventHandler(this.SinhVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingNavigator)).EndInit();
			this.sinhVienBindingNavigator.ResumeLayout(false);
			this.sinhVienBindingNavigator.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sinhVienDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private QLSV_3DataSet qLSV_3DataSet;
		private System.Windows.Forms.BindingSource sinhVienBindingSource;
		private QLSV_3DataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
		private QLSV_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator sinhVienBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton sinhVienBindingNavigatorSaveItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox maSoTextBox;
		private System.Windows.Forms.TextBox hoTenTextBox;
		private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
		private System.Windows.Forms.CheckBox gioiTinhCheckBox;
		private System.Windows.Forms.TextBox diaChiTextBox;
		private System.Windows.Forms.TextBox dienThoaiTextBox;
		private System.Windows.Forms.TextBox maKhoaTextBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView sinhVienDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}