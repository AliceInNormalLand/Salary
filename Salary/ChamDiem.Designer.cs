
namespace Salary
{
    partial class ChamDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamDiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ThemDiem = new System.Windows.Forms.Button();
            this.XoaDiem = new System.Windows.Forms.Button();
            this.dtgvChamDiem = new System.Windows.Forms.DataGridView();
            this.sttCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamDiemDB = new Salary.ChamDiemDB();
            this.chamDiemTableAdapter = new Salary.ChamDiemDBTableAdapters.ChamDiemTableAdapter();
            this.btnExport = new System.Windows.Forms.Button();
            this.BtnThueTNCN = new System.Windows.Forms.Button();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChamDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamDiemDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.cbNam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbThang);
            this.groupBox1.Controls.Add(this.BtnThueTNCN);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.ThemDiem);
            this.groupBox1.Controls.Add(this.XoaDiem);
            this.groupBox1.Controls.Add(this.dtgvChamDiem);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 563);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi nhận điểm nhân viên";
            // 
            // ThemDiem
            // 
            this.ThemDiem.BackColor = System.Drawing.Color.Orange;
            this.ThemDiem.FlatAppearance.BorderSize = 0;
            this.ThemDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemDiem.Image = global::Salary.Properties.Resources.add_document;
            this.ThemDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemDiem.Location = new System.Drawing.Point(9, 33);
            this.ThemDiem.Name = "ThemDiem";
            this.ThemDiem.Size = new System.Drawing.Size(79, 35);
            this.ThemDiem.TabIndex = 8;
            this.ThemDiem.Text = "Thêm";
            this.ThemDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemDiem.UseVisualStyleBackColor = false;
            this.ThemDiem.Click += new System.EventHandler(this.ThemDiem_Click);
            // 
            // XoaDiem
            // 
            this.XoaDiem.BackColor = System.Drawing.Color.Orange;
            this.XoaDiem.FlatAppearance.BorderSize = 0;
            this.XoaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaDiem.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaDiem.Location = new System.Drawing.Point(94, 33);
            this.XoaDiem.Name = "XoaDiem";
            this.XoaDiem.Size = new System.Drawing.Size(79, 35);
            this.XoaDiem.TabIndex = 9;
            this.XoaDiem.Text = "Xóa";
            this.XoaDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaDiem.UseVisualStyleBackColor = false;
            this.XoaDiem.Click += new System.EventHandler(this.XoaDiem_Click);
            // 
            // dtgvChamDiem
            // 
            this.dtgvChamDiem.AllowUserToAddRows = false;
            this.dtgvChamDiem.AutoGenerateColumns = false;
            this.dtgvChamDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChamDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttCDDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.sttDGDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.maKLDataGridViewTextBoxColumn});
            this.dtgvChamDiem.DataSource = this.chamDiemBindingSource;
            this.dtgvChamDiem.Location = new System.Drawing.Point(9, 74);
            this.dtgvChamDiem.Name = "dtgvChamDiem";
            this.dtgvChamDiem.ReadOnly = true;
            this.dtgvChamDiem.RowHeadersWidth = 51;
            this.dtgvChamDiem.RowTemplate.Height = 24;
            this.dtgvChamDiem.Size = new System.Drawing.Size(950, 483);
            this.dtgvChamDiem.TabIndex = 7;
            this.dtgvChamDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChamDiem_CellClick);
            // 
            // sttCDDataGridViewTextBoxColumn
            // 
            this.sttCDDataGridViewTextBoxColumn.DataPropertyName = "SttCD";
            this.sttCDDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttCDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttCDDataGridViewTextBoxColumn.Name = "sttCDDataGridViewTextBoxColumn";
            this.sttCDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttCDDataGridViewTextBoxColumn.Width = 125;
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
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttDGDataGridViewTextBoxColumn
            // 
            this.sttDGDataGridViewTextBoxColumn.DataPropertyName = "SttDG";
            this.sttDGDataGridViewTextBoxColumn.HeaderText = "STT đánh giá";
            this.sttDGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttDGDataGridViewTextBoxColumn.Name = "sttDGDataGridViewTextBoxColumn";
            this.sttDGDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttDGDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Width = 125;
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
            // chamDiemBindingSource
            // 
            this.chamDiemBindingSource.DataMember = "ChamDiem";
            this.chamDiemBindingSource.DataSource = this.chamDiemDB;
            // 
            // chamDiemDB
            // 
            this.chamDiemDB.DataSetName = "ChamDiemDB";
            this.chamDiemDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chamDiemTableAdapter
            // 
            this.chamDiemTableAdapter.ClearBeforeFill = true;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Orange;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::Salary.Properties.Resources.spreadsheet;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(179, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(116, 35);
            this.btnExport.TabIndex = 41;
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
            this.BtnThueTNCN.Location = new System.Drawing.Point(301, 33);
            this.BtnThueTNCN.Name = "BtnThueTNCN";
            this.BtnThueTNCN.Size = new System.Drawing.Size(79, 35);
            this.BtnThueTNCN.TabIndex = 42;
            this.BtnThueTNCN.Text = "Xem";
            this.BtnThueTNCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnThueTNCN.UseVisualStyleBackColor = false;
            this.BtnThueTNCN.Click += new System.EventHandler(this.BtnThueTNCN_Click);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
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
            this.cbNam.Location = new System.Drawing.Point(765, 44);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(94, 24);
            this.cbNam.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tháng";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
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
            this.cbThang.Location = new System.Drawing.Point(865, 44);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(94, 24);
            this.cbThang.TabIndex = 43;
            // 
            // ChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 563);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChamDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GHI NHẬN ĐIỂM";
            this.Load += new System.EventHandler(this.DanhgiaNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChamDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamDiemDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvChamDiem;
        private System.Windows.Forms.Button ThemDiem;
        private System.Windows.Forms.Button XoaDiem;
        private ChamDiemDB chamDiemDB;
        private System.Windows.Forms.BindingSource chamDiemBindingSource;
        private ChamDiemDBTableAdapters.ChamDiemTableAdapter chamDiemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button BtnThueTNCN;
        public System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbThang;
    }
}