
namespace Salary
{
    partial class Giamtrugiacanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giamtrugiacanh));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbMaGTGC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbNV = new System.Windows.Forms.TextBox();
            this.dtpGTGC = new System.Windows.Forms.DateTimePicker();
            this.ThemGTGC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttGTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGTGCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongNPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGTNPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGTCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGTGCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamTruGiaCanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giamTruGiaCanhDB = new Salary.GiamTruGiaCanhDB();
            this.giamTruGiaCanhTableAdapter = new Salary.GiamTruGiaCanhDBTableAdapters.GiamTruGiaCanhTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamTruGiaCanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamTruGiaCanhDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ThemGTGC);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 502);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giảm trừ gia cảnh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbMaGTGC);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtbNV);
            this.groupBox2.Controls.Add(this.dtpGTGC);
            this.groupBox2.Location = new System.Drawing.Point(796, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 118);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giảm trừ gia cảnh";
            // 
            // txtbMaGTGC
            // 
            this.txtbMaGTGC.Location = new System.Drawing.Point(153, 90);
            this.txtbMaGTGC.Name = "txtbMaGTGC";
            this.txtbMaGTGC.Size = new System.Drawing.Size(130, 22);
            this.txtbMaGTGC.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(54, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 17);
            this.label14.TabIndex = 42;
            this.label14.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã giảm trừ gia cảnh";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(219, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "Ngày lập";
            // 
            // txtbNV
            // 
            this.txtbNV.Location = new System.Drawing.Point(153, 62);
            this.txtbNV.Name = "txtbNV";
            this.txtbNV.Size = new System.Drawing.Size(130, 22);
            this.txtbNV.TabIndex = 43;
            // 
            // dtpGTGC
            // 
            this.dtpGTGC.Location = new System.Drawing.Point(57, 33);
            this.dtpGTGC.Name = "dtpGTGC";
            this.dtpGTGC.Size = new System.Drawing.Size(226, 22);
            this.dtpGTGC.TabIndex = 40;
            // 
            // ThemGTGC
            // 
            this.ThemGTGC.BackColor = System.Drawing.Color.Orange;
            this.ThemGTGC.FlatAppearance.BorderSize = 0;
            this.ThemGTGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemGTGC.Image = global::Salary.Properties.Resources.add_document;
            this.ThemGTGC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemGTGC.Location = new System.Drawing.Point(9, 27);
            this.ThemGTGC.Name = "ThemGTGC";
            this.ThemGTGC.Size = new System.Drawing.Size(79, 35);
            this.ThemGTGC.TabIndex = 8;
            this.ThemGTGC.Text = "Thêm";
            this.ThemGTGC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemGTGC.UseVisualStyleBackColor = false;
            this.ThemGTGC.Click += new System.EventHandler(this.ThemGTGC_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttGTDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.maGTGCDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.tongNPTDataGridViewTextBoxColumn,
            this.tongGTNPTDataGridViewTextBoxColumn,
            this.tongGTCNDataGridViewTextBoxColumn,
            this.tongGTGCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giamTruGiaCanhBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 351);
            this.dataGridView1.TabIndex = 7;
            // 
            // sttGTDataGridViewTextBoxColumn
            // 
            this.sttGTDataGridViewTextBoxColumn.DataPropertyName = "SttGT";
            this.sttGTDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttGTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttGTDataGridViewTextBoxColumn.Name = "sttGTDataGridViewTextBoxColumn";
            this.sttGTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttGTDataGridViewTextBoxColumn.Width = 125;
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
            // maGTGCDataGridViewTextBoxColumn
            // 
            this.maGTGCDataGridViewTextBoxColumn.DataPropertyName = "MaGTGC";
            this.maGTGCDataGridViewTextBoxColumn.HeaderText = "Mã giảm trừ";
            this.maGTGCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maGTGCDataGridViewTextBoxColumn.Name = "maGTGCDataGridViewTextBoxColumn";
            this.maGTGCDataGridViewTextBoxColumn.ReadOnly = true;
            this.maGTGCDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongNPTDataGridViewTextBoxColumn
            // 
            this.tongNPTDataGridViewTextBoxColumn.DataPropertyName = "TongNPT";
            this.tongNPTDataGridViewTextBoxColumn.HeaderText = "Tổng NPT";
            this.tongNPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongNPTDataGridViewTextBoxColumn.Name = "tongNPTDataGridViewTextBoxColumn";
            this.tongNPTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongNPTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongGTNPTDataGridViewTextBoxColumn
            // 
            this.tongGTNPTDataGridViewTextBoxColumn.DataPropertyName = "TongGTNPT";
            this.tongGTNPTDataGridViewTextBoxColumn.HeaderText = "Tổng giảm trừ NPT";
            this.tongGTNPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongGTNPTDataGridViewTextBoxColumn.Name = "tongGTNPTDataGridViewTextBoxColumn";
            this.tongGTNPTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongGTNPTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongGTCNDataGridViewTextBoxColumn
            // 
            this.tongGTCNDataGridViewTextBoxColumn.DataPropertyName = "TongGTCN";
            this.tongGTCNDataGridViewTextBoxColumn.HeaderText = "Tổng giảm trừ CN";
            this.tongGTCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongGTCNDataGridViewTextBoxColumn.Name = "tongGTCNDataGridViewTextBoxColumn";
            this.tongGTCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongGTCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongGTGCDataGridViewTextBoxColumn
            // 
            this.tongGTGCDataGridViewTextBoxColumn.DataPropertyName = "TongGTGC";
            this.tongGTGCDataGridViewTextBoxColumn.HeaderText = "Tổng giảm trừ GC";
            this.tongGTGCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongGTGCDataGridViewTextBoxColumn.Name = "tongGTGCDataGridViewTextBoxColumn";
            this.tongGTGCDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongGTGCDataGridViewTextBoxColumn.Width = 125;
            // 
            // giamTruGiaCanhBindingSource
            // 
            this.giamTruGiaCanhBindingSource.DataMember = "GiamTruGiaCanh";
            this.giamTruGiaCanhBindingSource.DataSource = this.giamTruGiaCanhDB;
            // 
            // giamTruGiaCanhDB
            // 
            this.giamTruGiaCanhDB.DataSetName = "GiamTruGiaCanhDB";
            this.giamTruGiaCanhDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giamTruGiaCanhTableAdapter
            // 
            this.giamTruGiaCanhTableAdapter.ClearBeforeFill = true;
            // 
            // Giamtrugiacanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1092, 498);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giamtrugiacanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIẢM TRỪ GIA CẢNH";
            this.Load += new System.EventHandler(this.Giamtrugiacanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamTruGiaCanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamTruGiaCanhDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GiamTruGiaCanhDB giamTruGiaCanhDB;
        private System.Windows.Forms.BindingSource giamTruGiaCanhBindingSource;
        private GiamTruGiaCanhDBTableAdapters.GiamTruGiaCanhTableAdapter giamTruGiaCanhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttGTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGTGCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongNPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGTNPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGTCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGTGCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ThemGTGC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbMaGTGC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbNV;
        private System.Windows.Forms.DateTimePicker dtpGTGC;
    }
}