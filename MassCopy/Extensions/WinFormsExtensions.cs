using System;
using System.Windows.Forms;
// ReSharper disable CheckNamespace

namespace MassCopy
{
	public static class WinFormsExtensions
	{
		public static void AppendLine(this TextBox textBox, string value)
		{
			if (textBox.Text.Length == 0)
				textBox.Text = value;
			else
				textBox.AppendText(Environment.NewLine + value);
		}

		public static void AppendLine(this RichTextBox textBox, string value)
		{
			if (textBox.Text.Length == 0)
				textBox.Text = value;
			else
				textBox.AppendText(Environment.NewLine + value);
		}
	}
}