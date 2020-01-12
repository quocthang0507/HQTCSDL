namespace Lab7
{
	partial class XemDiem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDiem));
			this.dgv_Diem = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Xem = new System.Windows.Forms.Button();
			this.cbx_Khoa = new System.Windows.Forms.ComboBox();
			this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.qLSV_3DataSet = new Lab7.QLSV_3DataSet();
			this.cbx_TenSV = new System.Windows.Forms.ComboBox();
			this.cbx_MSSV = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.sinhVienTableAdapter = new Lab7.QLSV_3DataSetTableAdapters.SinhVienTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Diem)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_Diem
			// 
			this.dgv_Diem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgv_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Diem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_Diem.Location = new System.Drawing.Point(3, 146);
			this.dgv_Diem.Name = "dgv_Diem";
			this.dgv_Diem.Size = new System.Drawing.Size(691, 328);
			this.dgv_Diem.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.dgv_Diem, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 477);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Xem);
			this.panel1.Controls.Add(this.cbx_Khoa);
			this.panel1.Controls.Add(this.cbx_TenSV);
			this.panel1.Controls.Add(this.cbx_MSSV);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(691, 137);
			this.panel1.TabIndex = 4;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btn_Xem
			// 
			this.btn_Xem.Location = new System.Drawing.Point(409, 53);
			this.btn_Xem.Name = "btn_Xem";
			this.btn_Xem.Size = new System.Drawing.Size(75, 23);
			this.btn_Xem.TabIndex = 4;
			this.btn_Xem.Text = "Xem";
			this.btn_Xem.UseVisualStyleBackColor = true;
			this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
			// 
			// cbx_Khoa
			// 
			this.cbx_Khoa.DataSource = this.sinhVienBindingSource;
			this.cbx_Khoa.DisplayMember = "MaKhoa";
			this.cbx_Khoa.FormattingEnabled = true;
			this.cbx_Khoa.Location = new System.Drawing.Point(147, 79);
			this.cbx_Khoa.Name = "cbx_Khoa";
			this.cbx_Khoa.Size = new System.Drawing.Size(170, 25);
			this.cbx_Khoa.TabIndex = 2;
			// 
			// sinhVienBindingSource
			// 
			this.sinhVienBindingSource.DataMember = "SinhVien";
			this.sinhVienBindingSource.DataSource = this.qLSV_3DataSet;
			// 
			// qLSV_3DataSet
			// 
			this.qLSV_3DataSet.DataSetName = "QLSV_3DataSet";
			this.qLSV_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cbx_TenSV
			// 
			this.cbx_TenSV.DataSource = this.sinhVienBindingSource;
			this.cbx_TenSV.DisplayMember = "HoTen";
			this.cbx_TenSV.FormattingEnabled = true;
			this.cbx_TenSV.Location = new System.Drawing.Point(147, 53);
			this.cbx_TenSV.Name = "cbx_TenSV";
			this.cbx_TenSV.Size = new System.Drawing.Size(170, 25);
			this.cbx_TenSV.TabIndex = 2;
			this.cbx_TenSV.SelectedIndexChanged += new System.EventHandler(this.cbx_TenSV_SelectedIndexChanged);
			// 
			// cbx_MSSV
			// 
			this.cbx_MSSV.DataSource = this.sinhVienBindingSource;
			this.cbx_MSSV.DisplayMember = "MaSo";
			this.cbx_MSSV.FormattingEnabled = true;
			this.cbx_MSSV.Location = new System.Drawing.Point(147, 26);
			this.cbx_MSSV.Name = "cbx_MSSV";
			this.cbx_MSSV.Size = new System.Drawing.Size(170, 25);
			this.cbx_MSSV.TabIndex = 1;
			this.cbx_MSSV.SelectedIndexChanged += new System.EventHandler(this.cbx_MSSV_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(84, 82);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Khoa:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 53);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tên sinh viên:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Mã số sinh viên:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// sinhVienTableAdapter
			// 
			this.sinhVienTableAdapter.ClearBeforeFill = true;
			// 
			// XemDiem
			// 
			this.AcceptButton = this.btn_Xem;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 477);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "XemDiem";
			this.Text = "Xem điểm";
			this.Load += new System.EventHandler(this.XemDiem_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Diem)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_Diem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbx_TenSV;
		private System.Windows.Forms.ComboBox cbx_MSSV;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private QLSV_3DataSet qLSV_3DataSet;
		private System.Windows.Forms.BindingSource sinhVienBindingSource;
		private QLSV_3DataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
		private System.Windows.Forms.Button btn_Xem;
		private System.Windows.Forms.ComboBox cbx_Khoa;
	}
}