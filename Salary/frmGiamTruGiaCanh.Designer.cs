
namespace Salary
{
    partial class frmGiamTruGiaCanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiamTruGiaCanh));
            this.crystalReportViewerGiamTruGiaCanh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerGiamTruGiaCanh
            // 
            this.crystalReportViewerGiamTruGiaCanh.ActiveViewIndex = -1;
            this.crystalReportViewerGiamTruGiaCanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerGiamTruGiaCanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerGiamTruGiaCanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerGiamTruGiaCanh.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerGiamTruGiaCanh.Name = "crystalReportViewerGiamTruGiaCanh";
            this.crystalReportViewerGiamTruGiaCanh.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerGiamTruGiaCanh.TabIndex = 0;
            // 
            // frmGiamTruGiaCanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerGiamTruGiaCanh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiamTruGiaCanh";
            this.Text = "IN GIẢM TRỪ GIA CẢNH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerGiamTruGiaCanh;
    }
}