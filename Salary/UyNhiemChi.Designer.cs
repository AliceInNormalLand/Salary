
namespace Salary
{
    partial class UyNhiemChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyNhiemChi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnButToan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbNamCT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbThangCT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbChonCT = new System.Windows.Forms.ComboBox();
            this.dtpNgaylapUNC = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemUyNhiemChi = new System.Windows.Forms.Button();
            this.btnXemLCN = new System.Windows.Forms.Button();
            this.dtgvUNC = new System.Windows.Forms.DataGridView();
            this.sttUNCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttTTNCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSoThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttBLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttBHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttTKNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTKNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTKNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyNhiemChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyNhiemChiDB = new Salary.UyNhiemChiDB();
            this.uyNhiemChiTableAdapter = new Salary.UyNhiemChiDBTableAdapters.UyNhiemChiTableAdapter();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyNhiemChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyNhiemChiDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.BtnButToan);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpNgaylapUNC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ThemUyNhiemChi);
            this.groupBox1.Controls.Add(this.btnXemLCN);
            this.groupBox1.Controls.Add(this.dtgvUNC);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 626);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ủy nhiệm chi";
            // 
            // BtnButToan
            // 
            this.BtnButToan.BackColor = System.Drawing.Color.Orange;
            this.BtnButToan.FlatAppearance.BorderSize = 0;
            this.BtnButToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnButToan.Image = global::Salary.Properties.Resources.file_edit;
            this.BtnButToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnButToan.Location = new System.Drawing.Point(882, 66);
            this.BtnButToan.Name = "BtnButToan";
            this.BtnButToan.Size = new System.Drawing.Size(117, 35);
            this.BtnButToan.TabIndex = 41;
            this.BtnButToan.Text = "Lập bút toán";
            this.BtnButToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnButToan.UseVisualStyleBackColor = false;
            this.BtnButToan.Click += new System.EventHandler(this.BtnButToan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbNamCT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CbThangCT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CbChonCT);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 80);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kỳ lương";
            // 
            // CbNamCT
            // 
            this.CbNamCT.FormattingEnabled = true;
            this.CbNamCT.Items.AddRange(new object[] {
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
            this.CbNamCT.Location = new System.Drawing.Point(4, 45);
            this.CbNamCT.Name = "CbNamCT";
            this.CbNamCT.Size = new System.Drawing.Size(94, 24);
            this.CbNamCT.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nội dung chi";
            // 
            // CbThangCT
            // 
            this.CbThangCT.FormattingEnabled = true;
            this.CbThangCT.Items.AddRange(new object[] {
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
            this.CbThangCT.Location = new System.Drawing.Point(106, 45);
            this.CbThangCT.Name = "CbThangCT";
            this.CbThangCT.Size = new System.Drawing.Size(94, 24);
            this.CbThangCT.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tháng";
            // 
            // CbChonCT
            // 
            this.CbChonCT.FormattingEnabled = true;
            this.CbChonCT.Items.AddRange(new object[] {
            "Tạm ứng lương",
            "Bảng lương",
            "Thuế thu nhập cá nhân",
            "Bảo hiểm và kinh phí công đoàn"});
            this.CbChonCT.Location = new System.Drawing.Point(206, 45);
            this.CbChonCT.Name = "CbChonCT";
            this.CbChonCT.Size = new System.Drawing.Size(262, 24);
            this.CbChonCT.TabIndex = 38;
            // 
            // dtpNgaylapUNC
            // 
            this.dtpNgaylapUNC.Location = new System.Drawing.Point(856, 38);
            this.dtpNgaylapUNC.Name = "dtpNgaylapUNC";
            this.dtpNgaylapUNC.Size = new System.Drawing.Size(143, 22);
            this.dtpNgaylapUNC.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ngày lập";
            // 
            // ThemUyNhiemChi
            // 
            this.ThemUyNhiemChi.BackColor = System.Drawing.Color.Orange;
            this.ThemUyNhiemChi.FlatAppearance.BorderSize = 0;
            this.ThemUyNhiemChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemUyNhiemChi.Image = global::Salary.Properties.Resources.add_document;
            this.ThemUyNhiemChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemUyNhiemChi.Location = new System.Drawing.Point(699, 66);
            this.ThemUyNhiemChi.Name = "ThemUyNhiemChi";
            this.ThemUyNhiemChi.Size = new System.Drawing.Size(92, 35);
            this.ThemUyNhiemChi.TabIndex = 30;
            this.ThemUyNhiemChi.Text = "Tạo mới";
            this.ThemUyNhiemChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemUyNhiemChi.UseVisualStyleBackColor = false;
            this.ThemUyNhiemChi.Click += new System.EventHandler(this.UyNhiemChi_Click);
            // 
            // btnXemLCN
            // 
            this.btnXemLCN.BackColor = System.Drawing.Color.Orange;
            this.btnXemLCN.FlatAppearance.BorderSize = 0;
            this.btnXemLCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLCN.Image = global::Salary.Properties.Resources.search;
            this.btnXemLCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLCN.Location = new System.Drawing.Point(797, 66);
            this.btnXemLCN.Name = "btnXemLCN";
            this.btnXemLCN.Size = new System.Drawing.Size(79, 35);
            this.btnXemLCN.TabIndex = 15;
            this.btnXemLCN.Text = "Xem";
            this.btnXemLCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemLCN.UseVisualStyleBackColor = false;
            this.btnXemLCN.Click += new System.EventHandler(this.btnXemLCN_Click);
            // 
            // dtgvUNC
            // 
            this.dtgvUNC.AllowUserToAddRows = false;
            this.dtgvUNC.AutoGenerateColumns = false;
            this.dtgvUNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUNC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttUNCDataGridViewTextBoxColumn,
            this.ngaylapDataGridViewTextBoxColumn,
            this.noidungDataGridViewTextBoxColumn,
            this.sotienDataGridViewTextBoxColumn,
            this.sttTTNCNDataGridViewTextBoxColumn,
            this.MaSoThue,
            this.sttBLDataGridViewTextBoxColumn,
            this.maTUDataGridViewTextBoxColumn,
            this.sttBHDataGridViewTextBoxColumn,
            this.sttTKNHDataGridViewTextBoxColumn,
            this.SoTKNH,
            this.TenTKNH,
            this.TenNH,
            this.BHXH,
            this.BHYT,
            this.BHTN,
            this.KPCD});
            this.dtgvUNC.DataSource = this.uyNhiemChiBindingSource;
            this.dtgvUNC.Location = new System.Drawing.Point(9, 107);
            this.dtgvUNC.Name = "dtgvUNC";
            this.dtgvUNC.ReadOnly = true;
            this.dtgvUNC.RowHeadersWidth = 51;
            this.dtgvUNC.RowTemplate.Height = 24;
            this.dtgvUNC.Size = new System.Drawing.Size(992, 513);
            this.dtgvUNC.TabIndex = 7;
            // 
            // sttUNCDataGridViewTextBoxColumn
            // 
            this.sttUNCDataGridViewTextBoxColumn.DataPropertyName = "SttUNC";
            this.sttUNCDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttUNCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttUNCDataGridViewTextBoxColumn.Name = "sttUNCDataGridViewTextBoxColumn";
            this.sttUNCDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttUNCDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaylapDataGridViewTextBoxColumn
            // 
            this.ngaylapDataGridViewTextBoxColumn.DataPropertyName = "Ngaylap";
            this.ngaylapDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.ngaylapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaylapDataGridViewTextBoxColumn.Name = "ngaylapDataGridViewTextBoxColumn";
            this.ngaylapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaylapDataGridViewTextBoxColumn.Width = 125;
            // 
            // noidungDataGridViewTextBoxColumn
            // 
            this.noidungDataGridViewTextBoxColumn.DataPropertyName = "Noidung";
            this.noidungDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.noidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noidungDataGridViewTextBoxColumn.Name = "noidungDataGridViewTextBoxColumn";
            this.noidungDataGridViewTextBoxColumn.ReadOnly = true;
            this.noidungDataGridViewTextBoxColumn.Width = 125;
            // 
            // sotienDataGridViewTextBoxColumn
            // 
            this.sotienDataGridViewTextBoxColumn.DataPropertyName = "Sotien";
            this.sotienDataGridViewTextBoxColumn.HeaderText = "Số tiền";
            this.sotienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sotienDataGridViewTextBoxColumn.Name = "sotienDataGridViewTextBoxColumn";
            this.sotienDataGridViewTextBoxColumn.ReadOnly = true;
            this.sotienDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttTTNCNDataGridViewTextBoxColumn
            // 
            this.sttTTNCNDataGridViewTextBoxColumn.DataPropertyName = "SttTTNCN";
            this.sttTTNCNDataGridViewTextBoxColumn.HeaderText = "Số CT thuế";
            this.sttTTNCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTTNCNDataGridViewTextBoxColumn.Name = "sttTTNCNDataGridViewTextBoxColumn";
            this.sttTTNCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTTNCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // MaSoThue
            // 
            this.MaSoThue.DataPropertyName = "MaSoThue";
            this.MaSoThue.HeaderText = "Mã số thuế TNCN";
            this.MaSoThue.MinimumWidth = 6;
            this.MaSoThue.Name = "MaSoThue";
            this.MaSoThue.ReadOnly = true;
            this.MaSoThue.Width = 125;
            // 
            // sttBLDataGridViewTextBoxColumn
            // 
            this.sttBLDataGridViewTextBoxColumn.DataPropertyName = "SttBL";
            this.sttBLDataGridViewTextBoxColumn.HeaderText = "STT bảng lương";
            this.sttBLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttBLDataGridViewTextBoxColumn.Name = "sttBLDataGridViewTextBoxColumn";
            this.sttBLDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttBLDataGridViewTextBoxColumn.Width = 125;
            // 
            // maTUDataGridViewTextBoxColumn
            // 
            this.maTUDataGridViewTextBoxColumn.DataPropertyName = "MaTU";
            this.maTUDataGridViewTextBoxColumn.HeaderText = "Mã CT tạm ứng";
            this.maTUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTUDataGridViewTextBoxColumn.Name = "maTUDataGridViewTextBoxColumn";
            this.maTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTUDataGridViewTextBoxColumn.Width = 125;
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
            // sttTKNHDataGridViewTextBoxColumn
            // 
            this.sttTKNHDataGridViewTextBoxColumn.DataPropertyName = "SttTKNH";
            this.sttTKNHDataGridViewTextBoxColumn.HeaderText = "STT Tài khoản ngân hàng";
            this.sttTKNHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTKNHDataGridViewTextBoxColumn.Name = "sttTKNHDataGridViewTextBoxColumn";
            this.sttTKNHDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTKNHDataGridViewTextBoxColumn.Width = 125;
            // 
            // SoTKNH
            // 
            this.SoTKNH.DataPropertyName = "SoTKNH";
            this.SoTKNH.HeaderText = "Số TKNH";
            this.SoTKNH.MinimumWidth = 6;
            this.SoTKNH.Name = "SoTKNH";
            this.SoTKNH.ReadOnly = true;
            this.SoTKNH.Width = 125;
            // 
            // TenTKNH
            // 
            this.TenTKNH.DataPropertyName = "TenTKNH";
            this.TenTKNH.HeaderText = "Tên TKNH";
            this.TenTKNH.MinimumWidth = 6;
            this.TenTKNH.Name = "TenTKNH";
            this.TenTKNH.ReadOnly = true;
            this.TenTKNH.Width = 125;
            // 
            // TenNH
            // 
            this.TenNH.DataPropertyName = "TenNH";
            this.TenNH.HeaderText = "Tên NH";
            this.TenNH.MinimumWidth = 6;
            this.TenNH.Name = "TenNH";
            this.TenNH.ReadOnly = true;
            this.TenNH.Width = 125;
            // 
            // BHXH
            // 
            this.BHXH.DataPropertyName = "BHXH";
            this.BHXH.HeaderText = "Bảo hiểm xã hội";
            this.BHXH.MinimumWidth = 6;
            this.BHXH.Name = "BHXH";
            this.BHXH.ReadOnly = true;
            this.BHXH.Visible = false;
            this.BHXH.Width = 125;
            // 
            // BHYT
            // 
            this.BHYT.DataPropertyName = "BHYT";
            this.BHYT.HeaderText = "Bảo hiểm y tế";
            this.BHYT.MinimumWidth = 6;
            this.BHYT.Name = "BHYT";
            this.BHYT.ReadOnly = true;
            this.BHYT.Visible = false;
            this.BHYT.Width = 125;
            // 
            // BHTN
            // 
            this.BHTN.DataPropertyName = "BHTN";
            this.BHTN.HeaderText = "Bảo hiểm thất nghiệp";
            this.BHTN.MinimumWidth = 6;
            this.BHTN.Name = "BHTN";
            this.BHTN.ReadOnly = true;
            this.BHTN.Visible = false;
            this.BHTN.Width = 125;
            // 
            // KPCD
            // 
            this.KPCD.DataPropertyName = "KPCD";
            this.KPCD.HeaderText = "Kinh phí công đoàn";
            this.KPCD.MinimumWidth = 6;
            this.KPCD.Name = "KPCD";
            this.KPCD.ReadOnly = true;
            this.KPCD.Visible = false;
            this.KPCD.Width = 125;
            // 
            // uyNhiemChiBindingSource
            // 
            this.uyNhiemChiBindingSource.DataMember = "UyNhiemChi";
            this.uyNhiemChiBindingSource.DataSource = this.uyNhiemChiDB;
            // 
            // uyNhiemChiDB
            // 
            this.uyNhiemChiDB.DataSetName = "UyNhiemChiDB";
            this.uyNhiemChiDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyNhiemChiTableAdapter
            // 
            this.uyNhiemChiTableAdapter.ClearBeforeFill = true;
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(854, 632);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(147, 22);
            this.tbTongTien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tổng tiền";
            // 
            // UyNhiemChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1010, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyNhiemChi";
            this.Text = "ỦY NHIỆM CHI";
            this.Load += new System.EventHandler(this.UyNhiemChi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyNhiemChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyNhiemChiDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvUNC;
        private System.Windows.Forms.Button btnXemLCN;
        private System.Windows.Forms.Button ThemUyNhiemChi;
        public System.Windows.Forms.DateTimePicker dtpNgaylapUNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox CbNamCT;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox CbThangCT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox CbChonCT;
        private UyNhiemChiDB uyNhiemChiDB;
        private System.Windows.Forms.BindingSource uyNhiemChiBindingSource;
        private UyNhiemChiDBTableAdapters.UyNhiemChiTableAdapter uyNhiemChiTableAdapter;
        private System.Windows.Forms.Button BtnButToan;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttUNCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTTNCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTKNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTKNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTKNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KPCD;
        private System.Windows.Forms.Label label1;
    }
}