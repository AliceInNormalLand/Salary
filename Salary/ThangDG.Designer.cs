
namespace Salary
{
    partial class ThangDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThangDG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuaNV = new System.Windows.Forms.Button();
            this.ThemNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttTDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thangDGDB = new Salary.ThangDGDB();
            this.thangDGTableAdapter = new Salary.ThangDGDBTableAdapters.ThangDGTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangDGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangDGDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.SuaNV);
            this.groupBox1.Controls.Add(this.ThemNV);
            this.groupBox1.Controls.Add(this.btnXoaNV);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 448);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thang điểm đánh giá";
            // 
            // SuaNV
            // 
            this.SuaNV.BackColor = System.Drawing.Color.Orange;
            this.SuaNV.FlatAppearance.BorderSize = 0;
            this.SuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaNV.Image = global::Salary.Properties.Resources.file_edit;
            this.SuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaNV.Location = new System.Drawing.Point(179, 33);
            this.SuaNV.Name = "SuaNV";
            this.SuaNV.Size = new System.Drawing.Size(79, 35);
            this.SuaNV.TabIndex = 13;
            this.SuaNV.Text = "Sửa";
            this.SuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaNV.UseVisualStyleBackColor = false;
            // 
            // ThemNV
            // 
            this.ThemNV.BackColor = System.Drawing.Color.Orange;
            this.ThemNV.FlatAppearance.BorderSize = 0;
            this.ThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemNV.Image = global::Salary.Properties.Resources.add_document;
            this.ThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemNV.Location = new System.Drawing.Point(9, 33);
            this.ThemNV.Name = "ThemNV";
            this.ThemNV.Size = new System.Drawing.Size(79, 35);
            this.ThemNV.TabIndex = 11;
            this.ThemNV.Text = "Thêm";
            this.ThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemNV.UseVisualStyleBackColor = false;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.Orange;
            this.btnXoaNV.FlatAppearance.BorderSize = 0;
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Image = global::Salary.Properties.Resources.file_minus;
            this.btnXoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNV.Location = new System.Drawing.Point(94, 33);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(79, 35);
            this.btnXoaNV.TabIndex = 12;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNV.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttTDGDataGridViewTextBoxColumn,
            this.mucTTDataGridViewTextBoxColumn,
            this.mucTDDataGridViewTextBoxColumn,
            this.xeploaiDataGridViewTextBoxColumn,
            this.hesoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thangDGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 368);
            this.dataGridView1.TabIndex = 7;
            // 
            // sttTDGDataGridViewTextBoxColumn
            // 
            this.sttTDGDataGridViewTextBoxColumn.DataPropertyName = "SttTDG";
            this.sttTDGDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttTDGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTDGDataGridViewTextBoxColumn.Name = "sttTDGDataGridViewTextBoxColumn";
            this.sttTDGDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTDGDataGridViewTextBoxColumn.Width = 125;
            // 
            // mucTTDataGridViewTextBoxColumn
            // 
            this.mucTTDataGridViewTextBoxColumn.DataPropertyName = "MucTT";
            this.mucTTDataGridViewTextBoxColumn.HeaderText = "Mức tối thiểu";
            this.mucTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mucTTDataGridViewTextBoxColumn.Name = "mucTTDataGridViewTextBoxColumn";
            this.mucTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.mucTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // mucTDDataGridViewTextBoxColumn
            // 
            this.mucTDDataGridViewTextBoxColumn.DataPropertyName = "MucTD";
            this.mucTDDataGridViewTextBoxColumn.HeaderText = "Mức tối đa";
            this.mucTDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mucTDDataGridViewTextBoxColumn.Name = "mucTDDataGridViewTextBoxColumn";
            this.mucTDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mucTDDataGridViewTextBoxColumn.Width = 125;
            // 
            // xeploaiDataGridViewTextBoxColumn
            // 
            this.xeploaiDataGridViewTextBoxColumn.DataPropertyName = "Xeploai";
            this.xeploaiDataGridViewTextBoxColumn.HeaderText = "Xếp loại";
            this.xeploaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xeploaiDataGridViewTextBoxColumn.Name = "xeploaiDataGridViewTextBoxColumn";
            this.xeploaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.xeploaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // hesoDataGridViewTextBoxColumn
            // 
            this.hesoDataGridViewTextBoxColumn.DataPropertyName = "Heso";
            this.hesoDataGridViewTextBoxColumn.HeaderText = "Hệ số";
            this.hesoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hesoDataGridViewTextBoxColumn.Name = "hesoDataGridViewTextBoxColumn";
            this.hesoDataGridViewTextBoxColumn.ReadOnly = true;
            this.hesoDataGridViewTextBoxColumn.Width = 125;
            // 
            // thangDGBindingSource
            // 
            this.thangDGBindingSource.DataMember = "ThangDG";
            this.thangDGBindingSource.DataSource = this.thangDGDB;
            // 
            // thangDGDB
            // 
            this.thangDGDB.DataSetName = "ThangDGDB";
            this.thangDGDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thangDGTableAdapter
            // 
            this.thangDGTableAdapter.ClearBeforeFill = true;
            // 
            // ThangDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThangDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THANG ĐÁNH GIÁ";
            this.Load += new System.EventHandler(this.ThangDG_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangDGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangDGDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ThangDGDB thangDGDB;
        private System.Windows.Forms.BindingSource thangDGBindingSource;
        private ThangDGDBTableAdapters.ThangDGTableAdapter thangDGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SuaNV;
        private System.Windows.Forms.Button ThemNV;
        private System.Windows.Forms.Button btnXoaNV;
    }
}