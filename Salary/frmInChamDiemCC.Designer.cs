
namespace Salary
{
    partial class frmInChamDiemCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInChamDiemCC));
            this.crystalReportViewerChamDiemCC = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerChamDiemCC
            // 
            this.crystalReportViewerChamDiemCC.ActiveViewIndex = -1;
            this.crystalReportViewerChamDiemCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerChamDiemCC.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerChamDiemCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerChamDiemCC.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerChamDiemCC.Name = "crystalReportViewerChamDiemCC";
            this.crystalReportViewerChamDiemCC.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerChamDiemCC.TabIndex = 0;
            // 
            // frmInChamDiemCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerChamDiemCC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInChamDiemCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN BẢNG ĐIỂM CHUYÊN CẦN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerChamDiemCC;
    }
}