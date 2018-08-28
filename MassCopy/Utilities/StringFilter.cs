using System;
using System.Text;

namespace MassCopy.Utilities
{
	[Flags]
	public enum FilterOptions
	{
		RemoveSpaces = 1,
		/// <summary>
		/// Remove all characters except alphanumerics and spaces.
		/// </summary>
		RemoveSpecialCharacters = 2,
		RemoveNumerals = 4,
		RemoveLetters = 8,
	}

	public class StringFilter
	{
		public FilterOptions FilterOptions { get; set; }

		public StringFilter(FilterOptions filterOptions)
		{
			FilterOptions = filterOptions;
		}

		public string ApplyFilters(string str)
		{
			return ApplyFilters(str, FilterOptions);
		}

		public static string ApplyFilters(string str, FilterOptions options)
		{
			StringBuilder sb = new StringBuilder(str.Length);

			foreach (char c in str)
			{
				// c == Letter
				if (c.IsLetter())
				{
					if (!options.HasFlag(FilterOptions.RemoveLetters))
						sb.Append(c);
					continue;
				}
				// c == Numeral
				if (c.IsNumeral())
				{
					if (!options.HasFlag(FilterOptions.RemoveNumerals))
						sb.Append(c);
					continue;
				}
				// c == Space
				if (c == ' ')
				{
					if (!options.HasFlag(FilterOptions.RemoveSpaces))
						sb.Append(c);
					continue;
				}
				// c == Special character
				else
				{
					if (!options.HasFlag(FilterOptions.RemoveSpecialCharacters))
						sb.Append(c);
					continue;
				}
			}

			return sb.ToString();
		}
	}
}