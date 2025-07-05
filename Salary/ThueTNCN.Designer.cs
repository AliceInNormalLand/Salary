
namespace Salary
{
    partial class ThueTNCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThueTNCN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.BtnThueTNCN = new System.Windows.Forms.Button();
            this.BtnButToan = new System.Windows.Forms.Button();
            this.dtpNgaylapThue = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNamThue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThangThue = new System.Windows.Forms.ComboBox();
            this.ThemThueTNCN = new System.Windows.Forms.Button();
            this.dtgvThueTNCN = new System.Windows.Forms.DataGridView();
            this.sttTTNCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuNhapCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttBHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGTGCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttLCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuNhapTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttQDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thueTNCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thueTNCNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thueTNCNDB = new Salary.ThueTNCNDB();
            this.thueTNCNTableAdapter = new Salary.ThueTNCNDBTableAdapters.ThueTNCNTableAdapter();
            this.XoaDiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThueTNCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thueTNCNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thueTNCNDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.XoaDiem);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.BtnThueTNCN);
            this.groupBox1.Controls.Add(this.BtnButToan);
            this.groupBox1.Controls.Add(this.dtpNgaylapThue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbNamThue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbThangThue);
            this.groupBox1.Controls.Add(this.ThemThueTNCN);
            this.groupBox1.Controls.Add(this.dtgvThueTNCN);
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1254, 580);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuế thu nhập cá nhân";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Orange;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::Salary.Properties.Resources.spreadsheet;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(403, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(116, 35);
            this.btnExport.TabIndex = 40;
            this.btnExport.Text = "In báo cáo";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // BtnThueTNCN
            // 
            this.BtnThueTNCN.BackColor = System.Drawing.Color.Orange;
            this.BtnThueTNCN.FlatAppearance.BorderSize = 0;
            this.BtnThueTNCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThueTNCN.Image = global::Salary.Properties.Resources.search;
            this.BtnThueTNCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThueTNCN.Location = new System.Drawing.Point(194, 33);
            this.BtnThueTNCN.Name = "BtnThueTNCN";
            this.BtnThueTNCN.Size = new System.Drawing.Size(79, 35);
            this.BtnThueTNCN.TabIndex = 37;
            this.BtnThueTNCN.Text = "Xem";
            this.BtnThueTNCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnThueTNCN.UseVisualStyleBackColor = false;
            this.BtnThueTNCN.Click += new System.EventHandler(this.BtnThueTNCN_Click);
            // 
            // BtnButToan
            // 
            this.BtnButToan.BackColor = System.Drawing.Color.Orange;
            this.BtnButToan.FlatAppearance.BorderSize = 0;
            this.BtnButToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnButToan.Image = global::Salary.Properties.Resources.file_edit;
            this.BtnButToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnButToan.Location = new System.Drawing.Point(279, 33);
            this.BtnButToan.Name = "BtnButToan";
            this.BtnButToan.Size = new System.Drawing.Size(117, 35);
            this.BtnButToan.TabIndex = 12;
            this.BtnButToan.Text = "Lập bút toán";
            this.BtnButToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnButToan.UseVisualStyleBackColor = false;
            this.BtnButToan.Click += new System.EventHandler(this.BtnButToan_Click);
            // 
            // dtpNgaylapThue
            // 
            this.dtpNgaylapThue.Location = new System.Drawing.Point(1102, 46);
            this.dtpNgaylapThue.Name = "dtpNgaylapThue";
            this.dtpNgaylapThue.Size = new System.Drawing.Size(143, 22);
            this.dtpNgaylapThue.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1181, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ngày lập";
            // 
            // cbNamThue
            // 
            this.cbNamThue.FormattingEnabled = true;
            this.cbNamThue.Items.AddRange(new object[] {
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
            this.cbNamThue.Location = new System.Drawing.Point(9, 90);
            this.cbNamThue.Name = "cbNamThue";
            this.cbNamThue.Size = new System.Drawing.Size(94, 24);
            this.cbNamThue.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tháng";
            // 
            // cbThangThue
            // 
            this.cbThangThue.FormattingEnabled = true;
            this.cbThangThue.Items.AddRange(new object[] {
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
            this.cbThangThue.Location = new System.Drawing.Point(109, 90);
            this.cbThangThue.Name = "cbThangThue";
            this.cbThangThue.Size = new System.Drawing.Size(94, 24);
            this.cbThangThue.TabIndex = 23;
            // 
            // ThemThueTNCN
            // 
            this.ThemThueTNCN.BackColor = System.Drawing.Color.Orange;
            this.ThemThueTNCN.FlatAppearance.BorderSize = 0;
            this.ThemThueTNCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemThueTNCN.Image = global::Salary.Properties.Resources.add_document;
            this.ThemThueTNCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemThueTNCN.Location = new System.Drawing.Point(11, 33);
            this.ThemThueTNCN.Name = "ThemThueTNCN";
            this.ThemThueTNCN.Size = new System.Drawing.Size(92, 35);
            this.ThemThueTNCN.TabIndex = 22;
            this.ThemThueTNCN.Text = "Tạo mới";
            this.ThemThueTNCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemThueTNCN.UseVisualStyleBackColor = false;
            this.ThemThueTNCN.Click += new System.EventHandler(this.ThemThueTNCN_Click);
            // 
            // dtgvThueTNCN
            // 
            this.dtgvThueTNCN.AllowUserToAddRows = false;
            this.dtgvThueTNCN.AutoGenerateColumns = false;
            this.dtgvThueTNCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThueTNCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttTTNCNDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.thuNhapCTDataGridViewTextBoxColumn,
            this.sttBHDataGridViewTextBoxColumn,
            this.maGTGCDataGridViewTextBoxColumn,
            this.sttLCNDataGridViewTextBoxColumn,
            this.thuNhapTTDataGridViewTextBoxColumn,
            this.sttQDDataGridViewTextBoxColumn,
            this.thueTNCNDataGridViewTextBoxColumn,
            this.maKLDataGridViewTextBoxColumn});
            this.dtgvThueTNCN.DataSource = this.thueTNCNBindingSource;
            this.dtgvThueTNCN.Location = new System.Drawing.Point(9, 120);
            this.dtgvThueTNCN.Name = "dtgvThueTNCN";
            this.dtgvThueTNCN.ReadOnly = true;
            this.dtgvThueTNCN.RowHeadersWidth = 51;
            this.dtgvThueTNCN.RowTemplate.Height = 24;
            this.dtgvThueTNCN.Size = new System.Drawing.Size(1237, 454);
            this.dtgvThueTNCN.TabIndex = 7;
            this.dtgvThueTNCN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThueTNCN_CellClick);
            // 
            // sttTTNCNDataGridViewTextBoxColumn
            // 
            this.sttTTNCNDataGridViewTextBoxColumn.DataPropertyName = "SttTTNCN";
            this.sttTTNCNDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttTTNCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTTNCNDataGridViewTextBoxColumn.Name = "sttTTNCNDataGridViewTextBoxColumn";
            this.sttTTNCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTTNCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // thuNhapCTDataGridViewTextBoxColumn
            // 
            this.thuNhapCTDataGridViewTextBoxColumn.DataPropertyName = "ThuNhapCT";
            this.thuNhapCTDataGridViewTextBoxColumn.HeaderText = "Thu nhập chịu thuế";
            this.thuNhapCTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuNhapCTDataGridViewTextBoxColumn.Name = "thuNhapCTDataGridViewTextBoxColumn";
            this.thuNhapCTDataGridViewTextBoxColumn.ReadOnly = true;
            this.thuNhapCTDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttBHDataGridViewTextBoxColumn
            // 
            this.sttBHDataGridViewTextBoxColumn.DataPropertyName = "SttBH";
            this.sttBHDataGridViewTextBoxColumn.HeaderText = "STT CT bảo hiểm";
            this.sttBHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttBHDataGridViewTextBoxColumn.Name = "sttBHDataGridViewTextBoxColumn";
            this.sttBHDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttBHDataGridViewTextBoxColumn.Width = 125;
            // 
            // maGTGCDataGridViewTextBoxColumn
            // 
            this.maGTGCDataGridViewTextBoxColumn.DataPropertyName = "MaGTGC";
            this.maGTGCDataGridViewTextBoxColumn.HeaderText = "Mã giảm trừ gia cảnh";
            this.maGTGCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maGTGCDataGridViewTextBoxColumn.Name = "maGTGCDataGridViewTextBoxColumn";
            this.maGTGCDataGridViewTextBoxColumn.ReadOnly = true;
            this.maGTGCDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttLCNDataGridViewTextBoxColumn
            // 
            this.sttLCNDataGridViewTextBoxColumn.DataPropertyName = "SttLCN";
            this.sttLCNDataGridViewTextBoxColumn.HeaderText = "STT bảng lương cá nhân";
            this.sttLCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttLCNDataGridViewTextBoxColumn.Name = "sttLCNDataGridViewTextBoxColumn";
            this.sttLCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttLCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // thuNhapTTDataGridViewTextBoxColumn
            // 
            this.thuNhapTTDataGridViewTextBoxColumn.DataPropertyName = "ThuNhapTT";
            this.thuNhapTTDataGridViewTextBoxColumn.HeaderText = "Thu nhập tính thuế";
            this.thuNhapTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thuNhapTTDataGridViewTextBoxColumn.Name = "thuNhapTTDataGridViewTextBoxColumn";
            this.thuNhapTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.thuNhapTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttQDDataGridViewTextBoxColumn
            // 
            this.sttQDDataGridViewTextBoxColumn.DataPropertyName = "SttQD";
            this.sttQDDataGridViewTextBoxColumn.HeaderText = "STT quy định";
            this.sttQDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttQDDataGridViewTextBoxColumn.Name = "sttQDDataGridViewTextBoxColumn";
            this.sttQDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttQDDataGridViewTextBoxColumn.Width = 125;
            // 
            // thueTNCNDataGridViewTextBoxColumn
            // 
            this.thueTNCNDataGridViewTextBoxColumn.DataPropertyName = "ThueTNCN";
            this.thueTNCNDataGridViewTextBoxColumn.HeaderText = "Thuế TNCN";
            this.thueTNCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thueTNCNDataGridViewTextBoxColumn.Name = "thueTNCNDataGridViewTextBoxColumn";
            this.thueTNCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.thueTNCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKLDataGridViewTextBoxColumn
            // 
            this.maKLDataGridViewTextBoxColumn.DataPropertyName = "MaKL";
            this.maKLDataGridViewTextBoxColumn.HeaderText = "Mã kỳ lương";
            this.maKLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKLDataGridViewTextBoxColumn.Name = "maKLDataGridViewTextBoxColumn";
            this.maKLDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKLDataGridViewTextBoxColumn.Width = 125;
            // 
            // thueTNCNBindingSource
            // 
            this.thueTNCNBindingSource.DataMember = "ThueTNCN";
            this.thueTNCNBindingSource.DataSource = this.thueTNCNDB;
            // 
            // thueTNCNDB
            // 
            this.thueTNCNDB.DataSetName = "ThueTNCNDB";
            this.thueTNCNDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thueTNCNTableAdapter
            // 
            this.thueTNCNTableAdapter.ClearBeforeFill = true;
            // 
            // XoaDiem
            // 
            this.XoaDiem.BackColor = System.Drawing.Color.Orange;
            this.XoaDiem.FlatAppearance.BorderSize = 0;
            this.XoaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaDiem.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaDiem.Location = new System.Drawing.Point(109, 33);
            this.XoaDiem.Name = "XoaDiem";
            this.XoaDiem.Size = new System.Drawing.Size(79, 35);
            this.XoaDiem.TabIndex = 41;
            this.XoaDiem.Text = "Xóa";
            this.XoaDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaDiem.UseVisualStyleBackColor = false;
            this.XoaDiem.Click += new System.EventHandler(this.XoaDiem_Click);
            // 
            // ThueTNCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1259, 579);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThueTNCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THUẾ THU NHẬP CÁ NHÂN";
            this.Load += new System.EventHandler(this.ThueTNCN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThueTNCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thueTNCNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thueTNCNDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvThueTNCN;
        private System.Windows.Forms.Button ThemThueTNCN;
        public System.Windows.Forms.ComboBox cbNamThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbThangThue;
        public System.Windows.Forms.DateTimePicker dtpNgaylapThue;
        private System.Windows.Forms.Label label3;
        private ThueTNCNDB thueTNCNDB;
        private System.Windows.Forms.BindingSource thueTNCNBindingSource;
        private ThueTNCNDBTableAdapters.ThueTNCNTableAdapter thueTNCNTableAdapter;
        private System.Windows.Forms.Button BtnButToan;
        private System.Windows.Forms.Button BtnThueTNCN;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTTNCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuNhapCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGTGCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttLCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuNhapTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttQDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thueTNCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button XoaDiem;
    }
}