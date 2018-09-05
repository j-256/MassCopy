using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MassCopy.Logging
{
	public sealed class Logger : IDisposable
	{
		#region Members and constructor(s)
		//private static readonly Logger instance = new Logger();
		//public static Logger Instance
		//{
		//	get { return instance; }
		//}
		// ^ Should be equivalent to below
		public static Logger Instance { get; } = new Logger();

		/// <summary>
		/// The destination for the log message.
		/// </summary>
		[Flags]
		public enum LogTarget
		{
			TextBox = 1,
			File = 2,
			Both = TextBox | File
		}

		/// <summary>
		/// The RichTextBox used to display log messages.
		/// </summary>
		public RichTextBox LogBox { get; set; }

		/// <summary>
		/// Indicates where to display/save the log message.
		/// </summary>
		private enum LogType
		{
			Info,
			Warning,
			Error
		}

		/// <summary>
		/// The datetime format in compliance with ISO 8601.
		/// </summary>
		private const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fff";

		/// <summary>
		/// Gets the current date and time as a string.
		/// </summary>
		private string CurrentDateTime => DateTime.Now.ToString(DateTimeFormat);

		// ReSharper disable InconsistentNaming
		private const string Folder = "Logs";
		private readonly string FileName = $"log-{DateTime.Now:yyyy-MM-dd}.txt";
		/// <summary>
		/// The full path to the log file, relative to executable.
		/// </summary>
		public string FileFullName => $@"{Folder}\{FileName}";

		private readonly FileStream fs;
		private readonly StreamWriter sw;
		// ReSharper enable InconsistentNaming

		private Logger()
		{
			DirectoryExtensions.CreateDirectoryIfNotExists(Folder);
			// Will create file if one does not exist, otherwise opens existing file
			fs = new FileStream(FileFullName, FileMode.Append, FileAccess.Write, FileShare.None);
			sw = new StreamWriter(fs, Encoding.UTF8);
		}

		// Explicit static constructor to tell C# compiler
		//  not to mark type as beforefieldinit
		// Enables laziness (http://csharpindepth.com/Articles/General/Singleton.aspx)
		//static Logger()
		//{
		//}
		#endregion

		private void Log(string message, LogType logType, LogTarget logTarget)
		{
			// Prepend datetime and log type
			message = $"[{CurrentDateTime}] {logType.ToString().ToUpper()}: {message}";

			if (logTarget.HasFlag(LogTarget.TextBox))
			{
				LogBox.AppendLine(message);
			}

			if (logTarget.HasFlag(LogTarget.File))
			{
				sw.WriteLine(message);

				// Flush the buffer every line, for now
				sw.Flush();
				fs.Flush();
			}
		}

		#region Public log methods
		/// <summary>
		/// Logs an informational message to the log file and/or UI text box.
		/// </summary>
		/// <param name="message">The message to log.</param>
		/// <param name="logTarget">The destination for the log message.</param>
		public void Info(string message, LogTarget logTarget = LogTarget.Both)
		{
			Log(message, LogType.Info, logTarget);
		}

		/// <summary>
		/// Logs a warning message to the log file and/or UI text box.
		/// </summary>
		/// <param name="message">The message to log.</param>
		/// <param name="logTarget">The destination for the log message.</param>
		public void Warning(string message, LogTarget logTarget = LogTarget.Both)
		{
			Log(message, LogType.Warning, logTarget);
		}

		/// <summary>
		/// Logs an error message to the log file and/or UI text box.
		/// </summary>
		/// <param name="message">The message to log.</param>
		/// <param name="logTarget">The destination for the log message.</param>
		public void Error(string message, LogTarget logTarget = LogTarget.Both)
		{
			Log(message, LogType.Error, logTarget);
		}

		/// <summary>
		/// Logs an exception to the log file and/or UI text box.
		/// </summary>
		/// <param name="e">The exception to log.</param>
		/// <param name="logTarget">The destination for the log message.</param>
		public void Error(Exception e, LogTarget logTarget = LogTarget.Both)
		{
			Log(e.ToString(), LogType.Error, logTarget);
		}

		/// <summary>
		/// Logs a message and a related exception to the log file and/or UI text box.
		/// </summary>
		/// <param name="message">The message to log.</param>
		/// <param name="e">The exception to log.</param>
		/// <param name="logTarget">The destination for the log message.</param>
		public void Error(string message, Exception e, LogTarget logTarget = LogTarget.Both)
		{
			Log(message + Environment.NewLine + e.ToString(), LogType.Error, logTarget);
		}
		#endregion

		public void Dispose()
		{
			sw?.Dispose();
			fs?.Dispose();
		}
	}
}
