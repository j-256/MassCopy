namespace MassCopy
{
	partial class MainForm
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
			// Do we need this?
			Program.Logger.Dispose();

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.sourceBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.sourceBrowseBtn = new System.Windows.Forms.Button();
			this.foldersGroupBox = new System.Windows.Forms.GroupBox();
			this.sourceRecursiveCheckBox = new System.Windows.Forms.CheckBox();
			this.sourceTextBox = new System.Windows.Forms.TextBox();
			this.destinationTextBox = new System.Windows.Forms.TextBox();
			this.destinationLabel = new System.Windows.Forms.Label();
			this.destinationBrowseBtn = new System.Windows.Forms.Button();
			this.sourceLabel = new System.Windows.Forms.Label();
			this.destinationBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.alphaNumericsCheckBox = new System.Windows.Forms.CheckBox();
			this.listOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.listBrowseBtn = new System.Windows.Forms.Button();
			this.listTextBox = new System.Windows.Forms.TextBox();
			this.listGroupBox = new System.Windows.Forms.GroupBox();
			this.listClearBtn = new System.Windows.Forms.Button();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsGroupBox = new System.Windows.Forms.GroupBox();
			this.logTextBox = new System.Windows.Forms.RichTextBox();
			this.logGroupBox = new System.Windows.Forms.GroupBox();
			this.foldersGroupBox.SuspendLayout();
			this.listGroupBox.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.optionsGroupBox.SuspendLayout();
			this.logGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// sourceBrowseDialog
			// 
			this.sourceBrowseDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// sourceBrowseBtn
			// 
			this.sourceBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceBrowseBtn.AutoSize = true;
			this.sourceBrowseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.sourceBrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sourceBrowseBtn.Location = new System.Drawing.Point(446, 26);
			this.sourceBrowseBtn.Margin = new System.Windows.Forms.Padding(4);
			this.sourceBrowseBtn.Name = "sourceBrowseBtn";
			this.sourceBrowseBtn.Size = new System.Drawing.Size(81, 28);
			this.sourceBrowseBtn.TabIndex = 0;
			this.sourceBrowseBtn.Text = "Browse...";
			this.sourceBrowseBtn.UseVisualStyleBackColor = true;
			this.sourceBrowseBtn.Click += new System.EventHandler(this.sourceBrowseBtn_Click);
			// 
			// foldersGroupBox
			// 
			this.foldersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.foldersGroupBox.AutoSize = true;
			this.foldersGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.foldersGroupBox.Controls.Add(this.sourceRecursiveCheckBox);
			this.foldersGroupBox.Controls.Add(this.sourceTextBox);
			this.foldersGroupBox.Controls.Add(this.destinationTextBox);
			this.foldersGroupBox.Controls.Add(this.destinationLabel);
			this.foldersGroupBox.Controls.Add(this.destinationBrowseBtn);
			this.foldersGroupBox.Controls.Add(this.sourceLabel);
			this.foldersGroupBox.Controls.Add(this.sourceBrowseBtn);
			this.foldersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.foldersGroupBox.Location = new System.Drawing.Point(487, 38);
			this.foldersGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.foldersGroupBox.Name = "foldersGroupBox";
			this.foldersGroupBox.Size = new System.Drawing.Size(543, 136);
			this.foldersGroupBox.TabIndex = 1;
			this.foldersGroupBox.TabStop = false;
			this.foldersGroupBox.Text = "Folders";
			this.foldersGroupBox.Click += new System.EventHandler(this.ClearFocus);
			// 
			// sourceRecursiveCheckBox
			// 
			this.sourceRecursiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceRecursiveCheckBox.AutoSize = true;
			this.sourceRecursiveCheckBox.Cursor = System.Windows.Forms.Cursors.Help;
			this.sourceRecursiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sourceRecursiveCheckBox.Location = new System.Drawing.Point(85, 53);
			this.sourceRecursiveCheckBox.Name = "sourceRecursiveCheckBox";
			this.sourceRecursiveCheckBox.Size = new System.Drawing.Size(147, 21);
			this.sourceRecursiveCheckBox.TabIndex = 6;
			this.sourceRecursiveCheckBox.Text = "Search recursively";
			this.toolTip.SetToolTip(this.sourceRecursiveCheckBox, "Search subfolders in addition to selected folder.");
			this.sourceRecursiveCheckBox.UseVisualStyleBackColor = true;
			this.sourceRecursiveCheckBox.CheckedChanged += new System.EventHandler(this.sourceRecursiveCheckBox_CheckedChanged);
			// 
			// sourceTextBox
			// 
			this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sourceTextBox.Location = new System.Drawing.Point(109, 28);
			this.sourceTextBox.Name = "sourceTextBox";
			this.sourceTextBox.Size = new System.Drawing.Size(330, 24);
			this.sourceTextBox.TabIndex = 5;
			this.sourceTextBox.GotFocus += new System.EventHandler(this.sourceTextBox_GotFocus);
			this.sourceTextBox.LostFocus += new System.EventHandler(this.sourceTextBox_LostFocus);
			// 
			// destinationTextBox
			// 
			this.destinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.destinationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.destinationTextBox.Location = new System.Drawing.Point(109, 84);
			this.destinationTextBox.Name = "destinationTextBox";
			this.destinationTextBox.Size = new System.Drawing.Size(330, 24);
			this.destinationTextBox.TabIndex = 4;
			this.destinationTextBox.GotFocus += new System.EventHandler(this.destinationTextBox_GotFocus);
			this.destinationTextBox.LostFocus += new System.EventHandler(this.destinationTextBox_LostFocus);
			// 
			// destinationLabel
			// 
			this.destinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.destinationLabel.Cursor = System.Windows.Forms.Cursors.Help;
			this.destinationLabel.Location = new System.Drawing.Point(16, 86);
			this.destinationLabel.Name = "destinationLabel";
			this.destinationLabel.Size = new System.Drawing.Size(94, 20);
			this.destinationLabel.TabIndex = 3;
			this.destinationLabel.Text = "Destination";
			this.toolTip.SetToolTip(this.destinationLabel, "The destination folder for copied files.");
			// 
			// destinationBrowseBtn
			// 
			this.destinationBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.destinationBrowseBtn.AutoSize = true;
			this.destinationBrowseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.destinationBrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.destinationBrowseBtn.Location = new System.Drawing.Point(446, 82);
			this.destinationBrowseBtn.Margin = new System.Windows.Forms.Padding(4);
			this.destinationBrowseBtn.Name = "destinationBrowseBtn";
			this.destinationBrowseBtn.Size = new System.Drawing.Size(81, 28);
			this.destinationBrowseBtn.TabIndex = 2;
			this.destinationBrowseBtn.Text = "Browse...";
			this.destinationBrowseBtn.UseVisualStyleBackColor = true;
			this.destinationBrowseBtn.Click += new System.EventHandler(this.destinationBrowseBtn_Click);
			// 
			// sourceLabel
			// 
			this.sourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceLabel.AutoSize = true;
			this.sourceLabel.Cursor = System.Windows.Forms.Cursors.Help;
			this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.sourceLabel.Location = new System.Drawing.Point(41, 30);
			this.sourceLabel.Name = "sourceLabel";
			this.sourceLabel.Size = new System.Drawing.Size(62, 20);
			this.sourceLabel.TabIndex = 1;
			this.sourceLabel.Text = "Source";
			this.toolTip.SetToolTip(this.sourceLabel, "The folder containing the desired files.");
			// 
			// destinationBrowseDialog
			// 
			this.destinationBrowseDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// alphaNumericsCheckBox
			// 
			this.alphaNumericsCheckBox.AutoSize = true;
			this.alphaNumericsCheckBox.Cursor = System.Windows.Forms.Cursors.Help;
			this.alphaNumericsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alphaNumericsCheckBox.Location = new System.Drawing.Point(19, 25);
			this.alphaNumericsCheckBox.Name = "alphaNumericsCheckBox";
			this.alphaNumericsCheckBox.Size = new System.Drawing.Size(158, 22);
			this.alphaNumericsCheckBox.TabIndex = 0;
			this.alphaNumericsCheckBox.Text = "Alphanumerics only";
			this.toolTip.SetToolTip(this.alphaNumericsCheckBox, resources.GetString("alphaNumericsCheckBox.ToolTip"));
			this.alphaNumericsCheckBox.UseVisualStyleBackColor = true;
			this.alphaNumericsCheckBox.CheckedChanged += new System.EventHandler(this.alphaNumericsCheckBox_CheckedChanged);
			// 
			// listOpenFileDialog
			// 
			this.listOpenFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
			// 
			// listBrowseBtn
			// 
			this.listBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.listBrowseBtn.AutoSize = true;
			this.listBrowseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.listBrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBrowseBtn.Location = new System.Drawing.Point(389, 672);
			this.listBrowseBtn.Margin = new System.Windows.Forms.Padding(4);
			this.listBrowseBtn.Name = "listBrowseBtn";
			this.listBrowseBtn.Size = new System.Drawing.Size(78, 30);
			this.listBrowseBtn.TabIndex = 6;
			this.listBrowseBtn.Text = "Import...";
			this.listBrowseBtn.UseVisualStyleBackColor = true;
			this.listBrowseBtn.Click += new System.EventHandler(this.listBrowseBtn_Click);
			// 
			// listTextBox
			// 
			this.listTextBox.Location = new System.Drawing.Point(6, 25);
			this.listTextBox.Multiline = true;
			this.listTextBox.Name = "listTextBox";
			this.listTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.listTextBox.Size = new System.Drawing.Size(461, 640);
			this.listTextBox.TabIndex = 7;
			this.listTextBox.WordWrap = false;
			this.listTextBox.LostFocus += new System.EventHandler(this.listTextBox_LostFocus);
			// 
			// listGroupBox
			// 
			this.listGroupBox.Controls.Add(this.listClearBtn);
			this.listGroupBox.Controls.Add(this.listTextBox);
			this.listGroupBox.Controls.Add(this.listBrowseBtn);
			this.listGroupBox.Location = new System.Drawing.Point(6, 38);
			this.listGroupBox.Name = "listGroupBox";
			this.listGroupBox.Size = new System.Drawing.Size(474, 709);
			this.listGroupBox.TabIndex = 8;
			this.listGroupBox.TabStop = false;
			this.listGroupBox.Text = "File List";
			this.listGroupBox.Click += new System.EventHandler(this.ClearFocus);
			// 
			// listClearBtn
			// 
			this.listClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.listClearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.listClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listClearBtn.Location = new System.Drawing.Point(7, 672);
			this.listClearBtn.Margin = new System.Windows.Forms.Padding(4);
			this.listClearBtn.Name = "listClearBtn";
			this.listClearBtn.Size = new System.Drawing.Size(78, 30);
			this.listClearBtn.TabIndex = 8;
			this.listClearBtn.Text = "Clear";
			this.listClearBtn.UseVisualStyleBackColor = true;
			this.listClearBtn.Click += new System.EventHandler(this.listClearBtn_Click);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(3, 3);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.mainMenuStrip.Size = new System.Drawing.Size(1031, 31);
			this.mainMenuStrip.TabIndex = 9;
			this.mainMenuStrip.Text = "Menu";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 27);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// optionsGroupBox
			// 
			this.optionsGroupBox.Controls.Add(this.alphaNumericsCheckBox);
			this.optionsGroupBox.Location = new System.Drawing.Point(487, 181);
			this.optionsGroupBox.Name = "optionsGroupBox";
			this.optionsGroupBox.Size = new System.Drawing.Size(543, 231);
			this.optionsGroupBox.TabIndex = 10;
			this.optionsGroupBox.TabStop = false;
			this.optionsGroupBox.Text = "Options";
			this.optionsGroupBox.Click += new System.EventHandler(this.ClearFocus);
			// 
			// logTextBox
			// 
			this.logTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.logTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logTextBox.Location = new System.Drawing.Point(6, 25);
			this.logTextBox.Name = "logTextBox";
			this.logTextBox.ReadOnly = true;
			this.logTextBox.Size = new System.Drawing.Size(531, 260);
			this.logTextBox.TabIndex = 11;
			this.logTextBox.Text = "";
			// 
			// logGroupBox
			// 
			this.logGroupBox.Controls.Add(this.logTextBox);
			this.logGroupBox.Location = new System.Drawing.Point(487, 418);
			this.logGroupBox.Name = "logGroupBox";
			this.logGroupBox.Size = new System.Drawing.Size(543, 329);
			this.logGroupBox.TabIndex = 12;
			this.logGroupBox.TabStop = false;
			this.logGroupBox.Text = "Log";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1037, 753);
			this.Controls.Add(this.logGroupBox);
			this.Controls.Add(this.optionsGroupBox);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.listGroupBox);
			this.Controls.Add(this.foldersGroupBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(3);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MassCopy";
			this.Closed += new System.EventHandler(this.mainForm_Closed);
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.Click += new System.EventHandler(this.ClearFocus);
			this.foldersGroupBox.ResumeLayout(false);
			this.foldersGroupBox.PerformLayout();
			this.listGroupBox.ResumeLayout(false);
			this.listGroupBox.PerformLayout();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.optionsGroupBox.ResumeLayout(false);
			this.optionsGroupBox.PerformLayout();
			this.logGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog sourceBrowseDialog;
		private System.Windows.Forms.Button sourceBrowseBtn;
		private System.Windows.Forms.GroupBox foldersGroupBox;
		private System.Windows.Forms.Label destinationLabel;
		private System.Windows.Forms.Button destinationBrowseBtn;
		private System.Windows.Forms.Label sourceLabel;
		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.TextBox destinationTextBox;
		private System.Windows.Forms.FolderBrowserDialog destinationBrowseDialog;
		private System.Windows.Forms.CheckBox sourceRecursiveCheckBox;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.OpenFileDialog listOpenFileDialog;
		private System.Windows.Forms.Button listBrowseBtn;
		private System.Windows.Forms.TextBox listTextBox;
		private System.Windows.Forms.GroupBox listGroupBox;
		private System.Windows.Forms.Button listClearBtn;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.GroupBox optionsGroupBox;
		private System.Windows.Forms.CheckBox alphaNumericsCheckBox;
		public System.Windows.Forms.RichTextBox logTextBox;
		private System.Windows.Forms.GroupBox logGroupBox;
	}
}