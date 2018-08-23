namespace MassCopy
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.attributionRichTextBox = new MassCopy.CustomControls.ReadOnlyRichTextBox();
			this.SuspendLayout();
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Location = new System.Drawing.Point(26, 9);
			this.copyrightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(390, 20);
			this.copyrightLabel.TabIndex = 0;
			this.copyrightLabel.Text = "Copyright © 2018 Aegis Technologies, James Klein";
			// 
			// attributionRichTextBox
			// 
			this.attributionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.attributionRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.attributionRichTextBox.Location = new System.Drawing.Point(58, 43);
			this.attributionRichTextBox.Name = "attributionRichTextBox";
			this.attributionRichTextBox.ReadOnly = true;
			this.attributionRichTextBox.Size = new System.Drawing.Size(345, 31);
			this.attributionRichTextBox.TabIndex = 2;
			this.attributionRichTextBox.Text = "Icon made by Freepik from www.flaticon.com";
			// 
			// AboutForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(387, 69);
			this.Controls.Add(this.attributionRichTextBox);
			this.Controls.Add(this.copyrightLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MassCopy - About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label copyrightLabel;
		private MassCopy.CustomControls.ReadOnlyRichTextBox attributionRichTextBox;
	}
}