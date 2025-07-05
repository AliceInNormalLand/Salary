
namespace Salary
{
    partial class Hopdong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hopdong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttHDLDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNghiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioLamToiThieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuCapAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuCapDiLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuCapDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hopDongLDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hopDongLDDB = new Salary.HopDongLDDB();
            this.hopDongLDTableAdapter = new Salary.HopDongLDDBTableAdapters.HopDongLDTableAdapter();
            this.SuaHDLD = new System.Windows.Forms.Button();
            this.ThemHDLD = new System.Windows.Forms.Button();
            this.XoaHDLD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongLDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongLDDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.SuaHDLD);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.ThemHDLD);
            this.groupBox1.Controls.Add(this.XoaHDLD);
            this.groupBox1.Location = new System.Drawing.Point(-2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 480);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hợp đồng lao động";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttHDLDDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.ngayBatDauDataGridViewTextBoxColumn,
            this.ngayKetThucDataGridViewTextBoxColumn,
            this.luongCBDataGridViewTextBoxColumn,
            this.ngayNghiDataGridViewTextBoxColumn,
            this.gioLamToiThieuDataGridViewTextBoxColumn,
            this.phuCapAnDataGridViewTextBoxColumn,
            this.phuCapDiLaiDataGridViewTextBoxColumn,
            this.phuCapDienThoaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hopDongLDBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 406);
            this.dataGridView1.TabIndex = 7;
            // 
            // sttHDLDDataGridViewTextBoxColumn
            // 
            this.sttHDLDDataGridViewTextBoxColumn.DataPropertyName = "SttHDLD";
            this.sttHDLDDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttHDLDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttHDLDDataGridViewTextBoxColumn.Name = "sttHDLDDataGridViewTextBoxColumn";
            this.sttHDLDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttHDLDDataGridViewTextBoxColumn.Width = 125;
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
            // ngayBatDauDataGridViewTextBoxColumn
            // 
            this.ngayBatDauDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDau";
            this.ngayBatDauDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu";
            this.ngayBatDauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayBatDauDataGridViewTextBoxColumn.Name = "ngayBatDauDataGridViewTextBoxColumn";
            this.ngayBatDauDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayBatDauDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayKetThucDataGridViewTextBoxColumn
            // 
            this.ngayKetThucDataGridViewTextBoxColumn.DataPropertyName = "NgayKetThuc";
            this.ngayKetThucDataGridViewTextBoxColumn.HeaderText = "Ngày kết thúc";
            this.ngayKetThucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayKetThucDataGridViewTextBoxColumn.Name = "ngayKetThucDataGridViewTextBoxColumn";
            this.ngayKetThucDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayKetThucDataGridViewTextBoxColumn.Width = 125;
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
            // ngayNghiDataGridViewTextBoxColumn
            // 
            this.ngayNghiDataGridViewTextBoxColumn.DataPropertyName = "NgayNghi";
            this.ngayNghiDataGridViewTextBoxColumn.HeaderText = "Ngày nghỉ";
            this.ngayNghiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayNghiDataGridViewTextBoxColumn.Name = "ngayNghiDataGridViewTextBoxColumn";
            this.ngayNghiDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayNghiDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioLamToiThieuDataGridViewTextBoxColumn
            // 
            this.gioLamToiThieuDataGridViewTextBoxColumn.DataPropertyName = "GioLamToiThieu";
            this.gioLamToiThieuDataGridViewTextBoxColumn.HeaderText = "Giờ làm tối thiểu";
            this.gioLamToiThieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioLamToiThieuDataGridViewTextBoxColumn.Name = "gioLamToiThieuDataGridViewTextBoxColumn";
            this.gioLamToiThieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioLamToiThieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // phuCapAnDataGridViewTextBoxColumn
            // 
            this.phuCapAnDataGridViewTextBoxColumn.DataPropertyName = "PhuCapAn";
            this.phuCapAnDataGridViewTextBoxColumn.HeaderText = "Phụ cấp ăn uống";
            this.phuCapAnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phuCapAnDataGridViewTextBoxColumn.Name = "phuCapAnDataGridViewTextBoxColumn";
            this.phuCapAnDataGridViewTextBoxColumn.ReadOnly = true;
            this.phuCapAnDataGridViewTextBoxColumn.Width = 125;
            // 
            // phuCapDiLaiDataGridViewTextBoxColumn
            // 
            this.phuCapDiLaiDataGridViewTextBoxColumn.DataPropertyName = "PhuCapDiLai";
            this.phuCapDiLaiDataGridViewTextBoxColumn.HeaderText = "Phụ cấp đi lại";
            this.phuCapDiLaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phuCapDiLaiDataGridViewTextBoxColumn.Name = "phuCapDiLaiDataGridViewTextBoxColumn";
            this.phuCapDiLaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.phuCapDiLaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // phuCapDienThoaiDataGridViewTextBoxColumn
            // 
            this.phuCapDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "PhuCapDienThoai";
            this.phuCapDienThoaiDataGridViewTextBoxColumn.HeaderText = "Phụ cấp điện thoại";
            this.phuCapDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phuCapDienThoaiDataGridViewTextBoxColumn.Name = "phuCapDienThoaiDataGridViewTextBoxColumn";
            this.phuCapDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.phuCapDienThoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // hopDongLDBindingSource
            // 
            this.hopDongLDBindingSource.DataMember = "HopDongLD";
            this.hopDongLDBindingSource.DataSource = this.hopDongLDDB;
            // 
            // hopDongLDDB
            // 
            this.hopDongLDDB.DataSetName = "HopDongLDDB";
            this.hopDongLDDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hopDongLDTableAdapter
            // 
            this.hopDongLDTableAdapter.ClearBeforeFill = true;
            // 
            // SuaHDLD
            // 
            this.SuaHDLD.BackColor = System.Drawing.Color.Orange;
            this.SuaHDLD.FlatAppearance.BorderSize = 0;
            this.SuaHDLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaHDLD.Image = global::Salary.Properties.Resources.file_edit;
            this.SuaHDLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaHDLD.Location = new System.Drawing.Point(179, 33);
            this.SuaHDLD.Name = "SuaHDLD";
            this.SuaHDLD.Size = new System.Drawing.Size(79, 35);
            this.SuaHDLD.TabIndex = 9;
            this.SuaHDLD.Text = "Sửa";
            this.SuaHDLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaHDLD.UseVisualStyleBackColor = false;
            // 
            // ThemHDLD
            // 
            this.ThemHDLD.BackColor = System.Drawing.Color.Orange;
            this.ThemHDLD.FlatAppearance.BorderSize = 0;
            this.ThemHDLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemHDLD.Image = global::Salary.Properties.Resources.add_document;
            this.ThemHDLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemHDLD.Location = new System.Drawing.Point(9, 33);
            this.ThemHDLD.Name = "ThemHDLD";
            this.ThemHDLD.Size = new System.Drawing.Size(79, 35);
            this.ThemHDLD.TabIndex = 7;
            this.ThemHDLD.Text = "Thêm";
            this.ThemHDLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemHDLD.UseVisualStyleBackColor = false;
            // 
            // XoaHDLD
            // 
            this.XoaHDLD.BackColor = System.Drawing.Color.Orange;
            this.XoaHDLD.FlatAppearance.BorderSize = 0;
            this.XoaHDLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaHDLD.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaHDLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaHDLD.Location = new System.Drawing.Point(94, 33);
            this.XoaHDLD.Name = "XoaHDLD";
            this.XoaHDLD.Size = new System.Drawing.Size(79, 35);
            this.XoaHDLD.TabIndex = 8;
            this.XoaHDLD.Text = "Xóa";
            this.XoaHDLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaHDLD.UseVisualStyleBackColor = false;
            // 
            // Hopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 478);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hopdong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỢP ĐỒNG LAO ĐỘNG";
            this.Load += new System.EventHandler(this.Hopdong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongLDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopDongLDDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HopDongLDDB hopDongLDDB;
        private System.Windows.Forms.BindingSource hopDongLDBindingSource;
        private HopDongLDDBTableAdapters.HopDongLDTableAdapter hopDongLDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttHDLDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNghiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioLamToiThieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuCapAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuCapDiLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuCapDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SuaHDLD;
        private System.Windows.Forms.Button ThemHDLD;
        private System.Windows.Forms.Button XoaHDLD;
    }
}