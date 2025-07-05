
namespace Salary
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.BtnDMK = new System.Windows.Forms.Button();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienDB = new Salary.NhanVienDB();
            this.nhanVienTableAdapter = new Salary.NhanVienDBTableAdapters.NhanVienTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.textBoxNewPassword);
            this.groupBox2.Controls.Add(this.BtnDMK);
            this.groupBox2.Controls.Add(this.textBoxOldPassword);
            this.groupBox2.Controls.Add(this.textBoxUsername);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(1, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 191);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tạm ứng";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Orange;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuy.Location = new System.Drawing.Point(277, 143);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(68, 28);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(137, 93);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(208, 22);
            this.textBoxNewPassword.TabIndex = 28;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // BtnDMK
            // 
            this.BtnDMK.BackColor = System.Drawing.Color.Orange;
            this.BtnDMK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDMK.Location = new System.Drawing.Point(110, 143);
            this.BtnDMK.Name = "BtnDMK";
            this.BtnDMK.Size = new System.Drawing.Size(130, 28);
            this.BtnDMK.TabIndex = 11;
            this.BtnDMK.Text = "Đổi mật khẩu";
            this.BtnDMK.UseVisualStyleBackColor = false;
            this.BtnDMK.Click += new System.EventHandler(this.BtnDMK_Click);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(137, 62);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(208, 22);
            this.textBoxOldPassword.TabIndex = 7;
            this.textBoxOldPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(137, 30);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(208, 22);
            this.textBoxUsername.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(39, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "Mật khẩu mới";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(46, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Mật khẩu cũ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(36, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tên tài khoản";
            this.label14.Click += new System.EventHandler(this.label14_Click);
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
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(368, 197);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private NhanVienDB nhanVienDB;
        public System.Windows.Forms.Button BtnDMK;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private NhanVienDBTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        public System.Windows.Forms.Button btnHuy;
    }
}