
namespace Salary
{
    partial class Phongban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phongban));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuaPB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongBanDB = new Salary.PhongBanDB();
            this.ThemPB = new System.Windows.Forms.Button();
            this.XoaPB = new System.Windows.Forms.Button();
            this.phongbanTableAdapter = new Salary.PhongBanDBTableAdapters.PhongbanTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.SuaPB);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.ThemPB);
            this.groupBox1.Controls.Add(this.XoaPB);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 448);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng ban";
            // 
            // SuaPB
            // 
            this.SuaPB.BackColor = System.Drawing.Color.Orange;
            this.SuaPB.FlatAppearance.BorderSize = 0;
            this.SuaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaPB.Image = global::Salary.Properties.Resources.file_edit;
            this.SuaPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaPB.Location = new System.Drawing.Point(179, 33);
            this.SuaPB.Name = "SuaPB";
            this.SuaPB.Size = new System.Drawing.Size(79, 35);
            this.SuaPB.TabIndex = 6;
            this.SuaPB.Text = "Sửa";
            this.SuaPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaPB.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttPBDataGridViewTextBoxColumn,
            this.maPBDataGridViewTextBoxColumn,
            this.tenPBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phongbanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 368);
            this.dataGridView1.TabIndex = 7;
            // 
            // sttPBDataGridViewTextBoxColumn
            // 
            this.sttPBDataGridViewTextBoxColumn.DataPropertyName = "SttPB";
            this.sttPBDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttPBDataGridViewTextBoxColumn.Name = "sttPBDataGridViewTextBoxColumn";
            this.sttPBDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "Mã phòng ban";
            this.maPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenPBDataGridViewTextBoxColumn
            // 
            this.tenPBDataGridViewTextBoxColumn.DataPropertyName = "TenPB";
            this.tenPBDataGridViewTextBoxColumn.HeaderText = "Tên phòng ban";
            this.tenPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenPBDataGridViewTextBoxColumn.Name = "tenPBDataGridViewTextBoxColumn";
            this.tenPBDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongbanBindingSource
            // 
            this.phongbanBindingSource.DataMember = "Phongban";
            this.phongbanBindingSource.DataSource = this.phongBanDB;
            // 
            // phongBanDB
            // 
            this.phongBanDB.DataSetName = "PhongBanDB";
            this.phongBanDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThemPB
            // 
            this.ThemPB.BackColor = System.Drawing.Color.Orange;
            this.ThemPB.FlatAppearance.BorderSize = 0;
            this.ThemPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemPB.Image = global::Salary.Properties.Resources.add_document;
            this.ThemPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemPB.Location = new System.Drawing.Point(9, 33);
            this.ThemPB.Name = "ThemPB";
            this.ThemPB.Size = new System.Drawing.Size(79, 35);
            this.ThemPB.TabIndex = 4;
            this.ThemPB.Text = "Thêm";
            this.ThemPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemPB.UseVisualStyleBackColor = false;
            // 
            // XoaPB
            // 
            this.XoaPB.BackColor = System.Drawing.Color.Orange;
            this.XoaPB.FlatAppearance.BorderSize = 0;
            this.XoaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaPB.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaPB.Location = new System.Drawing.Point(94, 33);
            this.XoaPB.Name = "XoaPB";
            this.XoaPB.Size = new System.Drawing.Size(79, 35);
            this.XoaPB.TabIndex = 5;
            this.XoaPB.Text = "Xóa";
            this.XoaPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaPB.UseVisualStyleBackColor = false;
            // 
            // phongbanTableAdapter
            // 
            this.phongbanTableAdapter.ClearBeforeFill = true;
            // 
            // Phongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Phongban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÒNG BAN";
            this.Load += new System.EventHandler(this.Phongban_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PhongBanDB phongBanDB;
        private System.Windows.Forms.BindingSource phongbanBindingSource;
        private PhongBanDBTableAdapters.PhongbanTableAdapter phongbanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SuaPB;
        private System.Windows.Forms.Button ThemPB;
        private System.Windows.Forms.Button XoaPB;
    }
}