using nucs.JsonSettings;

namespace MassCopy
{
	public class Settings : JsonSettings
	{
		public override string FileName { get; set; } = "config.sin";

		#region Settings

		/// <summary>
		/// Full path to source folder.
		/// </summary>
		public string SourceFolder { get; set; }

		/// <summary>
		/// Full path to destination folder.
		/// </summary>
		public string DestinationFolder { get; set; }

		/// <summary>
		/// Whether or not to search subfolders of <seealso cref="SourceFolder"/>.
		/// </summary>
		public bool RecursiveSearch { get; set; }

		/// <summary>
		/// String array of file names to search for and copy.
		/// </summary>
		public string[] FileNames { get; set; }

		#endregion

		public Settings() { }
		public Settings(string fileName) : base(fileName) { }
	}
}