
namespace Salary
{
    partial class ChitietTU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChitietTU));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ThemTU2 = new System.Windows.Forms.Button();
            this.dtpTU = new System.Windows.Forms.DateTimePicker();
            this.tbSoTienTU = new System.Windows.Forms.TextBox();
            this.tbMoTa = new System.Windows.Forms.TextBox();
            this.tbMaTU = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.nhanVienDB = new Salary.NhanVienDB();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new Salary.NhanVienDBTableAdapters.NhanVienTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMaNV);
            this.groupBox2.Controls.Add(this.ThemTU2);
            this.groupBox2.Controls.Add(this.dtpTU);
            this.groupBox2.Controls.Add(this.tbSoTienTU);
            this.groupBox2.Controls.Add(this.tbMoTa);
            this.groupBox2.Controls.Add(this.tbMaTU);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(4, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 221);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tạm ứng";
            // 
            // ThemTU2
            // 
            this.ThemTU2.BackColor = System.Drawing.Color.Orange;
            this.ThemTU2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThemTU2.Location = new System.Drawing.Point(621, 180);
            this.ThemTU2.Name = "ThemTU2";
            this.ThemTU2.Size = new System.Drawing.Size(75, 28);
            this.ThemTU2.TabIndex = 11;
            this.ThemTU2.Text = "Thêm";
            this.ThemTU2.UseVisualStyleBackColor = false;
            this.ThemTU2.Click += new System.EventHandler(this.ThemTU2_Click);
            // 
            // dtpTU
            // 
            this.dtpTU.Location = new System.Drawing.Point(566, 40);
            this.dtpTU.Name = "dtpTU";
            this.dtpTU.Size = new System.Drawing.Size(130, 22);
            this.dtpTU.TabIndex = 2;
            // 
            // tbSoTienTU
            // 
            this.tbSoTienTU.Location = new System.Drawing.Point(488, 119);
            this.tbSoTienTU.Name = "tbSoTienTU";
            this.tbSoTienTU.Size = new System.Drawing.Size(208, 22);
            this.tbSoTienTU.TabIndex = 7;
            // 
            // tbMoTa
            // 
            this.tbMoTa.Location = new System.Drawing.Point(97, 155);
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.Size = new System.Drawing.Size(599, 22);
            this.tbMoTa.TabIndex = 5;
            // 
            // tbMaTU
            // 
            this.tbMaTU.Location = new System.Drawing.Point(566, 84);
            this.tbMaTU.Name = "tbMaTU";
            this.tbMaTU.Size = new System.Drawing.Size(130, 22);
            this.tbMaTU.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(346, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 17);
            this.label20.TabIndex = 20;
            this.label20.Text = "Khoản tạm ứng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(12, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "Mô tả";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(632, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Ngày lập";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(12, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Mã NV";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(630, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mã phiếu";
            // 
            // cbMaNV
            // 
            this.cbMaNV.DataSource = this.nhanVienBindingSource;
            this.cbMaNV.DisplayMember = "TenNV";
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(97, 119);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(196, 24);
            this.cbMaNV.TabIndex = 28;
            this.cbMaNV.ValueMember = "MaNV";
            // 
            // nhanVienDB
            // 
            this.nhanVienDB.DataSetName = "NhanVienDB";
            this.nhanVienDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.nhanVienDB;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ChitietTU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(723, 224);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChitietTU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠM ỨNG";
            this.Load += new System.EventHandler(this.ChitietTU_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpTU;
        private System.Windows.Forms.TextBox tbSoTienTU;
        private System.Windows.Forms.TextBox tbMoTa;
        private System.Windows.Forms.TextBox tbMaTU;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button ThemTU2;
        private System.Windows.Forms.ComboBox cbMaNV;
        private NhanVienDB nhanVienDB;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private NhanVienDBTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}