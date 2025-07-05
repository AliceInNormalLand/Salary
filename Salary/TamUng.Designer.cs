
namespace Salary
{
    partial class TamUng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TamUng));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnButToan = new System.Windows.Forms.Button();
            this.ThemTU = new System.Windows.Forms.Button();
            this.XoaTU = new System.Windows.Forms.Button();
            this.dtgvTU = new System.Windows.Forms.DataGridView();
            this.tamUngBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamUngDB = new Salary.TamUngDB();
            this.tamUngTableAdapter = new Salary.TamUngDBTableAdapters.TamUngTableAdapter();
            this.sttTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamUngBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamUngDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.BtnButToan);
            this.groupBox1.Controls.Add(this.ThemTU);
            this.groupBox1.Controls.Add(this.XoaTU);
            this.groupBox1.Controls.Add(this.dtgvTU);
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 556);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tạm ứng lương";
            // 
            // BtnButToan
            // 
            this.BtnButToan.BackColor = System.Drawing.Color.Orange;
            this.BtnButToan.FlatAppearance.BorderSize = 0;
            this.BtnButToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnButToan.Image = global::Salary.Properties.Resources.file_edit;
            this.BtnButToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnButToan.Location = new System.Drawing.Point(848, 33);
            this.BtnButToan.Name = "BtnButToan";
            this.BtnButToan.Size = new System.Drawing.Size(117, 35);
            this.BtnButToan.TabIndex = 11;
            this.BtnButToan.Text = "Lập bút toán";
            this.BtnButToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnButToan.UseVisualStyleBackColor = false;
            this.BtnButToan.Click += new System.EventHandler(this.BtnButToan_Click);
            // 
            // ThemTU
            // 
            this.ThemTU.BackColor = System.Drawing.Color.Orange;
            this.ThemTU.FlatAppearance.BorderSize = 0;
            this.ThemTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemTU.Image = global::Salary.Properties.Resources.add_document;
            this.ThemTU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemTU.Location = new System.Drawing.Point(8, 33);
            this.ThemTU.Name = "ThemTU";
            this.ThemTU.Size = new System.Drawing.Size(79, 35);
            this.ThemTU.TabIndex = 8;
            this.ThemTU.Text = "Thêm";
            this.ThemTU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemTU.UseVisualStyleBackColor = false;
            this.ThemTU.Click += new System.EventHandler(this.ThemTU_Click_1);
            // 
            // XoaTU
            // 
            this.XoaTU.BackColor = System.Drawing.Color.Orange;
            this.XoaTU.FlatAppearance.BorderSize = 0;
            this.XoaTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaTU.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaTU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaTU.Location = new System.Drawing.Point(93, 33);
            this.XoaTU.Name = "XoaTU";
            this.XoaTU.Size = new System.Drawing.Size(79, 35);
            this.XoaTU.TabIndex = 9;
            this.XoaTU.Text = "Xóa";
            this.XoaTU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaTU.UseVisualStyleBackColor = false;
            this.XoaTU.Click += new System.EventHandler(this.XoaTU_Click);
            // 
            // dtgvTU
            // 
            this.dtgvTU.AllowUserToAddRows = false;
            this.dtgvTU.AutoGenerateColumns = false;
            this.dtgvTU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttTUDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.maTUDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.motaDataGridViewTextBoxColumn,
            this.soTienDataGridViewTextBoxColumn,
            this.maKLDataGridViewTextBoxColumn});
            this.dtgvTU.DataSource = this.tamUngBindingSource;
            this.dtgvTU.Location = new System.Drawing.Point(9, 74);
            this.dtgvTU.Name = "dtgvTU";
            this.dtgvTU.ReadOnly = true;
            this.dtgvTU.RowHeadersWidth = 51;
            this.dtgvTU.RowTemplate.Height = 24;
            this.dtgvTU.Size = new System.Drawing.Size(956, 476);
            this.dtgvTU.TabIndex = 7;
            this.dtgvTU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tamUngBindingSource
            // 
            this.tamUngBindingSource.DataMember = "TamUng";
            this.tamUngBindingSource.DataSource = this.tamUngDB;
            // 
            // tamUngDB
            // 
            this.tamUngDB.DataSetName = "TamUngDB";
            this.tamUngDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tamUngTableAdapter
            // 
            this.tamUngTableAdapter.ClearBeforeFill = true;
            // 
            // sttTUDataGridViewTextBoxColumn
            // 
            this.sttTUDataGridViewTextBoxColumn.DataPropertyName = "SttTU";
            this.sttTUDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttTUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTUDataGridViewTextBoxColumn.Name = "sttTUDataGridViewTextBoxColumn";
            this.sttTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTUDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lạp";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // maTUDataGridViewTextBoxColumn
            // 
            this.maTUDataGridViewTextBoxColumn.DataPropertyName = "MaTU";
            this.maTUDataGridViewTextBoxColumn.HeaderText = "Mã chứng từ";
            this.maTUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTUDataGridViewTextBoxColumn.Name = "maTUDataGridViewTextBoxColumn";
            this.maTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTUDataGridViewTextBoxColumn.Width = 125;
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
            // motaDataGridViewTextBoxColumn
            // 
            this.motaDataGridViewTextBoxColumn.DataPropertyName = "Mota";
            this.motaDataGridViewTextBoxColumn.HeaderText = "Lý do tạm ứng";
            this.motaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            this.motaDataGridViewTextBoxColumn.ReadOnly = true;
            this.motaDataGridViewTextBoxColumn.Width = 125;
            // 
            // soTienDataGridViewTextBoxColumn
            // 
            this.soTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien";
            this.soTienDataGridViewTextBoxColumn.HeaderText = "Số tiền";
            this.soTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTienDataGridViewTextBoxColumn.Name = "soTienDataGridViewTextBoxColumn";
            this.soTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.soTienDataGridViewTextBoxColumn.Width = 125;
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
            // TamUng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(977, 559);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TamUng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠM ỨNG LƯƠNG";
            this.Load += new System.EventHandler(this.TamUng_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamUngBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamUngDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvTU;
        private System.Windows.Forms.Button ThemTU;
        private System.Windows.Forms.Button XoaTU;
        private System.Windows.Forms.Button BtnButToan;
        private TamUngDB tamUngDB;
        private System.Windows.Forms.BindingSource tamUngBindingSource;
        private TamUngDBTableAdapters.TamUngTableAdapter tamUngTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn;
    }
}