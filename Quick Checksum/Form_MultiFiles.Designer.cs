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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MultiFiles));
            this.dataGridView_Files = new System.Windows.Forms.DataGridView();
            this.Column_FILENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PROGRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SHA256 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_DGVFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyMD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MD5copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MD5compareWithClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SHA1copyToClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SHA1compareWithClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copySHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SHA256copyToClipboardToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SHA256compareWithClipboardToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFindDuplicates = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteThisFileFromDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Files)).BeginInit();
            this.contextMenuStrip_DGVFiles.SuspendLayout();
            this.toolStripMainTools.SuspendLayout();
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
            this.dataGridView_Files.ContextMenuStrip = this.contextMenuStrip_DGVFiles;
            this.dataGridView_Files.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Files.Location = new System.Drawing.Point(12, 28);
            this.dataGridView_Files.Name = "dataGridView_Files";
            this.dataGridView_Files.ReadOnly = true;
            this.dataGridView_Files.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_Files.RowHeadersVisible = false;
            this.dataGridView_Files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Files.Size = new System.Drawing.Size(1264, 422);
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
            // contextMenuStrip_DGVFiles
            // 
            this.contextMenuStrip_DGVFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMD5ToolStripMenuItem,
            this.copySHA1ToolStripMenuItem,
            this.copySHA256ToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteThisFileFromDiskToolStripMenuItem});
            this.contextMenuStrip_DGVFiles.Name = "contextMenuStrip_DGVFiles";
            this.contextMenuStrip_DGVFiles.Size = new System.Drawing.Size(140, 98);
            // 
            // copyMD5ToolStripMenuItem
            // 
            this.copyMD5ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MD5copyToClipboardToolStripMenuItem,
            this.MD5compareWithClipboardToolStripMenuItem});
            this.copyMD5ToolStripMenuItem.Name = "copyMD5ToolStripMenuItem";
            this.copyMD5ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copyMD5ToolStripMenuItem.Text = "MD5";
            // 
            // MD5copyToClipboardToolStripMenuItem
            // 
            this.MD5copyToClipboardToolStripMenuItem.Name = "MD5copyToClipboardToolStripMenuItem";
            this.MD5copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.MD5copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
            this.MD5copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.MD5copyToClipboardToolStripMenuItem_Click);
            // 
            // MD5compareWithClipboardToolStripMenuItem
            // 
            this.MD5compareWithClipboardToolStripMenuItem.Name = "MD5compareWithClipboardToolStripMenuItem";
            this.MD5compareWithClipboardToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.MD5compareWithClipboardToolStripMenuItem.Text = "Compare with clipboard";
            this.MD5compareWithClipboardToolStripMenuItem.Click += new System.EventHandler(this.MD5compareWithClipboardToolStripMenuItem_Click);
            // 
            // copySHA1ToolStripMenuItem
            // 
            this.copySHA1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SHA1copyToClipboardToolStripMenuItem1,
            this.SHA1compareWithClipboardToolStripMenuItem1});
            this.copySHA1ToolStripMenuItem.Name = "copySHA1ToolStripMenuItem";
            this.copySHA1ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copySHA1ToolStripMenuItem.Text = "SHA1";
            // 
            // SHA1copyToClipboardToolStripMenuItem1
            // 
            this.SHA1copyToClipboardToolStripMenuItem1.Name = "SHA1copyToClipboardToolStripMenuItem1";
            this.SHA1copyToClipboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.SHA1copyToClipboardToolStripMenuItem1.Text = "Copy to clipboard";
            this.SHA1copyToClipboardToolStripMenuItem1.Click += new System.EventHandler(this.SHA1copyToClipboardToolStripMenuItem_Click);
            // 
            // SHA1compareWithClipboardToolStripMenuItem1
            // 
            this.SHA1compareWithClipboardToolStripMenuItem1.Name = "SHA1compareWithClipboardToolStripMenuItem1";
            this.SHA1compareWithClipboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.SHA1compareWithClipboardToolStripMenuItem1.Text = "Compare with clipboard";
            this.SHA1compareWithClipboardToolStripMenuItem1.Click += new System.EventHandler(this.SHA1compareWithClipboardToolStripMenuItem_Click);
            // 
            // copySHA256ToolStripMenuItem
            // 
            this.copySHA256ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SHA256copyToClipboardToolStripMenuItem2,
            this.SHA256compareWithClipboardToolStripMenuItem2});
            this.copySHA256ToolStripMenuItem.Name = "copySHA256ToolStripMenuItem";
            this.copySHA256ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copySHA256ToolStripMenuItem.Text = "SHA256";
            // 
            // SHA256copyToClipboardToolStripMenuItem2
            // 
            this.SHA256copyToClipboardToolStripMenuItem2.Name = "SHA256copyToClipboardToolStripMenuItem2";
            this.SHA256copyToClipboardToolStripMenuItem2.Size = new System.Drawing.Size(202, 22);
            this.SHA256copyToClipboardToolStripMenuItem2.Text = "Copy to clipboard";
            this.SHA256copyToClipboardToolStripMenuItem2.Click += new System.EventHandler(this.SHA256copyToClipboardToolStripMenuItem_Click);
            // 
            // SHA256compareWithClipboardToolStripMenuItem2
            // 
            this.SHA256compareWithClipboardToolStripMenuItem2.Name = "SHA256compareWithClipboardToolStripMenuItem2";
            this.SHA256compareWithClipboardToolStripMenuItem2.Size = new System.Drawing.Size(202, 22);
            this.SHA256compareWithClipboardToolStripMenuItem2.Text = "Compare with clipboard";
            this.SHA256compareWithClipboardToolStripMenuItem2.Click += new System.EventHandler(this.SHA256compareWithClipboardToolStripMenuItem_Click);
            // 
            // toolStripMainTools
            // 
            this.toolStripMainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFindDuplicates,
            this.toolStripButtonClearTable,
            this.toolStripSeparator1,
            this.toolStripButtonAbout});
            this.toolStripMainTools.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainTools.Name = "toolStripMainTools";
            this.toolStripMainTools.Size = new System.Drawing.Size(1288, 25);
            this.toolStripMainTools.TabIndex = 1;
            this.toolStripMainTools.Text = "toolStrip1";
            // 
            // toolStripButtonFindDuplicates
            // 
            this.toolStripButtonFindDuplicates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindDuplicates.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFindDuplicates.Image")));
            this.toolStripButtonFindDuplicates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFindDuplicates.Name = "toolStripButtonFindDuplicates";
            this.toolStripButtonFindDuplicates.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindDuplicates.ToolTipText = "Find Dupplicates";
            this.toolStripButtonFindDuplicates.Click += new System.EventHandler(this.toolStripButtonFindDuplicates_Click);
            // 
            // toolStripButtonClearTable
            // 
            this.toolStripButtonClearTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearTable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearTable.Image")));
            this.toolStripButtonClearTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearTable.Name = "toolStripButtonClearTable";
            this.toolStripButtonClearTable.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClearTable.ToolTipText = "Clear Table";
            this.toolStripButtonClearTable.Click += new System.EventHandler(this.toolStripButtonClearTable_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAbout.ToolTipText = "About Info";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
            // 
            // deleteThisFileFromDiskToolStripMenuItem
            // 
            this.deleteThisFileFromDiskToolStripMenuItem.Name = "deleteThisFileFromDiskToolStripMenuItem";
            this.deleteThisFileFromDiskToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteThisFileFromDiskToolStripMenuItem.Text = "Delete file(s)";
            this.deleteThisFileFromDiskToolStripMenuItem.Click += new System.EventHandler(this.deleteThisFileFromDiskToolStripMenuItem_Click);
            // 
            // Form_MultiFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 462);
            this.Controls.Add(this.toolStripMainTools);
            this.Controls.Add(this.dataGridView_Files);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MultiFiles";
            this.Text = "Quick Checksum";
            this.Shown += new System.EventHandler(this.Form_MultiFiles_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Files)).EndInit();
            this.contextMenuStrip_DGVFiles.ResumeLayout(false);
            this.toolStripMainTools.ResumeLayout(false);
            this.toolStripMainTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FILENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PROGRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SHA256;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_DGVFiles;
        private System.Windows.Forms.ToolStripMenuItem copyMD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MD5copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MD5compareWithClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SHA1copyToClipboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SHA1compareWithClipboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copySHA256ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SHA256copyToClipboardToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SHA256compareWithClipboardToolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStripMainTools;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindDuplicates;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteThisFileFromDiskToolStripMenuItem;
    }
}