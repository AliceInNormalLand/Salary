
namespace Salary
{
    partial class LuongTTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuongTTV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuaLTTV = new System.Windows.Forms.Button();
            this.ThemLTTV = new System.Windows.Forms.Button();
            this.XoaLTTV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttTTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTTVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toiThieuVungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toiThieuVungDB = new Salary.ToiThieuVungDB();
            this.toiThieuVungTableAdapter = new Salary.ToiThieuVungDBTableAdapters.ToiThieuVungTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.SuaLTTV);
            this.groupBox1.Controls.Add(this.ThemLTTV);
            this.groupBox1.Controls.Add(this.XoaLTTV);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 450);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lương tối thiểu vùng";
            // 
            // SuaLTTV
            // 
            this.SuaLTTV.BackColor = System.Drawing.Color.Orange;
            this.SuaLTTV.FlatAppearance.BorderSize = 0;
            this.SuaLTTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaLTTV.Image = global::Salary.Properties.Resources.file_edit;
            this.SuaLTTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaLTTV.Location = new System.Drawing.Point(179, 33);
            this.SuaLTTV.Name = "SuaLTTV";
            this.SuaLTTV.Size = new System.Drawing.Size(79, 35);
            this.SuaLTTV.TabIndex = 15;
            this.SuaLTTV.Text = "Sửa";
            this.SuaLTTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaLTTV.UseVisualStyleBackColor = false;
            // 
            // ThemLTTV
            // 
            this.ThemLTTV.BackColor = System.Drawing.Color.Orange;
            this.ThemLTTV.FlatAppearance.BorderSize = 0;
            this.ThemLTTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemLTTV.Image = global::Salary.Properties.Resources.add_document;
            this.ThemLTTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemLTTV.Location = new System.Drawing.Point(9, 33);
            this.ThemLTTV.Name = "ThemLTTV";
            this.ThemLTTV.Size = new System.Drawing.Size(79, 35);
            this.ThemLTTV.TabIndex = 13;
            this.ThemLTTV.Text = "Thêm";
            this.ThemLTTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemLTTV.UseVisualStyleBackColor = false;
            // 
            // XoaLTTV
            // 
            this.XoaLTTV.BackColor = System.Drawing.Color.Orange;
            this.XoaLTTV.FlatAppearance.BorderSize = 0;
            this.XoaLTTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaLTTV.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaLTTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaLTTV.Location = new System.Drawing.Point(94, 33);
            this.XoaLTTV.Name = "XoaLTTV";
            this.XoaLTTV.Size = new System.Drawing.Size(79, 35);
            this.XoaLTTV.TabIndex = 14;
            this.XoaLTTV.Text = "Xóa";
            this.XoaLTTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaLTTV.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttTTVDataGridViewTextBoxColumn,
            this.tenVungDataGridViewTextBoxColumn,
            this.luongTTVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toiThieuVungBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 368);
            this.dataGridView1.TabIndex = 7;
            // 
            // sttTTVDataGridViewTextBoxColumn
            // 
            this.sttTTVDataGridViewTextBoxColumn.DataPropertyName = "SttTTV";
            this.sttTTVDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttTTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTTVDataGridViewTextBoxColumn.Name = "sttTTVDataGridViewTextBoxColumn";
            this.sttTTVDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTTVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenVungDataGridViewTextBoxColumn
            // 
            this.tenVungDataGridViewTextBoxColumn.DataPropertyName = "TenVung";
            this.tenVungDataGridViewTextBoxColumn.HeaderText = "Tên vùng";
            this.tenVungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenVungDataGridViewTextBoxColumn.Name = "tenVungDataGridViewTextBoxColumn";
            this.tenVungDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenVungDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongTTVDataGridViewTextBoxColumn
            // 
            this.luongTTVDataGridViewTextBoxColumn.DataPropertyName = "LuongTTV";
            this.luongTTVDataGridViewTextBoxColumn.HeaderText = "Mức lương ";
            this.luongTTVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongTTVDataGridViewTextBoxColumn.Name = "luongTTVDataGridViewTextBoxColumn";
            this.luongTTVDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongTTVDataGridViewTextBoxColumn.Width = 125;
            // 
            // toiThieuVungBindingSource
            // 
            this.toiThieuVungBindingSource.DataMember = "ToiThieuVung";
            this.toiThieuVungBindingSource.DataSource = this.toiThieuVungDB;
            // 
            // toiThieuVungDB
            // 
            this.toiThieuVungDB.DataSetName = "ToiThieuVungDB";
            this.toiThieuVungDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toiThieuVungTableAdapter
            // 
            this.toiThieuVungTableAdapter.ClearBeforeFill = true;
            // 
            // LuongTTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LuongTTV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LƯƠNG TỐI THIỂU VÙNG";
            this.Load += new System.EventHandler(this.LuongTTV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiThieuVungDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ToiThieuVungDB toiThieuVungDB;
        private System.Windows.Forms.BindingSource toiThieuVungBindingSource;
        private ToiThieuVungDBTableAdapters.ToiThieuVungTableAdapter toiThieuVungTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTTVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SuaLTTV;
        private System.Windows.Forms.Button ThemLTTV;
        private System.Windows.Forms.Button XoaLTTV;
    }
}