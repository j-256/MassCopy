using nucs.JsonSettings;
using System;
using System.Windows.Forms;

namespace MassCopy
{
	internal static class Program
	{
		public static Settings Settings = JsonSettings.Load<Settings>();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}