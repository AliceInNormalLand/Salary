
namespace Salary
{
    partial class ChitietLCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChitietLCS));
            this.SuaCV2 = new System.Windows.Forms.Button();
            this.ThemCV2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuaCV2
            // 
            this.SuaCV2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SuaCV2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SuaCV2.Location = new System.Drawing.Point(488, 124);
            this.SuaCV2.Name = "SuaCV2";
            this.SuaCV2.Size = new System.Drawing.Size(75, 28);
            this.SuaCV2.TabIndex = 34;
            this.SuaCV2.Text = "Sửa";
            this.SuaCV2.UseVisualStyleBackColor = false;
            // 
            // ThemCV2
            // 
            this.ThemCV2.BackColor = System.Drawing.Color.DarkCyan;
            this.ThemCV2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ThemCV2.Location = new System.Drawing.Point(488, 124);
            this.ThemCV2.Name = "ThemCV2";
            this.ThemCV2.Size = new System.Drawing.Size(75, 28);
            this.ThemCV2.TabIndex = 33;
            this.ThemCV2.Text = "Thêm";
            this.ThemCV2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(298, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ngày hiệu lực";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 28;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Location = new System.Drawing.Point(528, 15);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(35, 17);
            this.lbID.TabIndex = 27;
            this.lbID.Text = "STT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mức lương";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.SuaCV2);
            this.groupBox1.Controls.Add(this.ThemCV2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 166);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lương cơ sở";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 22);
            this.textBox2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(414, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 22);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // ChitietLCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 164);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChitietLCS";
            this.Text = "LƯƠNG CƠ SỞ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button SuaCV2;
        public System.Windows.Forms.Button ThemCV2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}