namespace Quick_Checksum
{
    partial class Form_MultiFiles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MultiFiles));
            this.dataGridView_Files = new System.Windows.Forms.DataGridView();
            this.Column_FILENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PROGRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SHA256 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Files)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Files
            // 
            this.dataGridView_Files.AllowUserToAddRows = false;
            this.dataGridView_Files.AllowUserToResizeRows = false;
            this.dataGridView_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_FILENAME,
            this.Column_PROGRESS,
            this.Column_MD5,
            this.Column_SHA1,
            this.Column_SHA256});
            this.dataGridView_Files.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Files.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Files.MultiSelect = false;
            this.dataGridView_Files.Name = "dataGridView_Files";
            this.dataGridView_Files.ReadOnly = true;
            this.dataGridView_Files.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_Files.RowHeadersVisible = false;
            this.dataGridView_Files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Files.Size = new System.Drawing.Size(1264, 438);
            this.dataGridView_Files.TabIndex = 0;
            // 
            // Column_FILENAME
            // 
            this.Column_FILENAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_FILENAME.HeaderText = "FILE NAME";
            this.Column_FILENAME.Name = "Column_FILENAME";
            this.Column_FILENAME.ReadOnly = true;
            // 
            // Column_PROGRESS
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column_PROGRESS.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_PROGRESS.HeaderText = "PROGRESS";
            this.Column_PROGRESS.Name = "Column_PROGRESS";
            this.Column_PROGRESS.ReadOnly = true;
            this.Column_PROGRESS.Width = 80;
            // 
            // Column_MD5
            // 
            this.Column_MD5.HeaderText = "MD5 SUM";
            this.Column_MD5.Name = "Column_MD5";
            this.Column_MD5.ReadOnly = true;
            this.Column_MD5.Width = 225;
            // 
            // Column_SHA1
            // 
            this.Column_SHA1.HeaderText = "SHA1 SUM";
            this.Column_SHA1.Name = "Column_SHA1";
            this.Column_SHA1.ReadOnly = true;
            this.Column_SHA1.Width = 275;
            // 
            // Column_SHA256
            // 
            this.Column_SHA256.HeaderText = "SHA256 SUM";
            this.Column_SHA256.Name = "Column_SHA256";
            this.Column_SHA256.ReadOnly = true;
            this.Column_SHA256.Width = 420;
            // 
            // Form_MultiFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 462);
            this.Controls.Add(this.dataGridView_Files);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MultiFiles";
            this.Text = "Quick Checksum";
            this.Shown += new System.EventHandler(this.Form_MultiFiles_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Files)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FILENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PROGRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SHA256;
    }
}