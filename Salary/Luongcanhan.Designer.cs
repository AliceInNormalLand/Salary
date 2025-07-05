
namespace Salary
{
    partial class Luongcanhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luongcanhan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaBangLuong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTTV = new System.Windows.Forms.ComboBox();
            this.toiThieuVungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toiThieuVungDB = new Salary.ToiThieuVungDB();
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnXemLCN = new System.Windows.Forms.Button();
            this.ThemLCN = new System.Windows.Forms.Button();
            this.dtgvLCN = new System.Windows.Forms.DataGridView();
            this.sttLCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttHDLDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttTDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCongCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCongTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTheoNCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTCKhongTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luongCNDB = new Salary.LuongCNDB();
            this.luongCNTableAdapter = new Salary.LuongCNDBTableAdapters.LuongCNTableAdapter();
            this.chamDiemDB = new Salary.ChamDiemDB();
            this.chamDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamDiemTableAdapter = new Salary.ChamDiemDBTableAdapters.ChamDiemTableAdapter();
            this.toiThieuVungTableAdapter = new Salary.ToiThieuVungDBTableAdapters.ToiThieuVungTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongCNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongCNDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamDiemDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamDiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.btnXoaBangLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTTV);
            this.groupBox1.Controls.Add(this.dtpNgaylap);
            this.groupBox1.Controls.Add(this.cbNam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbThang);
            this.groupBox1.Controls.Add(this.btnXemLCN);
            this.groupBox1.Controls.Add(this.ThemLCN);
            this.groupBox1.Controls.Add(this.dtgvLCN);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1195, 551);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lương cá nhân";
            // 
            // btnXoaBangLuong
            // 
            this.btnXoaBangLuong.BackColor = System.Drawing.Color.Orange;
            this.btnXoaBangLuong.FlatAppearance.BorderSize = 0;
            this.btnXoaBangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBangLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoaBangLuong.Image = global::Salary.Properties.Resources.file_minus;
            this.btnXoaBangLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBangLuong.Location = new System.Drawing.Point(193, 31);
            this.btnXoaBangLuong.Name = "btnXoaBangLuong";
            this.btnXoaBangLuong.Size = new System.Drawing.Size(75, 35);
            this.btnXoaBangLuong.TabIndex = 40;
            this.btnXoaBangLuong.Text = "Xóa ";
            this.btnXoaBangLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBangLuong.UseVisualStyleBackColor = false;
            this.btnXoaBangLuong.Click += new System.EventHandler(this.btnXoaBangLuong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(999, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Vùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1125, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày lập";
            // 
            // cbTTV
            // 
            this.cbTTV.DataSource = this.toiThieuVungBindingSource;
            this.cbTTV.DisplayMember = "TenVung";
            this.cbTTV.FormattingEnabled = true;
            this.cbTTV.Location = new System.Drawing.Point(946, 42);
            this.cbTTV.Name = "cbTTV";
            this.cbTTV.Size = new System.Drawing.Size(94, 24);
            this.cbTTV.TabIndex = 24;
            this.cbTTV.ValueMember = "LuongTTV";
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
            // dtpNgaylap
            // 
            this.dtpNgaylap.Location = new System.Drawing.Point(1046, 43);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(143, 22);
            this.dtpNgaylap.TabIndex = 15;
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
            this.cbNam.Location = new System.Drawing.Point(9, 101);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(94, 24);
            this.cbNam.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 12;
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
            this.cbThang.Location = new System.Drawing.Point(112, 101);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(94, 24);
            this.cbThang.TabIndex = 11;
            // 
            // btnXemLCN
            // 
            this.btnXemLCN.BackColor = System.Drawing.Color.Orange;
            this.btnXemLCN.FlatAppearance.BorderSize = 0;
            this.btnXemLCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLCN.Image = global::Salary.Properties.Resources.search;
            this.btnXemLCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLCN.Location = new System.Drawing.Point(108, 31);
            this.btnXemLCN.Name = "btnXemLCN";
            this.btnXemLCN.Size = new System.Drawing.Size(79, 35);
            this.btnXemLCN.TabIndex = 10;
            this.btnXemLCN.Text = "Xem";
            this.btnXemLCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemLCN.UseVisualStyleBackColor = false;
            this.btnXemLCN.Click += new System.EventHandler(this.btnXemLCN_Click);
            // 
            // ThemLCN
            // 
            this.ThemLCN.BackColor = System.Drawing.Color.Orange;
            this.ThemLCN.FlatAppearance.BorderSize = 0;
            this.ThemLCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemLCN.Image = global::Salary.Properties.Resources.add_document;
            this.ThemLCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemLCN.Location = new System.Drawing.Point(9, 30);
            this.ThemLCN.Name = "ThemLCN";
            this.ThemLCN.Size = new System.Drawing.Size(94, 35);
            this.ThemLCN.TabIndex = 9;
            this.ThemLCN.Text = "Tạo mới";
            this.ThemLCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemLCN.UseVisualStyleBackColor = false;
            this.ThemLCN.Click += new System.EventHandler(this.ThemLCN_Click);
            // 
            // dtgvLCN
            // 
            this.dtgvLCN.AllowUserToAddRows = false;
            this.dtgvLCN.AutoGenerateColumns = false;
            this.dtgvLCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttLCNDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.sttHDLDDataGridViewTextBoxColumn,
            this.luongCBDataGridViewTextBoxColumn,
            this.sttCCDataGridViewTextBoxColumn,
            this.sttTDGDataGridViewTextBoxColumn,
            this.ngayCongCHDataGridViewTextBoxColumn,
            this.ngayCongTTDataGridViewTextBoxColumn,
            this.luongTheoNCDataGridViewTextBoxColumn,
            this.luongTCDataGridViewTextBoxColumn,
            this.luongTCKhongTTDataGridViewTextBoxColumn,
            this.maKLDataGridViewTextBoxColumn});
            this.dtgvLCN.DataSource = this.luongCNBindingSource;
            this.dtgvLCN.Location = new System.Drawing.Point(9, 137);
            this.dtgvLCN.Name = "dtgvLCN";
            this.dtgvLCN.ReadOnly = true;
            this.dtgvLCN.RowHeadersWidth = 51;
            this.dtgvLCN.RowTemplate.Height = 24;
            this.dtgvLCN.Size = new System.Drawing.Size(1186, 408);
            this.dtgvLCN.TabIndex = 7;
            this.dtgvLCN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLCN_CellClick);
            this.dtgvLCN.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvLCN_CellFormatting_1);
            // 
            // sttLCNDataGridViewTextBoxColumn
            // 
            this.sttLCNDataGridViewTextBoxColumn.DataPropertyName = "SttLCN";
            this.sttLCNDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttLCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttLCNDataGridViewTextBoxColumn.Name = "sttLCNDataGridViewTextBoxColumn";
            this.sttLCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttLCNDataGridViewTextBoxColumn.Width = 125;
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
            // sttHDLDDataGridViewTextBoxColumn
            // 
            this.sttHDLDDataGridViewTextBoxColumn.DataPropertyName = "SttHDLD";
            this.sttHDLDDataGridViewTextBoxColumn.HeaderText = "STT HDLD";
            this.sttHDLDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttHDLDDataGridViewTextBoxColumn.Name = "sttHDLDDataGridViewTextBoxColumn";
            this.sttHDLDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttHDLDDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongCBDataGridViewTextBoxColumn
            // 
            this.luongCBDataGridViewTextBoxColumn.DataPropertyName = "LuongCB";
            this.luongCBDataGridViewTextBoxColumn.HeaderText = "Lương cơ bản";
            this.luongCBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongCBDataGridViewTextBoxColumn.Name = "luongCBDataGridViewTextBoxColumn";
            this.luongCBDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongCBDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttCCDataGridViewTextBoxColumn
            // 
            this.sttCCDataGridViewTextBoxColumn.DataPropertyName = "SttCC";
            this.sttCCDataGridViewTextBoxColumn.HeaderText = "STT chấm công";
            this.sttCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttCCDataGridViewTextBoxColumn.Name = "sttCCDataGridViewTextBoxColumn";
            this.sttCCDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttTDGDataGridViewTextBoxColumn
            // 
            this.sttTDGDataGridViewTextBoxColumn.DataPropertyName = "SttTDG";
            this.sttTDGDataGridViewTextBoxColumn.HeaderText = "STT thang đánh giá";
            this.sttTDGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTDGDataGridViewTextBoxColumn.Name = "sttTDGDataGridViewTextBoxColumn";
            this.sttTDGDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTDGDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayCongCHDataGridViewTextBoxColumn
            // 
            this.ngayCongCHDataGridViewTextBoxColumn.DataPropertyName = "NgayCongCH";
            this.ngayCongCHDataGridViewTextBoxColumn.HeaderText = "Ngày công chuẩn";
            this.ngayCongCHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCongCHDataGridViewTextBoxColumn.Name = "ngayCongCHDataGridViewTextBoxColumn";
            this.ngayCongCHDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayCongCHDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayCongTTDataGridViewTextBoxColumn
            // 
            this.ngayCongTTDataGridViewTextBoxColumn.DataPropertyName = "NgayCongTT";
            this.ngayCongTTDataGridViewTextBoxColumn.HeaderText = "Ngày công thực tế";
            this.ngayCongTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCongTTDataGridViewTextBoxColumn.Name = "ngayCongTTDataGridViewTextBoxColumn";
            this.ngayCongTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayCongTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongTheoNCDataGridViewTextBoxColumn
            // 
            this.luongTheoNCDataGridViewTextBoxColumn.DataPropertyName = "LuongTheoNC";
            this.luongTheoNCDataGridViewTextBoxColumn.HeaderText = "Lương theo ngày công";
            this.luongTheoNCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongTheoNCDataGridViewTextBoxColumn.Name = "luongTheoNCDataGridViewTextBoxColumn";
            this.luongTheoNCDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongTheoNCDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongTCDataGridViewTextBoxColumn
            // 
            this.luongTCDataGridViewTextBoxColumn.DataPropertyName = "LuongTC";
            this.luongTCDataGridViewTextBoxColumn.HeaderText = "Lương tăng ca";
            this.luongTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongTCDataGridViewTextBoxColumn.Name = "luongTCDataGridViewTextBoxColumn";
            this.luongTCDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongTCKhongTTDataGridViewTextBoxColumn
            // 
            this.luongTCKhongTTDataGridViewTextBoxColumn.DataPropertyName = "LuongTCKhongTT";
            this.luongTCKhongTTDataGridViewTextBoxColumn.HeaderText = "Lương tăng ca không tính thuế";
            this.luongTCKhongTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongTCKhongTTDataGridViewTextBoxColumn.Name = "luongTCKhongTTDataGridViewTextBoxColumn";
            this.luongTCKhongTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongTCKhongTTDataGridViewTextBoxColumn.Width = 125;
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
            // luongCNBindingSource
            // 
            this.luongCNBindingSource.DataMember = "LuongCN";
            this.luongCNBindingSource.DataSource = this.luongCNDB;
            // 
            // luongCNDB
            // 
            this.luongCNDB.DataSetName = "LuongCNDB";
            this.luongCNDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // luongCNTableAdapter
            // 
            this.luongCNTableAdapter.ClearBeforeFill = true;
            // 
            // chamDiemDB
            // 
            this.chamDiemDB.DataSetName = "ChamDiemDB";
            this.chamDiemDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chamDiemBindingSource
            // 
            this.chamDiemBindingSource.DataMember = "ChamDiem";
            this.chamDiemBindingSource.DataSource = this.chamDiemDB;
            // 
            // chamDiemTableAdapter
            // 
            this.chamDiemTableAdapter.ClearBeforeFill = true;
            // 
            // toiThieuVungTableAdapter
            // 
            this.toiThieuVungTableAdapter.ClearBeforeFill = true;
            // 
            // Luongcanhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1198, 553);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Luongcanhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LƯƠNG CÁ NHÂN";
            this.Load += new System.EventHandler(this.Luongcanhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongCNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongCNDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamDiemDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamDiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvLCN;
        private System.Windows.Forms.Button btnXemLCN;
        private System.Windows.Forms.Button ThemLCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbThang;
        public System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
        private LuongCNDB luongCNDB;
        private System.Windows.Forms.BindingSource luongCNBindingSource;
        private LuongCNDBTableAdapters.LuongCNTableAdapter luongCNTableAdapter;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbTTV;
        private ChamDiemDB chamDiemDB;
        private System.Windows.Forms.BindingSource chamDiemBindingSource;
        private ChamDiemDBTableAdapters.ChamDiemTableAdapter chamDiemTableAdapter;
        private ToiThieuVungDB toiThieuVungDB;
        private System.Windows.Forms.BindingSource toiThieuVungBindingSource;
        private ToiThieuVungDBTableAdapters.ToiThieuVungTableAdapter toiThieuVungTableAdapter;
        private System.Windows.Forms.Button btnXoaBangLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttLCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttHDLDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCongCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCongTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTheoNCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTCKhongTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn;
    }
}