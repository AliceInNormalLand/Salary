
namespace Salary
{
    partial class ChitietTKC2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChitietTKC2));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCTTKC2 = new System.Windows.Forms.TextBox();
            this.btnXemCTTKC2 = new System.Windows.Forms.Button();
            this.ThemCTTKC2 = new System.Windows.Forms.Button();
            this.cbNamCTTKC2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThangCTTKC2 = new System.Windows.Forms.ComboBox();
            this.CbSTHCT2 = new System.Windows.Forms.ComboBox();
            this.danhMucTKC2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMTKC2DB = new Salary.DMTKC2DB();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNHTCTTKC2 = new System.Windows.Forms.DateTimePicker();
            this.dtgvCTTKC2 = new System.Windows.Forms.DataGridView();
            this.maTKC2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayGSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienGiaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tKDUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSCoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDCoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietTKC2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chitietTKC2DB = new Salary.ChitietTKC2DB();
            this.label18 = new System.Windows.Forms.Label();
            this.danhMucTKC2TableAdapter = new Salary.DMTKC2DBTableAdapters.DanhMucTKC2TableAdapter();
            this.chiTietTKC2TableAdapter = new Salary.ChitietTKC2DBTableAdapters.ChiTietTKC2TableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucTKC2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKC2DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTTKC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietTKC2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietTKC2DB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbCTTKC2);
            this.groupBox2.Controls.Add(this.btnXemCTTKC2);
            this.groupBox2.Controls.Add(this.ThemCTTKC2);
            this.groupBox2.Controls.Add(this.cbNamCTTKC2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbThangCTTKC2);
            this.groupBox2.Controls.Add(this.CbSTHCT2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpNHTCTTKC2);
            this.groupBox2.Controls.Add(this.dtgvCTTKC2);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 647);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết tài khoản cấp 2";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Orange;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::Salary.Properties.Resources.spreadsheet;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(193, 30);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(123, 35);
            this.btnExport.TabIndex = 40;
            this.btnExport.Text = "In báo cáo";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(920, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Đơn vị: VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(914, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "Số dư đầu kỳ";
            // 
            // tbCTTKC2
            // 
            this.tbCTTKC2.Location = new System.Drawing.Point(884, 97);
            this.tbCTTKC2.Name = "tbCTTKC2";
            this.tbCTTKC2.Size = new System.Drawing.Size(121, 22);
            this.tbCTTKC2.TabIndex = 78;
            // 
            // btnXemCTTKC2
            // 
            this.btnXemCTTKC2.BackColor = System.Drawing.Color.Orange;
            this.btnXemCTTKC2.FlatAppearance.BorderSize = 0;
            this.btnXemCTTKC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCTTKC2.Image = global::Salary.Properties.Resources.add_document;
            this.btnXemCTTKC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemCTTKC2.Location = new System.Drawing.Point(108, 30);
            this.btnXemCTTKC2.Name = "btnXemCTTKC2";
            this.btnXemCTTKC2.Size = new System.Drawing.Size(79, 35);
            this.btnXemCTTKC2.TabIndex = 23;
            this.btnXemCTTKC2.Text = "Xem";
            this.btnXemCTTKC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemCTTKC2.UseVisualStyleBackColor = false;
            this.btnXemCTTKC2.Click += new System.EventHandler(this.btnXemCTTKC2_Click);
            // 
            // ThemCTTKC2
            // 
            this.ThemCTTKC2.BackColor = System.Drawing.Color.Orange;
            this.ThemCTTKC2.FlatAppearance.BorderSize = 0;
            this.ThemCTTKC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemCTTKC2.Image = global::Salary.Properties.Resources.add_document;
            this.ThemCTTKC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemCTTKC2.Location = new System.Drawing.Point(10, 30);
            this.ThemCTTKC2.Name = "ThemCTTKC2";
            this.ThemCTTKC2.Size = new System.Drawing.Size(92, 35);
            this.ThemCTTKC2.TabIndex = 77;
            this.ThemCTTKC2.Text = "Tạo mới";
            this.ThemCTTKC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemCTTKC2.UseVisualStyleBackColor = false;
            this.ThemCTTKC2.Click += new System.EventHandler(this.ThemCTTKC2_Click);
            // 
            // cbNamCTTKC2
            // 
            this.cbNamCTTKC2.FormattingEnabled = true;
            this.cbNamCTTKC2.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cbNamCTTKC2.Location = new System.Drawing.Point(381, 95);
            this.cbNamCTTKC2.Name = "cbNamCTTKC2";
            this.cbNamCTTKC2.Size = new System.Drawing.Size(94, 24);
            this.cbNamCTTKC2.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tháng";
            // 
            // cbThangCTTKC2
            // 
            this.cbThangCTTKC2.FormattingEnabled = true;
            this.cbThangCTTKC2.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbThangCTTKC2.Location = new System.Drawing.Point(481, 95);
            this.cbThangCTTKC2.Name = "cbThangCTTKC2";
            this.cbThangCTTKC2.Size = new System.Drawing.Size(94, 24);
            this.cbThangCTTKC2.TabIndex = 52;
            // 
            // CbSTHCT2
            // 
            this.CbSTHCT2.DataSource = this.danhMucTKC2BindingSource;
            this.CbSTHCT2.DisplayMember = "MaTKC2";
            this.CbSTHCT2.FormattingEnabled = true;
            this.CbSTHCT2.Location = new System.Drawing.Point(416, 45);
            this.CbSTHCT2.Name = "CbSTHCT2";
            this.CbSTHCT2.Size = new System.Drawing.Size(130, 24);
            this.CbSTHCT2.TabIndex = 51;
            this.CbSTHCT2.ValueMember = "MaTKC2";
            // 
            // danhMucTKC2BindingSource
            // 
            this.danhMucTKC2BindingSource.DataMember = "DanhMucTKC2";
            this.danhMucTKC2BindingSource.DataSource = this.dMTKC2DB;
            // 
            // dMTKC2DB
            // 
            this.dMTKC2DB.DataSetName = "DMTKC2DB";
            this.dMTKC2DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(897, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ngày hạch toán";
            // 
            // dtpNHTCTTKC2
            // 
            this.dtpNHTCTTKC2.Location = new System.Drawing.Point(805, 43);
            this.dtpNHTCTTKC2.Name = "dtpNHTCTTKC2";
            this.dtpNHTCTTKC2.Size = new System.Drawing.Size(200, 22);
            this.dtpNHTCTTKC2.TabIndex = 37;
            // 
            // dtgvCTTKC2
            // 
            this.dtgvCTTKC2.AutoGenerateColumns = false;
            this.dtgvCTTKC2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTTKC2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTKC2DataGridViewTextBoxColumn,
            this.sttBTDataGridViewTextBoxColumn,
            this.ngayGSDataGridViewTextBoxColumn,
            this.ngayCTDataGridViewTextBoxColumn,
            this.soCTDataGridViewTextBoxColumn,
            this.dienGiaiDataGridViewTextBoxColumn,
            this.tKDUDataGridViewTextBoxColumn,
            this.pSNoDataGridViewTextBoxColumn,
            this.pSCoDataGridViewTextBoxColumn,
            this.sDNoDataGridViewTextBoxColumn,
            this.sDCoDataGridViewTextBoxColumn});
            this.dtgvCTTKC2.DataSource = this.chiTietTKC2BindingSource;
            this.dtgvCTTKC2.Location = new System.Drawing.Point(6, 174);
            this.dtgvCTTKC2.Name = "dtgvCTTKC2";
            this.dtgvCTTKC2.RowHeadersWidth = 51;
            this.dtgvCTTKC2.RowTemplate.Height = 24;
            this.dtgvCTTKC2.Size = new System.Drawing.Size(999, 465);
            this.dtgvCTTKC2.TabIndex = 36;
            // 
            // maTKC2DataGridViewTextBoxColumn
            // 
            this.maTKC2DataGridViewTextBoxColumn.DataPropertyName = "MaTKC2";
            this.maTKC2DataGridViewTextBoxColumn.HeaderText = "MaTKC2";
            this.maTKC2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTKC2DataGridViewTextBoxColumn.Name = "maTKC2DataGridViewTextBoxColumn";
            this.maTKC2DataGridViewTextBoxColumn.Width = 125;
            // 
            // sttBTDataGridViewTextBoxColumn
            // 
            this.sttBTDataGridViewTextBoxColumn.DataPropertyName = "SttBT";
            this.sttBTDataGridViewTextBoxColumn.HeaderText = "SttBT";
            this.sttBTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttBTDataGridViewTextBoxColumn.Name = "sttBTDataGridViewTextBoxColumn";
            this.sttBTDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayGSDataGridViewTextBoxColumn
            // 
            this.ngayGSDataGridViewTextBoxColumn.DataPropertyName = "NgayGS";
            this.ngayGSDataGridViewTextBoxColumn.HeaderText = "NgayGS";
            this.ngayGSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayGSDataGridViewTextBoxColumn.Name = "ngayGSDataGridViewTextBoxColumn";
            this.ngayGSDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayCTDataGridViewTextBoxColumn
            // 
            this.ngayCTDataGridViewTextBoxColumn.DataPropertyName = "NgayCT";
            this.ngayCTDataGridViewTextBoxColumn.HeaderText = "NgayCT";
            this.ngayCTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCTDataGridViewTextBoxColumn.Name = "ngayCTDataGridViewTextBoxColumn";
            this.ngayCTDataGridViewTextBoxColumn.Width = 125;
            // 
            // soCTDataGridViewTextBoxColumn
            // 
            this.soCTDataGridViewTextBoxColumn.DataPropertyName = "SoCT";
            this.soCTDataGridViewTextBoxColumn.HeaderText = "SoCT";
            this.soCTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soCTDataGridViewTextBoxColumn.Name = "soCTDataGridViewTextBoxColumn";
            this.soCTDataGridViewTextBoxColumn.Width = 125;
            // 
            // dienGiaiDataGridViewTextBoxColumn
            // 
            this.dienGiaiDataGridViewTextBoxColumn.DataPropertyName = "DienGiai";
            this.dienGiaiDataGridViewTextBoxColumn.HeaderText = "DienGiai";
            this.dienGiaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dienGiaiDataGridViewTextBoxColumn.Name = "dienGiaiDataGridViewTextBoxColumn";
            this.dienGiaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tKDUDataGridViewTextBoxColumn
            // 
            this.tKDUDataGridViewTextBoxColumn.DataPropertyName = "TKDU";
            this.tKDUDataGridViewTextBoxColumn.HeaderText = "TKDU";
            this.tKDUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tKDUDataGridViewTextBoxColumn.Name = "tKDUDataGridViewTextBoxColumn";
            this.tKDUDataGridViewTextBoxColumn.Width = 125;
            // 
            // pSNoDataGridViewTextBoxColumn
            // 
            this.pSNoDataGridViewTextBoxColumn.DataPropertyName = "PSNo";
            this.pSNoDataGridViewTextBoxColumn.HeaderText = "PSNo";
            this.pSNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pSNoDataGridViewTextBoxColumn.Name = "pSNoDataGridViewTextBoxColumn";
            this.pSNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // pSCoDataGridViewTextBoxColumn
            // 
            this.pSCoDataGridViewTextBoxColumn.DataPropertyName = "PSCo";
            this.pSCoDataGridViewTextBoxColumn.HeaderText = "PSCo";
            this.pSCoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pSCoDataGridViewTextBoxColumn.Name = "pSCoDataGridViewTextBoxColumn";
            this.pSCoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDNoDataGridViewTextBoxColumn
            // 
            this.sDNoDataGridViewTextBoxColumn.DataPropertyName = "SDNo";
            this.sDNoDataGridViewTextBoxColumn.HeaderText = "SDNo";
            this.sDNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDNoDataGridViewTextBoxColumn.Name = "sDNoDataGridViewTextBoxColumn";
            this.sDNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDCoDataGridViewTextBoxColumn
            // 
            this.sDCoDataGridViewTextBoxColumn.DataPropertyName = "SDCo";
            this.sDCoDataGridViewTextBoxColumn.HeaderText = "SDCo";
            this.sDCoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDCoDataGridViewTextBoxColumn.Name = "sDCoDataGridViewTextBoxColumn";
            this.sDCoDataGridViewTextBoxColumn.Width = 125;
            // 
            // chiTietTKC2BindingSource
            // 
            this.chiTietTKC2BindingSource.DataMember = "ChiTietTKC2";
            this.chiTietTKC2BindingSource.DataSource = this.chitietTKC2DB;
            // 
            // chitietTKC2DB
            // 
            this.chitietTKC2DB.DataSetName = "ChitietTKC2DB";
            this.chitietTKC2DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(438, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "Số tài khoản";
            // 
            // danhMucTKC2TableAdapter
            // 
            this.danhMucTKC2TableAdapter.ClearBeforeFill = true;
            // 
            // chiTietTKC2TableAdapter
            // 
            this.chiTietTKC2TableAdapter.ClearBeforeFill = true;
            // 
            // ChitietTKC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1019, 653);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChitietTKC2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT TÀI KHOẢN CẤP 2";
            this.Load += new System.EventHandler(this.ChitietTKC2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucTKC2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKC2DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTTKC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietTKC2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietTKC2DB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dtgvCTTKC2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNHTCTTKC2;
        public System.Windows.Forms.ComboBox CbSTHCT2;
        private DMTKC2DB dMTKC2DB;
        private System.Windows.Forms.BindingSource danhMucTKC2BindingSource;
        private DMTKC2DBTableAdapters.DanhMucTKC2TableAdapter danhMucTKC2TableAdapter;
        public System.Windows.Forms.ComboBox cbNamCTTKC2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbThangCTTKC2;
        private System.Windows.Forms.Button ThemCTTKC2;
        private System.Windows.Forms.Button btnXemCTTKC2;
        private ChitietTKC2DB chitietTKC2DB;
        private System.Windows.Forms.BindingSource chiTietTKC2BindingSource;
        private ChitietTKC2DBTableAdapters.ChiTietTKC2TableAdapter chiTietTKC2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTKC2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienGiaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tKDUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSCoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDCoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCTTKC2;
        private System.Windows.Forms.Button btnExport;
    }
}