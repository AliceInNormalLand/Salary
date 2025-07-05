
namespace Salary
{
    partial class ButToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButToan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvButToan = new System.Windows.Forms.DataGridView();
            this.butToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butToanDB = new Salary.ButToanDB();
            this.butToanTableAdapter = new Salary.ButToanDBTableAdapters.ButToanTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnXemLCN = new System.Windows.Forms.Button();
            this.BtnLapBTBL = new System.Windows.Forms.Button();
            this.BtnLapBTThue = new System.Windows.Forms.Button();
            this.BtnLapBTUNC = new System.Windows.Forms.Button();
            this.BtnLapBTBH = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DtpCT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CbTKCo = new System.Windows.Forms.ComboBox();
            this.vwTK1vaTK2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vw2DB = new Salary.vw2DB();
            this.CbTKNo = new System.Windows.Forms.ComboBox();
            this.vwTK1vaTK2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwTKC1vaTKC2DB = new Salary.vwTKC1vaTKC2DB();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpBT = new System.Windows.Forms.DateTimePicker();
            this.BtnLapBTTU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vwTK1vaTK2TableAdapter = new Salary.vwTKC1vaTKC2DBTableAdapters.vwTK1vaTK2TableAdapter();
            this.vwTK1vaTK2TableAdapter1 = new Salary.vw2DBTableAdapters.vwTK1vaTK2TableAdapter();
            this.sttBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tKNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tKCoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttUNCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttBLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttTTNCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttBHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvButToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butToanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butToanDB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwTK1vaTK2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw2DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTK1vaTK2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTKC1vaTKC2DB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.dtgvButToan);
            this.groupBox1.Location = new System.Drawing.Point(0, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung bút toán";
            // 
            // dtgvButToan
            // 
            this.dtgvButToan.AllowUserToAddRows = false;
            this.dtgvButToan.AutoGenerateColumns = false;
            this.dtgvButToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvButToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttBTDataGridViewTextBoxColumn,
            this.ngaylapDataGridViewTextBoxColumn,
            this.noidungDataGridViewTextBoxColumn,
            this.tKNoDataGridViewTextBoxColumn,
            this.tKCoDataGridViewTextBoxColumn,
            this.sotienDataGridViewTextBoxColumn,
            this.maKLDataGridViewTextBoxColumn,
            this.sttUNCDataGridViewTextBoxColumn,
            this.sttBLDataGridViewTextBoxColumn,
            this.sttTTNCNDataGridViewTextBoxColumn,
            this.maTUDataGridViewTextBoxColumn,
            this.sttBHDataGridViewTextBoxColumn});
            this.dtgvButToan.DataSource = this.butToanBindingSource;
            this.dtgvButToan.Location = new System.Drawing.Point(6, 21);
            this.dtgvButToan.Name = "dtgvButToan";
            this.dtgvButToan.ReadOnly = true;
            this.dtgvButToan.RowHeadersWidth = 51;
            this.dtgvButToan.RowTemplate.Height = 24;
            this.dtgvButToan.Size = new System.Drawing.Size(1087, 386);
            this.dtgvButToan.TabIndex = 7;
            // 
            // butToanBindingSource
            // 
            this.butToanBindingSource.DataMember = "ButToan";
            this.butToanBindingSource.DataSource = this.butToanDB;
            // 
            // butToanDB
            // 
            this.butToanDB.DataSetName = "ButToanDB";
            this.butToanDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // butToanTableAdapter
            // 
            this.butToanTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.cbNam);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbThang);
            this.groupBox2.Controls.Add(this.btnXemLCN);
            this.groupBox2.Controls.Add(this.BtnLapBTBL);
            this.groupBox2.Controls.Add(this.BtnLapBTThue);
            this.groupBox2.Controls.Add(this.BtnLapBTUNC);
            this.groupBox2.Controls.Add(this.BtnLapBTBH);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.DtpBT);
            this.groupBox2.Controls.Add(this.BtnLapBTTU);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1097, 140);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết bút toán";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cbNam.Location = new System.Drawing.Point(412, 108);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(94, 24);
            this.cbNam.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tháng";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbThang.Location = new System.Drawing.Point(515, 108);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(94, 24);
            this.cbThang.TabIndex = 47;
            // 
            // btnXemLCN
            // 
            this.btnXemLCN.BackColor = System.Drawing.Color.Orange;
            this.btnXemLCN.FlatAppearance.BorderSize = 0;
            this.btnXemLCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLCN.Image = global::Salary.Properties.Resources.search;
            this.btnXemLCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLCN.Location = new System.Drawing.Point(6, 96);
            this.btnXemLCN.Name = "btnXemLCN";
            this.btnXemLCN.Size = new System.Drawing.Size(75, 28);
            this.btnXemLCN.TabIndex = 46;
            this.btnXemLCN.Text = "Xem";
            this.btnXemLCN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemLCN.UseVisualStyleBackColor = false;
            this.btnXemLCN.Click += new System.EventHandler(this.btnXemLCN_Click);
            // 
            // BtnLapBTBL
            // 
            this.BtnLapBTBL.BackColor = System.Drawing.Color.Orange;
            this.BtnLapBTBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLapBTBL.Image = ((System.Drawing.Image)(resources.GetObject("BtnLapBTBL.Image")));
            this.BtnLapBTBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapBTBL.Location = new System.Drawing.Point(6, 65);
            this.BtnLapBTBL.Name = "BtnLapBTBL";
            this.BtnLapBTBL.Size = new System.Drawing.Size(75, 28);
            this.BtnLapBTBL.TabIndex = 45;
            this.BtnLapBTBL.Text = "Tạo";
            this.BtnLapBTBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLapBTBL.UseVisualStyleBackColor = false;
            this.BtnLapBTBL.Visible = false;
            this.BtnLapBTBL.Click += new System.EventHandler(this.BtnLapBTBL_Click);
            // 
            // BtnLapBTThue
            // 
            this.BtnLapBTThue.BackColor = System.Drawing.Color.Orange;
            this.BtnLapBTThue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLapBTThue.Image = ((System.Drawing.Image)(resources.GetObject("BtnLapBTThue.Image")));
            this.BtnLapBTThue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapBTThue.Location = new System.Drawing.Point(6, 65);
            this.BtnLapBTThue.Name = "BtnLapBTThue";
            this.BtnLapBTThue.Size = new System.Drawing.Size(75, 28);
            this.BtnLapBTThue.TabIndex = 42;
            this.BtnLapBTThue.Text = "Tạo";
            this.BtnLapBTThue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLapBTThue.UseVisualStyleBackColor = false;
            this.BtnLapBTThue.Visible = false;
            this.BtnLapBTThue.Click += new System.EventHandler(this.BtnLapBTThue_Click);
            // 
            // BtnLapBTUNC
            // 
            this.BtnLapBTUNC.BackColor = System.Drawing.Color.Orange;
            this.BtnLapBTUNC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLapBTUNC.Image = ((System.Drawing.Image)(resources.GetObject("BtnLapBTUNC.Image")));
            this.BtnLapBTUNC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapBTUNC.Location = new System.Drawing.Point(6, 65);
            this.BtnLapBTUNC.Name = "BtnLapBTUNC";
            this.BtnLapBTUNC.Size = new System.Drawing.Size(75, 28);
            this.BtnLapBTUNC.TabIndex = 44;
            this.BtnLapBTUNC.Text = "Tạo";
            this.BtnLapBTUNC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLapBTUNC.UseVisualStyleBackColor = false;
            this.BtnLapBTUNC.Visible = false;
            this.BtnLapBTUNC.Click += new System.EventHandler(this.BtnLapBTUNC_Click);
            // 
            // BtnLapBTBH
            // 
            this.BtnLapBTBH.BackColor = System.Drawing.Color.Orange;
            this.BtnLapBTBH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLapBTBH.Image = ((System.Drawing.Image)(resources.GetObject("BtnLapBTBH.Image")));
            this.BtnLapBTBH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapBTBH.Location = new System.Drawing.Point(6, 65);
            this.BtnLapBTBH.Name = "BtnLapBTBH";
            this.BtnLapBTBH.Size = new System.Drawing.Size(75, 28);
            this.BtnLapBTBH.TabIndex = 43;
            this.BtnLapBTBH.Text = "Tạo";
            this.BtnLapBTBH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLapBTBH.UseVisualStyleBackColor = false;
            this.BtnLapBTBH.Visible = false;
            this.BtnLapBTBH.Click += new System.EventHandler(this.BtnLapBTBH_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtpCT);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CbTKCo);
            this.groupBox3.Controls.Add(this.CbTKNo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(615, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 115);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lấy dữ liệu";
            // 
            // DtpCT
            // 
            this.DtpCT.Location = new System.Drawing.Point(257, 39);
            this.DtpCT.Name = "DtpCT";
            this.DtpCT.Size = new System.Drawing.Size(200, 22);
            this.DtpCT.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(334, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ngày lập chứng từ";
            // 
            // CbTKCo
            // 
            this.CbTKCo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwTK1vaTK2BindingSource1, "CombinedColumn", true));
            this.CbTKCo.DataSource = this.vwTK1vaTK2BindingSource1;
            this.CbTKCo.DisplayMember = "CombinedColumn";
            this.CbTKCo.FormattingEnabled = true;
            this.CbTKCo.Location = new System.Drawing.Point(327, 79);
            this.CbTKCo.Name = "CbTKCo";
            this.CbTKCo.Size = new System.Drawing.Size(130, 24);
            this.CbTKCo.TabIndex = 52;
            this.CbTKCo.ValueMember = "CombinedColumn";
            // 
            // vwTK1vaTK2BindingSource1
            // 
            this.vwTK1vaTK2BindingSource1.DataMember = "vwTK1vaTK2";
            this.vwTK1vaTK2BindingSource1.DataSource = this.vw2DB;
            // 
            // vw2DB
            // 
            this.vw2DB.DataSetName = "vw2DB";
            this.vw2DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CbTKNo
            // 
            this.CbTKNo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwTK1vaTK2BindingSource, "CombinedColumn", true));
            this.CbTKNo.DataSource = this.vwTK1vaTK2BindingSource;
            this.CbTKNo.DisplayMember = "CombinedColumn";
            this.CbTKNo.FormattingEnabled = true;
            this.CbTKNo.Location = new System.Drawing.Point(89, 79);
            this.CbTKNo.Name = "CbTKNo";
            this.CbTKNo.Size = new System.Drawing.Size(130, 24);
            this.CbTKNo.TabIndex = 50;
            this.CbTKNo.ValueMember = "CombinedColumn";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(10, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "TK Nợ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(249, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "TK Có";
            // 
            // DtpBT
            // 
            this.DtpBT.Location = new System.Drawing.Point(6, 35);
            this.DtpBT.Name = "DtpBT";
            this.DtpBT.Size = new System.Drawing.Size(200, 22);
            this.DtpBT.TabIndex = 40;
            // 
            // BtnLapBTTU
            // 
            this.BtnLapBTTU.BackColor = System.Drawing.Color.Orange;
            this.BtnLapBTTU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLapBTTU.Image = ((System.Drawing.Image)(resources.GetObject("BtnLapBTTU.Image")));
            this.BtnLapBTTU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLapBTTU.Location = new System.Drawing.Point(6, 65);
            this.BtnLapBTTU.Name = "BtnLapBTTU";
            this.BtnLapBTTU.Size = new System.Drawing.Size(75, 28);
            this.BtnLapBTTU.TabIndex = 33;
            this.BtnLapBTTU.Text = "Tạo";
            this.BtnLapBTTU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLapBTTU.UseVisualStyleBackColor = false;
            this.BtnLapBTTU.Visible = false;
            this.BtnLapBTTU.Click += new System.EventHandler(this.BtnLapBTTU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày lập";
            // 
            // vwTK1vaTK2TableAdapter
            // 
            this.vwTK1vaTK2TableAdapter.ClearBeforeFill = true;
            // 
            // vwTK1vaTK2TableAdapter1
            // 
            this.vwTK1vaTK2TableAdapter1.ClearBeforeFill = true;
            // 
            // sttBTDataGridViewTextBoxColumn
            // 
            this.sttBTDataGridViewTextBoxColumn.DataPropertyName = "SttBT";
            this.sttBTDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sttBTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttBTDataGridViewTextBoxColumn.Name = "sttBTDataGridViewTextBoxColumn";
            this.sttBTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttBTDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaylapDataGridViewTextBoxColumn
            // 
            this.ngaylapDataGridViewTextBoxColumn.DataPropertyName = "Ngaylap";
            this.ngaylapDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.ngaylapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaylapDataGridViewTextBoxColumn.Name = "ngaylapDataGridViewTextBoxColumn";
            this.ngaylapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaylapDataGridViewTextBoxColumn.Width = 125;
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
            // tKNoDataGridViewTextBoxColumn
            // 
            this.tKNoDataGridViewTextBoxColumn.DataPropertyName = "TKNo";
            this.tKNoDataGridViewTextBoxColumn.HeaderText = "TK Nợ";
            this.tKNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tKNoDataGridViewTextBoxColumn.Name = "tKNoDataGridViewTextBoxColumn";
            this.tKNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tKNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tKCoDataGridViewTextBoxColumn
            // 
            this.tKCoDataGridViewTextBoxColumn.DataPropertyName = "TKCo";
            this.tKCoDataGridViewTextBoxColumn.HeaderText = "TK Có";
            this.tKCoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tKCoDataGridViewTextBoxColumn.Name = "tKCoDataGridViewTextBoxColumn";
            this.tKCoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tKCoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sotienDataGridViewTextBoxColumn
            // 
            this.sotienDataGridViewTextBoxColumn.DataPropertyName = "Sotien";
            this.sotienDataGridViewTextBoxColumn.HeaderText = "Số tiền";
            this.sotienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sotienDataGridViewTextBoxColumn.Name = "sotienDataGridViewTextBoxColumn";
            this.sotienDataGridViewTextBoxColumn.ReadOnly = true;
            this.sotienDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKLDataGridViewTextBoxColumn
            // 
            this.maKLDataGridViewTextBoxColumn.DataPropertyName = "MaKL";
            this.maKLDataGridViewTextBoxColumn.HeaderText = "Mã kỳ lương";
            this.maKLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKLDataGridViewTextBoxColumn.Name = "maKLDataGridViewTextBoxColumn";
            this.maKLDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKLDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttUNCDataGridViewTextBoxColumn
            // 
            this.sttUNCDataGridViewTextBoxColumn.DataPropertyName = "SttUNC";
            this.sttUNCDataGridViewTextBoxColumn.HeaderText = "STT ủy nhiệm chi";
            this.sttUNCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttUNCDataGridViewTextBoxColumn.Name = "sttUNCDataGridViewTextBoxColumn";
            this.sttUNCDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttUNCDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttBLDataGridViewTextBoxColumn
            // 
            this.sttBLDataGridViewTextBoxColumn.DataPropertyName = "SttBL";
            this.sttBLDataGridViewTextBoxColumn.HeaderText = "STT bảng lương";
            this.sttBLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttBLDataGridViewTextBoxColumn.Name = "sttBLDataGridViewTextBoxColumn";
            this.sttBLDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttBLDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttTTNCNDataGridViewTextBoxColumn
            // 
            this.sttTTNCNDataGridViewTextBoxColumn.DataPropertyName = "SttTTNCN";
            this.sttTTNCNDataGridViewTextBoxColumn.HeaderText = "STT thuế TNCN";
            this.sttTTNCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttTTNCNDataGridViewTextBoxColumn.Name = "sttTTNCNDataGridViewTextBoxColumn";
            this.sttTTNCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttTTNCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // maTUDataGridViewTextBoxColumn
            // 
            this.maTUDataGridViewTextBoxColumn.DataPropertyName = "MaTU";
            this.maTUDataGridViewTextBoxColumn.HeaderText = "Mã tạm ứng";
            this.maTUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTUDataGridViewTextBoxColumn.Name = "maTUDataGridViewTextBoxColumn";
            this.maTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTUDataGridViewTextBoxColumn.Width = 125;
            // 
            // sttBHDataGridViewTextBoxColumn
            // 
            this.sttBHDataGridViewTextBoxColumn.DataPropertyName = "SttBH";
            this.sttBHDataGridViewTextBoxColumn.HeaderText = "STT bảo hiểm";
            this.sttBHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttBHDataGridViewTextBoxColumn.Name = "sttBHDataGridViewTextBoxColumn";
            this.sttBHDataGridViewTextBoxColumn.ReadOnly = true;
            this.sttBHDataGridViewTextBoxColumn.Width = 125;
            // 
            // ButToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1103, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ButToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÚT TOÁN";
            this.Load += new System.EventHandler(this.ButToan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvButToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butToanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butToanDB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwTK1vaTK2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw2DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTK1vaTK2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTKC1vaTKC2DB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvButToan;
        private ButToanDB butToanDB;
        private System.Windows.Forms.BindingSource butToanBindingSource;
        private ButToanDBTableAdapters.ButToanTableAdapter butToanTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button BtnLapBTBL;
        public System.Windows.Forms.Button BtnLapBTThue;
        public System.Windows.Forms.Button BtnLapBTUNC;
        public System.Windows.Forms.Button BtnLapBTBH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker DtpCT;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox CbTKCo;
        public System.Windows.Forms.ComboBox CbTKNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpBT;
        public System.Windows.Forms.Button BtnLapBTTU;
        private System.Windows.Forms.Label label1;
        private vwTKC1vaTKC2DB vwTKC1vaTKC2DB;
        private System.Windows.Forms.BindingSource vwTK1vaTK2BindingSource;
        private vwTKC1vaTKC2DBTableAdapters.vwTK1vaTK2TableAdapter vwTK1vaTK2TableAdapter;
        private vw2DB vw2DB;
        private System.Windows.Forms.BindingSource vwTK1vaTK2BindingSource1;
        private vw2DBTableAdapters.vwTK1vaTK2TableAdapter vwTK1vaTK2TableAdapter1;
        private System.Windows.Forms.Button btnXemLCN;
        public System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tKNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tKCoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttUNCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttTTNCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttBHDataGridViewTextBoxColumn;
    }
}