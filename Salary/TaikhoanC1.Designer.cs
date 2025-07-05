
namespace Salary
{
    partial class TaikhoanC1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaikhoanC1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSDDK = new System.Windows.Forms.TextBox();
            this.BtnXemBL = new System.Windows.Forms.Button();
            this.ThemBangLuong = new System.Windows.Forms.Button();
            this.cbNamBL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThangBL = new System.Windows.Forms.ComboBox();
            this.CbTKC1 = new System.Windows.Forms.ComboBox();
            this.danhMucTKC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMTKC1DB = new Salary.DMTKC1DB();
            this.dtpNDK1 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.heThongTKC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTTKC1DB = new Salary.HTTKC1DB();
            this.danhMucTKC1TableAdapter = new Salary.DMTKC1DBTableAdapters.DanhMucTKC1TableAdapter();
            this.heThongTKC1TableAdapter = new Salary.HTTKC1DBTableAdapters.HeThongTKC1TableAdapter();
            this.sttTKC1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTKC1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duDauKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duCoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucTKC1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKC1DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongTKC1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTKC1DB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbSDDK);
            this.groupBox2.Controls.Add(this.BtnXemBL);
            this.groupBox2.Controls.Add(this.ThemBangLuong);
            this.groupBox2.Controls.Add(this.cbNamBL);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbThangBL);
            this.groupBox2.Controls.Add(this.CbTKC1);
            this.groupBox2.Controls.Add(this.dtpNDK1);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(0, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 582);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hệ thống tài khoản cấp 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(838, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Số dư đầu kỳ";
            // 
            // tbSDDK
            // 
            this.tbSDDK.Location = new System.Drawing.Point(729, 92);
            this.tbSDDK.Name = "tbSDDK";
            this.tbSDDK.Size = new System.Drawing.Size(202, 22);
            this.tbSDDK.TabIndex = 80;
            // 
            // BtnXemBL
            // 
            this.BtnXemBL.BackColor = System.Drawing.Color.Orange;
            this.BtnXemBL.FlatAppearance.BorderSize = 0;
            this.BtnXemBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXemBL.Image = global::Salary.Properties.Resources.add_document;
            this.BtnXemBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXemBL.Location = new System.Drawing.Point(105, 29);
            this.BtnXemBL.Name = "BtnXemBL";
            this.BtnXemBL.Size = new System.Drawing.Size(79, 35);
            this.BtnXemBL.TabIndex = 79;
            this.BtnXemBL.Text = "Xem";
            this.BtnXemBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnXemBL.UseVisualStyleBackColor = false;
            // 
            // ThemBangLuong
            // 
            this.ThemBangLuong.BackColor = System.Drawing.Color.Orange;
            this.ThemBangLuong.FlatAppearance.BorderSize = 0;
            this.ThemBangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemBangLuong.Image = global::Salary.Properties.Resources.add_document;
            this.ThemBangLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemBangLuong.Location = new System.Drawing.Point(12, 29);
            this.ThemBangLuong.Name = "ThemBangLuong";
            this.ThemBangLuong.Size = new System.Drawing.Size(92, 35);
            this.ThemBangLuong.TabIndex = 78;
            this.ThemBangLuong.Text = "Tạo mới";
            this.ThemBangLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemBangLuong.UseVisualStyleBackColor = false;
            this.ThemBangLuong.Click += new System.EventHandler(this.ThemBangLuong_Click);
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
            this.cbNamBL.Location = new System.Drawing.Point(361, 90);
            this.cbNamBL.Name = "cbNamBL";
            this.cbNamBL.Size = new System.Drawing.Size(94, 24);
            this.cbNamBL.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 63;
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
            this.cbThangBL.Location = new System.Drawing.Point(461, 90);
            this.cbThangBL.Name = "cbThangBL";
            this.cbThangBL.Size = new System.Drawing.Size(94, 24);
            this.cbThangBL.TabIndex = 62;
            // 
            // CbTKC1
            // 
            this.CbTKC1.DataSource = this.danhMucTKC1BindingSource;
            this.CbTKC1.DisplayMember = "MaTKC1";
            this.CbTKC1.FormattingEnabled = true;
            this.CbTKC1.Location = new System.Drawing.Point(395, 40);
            this.CbTKC1.Name = "CbTKC1";
            this.CbTKC1.Size = new System.Drawing.Size(130, 24);
            this.CbTKC1.TabIndex = 61;
            this.CbTKC1.ValueMember = "MaTKC1";
            // 
            // danhMucTKC1BindingSource
            // 
            this.danhMucTKC1BindingSource.DataMember = "DanhMucTKC1";
            this.danhMucTKC1BindingSource.DataSource = this.dMTKC1DB;
            // 
            // dMTKC1DB
            // 
            this.dMTKC1DB.DataSetName = "DMTKC1DB";
            this.dMTKC1DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpNDK1
            // 
            this.dtpNDK1.Location = new System.Drawing.Point(731, 42);
            this.dtpNDK1.Name = "dtpNDK1";
            this.dtpNDK1.Size = new System.Drawing.Size(200, 22);
            this.dtpNDK1.TabIndex = 60;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(844, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 17);
            this.label20.TabIndex = 56;
            this.label20.Text = "Ngày đầu kỳ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(416, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 17);
            this.label18.TabIndex = 57;
            this.label18.Text = "Số tài khoản";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttTKC1DataGridViewTextBoxColumn,
            this.ngayDKDataGridViewTextBoxColumn,
            this.maTKC1DataGridViewTextBoxColumn,
            this.duDauKyDataGridViewTextBoxColumn,
            this.duNoDataGridViewTextBoxColumn,
            this.duCoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.heThongTKC1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 134);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(922, 442);
            this.dataGridView2.TabIndex = 7;
            // 
            // heThongTKC1BindingSource
            // 
            this.heThongTKC1BindingSource.DataMember = "HeThongTKC1";
            this.heThongTKC1BindingSource.DataSource = this.hTTKC1DB;
            // 
            // hTTKC1DB
            // 
            this.hTTKC1DB.DataSetName = "HTTKC1DB";
            this.hTTKC1DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhMucTKC1TableAdapter
            // 
            this.danhMucTKC1TableAdapter.ClearBeforeFill = true;
            // 
            // heThongTKC1TableAdapter
            // 
            this.heThongTKC1TableAdapter.ClearBeforeFill = true;
            // 
            // sttTKC1DataGridViewTextBoxColumn
            // 
            this.sttTKC1DataGridViewTextBoxColumn.DataPropertyName = "SttTKC1";
            this.sttTKC1DataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttTKC1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTKC1DataGridViewTextBoxColumn.Name = "sttTKC1DataGridViewTextBoxColumn";
            this.sttTKC1DataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTKC1DataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayDKDataGridViewTextBoxColumn
            // 
            this.ngayDKDataGridViewTextBoxColumn.DataPropertyName = "NgayDK";
            this.ngayDKDataGridViewTextBoxColumn.HeaderText = "Ngày đầu kỳ";
            this.ngayDKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDKDataGridViewTextBoxColumn.Name = "ngayDKDataGridViewTextBoxColumn";
            this.ngayDKDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayDKDataGridViewTextBoxColumn.Width = 125;
            // 
            // maTKC1DataGridViewTextBoxColumn
            // 
            this.maTKC1DataGridViewTextBoxColumn.DataPropertyName = "MaTKC1";
            this.maTKC1DataGridViewTextBoxColumn.HeaderText = "Mã TK cấp 1";
            this.maTKC1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTKC1DataGridViewTextBoxColumn.Name = "maTKC1DataGridViewTextBoxColumn";
            this.maTKC1DataGridViewTextBoxColumn.ReadOnly = true;
            this.maTKC1DataGridViewTextBoxColumn.Width = 125;
            // 
            // duDauKyDataGridViewTextBoxColumn
            // 
            this.duDauKyDataGridViewTextBoxColumn.DataPropertyName = "DuDauKy";
            this.duDauKyDataGridViewTextBoxColumn.HeaderText = "Dư đầu kỳ";
            this.duDauKyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duDauKyDataGridViewTextBoxColumn.Name = "duDauKyDataGridViewTextBoxColumn";
            this.duDauKyDataGridViewTextBoxColumn.ReadOnly = true;
            this.duDauKyDataGridViewTextBoxColumn.Width = 125;
            // 
            // duNoDataGridViewTextBoxColumn
            // 
            this.duNoDataGridViewTextBoxColumn.DataPropertyName = "DuNo";
            this.duNoDataGridViewTextBoxColumn.HeaderText = "Dư nợ";
            this.duNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duNoDataGridViewTextBoxColumn.Name = "duNoDataGridViewTextBoxColumn";
            this.duNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.duNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // duCoDataGridViewTextBoxColumn
            // 
            this.duCoDataGridViewTextBoxColumn.DataPropertyName = "DuCo";
            this.duCoDataGridViewTextBoxColumn.HeaderText = "Dư có";
            this.duCoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duCoDataGridViewTextBoxColumn.Name = "duCoDataGridViewTextBoxColumn";
            this.duCoDataGridViewTextBoxColumn.ReadOnly = true;
            this.duCoDataGridViewTextBoxColumn.Width = 125;
            // 
            // TaikhoanC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(943, 577);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaikhoanC1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG TÀI KHOẢN CẤP 1";
            this.Load += new System.EventHandler(this.TaikhoanC1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucTKC1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKC1DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongTKC1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTKC1DB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.ComboBox cbNamBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbThangBL;
        public System.Windows.Forms.ComboBox CbTKC1;
        private System.Windows.Forms.DateTimePicker dtpNDK1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BtnXemBL;
        private System.Windows.Forms.Button ThemBangLuong;
        private DMTKC1DB dMTKC1DB;
        private System.Windows.Forms.BindingSource danhMucTKC1BindingSource;
        private DMTKC1DBTableAdapters.DanhMucTKC1TableAdapter danhMucTKC1TableAdapter;
        private HTTKC1DB hTTKC1DB;
        private System.Windows.Forms.BindingSource heThongTKC1BindingSource;
        private HTTKC1DBTableAdapters.HeThongTKC1TableAdapter heThongTKC1TableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSDDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTKC1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTKC1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duDauKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duCoDataGridViewTextBoxColumn;
    }
}