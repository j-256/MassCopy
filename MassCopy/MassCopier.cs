using MassCopy.Logging;
using MassCopy.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MassCopy
{
	public class MassCopier
	{
		private Settings Settings { get; set; }
		private Logger Logger { get; set; }

		public MassCopier(Settings settings, Logger logger)
		{
			Settings = settings;
			Logger = logger;
		}

		private enum FailedReason
		{
			AlreadyExists,
			Other,
		}

		private class FailedCopy
		{
			public string FullName { get; set; }
			public FailedReason Reason { get; set; }

			public FailedCopy(string fullName, FailedReason reason)
			{
				FullName = fullName;
				Reason = reason;
			}
		}

		public void CopyFiles()
		{
			#region Loading settings...
			Logger.Info("Loading settings...");
			DirectoryInfo sourceDir = new DirectoryInfo(Settings.SourceFolder);
			DirectoryInfo destinationDir = new DirectoryInfo(Settings.DestinationFolder);
			bool alphaNumericOnly = Settings.AlphaNumericOnly;
			bool recursiveSearch = Settings.RecursiveSearch;
			Logger.Info("Loaded settings.");
			#endregion

			#region Building HashSet...
			Logger.Info("Building HashSet...");

			// Create hashset, filtering out spaces and special characters as necessary
			HashSet<string> list = alphaNumericOnly
				? new HashSet<string>(Program.Settings.FileNames
					.Select(n => StringFilter.ApplyFilters(n, FilterOptions.RemoveSpaces | FilterOptions.RemoveSpecialCharacters)),
						StringComparer.OrdinalIgnoreCase)
				: new HashSet<string>(Program.Settings.FileNames, StringComparer.OrdinalIgnoreCase);

			// Full names of files successfully copied from sourceDir to destinationDir
			List<string> copied = new List<string>(Program.Settings.FileNames.Length);

			// Full names of files in sourceDir but not in list
			List<string> skipped = new List<string>(Program.Settings.FileNames.Length);
			
			// Full names of files in sourceDir and list but could not be copied
			List<FailedCopy> failed = new List<FailedCopy>(Program.Settings.FileNames.Length);

			Logger.Info("Built HashSet.");
			#endregion

			#region Copying files
			Logger.Info($"Attempting to copy {{{list.Count}}} files from" +
			            $" {{{Program.Settings.SourceFolder}}} to {{{Program.Settings.DestinationFolder}}}.");
			int filesEnumerated = 0;
			foreach (FileInfo file in sourceDir.EnumerateFiles())
			{
				filesEnumerated++;

				if (list.Contains(file.Name, StringComparer.OrdinalIgnoreCase))
				{
					try
					{
						string destFile = Path.Combine(destinationDir.FullName, file.Name);

						// Skip if destination file already exists
						if (File.Exists(destFile))
						{
							Logger.Error($"Failed to copy {{{file.Name}}}. File {{{destFile}}} already exists.");
							failed.Add(new FailedCopy(file.FullName, FailedReason.AlreadyExists));
							continue;
						}

						file.CopyTo(Path.Combine(destinationDir.FullName, file.Name));
						copied.Add(file.FullName);
					}
					catch (Exception e)
					{
						Logger.Error($"Failed to copy {file.Name}.", e);
						failed.Add(new FailedCopy(file.FullName, FailedReason.Other));
					}
				}
				else
				{
					skipped.Add(file.FullName);
				}
			}

			var groups = failed.GroupBy(f => f.Reason).Select(f => new { Reason = f.Key, Count = f.Count() }).ToArray();
			string failedSection = groups.Length != 0
				? groups.Aggregate("", (current, group) => current + $", Failed ({group.Reason}): {{{group.Count}}}")
				: ", Failed: {0}";


			Logger.Info("Operation completed." + Environment.NewLine +
			           $"Of {{{filesEnumerated}}} files enumerated:" + Environment.NewLine +
			           $"Copied: {{{copied.Count}}}, Skipped: {{{skipped.Count}}}{failedSection}");
			#endregion
		}
	}
}