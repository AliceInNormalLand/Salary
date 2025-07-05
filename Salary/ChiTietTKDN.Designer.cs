
namespace Salary
{
    partial class ChiTietTKDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietTKDN));
            this.nhanVienTableAdapter = new Salary.NhanVienDBTableAdapters.NhanVienTableAdapter();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienDB = new Salary.NhanVienDB();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemTKDN2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbTTHD = new System.Windows.Forms.CheckBox();
            this.tbTDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.btnSuaTKDN2 = new System.Windows.Forms.Button();
            this.cbLTK = new System.Windows.Forms.ComboBox();
            this.cbMNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(296, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Loại tài khoản";
            // 
            // btnThemTKDN2
            // 
            this.btnThemTKDN2.BackColor = System.Drawing.Color.Orange;
            this.btnThemTKDN2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemTKDN2.Location = new System.Drawing.Point(10, 21);
            this.btnThemTKDN2.Name = "btnThemTKDN2";
            this.btnThemTKDN2.Size = new System.Drawing.Size(75, 28);
            this.btnThemTKDN2.TabIndex = 8;
            this.btnThemTKDN2.Text = "Thêm";
            this.btnThemTKDN2.UseVisualStyleBackColor = false;
            this.btnThemTKDN2.Click += new System.EventHandler(this.btnThemTKDN2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(18, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Mật khẩu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(18, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tên đăng nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.cbMNV);
            this.groupBox2.Controls.Add(this.cbLTK);
            this.groupBox2.Controls.Add(this.ckbTTHD);
            this.groupBox2.Controls.Add(this.tbTDN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbMK);
            this.groupBox2.Controls.Add(this.btnSuaTKDN2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnThemTKDN2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 178);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết chấm điểm";
            // 
            // ckbTTHD
            // 
            this.ckbTTHD.AutoSize = true;
            this.ckbTTHD.Location = new System.Drawing.Point(21, 146);
            this.ckbTTHD.Name = "ckbTTHD";
            this.ckbTTHD.Size = new System.Drawing.Size(163, 21);
            this.ckbTTHD.TabIndex = 47;
            this.ckbTTHD.Text = "Tình trạng hoạt động";
            this.ckbTTHD.UseVisualStyleBackColor = true;
            // 
            // tbTDN
            // 
            this.tbTDN.Location = new System.Drawing.Point(129, 68);
            this.tbTDN.Name = "tbTDN";
            this.tbTDN.Size = new System.Drawing.Size(134, 22);
            this.tbTDN.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(296, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã nhân viên";
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(129, 105);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(134, 22);
            this.tbMK.TabIndex = 42;
            // 
            // btnSuaTKDN2
            // 
            this.btnSuaTKDN2.BackColor = System.Drawing.Color.Orange;
            this.btnSuaTKDN2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuaTKDN2.Location = new System.Drawing.Point(10, 21);
            this.btnSuaTKDN2.Name = "btnSuaTKDN2";
            this.btnSuaTKDN2.Size = new System.Drawing.Size(75, 28);
            this.btnSuaTKDN2.TabIndex = 41;
            this.btnSuaTKDN2.Text = "Sửa";
            this.btnSuaTKDN2.UseVisualStyleBackColor = false;
            this.btnSuaTKDN2.Click += new System.EventHandler(this.btnSuaTKDN2_Click);
            // 
            // cbLTK
            // 
            this.cbLTK.FormattingEnabled = true;
            this.cbLTK.Items.AddRange(new object[] {
            "GD",
            "PGD",
            "Member",
            "AdminKT",
            "MemberKT",
            "AdminNS",
            "MemberNS",
            "AdminIT",
            "MemberIT"});
            this.cbLTK.Location = new System.Drawing.Point(399, 68);
            this.cbLTK.Name = "cbLTK";
            this.cbLTK.Size = new System.Drawing.Size(128, 24);
            this.cbLTK.TabIndex = 49;
            // 
            // cbMNV
            // 
            this.cbMNV.DataSource = this.nhanVienBindingSource;
            this.cbMNV.DisplayMember = "MaNV";
            this.cbMNV.Location = new System.Drawing.Point(399, 103);
            this.cbMNV.Name = "cbMNV";
            this.cbMNV.Size = new System.Drawing.Size(128, 24);
            this.cbMNV.TabIndex = 50;
            this.cbMNV.ValueMember = "MaNV";
            // 
            // ChiTietTKDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(546, 192);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChiTietTKDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT TÀI KHOẢN ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.ChiTietTKDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NhanVienDBTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private NhanVienDB nhanVienDB;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnThemTKDN2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnSuaTKDN2;
        private System.Windows.Forms.CheckBox ckbTTHD;
        private System.Windows.Forms.TextBox tbTDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.ComboBox cbLTK;
        private System.Windows.Forms.ComboBox cbMNV;
    }
}