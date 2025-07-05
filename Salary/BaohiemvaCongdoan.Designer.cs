
namespace Salary
{
    partial class BaohiemvaCongdoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaohiemvaCongdoan));
            this.cbThangBH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvBaohiem = new System.Windows.Forms.DataGridView();
            this.sttBHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttLCSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttTTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttLCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHXHNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHXHDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHYTNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHYTDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHTNNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHTNDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongBHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanPhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kinhPhiCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baoHiemVaCongDoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bHvaCDDB = new Salary.BHvaCDDB();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNamBH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemBHvaCD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.BtnBHvaCD = new System.Windows.Forms.Button();
            this.BtnButToan = new System.Windows.Forms.Button();
            this.dtpNgaylapBH = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVung = new System.Windows.Forms.ComboBox();
            this.toiThieuVungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toiThieuVungDB = new Salary.ToiThieuVungDB();
            this.baoHiemVaCongDoanTableAdapter = new Salary.BHvaCDDBTableAdapters.BaoHiemVaCongDoanTableAdapter();
            this.toiThieuVungTableAdapter = new Salary.ToiThieuVungDBTableAdapters.ToiThieuVungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaohiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoHiemVaCongDoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHvaCDDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungDB)).BeginInit();
            this.SuspendLayout();
            // 
            // cbThangBH
            // 
            this.cbThangBH.FormattingEnabled = true;
            this.cbThangBH.Items.AddRange(new object[] {
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
            this.cbThangBH.Location = new System.Drawing.Point(110, 101);
            this.cbThangBH.Name = "cbThangBH";
            this.cbThangBH.Size = new System.Drawing.Size(94, 24);
            this.cbThangBH.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tháng";
            // 
            // dtgvBaohiem
            // 
            this.dtgvBaohiem.AllowUserToAddRows = false;
            this.dtgvBaohiem.AutoGenerateColumns = false;
            this.dtgvBaohiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBaohiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttBHDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.sttLCSDataGridViewTextBoxColumn,
            this.sttTTVDataGridViewTextBoxColumn,
            this.sttLCNDataGridViewTextBoxColumn,
            this.bHXHNVDataGridViewTextBoxColumn,
            this.bHXHDNDataGridViewTextBoxColumn,
            this.bHYTNVDataGridViewTextBoxColumn,
            this.bHYTDNDataGridViewTextBoxColumn,
            this.bHTNNVDataGridViewTextBoxColumn,
            this.bHTNDNDataGridViewTextBoxColumn,
            this.tongBHDataGridViewTextBoxColumn,
            this.doanPhiDataGridViewTextBoxColumn,
            this.kinhPhiCDDataGridViewTextBoxColumn,
            this.maKLDataGridViewTextBoxColumn});
            this.dtgvBaohiem.DataSource = this.baoHiemVaCongDoanBindingSource;
            this.dtgvBaohiem.Location = new System.Drawing.Point(9, 131);
            this.dtgvBaohiem.Name = "dtgvBaohiem";
            this.dtgvBaohiem.ReadOnly = true;
            this.dtgvBaohiem.RowHeadersWidth = 51;
            this.dtgvBaohiem.RowTemplate.Height = 24;
            this.dtgvBaohiem.Size = new System.Drawing.Size(1144, 474);
            this.dtgvBaohiem.TabIndex = 7;
            // 
            // sttBHDataGridViewTextBoxColumn
            // 
            this.sttBHDataGridViewTextBoxColumn.DataPropertyName = "SttBH";
            this.sttBHDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttBHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttBHDataGridViewTextBoxColumn.Name = "sttBHDataGridViewTextBoxColumn";
            this.sttBHDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttBHDataGridViewTextBoxColumn.Width = 125;
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
            // sttLCSDataGridViewTextBoxColumn
            // 
            this.sttLCSDataGridViewTextBoxColumn.DataPropertyName = "SttLCS";
            this.sttLCSDataGridViewTextBoxColumn.HeaderText = "STT lương cơ sở";
            this.sttLCSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttLCSDataGridViewTextBoxColumn.Name = "sttLCSDataGridViewTextBoxColumn";
            this.sttLCSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttLCSDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttTTVDataGridViewTextBoxColumn
            // 
            this.sttTTVDataGridViewTextBoxColumn.DataPropertyName = "SttTTV";
            this.sttTTVDataGridViewTextBoxColumn.HeaderText = "STT tối thiểu vùng";
            this.sttTTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTTVDataGridViewTextBoxColumn.Name = "sttTTVDataGridViewTextBoxColumn";
            this.sttTTVDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTTVDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttLCNDataGridViewTextBoxColumn
            // 
            this.sttLCNDataGridViewTextBoxColumn.DataPropertyName = "SttLCN";
            this.sttLCNDataGridViewTextBoxColumn.HeaderText = "STT lương cá nhân";
            this.sttLCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttLCNDataGridViewTextBoxColumn.Name = "sttLCNDataGridViewTextBoxColumn";
            this.sttLCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttLCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // bHXHNVDataGridViewTextBoxColumn
            // 
            this.bHXHNVDataGridViewTextBoxColumn.DataPropertyName = "BHXHNV";
            this.bHXHNVDataGridViewTextBoxColumn.HeaderText = "BHXHNV";
            this.bHXHNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bHXHNVDataGridViewTextBoxColumn.Name = "bHXHNVDataGridViewTextBoxColumn";
            this.bHXHNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.bHXHNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // bHXHDNDataGridViewTextBoxColumn
            // 
            this.bHXHDNDataGridViewTextBoxColumn.DataPropertyName = "BHXHDN";
            this.bHXHDNDataGridViewTextBoxColumn.HeaderText = "BHXHDN";
            this.bHXHDNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bHXHDNDataGridViewTextBoxColumn.Name = "bHXHDNDataGridViewTextBoxColumn";
            this.bHXHDNDataGridViewTextBoxColumn.ReadOnly = true;
            this.bHXHDNDataGridViewTextBoxColumn.Width = 125;
            // 
            // bHYTNVDataGridViewTextBoxColumn
            // 
            this.bHYTNVDataGridViewTextBoxColumn.DataPropertyName = "BHYTNV";
            this.bHYTNVDataGridViewTextBoxColumn.HeaderText = "BHYTNV";
            this.bHYTNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bHYTNVDataGridViewTextBoxColumn.Name = "bHYTNVDataGridViewTextBoxColumn";
            this.bHYTNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.bHYTNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // bHYTDNDataGridViewTextBoxColumn
            // 
            this.bHYTDNDataGridViewTextBoxColumn.DataPropertyName = "BHYTDN";
            this.bHYTDNDataGridViewTextBoxColumn.HeaderText = "BHYTDN";
            this.bHYTDNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bHYTDNDataGridViewTextBoxColumn.Name = "bHYTDNDataGridViewTextBoxColumn";
            this.bHYTDNDataGridViewTextBoxColumn.ReadOnly = true;
            this.bHYTDNDataGridViewTextBoxColumn.Width = 125;
            // 
            // bHTNNVDataGridViewTextBoxColumn
            // 
            this.bHTNNVDataGridViewTextBoxColumn.DataPropertyName = "BHTNNV";
            this.bHTNNVDataGridViewTextBoxColumn.HeaderText = "BHTNNV";
            this.bHTNNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bHTNNVDataGridViewTextBoxColumn.Name = "bHTNNVDataGridViewTextBoxColumn";
            this.bHTNNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.bHTNNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // bHTNDNDataGridViewTextBoxColumn
            // 
            this.bHTNDNDataGridViewTextBoxColumn.DataPropertyName = "BHTNDN";
            this.bHTNDNDataGridViewTextBoxColumn.HeaderText = "BHTNDN";
            this.bHTNDNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bHTNDNDataGridViewTextBoxColumn.Name = "bHTNDNDataGridViewTextBoxColumn";
            this.bHTNDNDataGridViewTextBoxColumn.ReadOnly = true;
            this.bHTNDNDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongBHDataGridViewTextBoxColumn
            // 
            this.tongBHDataGridViewTextBoxColumn.DataPropertyName = "TongBH";
            this.tongBHDataGridViewTextBoxColumn.HeaderText = "Tổng bảo hiểm";
            this.tongBHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongBHDataGridViewTextBoxColumn.Name = "tongBHDataGridViewTextBoxColumn";
            this.tongBHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongBHDataGridViewTextBoxColumn.Width = 125;
            // 
            // doanPhiDataGridViewTextBoxColumn
            // 
            this.doanPhiDataGridViewTextBoxColumn.DataPropertyName = "DoanPhi";
            this.doanPhiDataGridViewTextBoxColumn.HeaderText = "Đoàn phí";
            this.doanPhiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doanPhiDataGridViewTextBoxColumn.Name = "doanPhiDataGridViewTextBoxColumn";
            this.doanPhiDataGridViewTextBoxColumn.ReadOnly = true;
            this.doanPhiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kinhPhiCDDataGridViewTextBoxColumn
            // 
            this.kinhPhiCDDataGridViewTextBoxColumn.DataPropertyName = "KinhPhiCD";
            this.kinhPhiCDDataGridViewTextBoxColumn.HeaderText = "Kinh phí công đoàn";
            this.kinhPhiCDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kinhPhiCDDataGridViewTextBoxColumn.Name = "kinhPhiCDDataGridViewTextBoxColumn";
            this.kinhPhiCDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kinhPhiCDDataGridViewTextBoxColumn.Width = 125;
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
            // baoHiemVaCongDoanBindingSource
            // 
            this.baoHiemVaCongDoanBindingSource.DataMember = "BaoHiemVaCongDoan";
            this.baoHiemVaCongDoanBindingSource.DataSource = this.bHvaCDDB;
            // 
            // bHvaCDDB
            // 
            this.bHvaCDDB.DataSetName = "BHvaCDDB";
            this.bHvaCDDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Năm";
            // 
            // cbNamBH
            // 
            this.cbNamBH.FormattingEnabled = true;
            this.cbNamBH.Items.AddRange(new object[] {
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
            this.cbNamBH.Location = new System.Drawing.Point(10, 101);
            this.cbNamBH.Name = "cbNamBH";
            this.cbNamBH.Size = new System.Drawing.Size(94, 24);
            this.cbNamBH.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1089, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày lập";
            // 
            // ThemBHvaCD
            // 
            this.ThemBHvaCD.BackColor = System.Drawing.Color.Orange;
            this.ThemBHvaCD.FlatAppearance.BorderSize = 0;
            this.ThemBHvaCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemBHvaCD.Image = global::Salary.Properties.Resources.add_document;
            this.ThemBHvaCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemBHvaCD.Location = new System.Drawing.Point(9, 33);
            this.ThemBHvaCD.Name = "ThemBHvaCD";
            this.ThemBHvaCD.Size = new System.Drawing.Size(95, 35);
            this.ThemBHvaCD.TabIndex = 21;
            this.ThemBHvaCD.Text = "Tạo mới";
            this.ThemBHvaCD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemBHvaCD.UseVisualStyleBackColor = false;
            this.ThemBHvaCD.Click += new System.EventHandler(this.ThemBHvaCD_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.BtnBHvaCD);
            this.groupBox1.Controls.Add(this.BtnButToan);
            this.groupBox1.Controls.Add(this.dtpNgaylapBH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbVung);
            this.groupBox1.Controls.Add(this.ThemBHvaCD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbNamBH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgvBaohiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbThangBH);
            this.groupBox1.Location = new System.Drawing.Point(-1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 611);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bảo hiểm và công đoàn của nhân viên";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Orange;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::Salary.Properties.Resources.spreadsheet;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(317, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(132, 35);
            this.btnExport.TabIndex = 39;
            this.btnExport.Text = "In báo cáo";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // BtnBHvaCD
            // 
            this.BtnBHvaCD.BackColor = System.Drawing.Color.Orange;
            this.BtnBHvaCD.FlatAppearance.BorderSize = 0;
            this.BtnBHvaCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBHvaCD.Image = global::Salary.Properties.Resources.search;
            this.BtnBHvaCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBHvaCD.Location = new System.Drawing.Point(232, 33);
            this.BtnBHvaCD.Name = "BtnBHvaCD";
            this.BtnBHvaCD.Size = new System.Drawing.Size(79, 35);
            this.BtnBHvaCD.TabIndex = 38;
            this.BtnBHvaCD.Text = "Xem";
            this.BtnBHvaCD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBHvaCD.UseVisualStyleBackColor = false;
            this.BtnBHvaCD.Click += new System.EventHandler(this.BtnBHvaCD_Click);
            // 
            // BtnButToan
            // 
            this.BtnButToan.BackColor = System.Drawing.Color.Orange;
            this.BtnButToan.FlatAppearance.BorderSize = 0;
            this.BtnButToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnButToan.Image = global::Salary.Properties.Resources.file_edit;
            this.BtnButToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnButToan.Location = new System.Drawing.Point(109, 33);
            this.BtnButToan.Name = "BtnButToan";
            this.BtnButToan.Size = new System.Drawing.Size(117, 35);
            this.BtnButToan.TabIndex = 12;
            this.BtnButToan.Text = "Lập bút toán";
            this.BtnButToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnButToan.UseVisualStyleBackColor = false;
            this.BtnButToan.Click += new System.EventHandler(this.BtnButToan_Click);
            // 
            // dtpNgaylapBH
            // 
            this.dtpNgaylapBH.Location = new System.Drawing.Point(1010, 46);
            this.dtpNgaylapBH.Name = "dtpNgaylapBH";
            this.dtpNgaylapBH.Size = new System.Drawing.Size(143, 22);
            this.dtpNgaylapBH.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1112, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vùng";
            // 
            // cbVung
            // 
            this.cbVung.DataSource = this.toiThieuVungBindingSource;
            this.cbVung.DisplayMember = "TenVung";
            this.cbVung.FormattingEnabled = true;
            this.cbVung.Location = new System.Drawing.Point(1059, 101);
            this.cbVung.Name = "cbVung";
            this.cbVung.Size = new System.Drawing.Size(94, 24);
            this.cbVung.TabIndex = 22;
            this.cbVung.ValueMember = "LuongTTV";
            // 
            // toiThieuVungBindingSource
            // 
            this.toiThieuVungBindingSource.DataMember = "ToiThieuVung";
            this.toiThieuVungBindingSource.DataSource = this.toiThieuVungDB;
            // 
            // toiThieuVungDB
            // 
            this.toiThieuVungDB.DataSetName = "ToiThieuVungDB";
            this.toiThieuVungDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baoHiemVaCongDoanTableAdapter
            // 
            this.baoHiemVaCongDoanTableAdapter.ClearBeforeFill = true;
            // 
            // toiThieuVungTableAdapter
            // 
            this.toiThieuVungTableAdapter.ClearBeforeFill = true;
            // 
            // BaohiemvaCongdoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::Salary.Properties.Resources.Nen_xanh_duong_pastel;
            this.ClientSize = new System.Drawing.Size(1157, 608);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaohiemvaCongdoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢO HIỂM VÀ CÔNG ĐOÀN";
            this.Load += new System.EventHandler(this.Baohiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaohiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoHiemVaCongDoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHvaCDDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cbThangBH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvBaohiem;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbNamBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ThemBHvaCD;
        private System.Windows.Forms.GroupBox groupBox1;
        private BHvaCDDB bHvaCDDB;
        private System.Windows.Forms.BindingSource baoHiemVaCongDoanBindingSource;
        private BHvaCDDBTableAdapters.BaoHiemVaCongDoanTableAdapter baoHiemVaCongDoanTableAdapter;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbVung;
        public System.Windows.Forms.DateTimePicker dtpNgaylapBH;
        private ToiThieuVungDB toiThieuVungDB;
        private System.Windows.Forms.BindingSource toiThieuVungBindingSource;
        private ToiThieuVungDBTableAdapters.ToiThieuVungTableAdapter toiThieuVungTableAdapter;
        private System.Windows.Forms.Button BtnButToan;
        private System.Windows.Forms.Button BtnBHvaCD;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttLCSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttLCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bHXHNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bHXHDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bHYTNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bHYTDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bHTNNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bHTNDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongBHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanPhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kinhPhiCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn;
    }
}