using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MassCopy.Logging
{
	public sealed class Logger : IDisposable
	{
		//private static readonly Logger instance = new Logger();
		//public static Logger Instance
		//{
		//	get { return instance; }
		//}
		// ^ Should be equivalent to below

		public static Logger Instance { get; } = new Logger();

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

		/// <summary>
		/// The RichTextBox used to display log messages.
		/// </summary>
		public RichTextBox LogBox { get; set; }

		/// <summary>
		/// The name of the log file.
		/// </summary>
		private const string LogFileName = "log.sin";

		// ReSharper disable InconsistentNaming
		private readonly FileStream fs;
		private readonly StreamWriter sw;
		// ReSharper enable InconsistentNaming

		public Logger()
		{
			// Will create file if one does not exist, otherwise opens existing file
			fs = new FileStream(LogFileName, FileMode.Append, FileAccess.Write, FileShare.None);
			sw = new StreamWriter(fs, Encoding.UTF8);
		}

		// Explicit static constructor to tell C# compiler
		//  not to mark type as beforefieldinit
		// Enables laziness (http://csharpindepth.com/Articles/General/Singleton.aspx)
		//static Logger()
		//{
		//}

		private void Log(LogType logType, string message)
		{
			message = $"[{CurrentDateTime}] {logType.ToString().ToUpperInvariant()}: {message}";
			LogBox.AppendLine(message);
			sw.WriteLine(message);
			// Flush the buffer every line, for now
			sw.Flush();
			fs.Flush();
		}

		#region Public log methods
		/// <summary>
		/// Logs an informational message to the log file and UI text box.
		/// </summary>
		/// <param name="message">The message to log.</param>
		public void Info(string message)
		{
			Log(LogType.Info, message);
		}

		/// <summary>
		/// Logs a warning message to the log file and UI text box.
		/// </summary>
		/// <param name="message">The message to log.</param>
		public void Warning(string message)
		{
			Log(LogType.Warning, message);
		}

		/// <summary>
		/// Logs an error message to the log file and UI text box.
		/// </summary>
		/// <param name="message">The message to log.</param>
		public void Error(string message)
		{
			Log(LogType.Error, message);
		}
		#endregion

		public void Dispose()
		{
			sw?.Dispose();
			fs?.Dispose();
		}
	}
}
