// ReSharper disable CheckNamespace

namespace MassCopy
{
	public static class CharExtensions
	{
		public static bool IsLetter(this char c)
		{
			return (c >= 'A' && c <= 'Z'
			        || c >= 'a' && c <= 'z');
		}

		public static bool IsNumeral(this char c)
		{
			return c >= '0' && c <= '9';
		}

		public static bool IsSpecialCharacter(this char c)
		{
			// Not a space or a letter or a numeral
			return !(c == ' '
			         || IsLetter(c)
			         || IsNumeral(c));
		}
	}
}