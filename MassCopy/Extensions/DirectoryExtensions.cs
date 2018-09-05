// ReSharper disable CheckNamespace

using System.IO;

namespace MassCopy
{
	public static class DirectoryExtensions
	{
		/// <summary>
		/// Creates specified directory if it does not already exist.
		/// </summary>
		/// <param name="path">The full or relative path to a directory.</param>
		/// <returns><seealso cref="DirectoryInfo"/> of given directory.</returns>
		public static DirectoryInfo CreateDirectoryIfNotExists(string path)
		{
			// ReSharper disable once ConvertIfStatementToReturnStatement
			if (Directory.Exists(path))
			{
				return new DirectoryInfo(path);
			}
			else
			{
				return Directory.CreateDirectory(path);
			}
		}
	}
}