
namespace Salary
{
    partial class Bangluong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bangluong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.XetDuyet = new System.Windows.Forms.Button();
            this.btnBoDuyetTatCa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDuyetTatCa = new System.Windows.Forms.Button();
            this.dtpNgaylapBL = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.BtnXemBL = new System.Windows.Forms.Button();
            this.cbNamBL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThangBL = new System.Windows.Forms.ComboBox();
            this.ThemBangLuong = new System.Windows.Forms.Button();
            this.dtgvBangLuong = new System.Windows.Forms.DataGridView();
            this.sttBLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCongCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCongTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongTheoNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCapDiLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCapDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHXHNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHYTNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHTNNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueTNCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTamUng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttLCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttBHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttTTNCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDuyetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bangLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongDB = new Salary.BangLuongDB();
            this.bangLuongTableAdapter = new Salary.BangLuongDBTableAdapters.BangLuongTableAdapter();
            this.BtnButToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.BtnButToan);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.BtnXemBL);
            this.groupBox1.Controls.Add(this.cbNamBL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbThangBL);
            this.groupBox1.Controls.Add(this.ThemBangLuong);
            this.groupBox1.Controls.Add(this.dtgvBangLuong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1244, 604);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lương thực lĩnh";
            this.groupBox1.SizeChanged += new System.EventHandler(this.groupBox1_SizeChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.XetDuyet);
            this.groupBox2.Controls.Add(this.btnBoDuyetTatCa);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDuyetTatCa);
            this.groupBox2.Controls.Add(this.dtpNgaylapBL);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(841, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 124);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // XetDuyet
            // 
            this.XetDuyet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.XetDuyet.BackColor = System.Drawing.Color.Orange;
            this.XetDuyet.FlatAppearance.BorderSize = 0;
            this.XetDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XetDuyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XetDuyet.Location = new System.Drawing.Point(277, 85);
            this.XetDuyet.Name = "XetDuyet";
            this.XetDuyet.Size = new System.Drawing.Size(114, 35);
            this.XetDuyet.TabIndex = 37;
            this.XetDuyet.Text = "Xét duyệt";
            this.XetDuyet.UseVisualStyleBackColor = false;
            this.XetDuyet.Click += new System.EventHandler(this.XetDuyet_Click);
            // 
            // btnBoDuyetTatCa
            // 
            this.btnBoDuyetTatCa.BackColor = System.Drawing.Color.Orange;
            this.btnBoDuyetTatCa.FlatAppearance.BorderSize = 0;
            this.btnBoDuyetTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoDuyetTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoDuyetTatCa.Location = new System.Drawing.Point(28, 85);
            this.btnBoDuyetTatCa.Name = "btnBoDuyetTatCa";
            this.btnBoDuyetTatCa.Size = new System.Drawing.Size(123, 35);
            this.btnBoDuyetTatCa.TabIndex = 40;
            this.btnBoDuyetTatCa.Text = "Bỏ duyệt tất cả";
            this.btnBoDuyetTatCa.UseVisualStyleBackColor = false;
            this.btnBoDuyetTatCa.Click += new System.EventHandler(this.btnBoDuyetTatCa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày lập";
            // 
            // btnDuyetTatCa
            // 
            this.btnDuyetTatCa.BackColor = System.Drawing.Color.Orange;
            this.btnDuyetTatCa.FlatAppearance.BorderSize = 0;
            this.btnDuyetTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuyetTatCa.Location = new System.Drawing.Point(157, 85);
            this.btnDuyetTatCa.Name = "btnDuyetTatCa";
            this.btnDuyetTatCa.Size = new System.Drawing.Size(114, 35);
            this.btnDuyetTatCa.TabIndex = 39;
            this.btnDuyetTatCa.Text = "Duyệt tất cả";
            this.btnDuyetTatCa.UseVisualStyleBackColor = false;
            this.btnDuyetTatCa.Click += new System.EventHandler(this.btnDuyetTatCa_Click);
            // 
            // dtpNgaylapBL
            // 
            this.dtpNgaylapBL.Location = new System.Drawing.Point(233, 49);
            this.dtpNgaylapBL.Name = "dtpNgaylapBL";
            this.dtpNgaylapBL.Size = new System.Drawing.Size(158, 22);
            this.dtpNgaylapBL.TabIndex = 35;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Orange;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::Salary.Properties.Resources.spreadsheet;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(182, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(132, 35);
            this.btnExport.TabIndex = 38;
            this.btnExport.Text = "In báo cáo";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // BtnXemBL
            // 
            this.BtnXemBL.BackColor = System.Drawing.Color.Orange;
            this.BtnXemBL.FlatAppearance.BorderSize = 0;
            this.BtnXemBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXemBL.Image = global::Salary.Properties.Resources.search;
            this.BtnXemBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXemBL.Location = new System.Drawing.Point(102, 33);
            this.BtnXemBL.Name = "BtnXemBL";
            this.BtnXemBL.Size = new System.Drawing.Size(79, 35);
            this.BtnXemBL.TabIndex = 36;
            this.BtnXemBL.Text = "Xem";
            this.BtnXemBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnXemBL.UseVisualStyleBackColor = false;
            this.BtnXemBL.Click += new System.EventHandler(this.BtnXemBL_Click_1);
            // 
            // cbNamBL
            // 
            this.cbNamBL.FormattingEnabled = true;
            this.cbNamBL.Items.AddRange(new object[] {
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
            this.cbNamBL.Location = new System.Drawing.Point(10, 91);
            this.cbNamBL.Name = "cbNamBL";
            this.cbNamBL.Size = new System.Drawing.Size(94, 24);
            this.cbNamBL.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tháng";
            // 
            // cbThangBL
            // 
            this.cbThangBL.FormattingEnabled = true;
            this.cbThangBL.Items.AddRange(new object[] {
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
            this.cbThangBL.Location = new System.Drawing.Point(110, 91);
            this.cbThangBL.Name = "cbThangBL";
            this.cbThangBL.Size = new System.Drawing.Size(94, 24);
            this.cbThangBL.TabIndex = 30;
            // 
            // ThemBangLuong
            // 
            this.ThemBangLuong.BackColor = System.Drawing.Color.Orange;
            this.ThemBangLuong.FlatAppearance.BorderSize = 0;
            this.ThemBangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemBangLuong.Image = global::Salary.Properties.Resources.add_document;
            this.ThemBangLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemBangLuong.Location = new System.Drawing.Point(9, 33);
            this.ThemBangLuong.Name = "ThemBangLuong";
            this.ThemBangLuong.Size = new System.Drawing.Size(92, 35);
            this.ThemBangLuong.TabIndex = 29;
            this.ThemBangLuong.Text = "Tạo mới";
            this.ThemBangLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemBangLuong.UseVisualStyleBackColor = false;
            this.ThemBangLuong.Click += new System.EventHandler(this.ThemBangLuong_Click);
            // 
            // dtgvBangLuong
            // 
            this.dtgvBangLuong.AllowUserToAddRows = false;
            this.dtgvBangLuong.AllowUserToOrderColumns = true;
            this.dtgvBangLuong.AutoGenerateColumns = false;
            this.dtgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttBLDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.MaNV,
            this.TenNV,
            this.LuongCB,
            this.NgayCongCH,
            this.NgayCongTT,
            this.LuongTheoNC,
            this.LuongTC,
            this.PhuCapAn,
            this.PhuCapDiLai,
            this.PhuCapDienThoai,
            this.TongLuong,
            this.BHXHNV,
            this.BHYTNV,
            this.BHTNNV,
            this.ThueTNCN,
            this.DoanPhi,
            this.TongTamUng,
            this.sttLCNDataGridViewTextBoxColumn,
            this.sttBHDataGridViewTextBoxColumn,
            this.sttTTNCNDataGridViewTextBoxColumn,
            this.luongTNDataGridViewTextBoxColumn,
            this.maKLDataGridViewTextBoxColumn,
            this.tinhTrangDuyetDataGridViewCheckBoxColumn});
            this.dtgvBangLuong.DataSource = this.bangLuongBindingSource;
            this.dtgvBangLuong.Location = new System.Drawing.Point(9, 130);
            this.dtgvBangLuong.Name = "dtgvBangLuong";
            this.dtgvBangLuong.RowHeadersWidth = 51;
            this.dtgvBangLuong.RowTemplate.Height = 24;
            this.dtgvBangLuong.Size = new System.Drawing.Size(1231, 468);
            this.dtgvBangLuong.TabIndex = 7;
            // 
            // sttBLDataGridViewTextBoxColumn
            // 
            this.sttBLDataGridViewTextBoxColumn.DataPropertyName = "SttBL";
            this.sttBLDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttBLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttBLDataGridViewTextBoxColumn.Name = "sttBLDataGridViewTextBoxColumn";
            this.sttBLDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttBLDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 125;
            // 
            // LuongCB
            // 
            this.LuongCB.DataPropertyName = "LuongCB";
            this.LuongCB.HeaderText = "Lương cơ bản";
            this.LuongCB.MinimumWidth = 6;
            this.LuongCB.Name = "LuongCB";
            this.LuongCB.Width = 125;
            // 
            // NgayCongCH
            // 
            this.NgayCongCH.DataPropertyName = "NgayCongCH";
            this.NgayCongCH.HeaderText = "Ngày công chuẩn";
            this.NgayCongCH.MinimumWidth = 6;
            this.NgayCongCH.Name = "NgayCongCH";
            this.NgayCongCH.Width = 125;
            // 
            // NgayCongTT
            // 
            this.NgayCongTT.DataPropertyName = "NgayCongTT";
            this.NgayCongTT.HeaderText = "Ngày công thực tế";
            this.NgayCongTT.MinimumWidth = 6;
            this.NgayCongTT.Name = "NgayCongTT";
            this.NgayCongTT.Width = 125;
            // 
            // LuongTheoNC
            // 
            this.LuongTheoNC.DataPropertyName = "LuongTheoNC";
            this.LuongTheoNC.HeaderText = "Lương theo ngày";
            this.LuongTheoNC.MinimumWidth = 6;
            this.LuongTheoNC.Name = "LuongTheoNC";
            this.LuongTheoNC.Width = 125;
            // 
            // LuongTC
            // 
            this.LuongTC.DataPropertyName = "LuongTC";
            this.LuongTC.HeaderText = "Lương tăng ca";
            this.LuongTC.MinimumWidth = 6;
            this.LuongTC.Name = "LuongTC";
            this.LuongTC.Width = 125;
            // 
            // PhuCapAn
            // 
            this.PhuCapAn.DataPropertyName = "PhuCapAn";
            this.PhuCapAn.HeaderText = "Phụ cấp ăn";
            this.PhuCapAn.MinimumWidth = 6;
            this.PhuCapAn.Name = "PhuCapAn";
            this.PhuCapAn.Width = 125;
            // 
            // PhuCapDiLai
            // 
            this.PhuCapDiLai.DataPropertyName = "PhuCapDiLai";
            this.PhuCapDiLai.HeaderText = "Phụ cấp đi lại";
            this.PhuCapDiLai.MinimumWidth = 6;
            this.PhuCapDiLai.Name = "PhuCapDiLai";
            this.PhuCapDiLai.Width = 125;
            // 
            // PhuCapDienThoai
            // 
            this.PhuCapDienThoai.DataPropertyName = "PhuCapDienThoai";
            this.PhuCapDienThoai.HeaderText = "Phụ cấp điện thoại";
            this.PhuCapDienThoai.MinimumWidth = 6;
            this.PhuCapDienThoai.Name = "PhuCapDienThoai";
            this.PhuCapDienThoai.Width = 125;
            // 
            // TongLuong
            // 
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "Tổng lương";
            this.TongLuong.MinimumWidth = 6;
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.Width = 125;
            // 
            // BHXHNV
            // 
            this.BHXHNV.DataPropertyName = "BHXHNV";
            this.BHXHNV.HeaderText = "BHXH";
            this.BHXHNV.MinimumWidth = 6;
            this.BHXHNV.Name = "BHXHNV";
            this.BHXHNV.Width = 125;
            // 
            // BHYTNV
            // 
            this.BHYTNV.DataPropertyName = "BHYTNV";
            this.BHYTNV.HeaderText = "BHYT";
            this.BHYTNV.MinimumWidth = 6;
            this.BHYTNV.Name = "BHYTNV";
            this.BHYTNV.Width = 125;
            // 
            // BHTNNV
            // 
            this.BHTNNV.DataPropertyName = "BHTNNV";
            this.BHTNNV.HeaderText = "BHTN";
            this.BHTNNV.MinimumWidth = 6;
            this.BHTNNV.Name = "BHTNNV";
            this.BHTNNV.Width = 125;
            // 
            // ThueTNCN
            // 
            this.ThueTNCN.DataPropertyName = "ThueTNCN";
            this.ThueTNCN.HeaderText = "Thuế TNCN";
            this.ThueTNCN.MinimumWidth = 6;
            this.ThueTNCN.Name = "ThueTNCN";
            this.ThueTNCN.Width = 125;
            // 
            // DoanPhi
            // 
            this.DoanPhi.DataPropertyName = "DoanPhi";
            this.DoanPhi.HeaderText = "Đoàn phí";
            this.DoanPhi.MinimumWidth = 6;
            this.DoanPhi.Name = "DoanPhi";
            this.DoanPhi.Width = 125;
            // 
            // TongTamUng
            // 
            this.TongTamUng.DataPropertyName = "TongTamUng";
            this.TongTamUng.HeaderText = "Tổng tạm ứng";
            this.TongTamUng.MinimumWidth = 6;
            this.TongTamUng.Name = "TongTamUng";
            this.TongTamUng.ReadOnly = true;
            this.TongTamUng.Width = 125;
            // 
            // sttLCNDataGridViewTextBoxColumn
            // 
            this.sttLCNDataGridViewTextBoxColumn.DataPropertyName = "SttLCN";
            this.sttLCNDataGridViewTextBoxColumn.HeaderText = "SttLCN";
            this.sttLCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttLCNDataGridViewTextBoxColumn.Name = "sttLCNDataGridViewTextBoxColumn";
            this.sttLCNDataGridViewTextBoxColumn.Visible = false;
            this.sttLCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttBHDataGridViewTextBoxColumn
            // 
            this.sttBHDataGridViewTextBoxColumn.DataPropertyName = "SttBH";
            this.sttBHDataGridViewTextBoxColumn.HeaderText = "SttBH";
            this.sttBHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttBHDataGridViewTextBoxColumn.Name = "sttBHDataGridViewTextBoxColumn";
            this.sttBHDataGridViewTextBoxColumn.Visible = false;
            this.sttBHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttTTNCNDataGridViewTextBoxColumn
            // 
            this.sttTTNCNDataGridViewTextBoxColumn.DataPropertyName = "SttTTNCN";
            this.sttTTNCNDataGridViewTextBoxColumn.HeaderText = "SttTTNCN";
            this.sttTTNCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTTNCNDataGridViewTextBoxColumn.Name = "sttTTNCNDataGridViewTextBoxColumn";
            this.sttTTNCNDataGridViewTextBoxColumn.Visible = false;
            this.sttTTNCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongTNDataGridViewTextBoxColumn
            // 
            this.luongTNDataGridViewTextBoxColumn.DataPropertyName = "LuongTN";
            this.luongTNDataGridViewTextBoxColumn.HeaderText = "LuongTN";
            this.luongTNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongTNDataGridViewTextBoxColumn.Name = "luongTNDataGridViewTextBoxColumn";
            this.luongTNDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKLDataGridViewTextBoxColumn
            // 
            this.maKLDataGridViewTextBoxColumn.DataPropertyName = "MaKL";
            this.maKLDataGridViewTextBoxColumn.HeaderText = "MaKL";
            this.maKLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKLDataGridViewTextBoxColumn.Name = "maKLDataGridViewTextBoxColumn";
            this.maKLDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhTrangDuyetDataGridViewCheckBoxColumn
            // 
            this.tinhTrangDuyetDataGridViewCheckBoxColumn.DataPropertyName = "TinhTrangDuyet";
            this.tinhTrangDuyetDataGridViewCheckBoxColumn.HeaderText = "Tình trạng duyệt";
            this.tinhTrangDuyetDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.tinhTrangDuyetDataGridViewCheckBoxColumn.Name = "tinhTrangDuyetDataGridViewCheckBoxColumn";
            this.tinhTrangDuyetDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bangLuongBindingSource
            // 
            this.bangLuongBindingSource.DataMember = "BangLuong";
            this.bangLuongBindingSource.DataSource = this.bangLuongDB;
            // 
            // bangLuongDB
            // 
            this.bangLuongDB.DataSetName = "BangLuongDB";
            this.bangLuongDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangLuongTableAdapter
            // 
            this.bangLuongTableAdapter.ClearBeforeFill = true;
            // 
            // BtnButToan
            // 
            this.BtnButToan.BackColor = System.Drawing.Color.Orange;
            this.BtnButToan.FlatAppearance.BorderSize = 0;
            this.BtnButToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnButToan.Image = global::Salary.Properties.Resources.file_edit;
            this.BtnButToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnButToan.Location = new System.Drawing.Point(316, 33);
            this.BtnButToan.Name = "BtnButToan";
            this.BtnButToan.Size = new System.Drawing.Size(117, 35);
            this.BtnButToan.TabIndex = 42;
            this.BtnButToan.Text = "Lập bút toán";
            this.BtnButToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnButToan.UseVisualStyleBackColor = false;
            this.BtnButToan.Click += new System.EventHandler(this.BtnButToan_Click);
            // 
            // Bangluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1244, 604);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bangluong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢNG LƯƠNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bangluong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dtpNgaylapBL;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbNamBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbThangBL;
        private System.Windows.Forms.Button ThemBangLuong;
        private System.Windows.Forms.Button BtnXemBL;
        public System.Windows.Forms.Button XetDuyet;
        private BangLuongDB bangLuongDB;
        private System.Windows.Forms.BindingSource bangLuongBindingSource;
        private BangLuongDBTableAdapters.BangLuongTableAdapter bangLuongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCongCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCongTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongTheoNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCapDiLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCapDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHXHNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHYTNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHTNNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueTNCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTamUng;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttLCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTTNCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tinhTrangDuyetDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dtgvBangLuong;
        private System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnDuyetTatCa;
        public System.Windows.Forms.Button btnBoDuyetTatCa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnButToan;
    }
}