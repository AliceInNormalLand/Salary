
namespace Salary
{
    partial class frmInBangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInBangLuong));
            this.crystalReportViewerBaoCaoLuong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerBaoCaoLuong
            // 
            this.crystalReportViewerBaoCaoLuong.ActiveViewIndex = -1;
            this.crystalReportViewerBaoCaoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerBaoCaoLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerBaoCaoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerBaoCaoLuong.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerBaoCaoLuong.Name = "crystalReportViewerBaoCaoLuong";
            this.crystalReportViewerBaoCaoLuong.Size = new System.Drawing.Size(1069, 567);
            this.crystalReportViewerBaoCaoLuong.TabIndex = 0;
            // 
            // frmInBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 567);
            this.Controls.Add(this.crystalReportViewerBaoCaoLuong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInBangLuong";
            this.Text = "IN BẢNG LƯƠNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerBaoCaoLuong;
    }
}