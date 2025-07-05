
namespace Salary
{
    partial class QuyDinhTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuyDinhTT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuaNV = new System.Windows.Forms.Button();
            this.ThemNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttQDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thueSuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luyTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyDinhTTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quyDinhTTDB = new Salary.QuyDinhTTDB();
            this.quyDinhTTTableAdapter = new Salary.QuyDinhTTDBTableAdapters.QuyDinhTTTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyDinhTTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyDinhTTDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.SuaNV);
            this.groupBox1.Controls.Add(this.ThemNV);
            this.groupBox1.Controls.Add(this.btnXoaNV);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 448);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quy định tính thuế";
            // 
            // SuaNV
            // 
            this.SuaNV.BackColor = System.Drawing.Color.Orange;
            this.SuaNV.FlatAppearance.BorderSize = 0;
            this.SuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaNV.Image = global::Salary.Properties.Resources.file_edit;
            this.SuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuaNV.Location = new System.Drawing.Point(179, 33);
            this.SuaNV.Name = "SuaNV";
            this.SuaNV.Size = new System.Drawing.Size(79, 35);
            this.SuaNV.TabIndex = 10;
            this.SuaNV.Text = "Sửa";
            this.SuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SuaNV.UseVisualStyleBackColor = false;
            // 
            // ThemNV
            // 
            this.ThemNV.BackColor = System.Drawing.Color.Orange;
            this.ThemNV.FlatAppearance.BorderSize = 0;
            this.ThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemNV.Image = global::Salary.Properties.Resources.add_document;
            this.ThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemNV.Location = new System.Drawing.Point(9, 33);
            this.ThemNV.Name = "ThemNV";
            this.ThemNV.Size = new System.Drawing.Size(79, 35);
            this.ThemNV.TabIndex = 8;
            this.ThemNV.Text = "Thêm";
            this.ThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ThemNV.UseVisualStyleBackColor = false;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.Orange;
            this.btnXoaNV.FlatAppearance.BorderSize = 0;
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Image = global::Salary.Properties.Resources.file_minus;
            this.btnXoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNV.Location = new System.Drawing.Point(94, 33);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(79, 35);
            this.btnXoaNV.TabIndex = 9;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNV.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttQDDataGridViewTextBoxColumn,
            this.luongTTDataGridViewTextBoxColumn,
            this.luongTDDataGridViewTextBoxColumn,
            this.thueSuatDataGridViewTextBoxColumn,
            this.luyTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quyDinhTTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 368);
            this.dataGridView1.TabIndex = 7;
            // 
            // sttQDDataGridViewTextBoxColumn
            // 
            this.sttQDDataGridViewTextBoxColumn.DataPropertyName = "SttQD";
            this.sttQDDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttQDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttQDDataGridViewTextBoxColumn.Name = "sttQDDataGridViewTextBoxColumn";
            this.sttQDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttQDDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongTTDataGridViewTextBoxColumn
            // 
            this.luongTTDataGridViewTextBoxColumn.DataPropertyName = "LuongTT";
            this.luongTTDataGridViewTextBoxColumn.HeaderText = "Lương tối thiểu";
            this.luongTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongTTDataGridViewTextBoxColumn.Name = "luongTTDataGridViewTextBoxColumn";
            this.luongTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongTDDataGridViewTextBoxColumn
            // 
            this.luongTDDataGridViewTextBoxColumn.DataPropertyName = "LuongTD";
            this.luongTDDataGridViewTextBoxColumn.HeaderText = "Lương tối đa";
            this.luongTDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongTDDataGridViewTextBoxColumn.Name = "luongTDDataGridViewTextBoxColumn";
            this.luongTDDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongTDDataGridViewTextBoxColumn.Width = 125;
            // 
            // thueSuatDataGridViewTextBoxColumn
            // 
            this.thueSuatDataGridViewTextBoxColumn.DataPropertyName = "ThueSuat";
            this.thueSuatDataGridViewTextBoxColumn.HeaderText = "Thuế suất";
            this.thueSuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thueSuatDataGridViewTextBoxColumn.Name = "thueSuatDataGridViewTextBoxColumn";
            this.thueSuatDataGridViewTextBoxColumn.ReadOnly = true;
            this.thueSuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // luyTienDataGridViewTextBoxColumn
            // 
            this.luyTienDataGridViewTextBoxColumn.DataPropertyName = "LuyTien";
            this.luyTienDataGridViewTextBoxColumn.HeaderText = "Lũy tiến";
            this.luyTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luyTienDataGridViewTextBoxColumn.Name = "luyTienDataGridViewTextBoxColumn";
            this.luyTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.luyTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // quyDinhTTBindingSource
            // 
            this.quyDinhTTBindingSource.DataMember = "QuyDinhTT";
            this.quyDinhTTBindingSource.DataSource = this.quyDinhTTDB;
            // 
            // quyDinhTTDB
            // 
            this.quyDinhTTDB.DataSetName = "QuyDinhTTDB";
            this.quyDinhTTDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quyDinhTTTableAdapter
            // 
            this.quyDinhTTTableAdapter.ClearBeforeFill = true;
            // 
            // QuyDinhTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuyDinhTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUY ĐỊNH TÍNH THUẾ";
            this.Load += new System.EventHandler(this.QuyDinhTT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyDinhTTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyDinhTTDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuyDinhTTDB quyDinhTTDB;
        private System.Windows.Forms.BindingSource quyDinhTTBindingSource;
        private QuyDinhTTDBTableAdapters.QuyDinhTTTableAdapter quyDinhTTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttQDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thueSuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luyTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SuaNV;
        private System.Windows.Forms.Button ThemNV;
        private System.Windows.Forms.Button btnXoaNV;
    }
}