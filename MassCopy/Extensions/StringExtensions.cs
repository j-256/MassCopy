// ReSharper disable CheckNamespace

namespace MassCopy
{
	public static class StringExtensions
	{
		/// <summary>
		/// Returns a new string in which the last <paramref name="n"/> characters have been removed.
		/// </summary>
		/// <param name="str">The string from which to remove characters.</param>
		/// <param name="n">The number of characters to remove.</param>
		public static string RemoveLast(this string str, int n)
		{
			return str.Remove(str.Length - n);
		}
	}
}