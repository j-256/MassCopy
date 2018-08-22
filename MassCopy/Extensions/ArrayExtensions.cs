using System;
// ReSharper disable CheckNamespace

namespace MassCopy
{
	public static class ArrayExtensions
	{
		public static bool IsNullOrEmpty(this Array array)
		{
			return (array == null || array.Length == 0);
		}
	}
}