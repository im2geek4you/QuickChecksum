namespace Quick_Checksum
{
    partial class Form_Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Loading));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Files = new System.Windows.Forms.Label();
            this.backgroundWorkerChecksum = new System.ComponentModel.BackgroundWorker();
            this.labelClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label_Files
            // 
            resources.ApplyResources(this.label_Files, "label_Files");
            this.label_Files.Name = "label_Files";
            // 
            // backgroundWorkerChecksum
            // 
            this.backgroundWorkerChecksum.WorkerReportsProgress = true;
            this.backgroundWorkerChecksum.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerChecksum_DoWork);
            this.backgroundWorkerChecksum.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerChecksum_ProgressChanged);
            this.backgroundWorkerChecksum.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerChecksum_RunWorkerCompleted);
            // 
            // labelClose
            // 
            resources.ApplyResources(this.labelClose, "labelClose");
            this.labelClose.Name = "labelClose";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // Form_Loading
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.label_Files);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Loading";
            this.Load += new System.EventHandler(this.Form_Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Files;
        private System.ComponentModel.BackgroundWorker backgroundWorkerChecksum;
        private System.Windows.Forms.Label labelClose;
    }
}

