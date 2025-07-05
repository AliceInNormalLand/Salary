
namespace Salary
{
    partial class DanhmucTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhmucTK));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhMucTK = new System.Windows.Forms.DataGridView();
            this.combinedColumnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhChatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwTK1vaTK2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwTKC1vaTKC2DB = new Salary.vwTKC1vaTKC2DB();
            this.vwTK1vaTK2TableAdapter = new Salary.vwTKC1vaTKC2DBTableAdapters.vwTK1vaTK2TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMucTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTK1vaTK2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTKC1vaTKC2DB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhMucTK);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 621);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH MỤC TÀI KHOẢN";
            // 
            // dtgvDanhMucTK
            // 
            this.dtgvDanhMucTK.AutoGenerateColumns = false;
            this.dtgvDanhMucTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhMucTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.combinedColumnDataGridViewTextBoxColumn,
            this.tenTKDataGridViewTextBoxColumn,
            this.tinhChatDataGridViewTextBoxColumn,
            this.loaiTKDataGridViewTextBoxColumn});
            this.dtgvDanhMucTK.DataSource = this.vwTK1vaTK2BindingSource;
            this.dtgvDanhMucTK.Location = new System.Drawing.Point(6, 21);
            this.dtgvDanhMucTK.Name = "dtgvDanhMucTK";
            this.dtgvDanhMucTK.RowHeadersWidth = 51;
            this.dtgvDanhMucTK.RowTemplate.Height = 24;
            this.dtgvDanhMucTK.Size = new System.Drawing.Size(781, 594);
            this.dtgvDanhMucTK.TabIndex = 0;
            // 
            // combinedColumnDataGridViewTextBoxColumn
            // 
            this.combinedColumnDataGridViewTextBoxColumn.DataPropertyName = "CombinedColumn";
            this.combinedColumnDataGridViewTextBoxColumn.HeaderText = "Số tài khoản";
            this.combinedColumnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.combinedColumnDataGridViewTextBoxColumn.Name = "combinedColumnDataGridViewTextBoxColumn";
            this.combinedColumnDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenTKDataGridViewTextBoxColumn
            // 
            this.tenTKDataGridViewTextBoxColumn.DataPropertyName = "TenTK";
            this.tenTKDataGridViewTextBoxColumn.HeaderText = "Tên tài khoản";
            this.tenTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTKDataGridViewTextBoxColumn.Name = "tenTKDataGridViewTextBoxColumn";
            this.tenTKDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhChatDataGridViewTextBoxColumn
            // 
            this.tinhChatDataGridViewTextBoxColumn.DataPropertyName = "TinhChat";
            this.tinhChatDataGridViewTextBoxColumn.HeaderText = "Tính chất";
            this.tinhChatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhChatDataGridViewTextBoxColumn.Name = "tinhChatDataGridViewTextBoxColumn";
            this.tinhChatDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaiTKDataGridViewTextBoxColumn
            // 
            this.loaiTKDataGridViewTextBoxColumn.DataPropertyName = "LoaiTK";
            this.loaiTKDataGridViewTextBoxColumn.HeaderText = "Loại tài khoản";
            this.loaiTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiTKDataGridViewTextBoxColumn.Name = "loaiTKDataGridViewTextBoxColumn";
            this.loaiTKDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwTK1vaTK2BindingSource
            // 
            this.vwTK1vaTK2BindingSource.DataMember = "vwTK1vaTK2";
            this.vwTK1vaTK2BindingSource.DataSource = this.vwTKC1vaTKC2DB;
            // 
            // vwTKC1vaTKC2DB
            // 
            this.vwTKC1vaTKC2DB.DataSetName = "vwTKC1vaTKC2DB";
            this.vwTKC1vaTKC2DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwTK1vaTK2TableAdapter
            // 
            this.vwTK1vaTK2TableAdapter.ClearBeforeFill = true;
            // 
            // DanhmucTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(794, 622);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhmucTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC TÀI KHOẢN";
            this.Load += new System.EventHandler(this.DanhmucTK_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMucTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTK1vaTK2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTKC1vaTKC2DB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDanhMucTK;
        private vwTKC1vaTKC2DB vwTKC1vaTKC2DB;
        private System.Windows.Forms.BindingSource vwTK1vaTK2BindingSource;
        private vwTKC1vaTKC2DBTableAdapters.vwTK1vaTK2TableAdapter vwTK1vaTK2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn combinedColumnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhChatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTKDataGridViewTextBoxColumn;
    }
}