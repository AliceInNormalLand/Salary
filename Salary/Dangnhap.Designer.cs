
namespace Salary
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.BtnDangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(186, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(186, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(185, 126);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(210, 22);
            this.txtMK.TabIndex = 7;
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(185, 74);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(210, 22);
            this.txtTDN.TabIndex = 6;
            this.txtTDN.TextChanged += new System.EventHandler(this.txtTDN_TextChanged);
            // 
            // BtnDangnhap
            // 
            this.BtnDangnhap.BackColor = System.Drawing.Color.Transparent;
            this.BtnDangnhap.ForeColor = System.Drawing.Color.Black;
            this.BtnDangnhap.Location = new System.Drawing.Point(233, 181);
            this.BtnDangnhap.Name = "BtnDangnhap";
            this.BtnDangnhap.Size = new System.Drawing.Size(113, 33);
            this.BtnDangnhap.TabIndex = 10;
            this.BtnDangnhap.Text = "Đăng nhập";
            this.BtnDangnhap.UseVisualStyleBackColor = false;
            this.BtnDangnhap.Click += new System.EventHandler(this.BtnDangnhap_Click);
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 259);
            this.Controls.Add(this.BtnDangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTDN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.Button BtnDangnhap;
    }
}