
namespace Salary
{
    partial class ChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamCong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnXemLCN = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.dataGridViewChamCong = new System.Windows.Forms.DataGridView();
            this.chamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamCongDB = new Salary.ChamCongDB();
            this.chamCongTableAdapter = new Salary.ChamCongDBTableAdapters.ChamCongTableAdapter();
            this.sttCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuaNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongPhepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phepToiDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNNLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.cbNam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbThang);
            this.groupBox1.Controls.Add(this.btnXemLCN);
            this.groupBox1.Controls.Add(this.BtnImport);
            this.groupBox1.Controls.Add(this.dataGridViewChamCong);
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1166, 530);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chấm công";
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
            this.cbNam.Location = new System.Drawing.Point(10, 80);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(94, 24);
            this.cbNam.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 16;
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
            this.cbThang.Location = new System.Drawing.Point(113, 80);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(94, 24);
            this.cbThang.TabIndex = 15;
            // 
            // btnXemLCN
            // 
            this.btnXemLCN.BackColor = System.Drawing.Color.Orange;
            this.btnXemLCN.FlatAppearance.BorderSize = 0;
            this.btnXemLCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLCN.Image = global::Salary.Properties.Resources.search;
            this.btnXemLCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLCN.Location = new System.Drawing.Point(9, 21);
            this.btnXemLCN.Name = "btnXemLCN";
            this.btnXemLCN.Size = new System.Drawing.Size(79, 35);
            this.btnXemLCN.TabIndex = 11;
            this.btnXemLCN.Text = "Xem";
            this.btnXemLCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemLCN.UseVisualStyleBackColor = false;
            this.btnXemLCN.Click += new System.EventHandler(this.btnXemLCN_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.Orange;
            this.BtnImport.FlatAppearance.BorderSize = 0;
            this.BtnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.Image = global::Salary.Properties.Resources.import;
            this.BtnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImport.Location = new System.Drawing.Point(1034, 21);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(119, 35);
            this.BtnImport.TabIndex = 8;
            this.BtnImport.Text = "Import Excel";
            this.BtnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // dataGridViewChamCong
            // 
            this.dataGridViewChamCong.AllowUserToAddRows = false;
            this.dataGridViewChamCong.AutoGenerateColumns = false;
            this.dataGridViewChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttCCDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.motNgayDataGridViewTextBoxColumn,
            this.nuaNgayDataGridViewTextBoxColumn,
            this.tongCongDataGridViewTextBoxColumn,
            this.tongPhepDataGridViewTextBoxColumn,
            this.phepToiDaDataGridViewTextBoxColumn,
            this.tCNTDataGridViewTextBoxColumn,
            this.tCNNTDataGridViewTextBoxColumn,
            this.tCNNLDataGridViewTextBoxColumn,
            this.maKLDataGridViewTextBoxColumn});
            this.dataGridViewChamCong.DataSource = this.chamCongBindingSource;
            this.dataGridViewChamCong.Location = new System.Drawing.Point(9, 110);
            this.dataGridViewChamCong.Name = "dataGridViewChamCong";
            this.dataGridViewChamCong.ReadOnly = true;
            this.dataGridViewChamCong.RowHeadersWidth = 51;
            this.dataGridViewChamCong.RowTemplate.Height = 24;
            this.dataGridViewChamCong.Size = new System.Drawing.Size(1144, 414);
            this.dataGridViewChamCong.TabIndex = 7;
            // 
            // chamCongBindingSource
            // 
            this.chamCongBindingSource.DataMember = "ChamCong";
            this.chamCongBindingSource.DataSource = this.chamCongDB;
            // 
            // chamCongDB
            // 
            this.chamCongDB.DataSetName = "ChamCongDB";
            this.chamCongDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chamCongTableAdapter
            // 
            this.chamCongTableAdapter.ClearBeforeFill = true;
            // 
            // sttCCDataGridViewTextBoxColumn
            // 
            this.sttCCDataGridViewTextBoxColumn.DataPropertyName = "SttCC";
            this.sttCCDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttCCDataGridViewTextBoxColumn.Name = "sttCCDataGridViewTextBoxColumn";
            this.sttCCDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttCCDataGridViewTextBoxColumn.Width = 125;
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
            // motNgayDataGridViewTextBoxColumn
            // 
            this.motNgayDataGridViewTextBoxColumn.DataPropertyName = "MotNgay";
            this.motNgayDataGridViewTextBoxColumn.HeaderText = "Một ngày công";
            this.motNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motNgayDataGridViewTextBoxColumn.Name = "motNgayDataGridViewTextBoxColumn";
            this.motNgayDataGridViewTextBoxColumn.ReadOnly = true;
            this.motNgayDataGridViewTextBoxColumn.Width = 125;
            // 
            // nuaNgayDataGridViewTextBoxColumn
            // 
            this.nuaNgayDataGridViewTextBoxColumn.DataPropertyName = "NuaNgay";
            this.nuaNgayDataGridViewTextBoxColumn.HeaderText = "Nửa ngày công";
            this.nuaNgayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nuaNgayDataGridViewTextBoxColumn.Name = "nuaNgayDataGridViewTextBoxColumn";
            this.nuaNgayDataGridViewTextBoxColumn.ReadOnly = true;
            this.nuaNgayDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongCongDataGridViewTextBoxColumn
            // 
            this.tongCongDataGridViewTextBoxColumn.DataPropertyName = "TongCong";
            this.tongCongDataGridViewTextBoxColumn.HeaderText = "Tổng công";
            this.tongCongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongCongDataGridViewTextBoxColumn.Name = "tongCongDataGridViewTextBoxColumn";
            this.tongCongDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongCongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongPhepDataGridViewTextBoxColumn
            // 
            this.tongPhepDataGridViewTextBoxColumn.DataPropertyName = "TongPhep";
            this.tongPhepDataGridViewTextBoxColumn.HeaderText = "Tổng phép";
            this.tongPhepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongPhepDataGridViewTextBoxColumn.Name = "tongPhepDataGridViewTextBoxColumn";
            this.tongPhepDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongPhepDataGridViewTextBoxColumn.Width = 125;
            // 
            // phepToiDaDataGridViewTextBoxColumn
            // 
            this.phepToiDaDataGridViewTextBoxColumn.DataPropertyName = "PhepToiDa";
            this.phepToiDaDataGridViewTextBoxColumn.HeaderText = "Phép tối đa";
            this.phepToiDaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phepToiDaDataGridViewTextBoxColumn.Name = "phepToiDaDataGridViewTextBoxColumn";
            this.phepToiDaDataGridViewTextBoxColumn.ReadOnly = true;
            this.phepToiDaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tCNTDataGridViewTextBoxColumn
            // 
            this.tCNTDataGridViewTextBoxColumn.DataPropertyName = "TCNT";
            this.tCNTDataGridViewTextBoxColumn.HeaderText = "Tăng ca ngày thường";
            this.tCNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCNTDataGridViewTextBoxColumn.Name = "tCNTDataGridViewTextBoxColumn";
            this.tCNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tCNNTDataGridViewTextBoxColumn
            // 
            this.tCNNTDataGridViewTextBoxColumn.DataPropertyName = "TCNNT";
            this.tCNNTDataGridViewTextBoxColumn.HeaderText = "Tăng ca ngày nghỉ tuần";
            this.tCNNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCNNTDataGridViewTextBoxColumn.Name = "tCNNTDataGridViewTextBoxColumn";
            this.tCNNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCNNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tCNNLDataGridViewTextBoxColumn
            // 
            this.tCNNLDataGridViewTextBoxColumn.DataPropertyName = "TCNNL";
            this.tCNNLDataGridViewTextBoxColumn.HeaderText = "Tăng ca ngày nghỉ lễ";
            this.tCNNLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCNNLDataGridViewTextBoxColumn.Name = "tCNNLDataGridViewTextBoxColumn";
            this.tCNNLDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCNNLDataGridViewTextBoxColumn.Width = 125;
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
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1165, 523);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHẤM CÔNG";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewChamCong;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nuaNgayPhepDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnImport;
        private ChamCongDB chamCongDB;
        private System.Windows.Forms.BindingSource chamCongBindingSource;
        private ChamCongDBTableAdapters.ChamCongTableAdapter chamCongTableAdapter;
        private System.Windows.Forms.Button btnXemLCN;
        public System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuaNgayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongPhepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phepToiDaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNNLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn;
    }
}