
namespace Salary
{
    partial class TaikhoanDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaikhoanDN));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuaTKDN = new System.Windows.Forms.Button();
            this.ThemTKDN = new System.Windows.Forms.Button();
            this.XoaTKDN = new System.Windows.Forms.Button();
            this.dtgvTKDN = new System.Windows.Forms.DataGridView();
            this.sttDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoatDongDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dangNhapDB = new Salary.DangNhapDB();
            this.dangNhapTableAdapter = new Salary.DangNhapDBTableAdapters.DangNhapTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTKDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.SuaTKDN);
            this.groupBox2.Controls.Add(this.ThemTKDN);
            this.groupBox2.Controls.Add(this.XoaTKDN);
            this.groupBox2.Controls.Add(this.dtgvTKDN);
            this.groupBox2.Location = new System.Drawing.Point(-2, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 544);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản người dùng";
            // 
            // SuaTKDN
            // 
            this.SuaTKDN.BackColor = System.Drawing.Color.Orange;
            this.SuaTKDN.FlatAppearance.BorderSize = 0;
            this.SuaTKDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaTKDN.Image = global::Salary.Properties.Resources.file_edit;
            this.SuaTKDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaTKDN.Location = new System.Drawing.Point(179, 33);
            this.SuaTKDN.Name = "SuaTKDN";
            this.SuaTKDN.Size = new System.Drawing.Size(79, 35);
            this.SuaTKDN.TabIndex = 10;
            this.SuaTKDN.Text = "Sửa";
            this.SuaTKDN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaTKDN.UseVisualStyleBackColor = false;
            this.SuaTKDN.Click += new System.EventHandler(this.SuaTKDN_Click);
            // 
            // ThemTKDN
            // 
            this.ThemTKDN.BackColor = System.Drawing.Color.Orange;
            this.ThemTKDN.FlatAppearance.BorderSize = 0;
            this.ThemTKDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemTKDN.Image = global::Salary.Properties.Resources.add_document;
            this.ThemTKDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemTKDN.Location = new System.Drawing.Point(9, 33);
            this.ThemTKDN.Name = "ThemTKDN";
            this.ThemTKDN.Size = new System.Drawing.Size(79, 35);
            this.ThemTKDN.TabIndex = 8;
            this.ThemTKDN.Text = "Thêm";
            this.ThemTKDN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemTKDN.UseVisualStyleBackColor = false;
            this.ThemTKDN.Click += new System.EventHandler(this.ThemTKDN_Click);
            // 
            // XoaTKDN
            // 
            this.XoaTKDN.BackColor = System.Drawing.Color.Orange;
            this.XoaTKDN.FlatAppearance.BorderSize = 0;
            this.XoaTKDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaTKDN.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaTKDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaTKDN.Location = new System.Drawing.Point(94, 33);
            this.XoaTKDN.Name = "XoaTKDN";
            this.XoaTKDN.Size = new System.Drawing.Size(79, 35);
            this.XoaTKDN.TabIndex = 9;
            this.XoaTKDN.Text = "Xóa";
            this.XoaTKDN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaTKDN.UseVisualStyleBackColor = false;
            this.XoaTKDN.Click += new System.EventHandler(this.XoaTKDN_Click);
            // 
            // dtgvTKDN
            // 
            this.dtgvTKDN.AllowUserToAddRows = false;
            this.dtgvTKDN.AutoGenerateColumns = false;
            this.dtgvTKDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTKDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttDNDataGridViewTextBoxColumn,
            this.tenDNDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.hoatDongDataGridViewCheckBoxColumn,
            this.loaiDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn});
            this.dtgvTKDN.DataSource = this.dangNhapBindingSource;
            this.dtgvTKDN.Location = new System.Drawing.Point(9, 74);
            this.dtgvTKDN.Name = "dtgvTKDN";
            this.dtgvTKDN.ReadOnly = true;
            this.dtgvTKDN.RowHeadersWidth = 51;
            this.dtgvTKDN.RowTemplate.Height = 24;
            this.dtgvTKDN.Size = new System.Drawing.Size(803, 464);
            this.dtgvTKDN.TabIndex = 7;
            this.dtgvTKDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTKNH_CellClick);
            // 
            // sttDNDataGridViewTextBoxColumn
            // 
            this.sttDNDataGridViewTextBoxColumn.DataPropertyName = "SttDN";
            this.sttDNDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttDNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttDNDataGridViewTextBoxColumn.Name = "sttDNDataGridViewTextBoxColumn";
            this.sttDNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttDNDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenDNDataGridViewTextBoxColumn
            // 
            this.tenDNDataGridViewTextBoxColumn.DataPropertyName = "TenDN";
            this.tenDNDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tenDNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDNDataGridViewTextBoxColumn.Name = "tenDNDataGridViewTextBoxColumn";
            this.tenDNDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDNDataGridViewTextBoxColumn.Width = 125;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.matKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            this.matKhauDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoatDongDataGridViewCheckBoxColumn
            // 
            this.hoatDongDataGridViewCheckBoxColumn.DataPropertyName = "HoatDong";
            this.hoatDongDataGridViewCheckBoxColumn.HeaderText = "Hoạt động";
            this.hoatDongDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.hoatDongDataGridViewCheckBoxColumn.Name = "hoatDongDataGridViewCheckBoxColumn";
            this.hoatDongDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hoatDongDataGridViewCheckBoxColumn.Width = 125;
            // 
            // loaiDataGridViewTextBoxColumn
            // 
            this.loaiDataGridViewTextBoxColumn.DataPropertyName = "Loai";
            this.loaiDataGridViewTextBoxColumn.HeaderText = "Loại";
            this.loaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiDataGridViewTextBoxColumn.Name = "loaiDataGridViewTextBoxColumn";
            this.loaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.loaiDataGridViewTextBoxColumn.Width = 125;
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
            // dangNhapBindingSource
            // 
            this.dangNhapBindingSource.DataMember = "DangNhap";
            this.dangNhapBindingSource.DataSource = this.dangNhapDB;
            // 
            // dangNhapDB
            // 
            this.dangNhapDB.DataSetName = "DangNhapDB";
            this.dangNhapDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dangNhapTableAdapter
            // 
            this.dangNhapTableAdapter.ClearBeforeFill = true;
            // 
            // TaikhoanDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 542);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaikhoanDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÀI KHOẢN ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.TaikhoanDN_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTKDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangNhapDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvTKDN;
        private DangNhapDB dangNhapDB;
        private System.Windows.Forms.BindingSource dangNhapBindingSource;
        private DangNhapDBTableAdapters.DangNhapTableAdapter dangNhapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hoatDongDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SuaTKDN;
        private System.Windows.Forms.Button ThemTKDN;
        private System.Windows.Forms.Button XoaTKDN;
    }
}