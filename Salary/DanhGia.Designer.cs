
namespace Salary
{
    partial class DanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhGia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuaDG = new System.Windows.Forms.Button();
            this.ThemDG = new System.Windows.Forms.Button();
            this.XoaDG = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truonghopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuthichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhGiaDB = new Salary.DanhGiaDB();
            this.danhgiaTableAdapter = new Salary.DanhGiaDBTableAdapters.DanhgiaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhgiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.SuaDG);
            this.groupBox1.Controls.Add(this.ThemDG);
            this.groupBox1.Controls.Add(this.XoaDG);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 452);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nội dung đánh giá";
            // 
            // SuaDG
            // 
            this.SuaDG.BackColor = System.Drawing.Color.Orange;
            this.SuaDG.FlatAppearance.BorderSize = 0;
            this.SuaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaDG.Image = global::Salary.Properties.Resources.file_edit;
            this.SuaDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaDG.Location = new System.Drawing.Point(179, 33);
            this.SuaDG.Name = "SuaDG";
            this.SuaDG.Size = new System.Drawing.Size(79, 35);
            this.SuaDG.TabIndex = 10;
            this.SuaDG.Text = "Sửa";
            this.SuaDG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaDG.UseVisualStyleBackColor = false;
            // 
            // ThemDG
            // 
            this.ThemDG.BackColor = System.Drawing.Color.Orange;
            this.ThemDG.FlatAppearance.BorderSize = 0;
            this.ThemDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemDG.Image = global::Salary.Properties.Resources.add_document;
            this.ThemDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemDG.Location = new System.Drawing.Point(9, 33);
            this.ThemDG.Name = "ThemDG";
            this.ThemDG.Size = new System.Drawing.Size(79, 35);
            this.ThemDG.TabIndex = 8;
            this.ThemDG.Text = "Thêm";
            this.ThemDG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemDG.UseVisualStyleBackColor = false;
            this.ThemDG.Click += new System.EventHandler(this.ThemDG_Click);
            // 
            // XoaDG
            // 
            this.XoaDG.BackColor = System.Drawing.Color.Orange;
            this.XoaDG.FlatAppearance.BorderSize = 0;
            this.XoaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaDG.Image = global::Salary.Properties.Resources.file_minus;
            this.XoaDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaDG.Location = new System.Drawing.Point(94, 33);
            this.XoaDG.Name = "XoaDG";
            this.XoaDG.Size = new System.Drawing.Size(79, 35);
            this.XoaDG.TabIndex = 9;
            this.XoaDG.Text = "Xóa";
            this.XoaDG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XoaDG.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttDGDataGridViewTextBoxColumn,
            this.noidungDataGridViewTextBoxColumn,
            this.truonghopDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.chuthichDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.danhgiaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 368);
            this.dataGridView1.TabIndex = 7;
            // 
            // sttDGDataGridViewTextBoxColumn
            // 
            this.sttDGDataGridViewTextBoxColumn.DataPropertyName = "SttDG";
            this.sttDGDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttDGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttDGDataGridViewTextBoxColumn.Name = "sttDGDataGridViewTextBoxColumn";
            this.sttDGDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttDGDataGridViewTextBoxColumn.Width = 125;
            // 
            // noidungDataGridViewTextBoxColumn
            // 
            this.noidungDataGridViewTextBoxColumn.DataPropertyName = "Noidung";
            this.noidungDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.noidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noidungDataGridViewTextBoxColumn.Name = "noidungDataGridViewTextBoxColumn";
            this.noidungDataGridViewTextBoxColumn.ReadOnly = true;
            this.noidungDataGridViewTextBoxColumn.Width = 125;
            // 
            // truonghopDataGridViewTextBoxColumn
            // 
            this.truonghopDataGridViewTextBoxColumn.DataPropertyName = "Truonghop";
            this.truonghopDataGridViewTextBoxColumn.HeaderText = "Trường hợp";
            this.truonghopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.truonghopDataGridViewTextBoxColumn.Name = "truonghopDataGridViewTextBoxColumn";
            this.truonghopDataGridViewTextBoxColumn.ReadOnly = true;
            this.truonghopDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemDataGridViewTextBoxColumn.Width = 125;
            // 
            // chuthichDataGridViewTextBoxColumn
            // 
            this.chuthichDataGridViewTextBoxColumn.DataPropertyName = "Chuthich";
            this.chuthichDataGridViewTextBoxColumn.HeaderText = "Chú thích";
            this.chuthichDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chuthichDataGridViewTextBoxColumn.Name = "chuthichDataGridViewTextBoxColumn";
            this.chuthichDataGridViewTextBoxColumn.ReadOnly = true;
            this.chuthichDataGridViewTextBoxColumn.Width = 125;
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
            // danhgiaTableAdapter
            // 
            this.danhgiaTableAdapter.ClearBeforeFill = true;
            // 
            // DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NỘI DUNG ĐÁNH GIÁ";
            this.Load += new System.EventHandler(this.DanhGia_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhgiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SuaDG;
        private System.Windows.Forms.Button ThemDG;
        private System.Windows.Forms.Button XoaDG;
        private DanhGiaDB danhGiaDB;
        private System.Windows.Forms.BindingSource danhgiaBindingSource;
        private DanhGiaDBTableAdapters.DanhgiaTableAdapter danhgiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn truonghopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuthichDataGridViewTextBoxColumn;
    }
}