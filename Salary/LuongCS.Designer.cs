
namespace Salary
{
    partial class LuongCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuongCS));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuaLCS = new System.Windows.Forms.Button();
            this.dtgvCPDN = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luongCSDB = new Salary.LuongCSDB();
            this.ThemLCS = new System.Windows.Forms.Button();
            this.XoaLCS = new System.Windows.Forms.Button();
            this.luongCSTableAdapter = new Salary.LuongCSDBTableAdapters.LuongCSTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCPDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongCSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongCSDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.SuaLCS);
            this.groupBox2.Controls.Add(this.dtgvCPDN);
            this.groupBox2.Controls.Add(this.ThemLCS);
            this.groupBox2.Controls.Add(this.XoaLCS);
            this.groupBox2.Location = new System.Drawing.Point(0, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 340);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mức lương cơ sở";
            // 
            // SuaLCS
            // 
            this.SuaLCS.BackColor = System.Drawing.Color.Orange;
            this.SuaLCS.FlatAppearance.BorderSize = 0;
            this.SuaLCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaLCS.Image = global::Salary.Properties.Resources.file_edit;
            this.SuaLCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaLCS.Location = new System.Drawing.Point(179, 33);
            this.SuaLCS.Name = "SuaLCS";
            this.SuaLCS.Size = new System.Drawing.Size(79, 35);
            this.SuaLCS.TabIndex = 12;
            this.SuaLCS.Text = "Sửa";
            this.SuaLCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaLCS.UseVisualStyleBackColor = false;
            // 
            // dtgvCPDN
            // 
            this.dtgvCPDN.AllowUserToAddRows = false;
            this.dtgvCPDN.AutoGenerateColumns = false;
            this.dtgvCPDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCPDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dtgvCPDN.DataSource = this.luongCSBindingSource;
            this.dtgvCPDN.Location = new System.Drawing.Point(9, 74);
            this.dtgvCPDN.Name = "dtgvCPDN";
            this.dtgvCPDN.ReadOnly = true;
            this.dtgvCPDN.RowHeadersWidth = 51;
            this.dtgvCPDN.RowTemplate.Height = 24;
            this.dtgvCPDN.Size = new System.Drawing.Size(492, 260);
            this.dtgvCPDN.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SttLCS";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số thứ tự";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MucCS";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mức lương cơ sở";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ngayhieuluc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày hiệu lực";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // luongCSBindingSource
            // 
            this.luongCSBindingSource.DataMember = "LuongCS";
            this.luongCSBindingSource.DataSource = this.luongCSDB;
            // 
            // luongCSDB
            // 
            this.luongCSDB.DataSetName = "LuongCSDB";
            this.luongCSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThemLCS
            // 
            this.ThemLCS.BackColor = System.Drawing.Color.Orange;
            this.ThemLCS.FlatAppearance.BorderSize = 0;
            this.ThemLCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemLCS.Image = global::Salary.Properties.Resources.add_document;
            this.ThemLCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemLCS.Location = new System.Drawing.Point(9, 33);
            this.ThemLCS.Name = "ThemLCS";
            this.ThemLCS.Size = new System.Drawing.Size(79, 35);
            this.ThemLCS.TabIndex = 10;
            this.ThemLCS.Text = "Thêm";
            this.ThemLCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemLCS.UseVisualStyleBackColor = false;
            // 
            // XoaLCS
            // 
            this.XoaLCS.BackColor = System.Drawing.Color.Orange;
            this.XoaLCS.FlatAppearance.BorderSize = 0;
            this.XoaLCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaLCS.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaLCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaLCS.Location = new System.Drawing.Point(94, 33);
            this.XoaLCS.Name = "XoaLCS";
            this.XoaLCS.Size = new System.Drawing.Size(79, 35);
            this.XoaLCS.TabIndex = 11;
            this.XoaLCS.Text = "Xóa";
            this.XoaLCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaLCS.UseVisualStyleBackColor = false;
            // 
            // luongCSTableAdapter
            // 
            this.luongCSTableAdapter.ClearBeforeFill = true;
            // 
            // LuongCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(506, 340);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LuongCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LƯƠNG CƠ SỞ";
            this.Load += new System.EventHandler(this.LuongCS_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCPDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongCSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongCSDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvCPDN;
        //private LuongCSDBTableAdapters.LuongCSTableAdapter luongCSTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn sttLCSDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn mucCSDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ngayhieulucDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SuaLCS;
        private System.Windows.Forms.Button ThemLCS;
        private System.Windows.Forms.Button XoaLCS;
        private LuongCSDB luongCSDB;
        private System.Windows.Forms.BindingSource luongCSBindingSource;
        private LuongCSDBTableAdapters.LuongCSTableAdapter luongCSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}