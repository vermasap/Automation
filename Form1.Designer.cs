
namespace WindowsDownload
{
    partial class Form1
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
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnPath = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.LblProgress = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(202, 94);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(314, 20);
            this.TxtUrl.TabIndex = 0;
            // 
            // BtnDownload
            // 
            this.BtnDownload.Location = new System.Drawing.Point(522, 94);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(75, 20);
            this.BtnDownload.TabIndex = 1;
            this.BtnDownload.Text = "Download";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(304, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(138, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "File Downloader Application";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(57, 97);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(139, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Enter URL to Download File";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(107, 179);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Download Path : ";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.FolderBrowserDialog1_HelpRequest_1);
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(522, 176);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(75, 20);
            this.BtnPath.TabIndex = 6;
            this.BtnPath.Text = "Select Path";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.Button1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // TxtPath
            // 
            this.TxtPath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtPath.Enabled = false;
            this.TxtPath.Location = new System.Drawing.Point(202, 176);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(314, 20);
            this.TxtPath.TabIndex = 7;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(299, 306);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(108, 23);
            this.ProgressBar1.TabIndex = 8;
            this.ProgressBar1.Visible = false;
            this.ProgressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // LblProgress
            // 
            this.LblProgress.AutoSize = true;
            this.LblProgress.Location = new System.Drawing.Point(296, 273);
            this.LblProgress.Name = "LblProgress";
            this.LblProgress.Size = new System.Drawing.Size(111, 13);
            this.LblProgress.TabIndex = 9;
            this.LblProgress.Text = "Download In Progress";
            this.LblProgress.Visible = false;
            this.LblProgress.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(332, 359);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(0, 13);
            this.lblDownload.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.LblProgress);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.BtnPath);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.TxtUrl);
            this.Name = "Form1";
            this.Text = "Basic File Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnPath;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Label LblProgress;
        private System.Windows.Forms.Label lblDownload;
    }
}

