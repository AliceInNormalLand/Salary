
namespace Salary
{
    partial class TaikhoanC2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaikhoanC2));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSDDK = new System.Windows.Forms.TextBox();
            this.BtnXemBL = new System.Windows.Forms.Button();
            this.ThemBangLuong = new System.Windows.Forms.Button();
            this.cbNamHTTK2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThangHTTK2 = new System.Windows.Forms.ComboBox();
            this.CbSTK2 = new System.Windows.Forms.ComboBox();
            this.danhMucTKC2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMTKC2DB = new Salary.DMTKC2DB();
            this.dtpNDK2 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.heThongTKC2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTTKC2DB = new Salary.HTTKC2DB();
            this.danhMucTKC2TableAdapter = new Salary.DMTKC2DBTableAdapters.DanhMucTKC2TableAdapter();
            this.heThongTKC2TableAdapter = new Salary.HTTKC2DBTableAdapters.HeThongTKC2TableAdapter();
            this.sttTKC2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTKC2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duDauKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duCoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucTKC2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKC2DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongTKC2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTKC2DB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbSDDK);
            this.groupBox2.Controls.Add(this.BtnXemBL);
            this.groupBox2.Controls.Add(this.ThemBangLuong);
            this.groupBox2.Controls.Add(this.cbNamHTTK2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbThangHTTK2);
            this.groupBox2.Controls.Add(this.CbSTK2);
            this.groupBox2.Controls.Add(this.dtpNDK2);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(-1, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 638);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản cấp 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(941, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Số dư đầu kỳ";
            // 
            // tbSDDK
            // 
            this.tbSDDK.Location = new System.Drawing.Point(832, 98);
            this.tbSDDK.Name = "tbSDDK";
            this.tbSDDK.Size = new System.Drawing.Size(202, 22);
            this.tbSDDK.TabIndex = 78;
            // 
            // BtnXemBL
            // 
            this.BtnXemBL.BackColor = System.Drawing.Color.Orange;
            this.BtnXemBL.FlatAppearance.BorderSize = 0;
            this.BtnXemBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXemBL.Image = global::Salary.Properties.Resources.add_document;
            this.BtnXemBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXemBL.Location = new System.Drawing.Point(101, 24);
            this.BtnXemBL.Name = "BtnXemBL";
            this.BtnXemBL.Size = new System.Drawing.Size(79, 35);
            this.BtnXemBL.TabIndex = 77;
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
            this.ThemBangLuong.Location = new System.Drawing.Point(8, 24);
            this.ThemBangLuong.Name = "ThemBangLuong";
            this.ThemBangLuong.Size = new System.Drawing.Size(92, 35);
            this.ThemBangLuong.TabIndex = 76;
            this.ThemBangLuong.Text = "Tạo mới";
            this.ThemBangLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemBangLuong.UseVisualStyleBackColor = false;
            this.ThemBangLuong.Click += new System.EventHandler(this.ThemBangLuong_Click);
            // 
            // cbNamHTTK2
            // 
            this.cbNamHTTK2.FormattingEnabled = true;
            this.cbNamHTTK2.Items.AddRange(new object[] {
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
            this.cbNamHTTK2.Location = new System.Drawing.Point(390, 96);
            this.cbNamHTTK2.Name = "cbNamHTTK2";
            this.cbNamHTTK2.Size = new System.Drawing.Size(94, 24);
            this.cbNamHTTK2.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tháng";
            // 
            // cbThangHTTK2
            // 
            this.cbThangHTTK2.FormattingEnabled = true;
            this.cbThangHTTK2.Items.AddRange(new object[] {
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
            this.cbThangHTTK2.Location = new System.Drawing.Point(490, 96);
            this.cbThangHTTK2.Name = "cbThangHTTK2";
            this.cbThangHTTK2.Size = new System.Drawing.Size(94, 24);
            this.cbThangHTTK2.TabIndex = 72;
            // 
            // CbSTK2
            // 
            this.CbSTK2.DataSource = this.danhMucTKC2BindingSource;
            this.CbSTK2.DisplayMember = "MaTKC2";
            this.CbSTK2.FormattingEnabled = true;
            this.CbSTK2.Location = new System.Drawing.Point(424, 46);
            this.CbSTK2.Name = "CbSTK2";
            this.CbSTK2.Size = new System.Drawing.Size(130, 24);
            this.CbSTK2.TabIndex = 71;
            this.CbSTK2.ValueMember = "MaTKC2";
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
            // dtpNDK2
            // 
            this.dtpNDK2.Location = new System.Drawing.Point(832, 44);
            this.dtpNDK2.Name = "dtpNDK2";
            this.dtpNDK2.Size = new System.Drawing.Size(200, 22);
            this.dtpNDK2.TabIndex = 70;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(945, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 17);
            this.label20.TabIndex = 66;
            this.label20.Text = "Ngày đầu kỳ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(445, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 17);
            this.label18.TabIndex = 67;
            this.label18.Text = "Số tài khoản";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttTKC2DataGridViewTextBoxColumn,
            this.ngayDKDataGridViewTextBoxColumn,
            this.maTKC2DataGridViewTextBoxColumn,
            this.duDauKyDataGridViewTextBoxColumn,
            this.duNoDataGridViewTextBoxColumn,
            this.duCoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.heThongTKC2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1023, 489);
            this.dataGridView2.TabIndex = 7;
            // 
            // heThongTKC2BindingSource
            // 
            this.heThongTKC2BindingSource.DataMember = "HeThongTKC2";
            this.heThongTKC2BindingSource.DataSource = this.hTTKC2DB;
            // 
            // hTTKC2DB
            // 
            this.hTTKC2DB.DataSetName = "HTTKC2DB";
            this.hTTKC2DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhMucTKC2TableAdapter
            // 
            this.danhMucTKC2TableAdapter.ClearBeforeFill = true;
            // 
            // heThongTKC2TableAdapter
            // 
            this.heThongTKC2TableAdapter.ClearBeforeFill = true;
            // 
            // sttTKC2DataGridViewTextBoxColumn
            // 
            this.sttTKC2DataGridViewTextBoxColumn.DataPropertyName = "SttTKC2";
            this.sttTKC2DataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttTKC2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTKC2DataGridViewTextBoxColumn.Name = "sttTKC2DataGridViewTextBoxColumn";
            this.sttTKC2DataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTKC2DataGridViewTextBoxColumn.Width = 125;
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
            // maTKC2DataGridViewTextBoxColumn
            // 
            this.maTKC2DataGridViewTextBoxColumn.DataPropertyName = "MaTKC2";
            this.maTKC2DataGridViewTextBoxColumn.HeaderText = "Mã TK cấp 2";
            this.maTKC2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTKC2DataGridViewTextBoxColumn.Name = "maTKC2DataGridViewTextBoxColumn";
            this.maTKC2DataGridViewTextBoxColumn.ReadOnly = true;
            this.maTKC2DataGridViewTextBoxColumn.Width = 125;
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
            // TaikhoanC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1043, 638);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaikhoanC2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG TÀI KHOẢN CẤP 2";
            this.Load += new System.EventHandler(this.TaikhoanC2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucTKC2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKC2DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongTKC2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTKC2DB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.ComboBox cbNamHTTK2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbThangHTTK2;
        public System.Windows.Forms.ComboBox CbSTK2;
        private System.Windows.Forms.DateTimePicker dtpNDK2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BtnXemBL;
        private System.Windows.Forms.Button ThemBangLuong;
        private DMTKC2DB dMTKC2DB;
        private System.Windows.Forms.BindingSource danhMucTKC2BindingSource;
        private DMTKC2DBTableAdapters.DanhMucTKC2TableAdapter danhMucTKC2TableAdapter;
        private HTTKC2DB hTTKC2DB;
        private System.Windows.Forms.BindingSource heThongTKC2BindingSource;
        private HTTKC2DBTableAdapters.HeThongTKC2TableAdapter heThongTKC2TableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSDDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTKC2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTKC2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duDauKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duCoDataGridViewTextBoxColumn;
    }
}