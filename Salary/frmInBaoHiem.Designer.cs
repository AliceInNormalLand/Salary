﻿
namespace Salary
{
    partial class frmInBaoHiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInBaoHiem));
            this.crystalReportViewerBaoHiem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerBaoHiem
            // 
            this.crystalReportViewerBaoHiem.ActiveViewIndex = -1;
            this.crystalReportViewerBaoHiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerBaoHiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerBaoHiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerBaoHiem.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerBaoHiem.Name = "crystalReportViewerBaoHiem";
            this.crystalReportViewerBaoHiem.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerBaoHiem.TabIndex = 0;
            // 
            // frmInBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerBaoHiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInBaoHiem";
            this.Text = "IN BÁO CÁO CHI PHÍ BẢO HIỂM VÀ CÔNG ĐOÀN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerBaoHiem;
    }
}