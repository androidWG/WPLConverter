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
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.ValidHeader = new System.Windows.Forms.ColumnHeader();
            this.TitleHeader = new System.Windows.Forms.ColumnHeader();
            this.ArtistHeader = new System.Windows.Forms.ColumnHeader();
            this.FolderHeader = new System.Windows.Forms.ColumnHeader();
            this.FilenameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullpathTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FilenameTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackInfoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.EncodingTscb = new System.Windows.Forms.ToolStripComboBox();
            this.URLEscapeTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SaveFileDiag = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDiag
            // 
            this.OpenFileDiag.Filter = "All supported files|*.m3u;*.m3u8;*.wpl|MP3 URL files (*.m3u, *.m3u8)|*.m3u;*.m3u8" + "|Windows Media Player playlist files (*.wpl)|*.wpl|All files (*.*)|*.*";
            this.OpenFileDiag.Title = "Open playlist file";
            // 
            // TrackLst
            // 
            this.TrackLst.AllowColumnReorder = true;
            this.TrackLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.NameHeader, this.ValidHeader, this.TitleHeader, this.ArtistHeader, this.FolderHeader });
            this.TrackLst.FullRowSelect = true;
            this.TrackLst.GridLines = true;
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
            this.NameHeader.Width = 120;
            // 
            // ValidHeader
            // 
            this.ValidHeader.Text = "Valid";
            this.ValidHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValidHeader.Width = 40;
            // 
            // TitleHeader
            // 
            this.TitleHeader.Text = "Title";
            this.TitleHeader.Width = 32;
            // 
            // ArtistHeader
            // 
            this.ArtistHeader.Text = "Artist";
            this.ArtistHeader.Width = 35;
            // 
            // FolderHeader
            // 
            this.FolderHeader.Text = "Folder";
            this.FolderHeader.Width = 200;
            // 
            // FilenameLbl
            // 
            this.FilenameLbl.AutoSize = true;
            this.FilenameLbl.Location = new System.Drawing.Point(126, 4);
            this.FilenameLbl.Name = "FilenameLbl";
            this.FilenameLbl.Size = new System.Drawing.Size(0, 13);
            this.FilenameLbl.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loaded playlist file:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FileTsmi, this.optionsToolStripMenuItem, this.HelpTsmi });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "Menu";
            // 
            // FileTsmi
            // 
            this.FileTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.OpenTsmi, this.SaveAsTsmi });
            this.FileTsmi.Name = "FileTsmi";
            this.FileTsmi.Size = new System.Drawing.Size(37, 20);
            this.FileTsmi.Text = "File";
            // 
            // OpenTsmi
            // 
            this.OpenTsmi.Name = "OpenTsmi";
            this.OpenTsmi.Size = new System.Drawing.Size(123, 22);
            this.OpenTsmi.Text = "&Open...";
            this.OpenTsmi.Click += new System.EventHandler(this.OpenTsmi_Click);
            // 
            // SaveAsTsmi
            // 
            this.SaveAsTsmi.Name = "SaveAsTsmi";
            this.SaveAsTsmi.Size = new System.Drawing.Size(123, 22);
            this.SaveAsTsmi.Text = "&Save As...";
            this.SaveAsTsmi.Click += new System.EventHandler(this.SaveAsTsmi_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FullpathTsmi, this.toolStripSeparator4, this.toolStripMenuItem1, this.FilenameTsmi, this.toolStripSeparator2, this.toolStripMenuItem2, this.TrackInfoTsmi, this.EncodingTscb, this.URLEscapeTsmi });
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // FullpathTsmi
            // 
            this.FullpathTsmi.CheckOnClick = true;
            this.FullpathTsmi.Name = "FullpathTsmi";
            this.FullpathTsmi.Size = new System.Drawing.Size(294, 22);
            this.FullpathTsmi.Text = "Write full paths";
            this.FullpathTsmi.ToolTipText = "WPL and M3U(8) files usually contain paths to songs relative to the playlist\r\nfil" + "e path, but both support absolute paths as well. Check this option to always\r\nwr" + "ite absolute paths when saving files.";
            this.FullpathTsmi.CheckedChanged += new System.EventHandler(this.FullpathTsmi_CheckedChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(291, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(294, 22);
            this.toolStripMenuItem1.Text = "WPL only";
            // 
            // FilenameTsmi
            // 
            this.FilenameTsmi.CheckOnClick = true;
            this.FilenameTsmi.Name = "FilenameTsmi";
            this.FilenameTsmi.Size = new System.Drawing.Size(294, 22);
            this.FilenameTsmi.Text = "Use new filename as playlist name";
            this.FilenameTsmi.ToolTipText = resources.GetString("FilenameTsmi.ToolTipText");
            this.FilenameTsmi.CheckedChanged += new System.EventHandler(this.FilenameTsmi_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(294, 22);
            this.toolStripMenuItem2.Text = "M3U(8) only";
            // 
            // TrackInfoTsmi
            // 
            this.TrackInfoTsmi.CheckOnClick = true;
            this.TrackInfoTsmi.Name = "TrackInfoTsmi";
            this.TrackInfoTsmi.Size = new System.Drawing.Size(294, 22);
            this.TrackInfoTsmi.Text = "Write filename as track info when missing";
            this.TrackInfoTsmi.ToolTipText = resources.GetString("TrackInfoTsmi.ToolTipText");
            this.TrackInfoTsmi.CheckedChanged += new System.EventHandler(this.TrackInfoTsmi_CheckedChanged);
            // 
            // EncodingTscb
            // 
            this.EncodingTscb.Items.AddRange(new object[] { "UTF-8 (default)", "UTF-16", "UTF-32", "ASCII" });
            this.EncodingTscb.Name = "EncodingTscb";
            this.EncodingTscb.Size = new System.Drawing.Size(140, 23);
            this.EncodingTscb.Text = "Override encoding";
            this.EncodingTscb.ToolTipText = "Overrides the encoding used for M3U(8) files. Normally, \r\nM3U8 is UTF-8 only whil" + "e M3U can be any encoding. \r\nWPLConverter uses UTF-8 by default on both, but you" + " can \r\noverride this setting here.";
            this.EncodingTscb.SelectedIndexChanged += new System.EventHandler(this.EncodingTscb_SelectedIndexChanged);
            // 
            // URLEscapeTsmi
            // 
            this.URLEscapeTsmi.CheckOnClick = true;
            this.URLEscapeTsmi.Name = "URLEscapeTsmi";
            this.URLEscapeTsmi.Size = new System.Drawing.Size(294, 22);
            this.URLEscapeTsmi.Text = "URL escape paths";
            this.URLEscapeTsmi.ToolTipText = "Some programs may expect M3U(8) files with URL encoding on paths. Check this to e" + "nable URL escaping.";
            this.URLEscapeTsmi.CheckedChanged += new System.EventHandler(this.URLEscapeTsmi_CheckedChanged);
            // 
            // HelpTsmi
            // 
            this.HelpTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.gitHubToolStripMenuItem, this.aboutToolStripMenuItem });
            this.HelpTsmi.Name = "HelpTsmi";
            this.HelpTsmi.Size = new System.Drawing.Size(44, 20);
            this.HelpTsmi.Text = "Help";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
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
            this.SaveFileDiag.Filter = "Windows Media Player playlist file|*.wpl|MP3 URL file (*.m3u)|*.m3u|UTF-8 MP3 URL" + " file (*.m3u8)|*.m3u8";
            this.SaveFileDiag.Title = "Save playlist file";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilenameLbl, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 23);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.RefreshBtn);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ColumnHeader TitleHeader;
        private System.Windows.Forms.ColumnHeader ArtistHeader;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

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

