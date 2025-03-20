namespace WPLConverter
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.OpenFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.TrackLst = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FolderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilenameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SaveFileDiag = new System.Windows.Forms.SaveFileDialog();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullpathTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.FilenameTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackInfoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.EncodingTscb = new System.Windows.Forms.ToolStripComboBox();
            this.URLEscapeTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDiag
            // 
            this.OpenFileDiag.Filter = "All supported files|*.m3u;*.m3u8;*.wpl|MP3 URL files (*.m3u, *.m3u8)|*.m3u;*.m3u8" +
    "|Windows Media Player playlist files (*.wpl)|*.wpl|All files (*.*)|*.*";
            this.OpenFileDiag.Title = "Open Playlist File";
            // 
            // TrackLst
            // 
            this.TrackLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.FolderHeader,
            this.ValidHeader});
            this.TrackLst.HideSelection = false;
            this.TrackLst.Location = new System.Drawing.Point(12, 60);
            this.TrackLst.Name = "TrackLst";
            this.TrackLst.Size = new System.Drawing.Size(538, 433);
            this.TrackLst.TabIndex = 6;
            this.TrackLst.UseCompatibleStateImageBehavior = false;
            this.TrackLst.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 253;
            // 
            // FolderHeader
            // 
            this.FolderHeader.Text = "Folder";
            this.FolderHeader.Width = 208;
            // 
            // ValidHeader
            // 
            this.ValidHeader.Text = "Valid";
            // 
            // FilenameLbl
            // 
            this.FilenameLbl.AutoSize = true;
            this.FilenameLbl.Location = new System.Drawing.Point(71, 33);
            this.FilenameLbl.Name = "FilenameLbl";
            this.FilenameLbl.Size = new System.Drawing.Size(0, 13);
            this.FilenameLbl.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loaded:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTsmi,
            this.optionsToolStripMenuItem,
            this.HelpTsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileTsmi
            // 
            this.FileTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTsmi,
            this.SaveAsTsmi});
            this.FileTsmi.Name = "FileTsmi";
            this.FileTsmi.Size = new System.Drawing.Size(37, 20);
            this.FileTsmi.Text = "File";
            // 
            // OpenTsmi
            // 
            this.OpenTsmi.Name = "OpenTsmi";
            this.OpenTsmi.Size = new System.Drawing.Size(180, 22);
            this.OpenTsmi.Text = "&Open...";
            this.OpenTsmi.Click += new System.EventHandler(this.OpenTsmi_Click);
            // 
            // SaveAsTsmi
            // 
            this.SaveAsTsmi.Name = "SaveAsTsmi";
            this.SaveAsTsmi.Size = new System.Drawing.Size(180, 22);
            this.SaveAsTsmi.Text = "&Save As...";
            this.SaveAsTsmi.Click += new System.EventHandler(this.SaveAsTsmi_Click);
            // 
            // HelpTsmi
            // 
            this.HelpTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.HelpTsmi.Name = "HelpTsmi";
            this.HelpTsmi.Size = new System.Drawing.Size(44, 20);
            this.HelpTsmi.Text = "&Help";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "WPLConverter v1.0";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.Location = new System.Drawing.Point(475, 28);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 11;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SaveFileDiag
            // 
            this.SaveFileDiag.Filter = "Windows Media Player playlist file|*.wpl|MP3 URL file (*.m3u)|*.m3u|UTF-8 MP3 URL" +
    " file (*.m3u8)|*.m3u8";
            this.SaveFileDiag.Title = "Save Playlist File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullpathTsmi,
            this.toolStripSeparator4,
            this.toolStripMenuItem1,
            this.FilenameTsmi,
            this.toolStripSeparator2,
            this.toolStripMenuItem2,
            this.TrackInfoTsmi,
            this.EncodingTscb,
            this.URLEscapeTsmi});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // FullpathTsmi
            // 
            this.FullpathTsmi.CheckOnClick = true;
            this.FullpathTsmi.Name = "FullpathTsmi";
            this.FullpathTsmi.Size = new System.Drawing.Size(254, 22);
            this.FullpathTsmi.Text = "Write full paths";
            this.FullpathTsmi.CheckedChanged += new System.EventHandler(this.FullpathTsmi_CheckedChanged);
            // 
            // FilenameTsmi
            // 
            this.FilenameTsmi.CheckOnClick = true;
            this.FilenameTsmi.Name = "FilenameTsmi";
            this.FilenameTsmi.Size = new System.Drawing.Size(254, 22);
            this.FilenameTsmi.Text = "Use new filename as playlist name";
            this.FilenameTsmi.ToolTipText = resources.GetString("FilenameTsmi.ToolTipText");
            this.FilenameTsmi.CheckedChanged += new System.EventHandler(this.FilenameTsmi_CheckedChanged);
            // 
            // TrackInfoTsmi
            // 
            this.TrackInfoTsmi.CheckOnClick = true;
            this.TrackInfoTsmi.Name = "TrackInfoTsmi";
            this.TrackInfoTsmi.Size = new System.Drawing.Size(254, 22);
            this.TrackInfoTsmi.Text = "Write filename as track info";
            this.TrackInfoTsmi.ToolTipText = resources.GetString("TrackInfoTsmi.ToolTipText");
            this.TrackInfoTsmi.CheckedChanged += new System.EventHandler(this.TrackInfoTsmi_CheckedChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 22);
            this.toolStripMenuItem1.Text = "WPL only";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(254, 22);
            this.toolStripMenuItem2.Text = "M3U only";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(251, 6);
            // 
            // EncodingTscb
            // 
            this.EncodingTscb.Items.AddRange(new object[] {
            "UTF-8 (default)",
            "UTF-16",
            "UTF-32",
            "ASCII"});
            this.EncodingTscb.Name = "EncodingTscb";
            this.EncodingTscb.Size = new System.Drawing.Size(121, 23);
            this.EncodingTscb.Text = "Override encoding";
            this.EncodingTscb.ToolTipText = "Overrides the encoding used for M3U(8) files. Normally, M3U8 is UTF-8 only while " +
    "M3U \r\ncan be any encoding. WPLConverter uses UTF-8 by default on both, but you c" +
    "an override \r\nthis setting here.";
            this.EncodingTscb.SelectedIndexChanged += new System.EventHandler(this.EncodingTscb_SelectedIndexChanged);
            // 
            // URLEscapeTsmi
            // 
            this.URLEscapeTsmi.CheckOnClick = true;
            this.URLEscapeTsmi.Name = "URLEscapeTsmi";
            this.URLEscapeTsmi.Size = new System.Drawing.Size(254, 22);
            this.URLEscapeTsmi.Text = "URL escape paths";
            this.URLEscapeTsmi.ToolTipText = "Some prgrams may expect M3U(8) files with URL encoding on paths.\r\nCheck this to e" +
    "nable URL escaping.";
            this.URLEscapeTsmi.CheckedChanged += new System.EventHandler(this.URLEscapeTsmi_CheckedChanged);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 505);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilenameLbl);
            this.Controls.Add(this.TrackLst);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WPLConverter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileDiag;
        private System.Windows.Forms.ListView TrackLst;
        private System.Windows.Forms.Label FilenameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader FolderHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileTsmi;
        private System.Windows.Forms.ToolStripMenuItem OpenTsmi;
        private System.Windows.Forms.ToolStripMenuItem SaveAsTsmi;
        private System.Windows.Forms.ToolStripMenuItem HelpTsmi;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ValidHeader;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.SaveFileDialog SaveFileDiag;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullpathTsmi;
        private System.Windows.Forms.ToolStripMenuItem FilenameTsmi;
        private System.Windows.Forms.ToolStripMenuItem TrackInfoTsmi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox EncodingTscb;
        private System.Windows.Forms.ToolStripMenuItem URLEscapeTsmi;
    }
}

