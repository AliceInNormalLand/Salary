
namespace Salary
{
    partial class ChitietCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChitietCD));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienDB = new Salary.NhanVienDB();
            this.CbGhiChu = new System.Windows.Forms.ComboBox();
            this.danhgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhGiaDB = new Salary.DanhGiaDB();
            this.label1 = new System.Windows.Forms.Label();
            this.CbDiem = new System.Windows.Forms.ComboBox();
            this.CbDG = new System.Windows.Forms.ComboBox();
            this.ThemCD2 = new System.Windows.Forms.Button();
            this.dtpCD = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.danhgiaTableAdapter = new Salary.DanhGiaDBTableAdapters.DanhgiaTableAdapter();
            this.nhanVienTableAdapter = new Salary.NhanVienDBTableAdapters.NhanVienTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhgiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMaNV);
            this.groupBox2.Controls.Add(this.CbGhiChu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CbDiem);
            this.groupBox2.Controls.Add(this.CbDG);
            this.groupBox2.Controls.Add(this.ThemCD2);
            this.groupBox2.Controls.Add(this.dtpCD);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 192);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết chấm điểm";
            // 
            // cbMaNV
            // 
            this.cbMaNV.DataSource = this.nhanVienBindingSource;
            this.cbMaNV.DisplayMember = "TenNV";
            this.cbMaNV.Location = new System.Drawing.Point(117, 68);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(209, 24);
            this.cbMaNV.TabIndex = 40;
            this.cbMaNV.ValueMember = "MaNV";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.nhanVienDB;
            // 
            // nhanVienDB
            // 
            this.nhanVienDB.DataSetName = "NhanVienDB";
            this.nhanVienDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CbGhiChu
            // 
            this.CbGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.danhgiaBindingSource, "Truonghop", true));
            this.CbGhiChu.DataSource = this.danhgiaBindingSource;
            this.CbGhiChu.DisplayMember = "Truonghop";
            this.CbGhiChu.Enabled = false;
            this.CbGhiChu.FormattingEnabled = true;
            this.CbGhiChu.Location = new System.Drawing.Point(117, 146);
            this.CbGhiChu.Name = "CbGhiChu";
            this.CbGhiChu.Size = new System.Drawing.Size(552, 24);
            this.CbGhiChu.TabIndex = 38;
            this.CbGhiChu.ValueMember = "Truonghop";
            // 
            // danhgiaBindingSource
            // 
            this.danhgiaBindingSource.DataMember = "Danhgia";
            this.danhgiaBindingSource.DataSource = this.danhGiaDB;
            // 
            // danhGiaDB
            // 
            this.danhGiaDB.DataSetName = "DanhGiaDB";
            this.danhGiaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(390, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Điểm";
            // 
            // CbDiem
            // 
            this.CbDiem.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.danhgiaBindingSource, "Diem", true));
            this.CbDiem.DataSource = this.danhgiaBindingSource;
            this.CbDiem.DisplayMember = "Diem";
            this.CbDiem.FormattingEnabled = true;
            this.CbDiem.Location = new System.Drawing.Point(460, 105);
            this.CbDiem.Name = "CbDiem";
            this.CbDiem.Size = new System.Drawing.Size(209, 24);
            this.CbDiem.TabIndex = 36;
            this.CbDiem.ValueMember = "Diem";
            // 
            // CbDG
            // 
            this.CbDG.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.danhgiaBindingSource, "SttDG", true));
            this.CbDG.DataSource = this.danhgiaBindingSource;
            this.CbDG.DisplayMember = "Truonghop";
            this.CbDG.Location = new System.Drawing.Point(117, 105);
            this.CbDG.Name = "CbDG";
            this.CbDG.Size = new System.Drawing.Size(209, 24);
            this.CbDG.TabIndex = 34;
            this.CbDG.ValueMember = "SttDG";
            // 
            // ThemCD2
            // 
            this.ThemCD2.BackColor = System.Drawing.Color.Orange;
            this.ThemCD2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThemCD2.Location = new System.Drawing.Point(15, 24);
            this.ThemCD2.Name = "ThemCD2";
            this.ThemCD2.Size = new System.Drawing.Size(75, 28);
            this.ThemCD2.TabIndex = 8;
            this.ThemCD2.Text = "Thêm";
            this.ThemCD2.UseVisualStyleBackColor = false;
            this.ThemCD2.Click += new System.EventHandler(this.ThemCD2_Click);
            // 
            // dtpCD
            // 
            this.dtpCD.Location = new System.Drawing.Point(539, 37);
            this.dtpCD.Name = "dtpCD";
            this.dtpCD.Size = new System.Drawing.Size(130, 22);
            this.dtpCD.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(54, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 17);
            this.label20.TabIndex = 20;
            this.label20.Text = "Ghi chú";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(605, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Ngày lập";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(18, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Mục đánh giá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(18, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mã nhân viên";
            // 
            // danhgiaTableAdapter
            // 
            this.danhgiaTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ChitietCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(690, 198);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChitietCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHẤM ĐIỂM NHÂN VIÊN";
            this.Load += new System.EventHandler(this.ChitietCD_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhgiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button ThemCD2;
        private System.Windows.Forms.DateTimePicker dtpCD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private DanhGiaDB danhGiaDB;
        private System.Windows.Forms.BindingSource danhgiaBindingSource;
        private DanhGiaDBTableAdapters.DanhgiaTableAdapter danhgiaTableAdapter;
        private NhanVienDB nhanVienDB;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private NhanVienDBTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDiem;
        private System.Windows.Forms.ComboBox CbDG;
        private System.Windows.Forms.ComboBox CbGhiChu;
        private System.Windows.Forms.ComboBox cbMaNV;
    }
}