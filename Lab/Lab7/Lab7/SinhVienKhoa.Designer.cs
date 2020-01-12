namespace Lab7
{
	partial class SinhVienKhoa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVienKhoa));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_Xem = new System.Windows.Forms.Button();
			this.cbx_TenKhoa = new System.Windows.Forms.ComboBox();
			this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.qLSV_3DataSet = new Lab7.QLSV_3DataSet();
			this.cbx_MaKhoa = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgv_SinhVienKhoa = new System.Windows.Forms.DataGridView();
			this.khoaTableAdapter = new Lab7.QLSV_3DataSetTableAdapters.KhoaTableAdapter();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVienKhoa)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dgv_SinhVienKhoa, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(778, 106);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btn_Xem);
			this.panel2.Controls.Add(this.cbx_TenKhoa);
			this.panel2.Controls.Add(this.cbx_MaKhoa);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(778, 106);
			this.panel2.TabIndex = 5;
			// 
			// btn_Xem
			// 
			this.btn_Xem.Location = new System.Drawing.Point(351, 38);
			this.btn_Xem.Name = "btn_Xem";
			this.btn_Xem.Size = new System.Drawing.Size(75, 23);
			this.btn_Xem.TabIndex = 4;
			this.btn_Xem.Text = "Xem";
			this.btn_Xem.UseVisualStyleBackColor = true;
			this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
			// 
			// cbx_TenKhoa
			// 
			this.cbx_TenKhoa.DataSource = this.khoaBindingSource;
			this.cbx_TenKhoa.DisplayMember = "TenKhoa";
			this.cbx_TenKhoa.FormattingEnabled = true;
			this.cbx_TenKhoa.Location = new System.Drawing.Point(147, 53);
			this.cbx_TenKhoa.Name = "cbx_TenKhoa";
			this.cbx_TenKhoa.Size = new System.Drawing.Size(170, 25);
			this.cbx_TenKhoa.TabIndex = 2;
			// 
			// khoaBindingSource
			// 
			this.khoaBindingSource.DataMember = "Khoa";
			this.khoaBindingSource.DataSource = this.qLSV_3DataSet;
			// 
			// qLSV_3DataSet
			// 
			this.qLSV_3DataSet.DataSetName = "QLSV_3DataSet";
			this.qLSV_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cbx_MaKhoa
			// 
			this.cbx_MaKhoa.DataSource = this.khoaBindingSource;
			this.cbx_MaKhoa.DisplayMember = "MaKhoa";
			this.cbx_MaKhoa.FormattingEnabled = true;
			this.cbx_MaKhoa.Location = new System.Drawing.Point(147, 26);
			this.cbx_MaKhoa.Name = "cbx_MaKhoa";
			this.cbx_MaKhoa.Size = new System.Drawing.Size(170, 25);
			this.cbx_MaKhoa.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 53);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tên khoa:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Mã khoa:";
			// 
			// dgv_SinhVienKhoa
			// 
			this.dgv_SinhVienKhoa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgv_SinhVienKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_SinhVienKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_SinhVienKhoa.Location = new System.Drawing.Point(3, 115);
			this.dgv_SinhVienKhoa.Name = "dgv_SinhVienKhoa";
			this.dgv_SinhVienKhoa.Size = new System.Drawing.Size(778, 443);
			this.dgv_SinhVienKhoa.TabIndex = 1;
			// 
			// khoaTableAdapter
			// 
			this.khoaTableAdapter.ClearBeforeFill = true;
			// 
			// SinhVienKhoa
			// 
			this.AcceptButton = this.btn_Xem;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "SinhVienKhoa";
			this.Text = "Danh sách sinh viên thuộc khoa";
			this.Load += new System.EventHandler(this.SinhVienKhoa_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qLSV_3DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVienKhoa)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgv_SinhVienKhoa;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn_Xem;
		private System.Windows.Forms.ComboBox cbx_TenKhoa;
		private System.Windows.Forms.ComboBox cbx_MaKhoa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private QLSV_3DataSet qLSV_3DataSet;
		private System.Windows.Forms.BindingSource khoaBindingSource;
		private QLSV_3DataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
	}
}