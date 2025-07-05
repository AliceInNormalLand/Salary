
namespace Salary
{
    partial class frmInThueTNCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInThueTNCN));
            this.crystalReportViewerThueTNCN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerThueTNCN
            // 
            this.crystalReportViewerThueTNCN.ActiveViewIndex = -1;
            this.crystalReportViewerThueTNCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerThueTNCN.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerThueTNCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerThueTNCN.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerThueTNCN.Name = "crystalReportViewerThueTNCN";
            this.crystalReportViewerThueTNCN.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerThueTNCN.TabIndex = 0;
            // 
            // frmInThueTNCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerThueTNCN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInThueTNCN";
            this.Text = "IN BÁO CÁO THUẾ THU NHẬP CÁ NHÂN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerThueTNCN;
    }
}