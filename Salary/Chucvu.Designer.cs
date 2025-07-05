
namespace Salary
{
    partial class Chucvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chucvu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuaCV = new System.Windows.Forms.Button();
            this.ThemCV = new System.Windows.Forms.Button();
            this.XoaCV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucVuDB = new Salary.ChucVuDB();
            this.chucVuTableAdapter = new Salary.ChucVuDBTableAdapters.ChucVuTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.SuaCV);
            this.groupBox1.Controls.Add(this.ThemCV);
            this.groupBox1.Controls.Add(this.XoaCV);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // SuaCV
            // 
            this.SuaCV.BackColor = System.Drawing.Color.Orange;
            this.SuaCV.FlatAppearance.BorderSize = 0;
            this.SuaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaCV.Image = global::Salary.Properties.Resources.file_edit;
            this.SuaCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaCV.Location = new System.Drawing.Point(178, 33);
            this.SuaCV.Name = "SuaCV";
            this.SuaCV.Size = new System.Drawing.Size(79, 35);
            this.SuaCV.TabIndex = 10;
            this.SuaCV.Text = "Sửa";
            this.SuaCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaCV.UseVisualStyleBackColor = false;
            this.SuaCV.Click += new System.EventHandler(this.SuaCV_Click);
            // 
            // ThemCV
            // 
            this.ThemCV.BackColor = System.Drawing.Color.Orange;
            this.ThemCV.FlatAppearance.BorderSize = 0;
            this.ThemCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemCV.Image = global::Salary.Properties.Resources.add_document;
            this.ThemCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemCV.Location = new System.Drawing.Point(8, 33);
            this.ThemCV.Name = "ThemCV";
            this.ThemCV.Size = new System.Drawing.Size(79, 35);
            this.ThemCV.TabIndex = 8;
            this.ThemCV.Text = "Thêm";
            this.ThemCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemCV.UseVisualStyleBackColor = false;
            this.ThemCV.Click += new System.EventHandler(this.ThemCV_Click);
            // 
            // XoaCV
            // 
            this.XoaCV.BackColor = System.Drawing.Color.Orange;
            this.XoaCV.FlatAppearance.BorderSize = 0;
            this.XoaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaCV.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaCV.Location = new System.Drawing.Point(93, 33);
            this.XoaCV.Name = "XoaCV";
            this.XoaCV.Size = new System.Drawing.Size(79, 35);
            this.XoaCV.TabIndex = 9;
            this.XoaCV.Text = "Xóa";
            this.XoaCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaCV.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttCVDataGridViewTextBoxColumn,
            this.maCVDataGridViewTextBoxColumn,
            this.tenCVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chucVuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(489, 368);
            this.dataGridView1.TabIndex = 7;
            // 
            // sttCVDataGridViewTextBoxColumn
            // 
            this.sttCVDataGridViewTextBoxColumn.DataPropertyName = "SttCV";
            this.sttCVDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttCVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttCVDataGridViewTextBoxColumn.Name = "sttCVDataGridViewTextBoxColumn";
            this.sttCVDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttCVDataGridViewTextBoxColumn.Width = 125;
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "MaCV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "Mã chức vụ";
            this.maCVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            this.maCVDataGridViewTextBoxColumn.ReadOnly = true;
            this.maCVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenCVDataGridViewTextBoxColumn
            // 
            this.tenCVDataGridViewTextBoxColumn.DataPropertyName = "TenCV";
            this.tenCVDataGridViewTextBoxColumn.HeaderText = "Tên chức vụ";
            this.tenCVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenCVDataGridViewTextBoxColumn.Name = "tenCVDataGridViewTextBoxColumn";
            this.tenCVDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenCVDataGridViewTextBoxColumn.Width = 125;
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataMember = "ChucVu";
            this.chucVuBindingSource.DataSource = this.chucVuDB;
            // 
            // chucVuDB
            // 
            this.chucVuDB.DataSetName = "ChucVuDB";
            this.chucVuDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chucVuTableAdapter
            // 
            this.chucVuTableAdapter.ClearBeforeFill = true;
            // 
            // Chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 447);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chucvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỨC VỤ";
            this.Load += new System.EventHandler(this.Chucvu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ChucVuDB chucVuDB;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private ChucVuDBTableAdapters.ChucVuTableAdapter chucVuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SuaCV;
        private System.Windows.Forms.Button ThemCV;
        private System.Windows.Forms.Button XoaCV;
    }
}