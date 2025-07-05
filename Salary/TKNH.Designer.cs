
namespace Salary
{
    partial class TKNH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKNH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuaNV = new System.Windows.Forms.Button();
            this.ThemNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttTKNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTKNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTKNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanNHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanNHDB = new Salary.TaiKhoanNHDB();
            this.taiKhoanNHTableAdapter = new Salary.TaiKhoanNHDBTableAdapters.TaiKhoanNHTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanNHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanNHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.SuaNV);
            this.groupBox1.Controls.Add(this.ThemNV);
            this.groupBox1.Controls.Add(this.btnXoaNV);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 451);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản ngân hàng của nhân viên";
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
            this.SuaNV.TabIndex = 16;
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
            this.ThemNV.TabIndex = 14;
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
            this.btnXoaNV.TabIndex = 15;
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
            this.sttTKNHDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.soTKNHDataGridViewTextBoxColumn,
            this.tenTKNHDataGridViewTextBoxColumn,
            this.tenNHDataGridViewTextBoxColumn,
            this.loaiTKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taiKhoanNHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 368);
            this.dataGridView1.TabIndex = 7;
            // 
            // sttTKNHDataGridViewTextBoxColumn
            // 
            this.sttTKNHDataGridViewTextBoxColumn.DataPropertyName = "SttTKNH";
            this.sttTKNHDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttTKNHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTKNHDataGridViewTextBoxColumn.Name = "sttTKNHDataGridViewTextBoxColumn";
            this.sttTKNHDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTKNHDataGridViewTextBoxColumn.Width = 125;
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
            // soTKNHDataGridViewTextBoxColumn
            // 
            this.soTKNHDataGridViewTextBoxColumn.DataPropertyName = "SoTKNH";
            this.soTKNHDataGridViewTextBoxColumn.HeaderText = "Số tài khoản";
            this.soTKNHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTKNHDataGridViewTextBoxColumn.Name = "soTKNHDataGridViewTextBoxColumn";
            this.soTKNHDataGridViewTextBoxColumn.ReadOnly = true;
            this.soTKNHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenTKNHDataGridViewTextBoxColumn
            // 
            this.tenTKNHDataGridViewTextBoxColumn.DataPropertyName = "TenTKNH";
            this.tenTKNHDataGridViewTextBoxColumn.HeaderText = "Tên tài khoản";
            this.tenTKNHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTKNHDataGridViewTextBoxColumn.Name = "tenTKNHDataGridViewTextBoxColumn";
            this.tenTKNHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTKNHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNHDataGridViewTextBoxColumn
            // 
            this.tenNHDataGridViewTextBoxColumn.DataPropertyName = "TenNH";
            this.tenNHDataGridViewTextBoxColumn.HeaderText = "Tên ngân hàng";
            this.tenNHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNHDataGridViewTextBoxColumn.Name = "tenNHDataGridViewTextBoxColumn";
            this.tenNHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNHDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaiTKDataGridViewTextBoxColumn
            // 
            this.loaiTKDataGridViewTextBoxColumn.DataPropertyName = "LoaiTK";
            this.loaiTKDataGridViewTextBoxColumn.HeaderText = "Loại TK";
            this.loaiTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiTKDataGridViewTextBoxColumn.Name = "loaiTKDataGridViewTextBoxColumn";
            this.loaiTKDataGridViewTextBoxColumn.ReadOnly = true;
            this.loaiTKDataGridViewTextBoxColumn.Width = 125;
            // 
            // taiKhoanNHBindingSource
            // 
            this.taiKhoanNHBindingSource.DataMember = "TaiKhoanNH";
            this.taiKhoanNHBindingSource.DataSource = this.taiKhoanNHDB;
            // 
            // taiKhoanNHDB
            // 
            this.taiKhoanNHDB.DataSetName = "TaiKhoanNHDB";
            this.taiKhoanNHDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanNHTableAdapter
            // 
            this.taiKhoanNHTableAdapter.ClearBeforeFill = true;
            // 
            // TKNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TKNH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÀI KHOẢN NGÂN HÀNG";
            this.Load += new System.EventHandler(this.TKNH_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanNHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanNHDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TaiKhoanNHDB taiKhoanNHDB;
        private System.Windows.Forms.BindingSource taiKhoanNHBindingSource;
        private TaiKhoanNHDBTableAdapters.TaiKhoanNHTableAdapter taiKhoanNHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTKNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTKNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTKNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SuaNV;
        private System.Windows.Forms.Button ThemNV;
        private System.Windows.Forms.Button btnXoaNV;
    }
}