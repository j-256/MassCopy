#pragma warning disable IDE1006 // Naming Styles
using System;
using System.IO;
using System.Windows.Forms;
using static MassCopy.Program;

namespace MassCopy
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			#region Load previous settings
			if (!string.IsNullOrEmpty(Program.Settings.SourceFolder) && Directory.Exists(Program.Settings.SourceFolder))
			{
				sourceTextBox.Text = Program.Settings.SourceFolder;
			}

			if (!string.IsNullOrEmpty(Program.Settings.DestinationFolder) && Directory.Exists(Program.Settings.DestinationFolder))
			{
				destinationTextBox.Text = Program.Settings.DestinationFolder;
			}

			if (!Program.Settings.FileNames.IsNullOrEmpty())
			{
				listTextBox.Lines = Program.Settings.FileNames;
			}

			sourceRecursiveCheckBox.Checked = Program.Settings.RecursiveSearch;

			alphaNumericsCheckBox.Checked = Program.Settings.AlphaNumericOnly;
			#endregion
		}

		#region Main form
		private void mainForm_Load(object sender, EventArgs e)
		{
			Logger.LogBox = logTextBox;
			Logger.Info("--- Application started. ---");
		}

		private void mainForm_Closed(object sender, EventArgs e)
		{
			Logger.Info("--- Application closed. ---");
		}
		#endregion

		#region Multi-purpose
		private void ClearFocus(object sender, EventArgs e)
		{
			ActiveControl = null;
		}
		#endregion

		#region Source
		private void sourceBrowseBtn_Click(object sender, EventArgs e)
		{
			DialogResult selectFolderResult = sourceBrowseDialog.ShowDialog();
			if (selectFolderResult == DialogResult.OK)
			{
				string sourceFolder = sourceBrowseDialog.SelectedPath;

				Program.Settings.SourceFolder = sourceFolder;
				Program.Settings.Save();

				sourceTextBox.Text = sourceFolder;
			}
		}

		// Save changes to path only if valid, when focus is lost
		private string _previousSource;
		private void sourceTextBox_GotFocus(object sender, EventArgs e)
		{
			_previousSource = sourceTextBox.Text;
		}
		private void sourceTextBox_LostFocus(object sender, EventArgs e)
		{
			if (Directory.Exists(sourceTextBox.Text))
			{
				Program.Settings.SourceFolder = sourceTextBox.Text;
				Program.Settings.Save();
			}
			else
			{
				MessageBox.Show("Specified source folder does not exist.", "Invalid source folder!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				sourceTextBox.Text = _previousSource;
				_previousSource = null; // Probably not necessary, but may come in handy for checking where we are in the process
			}
		}

		private void sourceRecursiveCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.RecursiveSearch = sourceRecursiveCheckBox.Checked;
			Program.Settings.Save();
		}
		#endregion

		#region Destination
		private void destinationBrowseBtn_Click(object sender, EventArgs e)
		{
			DialogResult selectFolderResult = destinationBrowseDialog.ShowDialog();
			if (selectFolderResult == DialogResult.OK)
			{
				string destinationFolder = destinationBrowseDialog.SelectedPath;

				Program.Settings.DestinationFolder = destinationFolder;
				Program.Settings.Save();

				destinationTextBox.Text = destinationFolder;
			}
		}

		// Save changes to path only if valid, when focus is lost
		private string _previousDestination;
		private void destinationTextBox_GotFocus(object sender, EventArgs e)
		{
			_previousDestination = destinationTextBox.Text;
		}
		private void destinationTextBox_LostFocus(object sender, EventArgs e)
		{
			if (Directory.Exists(destinationTextBox.Text))
			{
				Program.Settings.DestinationFolder = destinationTextBox.Text;
				Program.Settings.Save();
			}
			else
			{
				MessageBox.Show("Specified destination folder does not exist.", "Invalid destination folder!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				destinationTextBox.Text = _previousDestination;
				_previousDestination = null; // Probably not necessary, but may come in handy for checking where we are in the process
			}
		}
		#endregion

		#region List
		private void listTextBox_LostFocus(object sender, EventArgs e)
		{
			Program.Settings.FileNames = listTextBox.Lines;
			Program.Settings.Save();
		}

		private void listClearBtn_Click(object sender, EventArgs e)
		{
			listTextBox.Clear();
			Program.Settings.FileNames = new string[0];
			Program.Settings.Save();
		}

		private void listBrowseBtn_Click(object sender, EventArgs e)
		{
			DialogResult openFileResult = listOpenFileDialog.ShowDialog();

			if (openFileResult == DialogResult.OK)
			{
				string[] lines = File.ReadAllLines(listOpenFileDialog.FileName);
				listTextBox.Lines = lines;
				Program.Settings.FileNames = lines;
				Program.Settings.Save();
			}
		}
		#endregion

		#region Menu / Toolbar
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (AboutForm aboutPage = new AboutForm())
			{
				aboutPage.ShowDialog(this);
			}
		}
		#endregion

		#region Options
		private void alphaNumericsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Program.Settings.AlphaNumericOnly = alphaNumericsCheckBox.Checked;
			Program.Settings.Save();
		}
		#endregion

		#region Log textbox
		private void logTextBox_TextChanged(object sender, EventArgs e)
		{
			logTextBox.SelectionStart = logTextBox.TextLength;
			logTextBox.ScrollToCaret();
		}
		#endregion

		private void runButton_Click(object sender, EventArgs e)
		{
			MassCopier copier = new MassCopier();

			copier.CopyFiles();
		}
	}
}
#pragma warning restore IDE1006 // Naming Styles