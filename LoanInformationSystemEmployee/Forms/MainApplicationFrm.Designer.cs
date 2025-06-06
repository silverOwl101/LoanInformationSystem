﻿
namespace LoanInformationSystemEmployee.Forms
{
    partial class MainApplicationFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplicationFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionReportSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyCollectionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAccountToolStripMenuItem,
            this.loanInformationToolStripMenuItem,
            this.postingToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1860, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerAccountToolStripMenuItem
            // 
            this.customerAccountToolStripMenuItem.Name = "customerAccountToolStripMenuItem";
            this.customerAccountToolStripMenuItem.Size = new System.Drawing.Size(201, 35);
            this.customerAccountToolStripMenuItem.Text = "Customer Account";
            this.customerAccountToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loanInformationToolStripMenuItem
            // 
            this.loanInformationToolStripMenuItem.Name = "loanInformationToolStripMenuItem";
            this.loanInformationToolStripMenuItem.Size = new System.Drawing.Size(184, 35);
            this.loanInformationToolStripMenuItem.Text = "Loan Information";
            this.loanInformationToolStripMenuItem.Click += new System.EventHandler(this.loanInformationToolStripMenuItem_Click);
            // 
            // postingToolStripMenuItem
            // 
            this.postingToolStripMenuItem.Name = "postingToolStripMenuItem";
            this.postingToolStripMenuItem.Size = new System.Drawing.Size(94, 35);
            this.postingToolStripMenuItem.Text = "Posting";
            this.postingToolStripMenuItem.Click += new System.EventHandler(this.postingToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionReportSummaryToolStripMenuItem,
            this.dailyCollectionReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(88, 35);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // collectionReportSummaryToolStripMenuItem
            // 
            this.collectionReportSummaryToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.collectionReportSummaryToolStripMenuItem.Name = "collectionReportSummaryToolStripMenuItem";
            this.collectionReportSummaryToolStripMenuItem.Size = new System.Drawing.Size(358, 36);
            this.collectionReportSummaryToolStripMenuItem.Text = "Collection Summary Report ";
            this.collectionReportSummaryToolStripMenuItem.Click += new System.EventHandler(this.collectionReportSummaryToolStripMenuItem_Click);
            // 
            // dailyCollectionReportToolStripMenuItem
            // 
            this.dailyCollectionReportToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.dailyCollectionReportToolStripMenuItem.Name = "dailyCollectionReportToolStripMenuItem";
            this.dailyCollectionReportToolStripMenuItem.Size = new System.Drawing.Size(358, 36);
            this.dailyCollectionReportToolStripMenuItem.Text = "Daily Collection Report";
            this.dailyCollectionReportToolStripMenuItem.Click += new System.EventHandler(this.dailyCollectionReportToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(101, 35);
            this.logoutToolStripMenuItem.Text = "Log-out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(980, 437);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainApplicationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1860, 907);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainApplicationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Information System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApplicationFrm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectionReportSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyCollectionReportToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}