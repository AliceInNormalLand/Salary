
namespace Salary
{
    partial class frmInChiTietTK2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInChiTietTK2));
            this.crystalReportViewerInSCTTK = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerInSCTTK
            // 
            this.crystalReportViewerInSCTTK.ActiveViewIndex = -1;
            this.crystalReportViewerInSCTTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerInSCTTK.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerInSCTTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerInSCTTK.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerInSCTTK.Name = "crystalReportViewerInSCTTK";
            this.crystalReportViewerInSCTTK.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerInSCTTK.TabIndex = 0;
            // 
            // frmInChiTietTK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerInSCTTK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInChiTietTK2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN SỔ CHI TIẾT TÀI KHOẢN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerInSCTTK;
    }
}