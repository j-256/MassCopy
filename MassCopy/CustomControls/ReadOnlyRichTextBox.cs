using System.Windows.Forms;

namespace MassCopy.CustomControls
{
	public sealed class ReadOnlyRichTextBox : RichTextBox
	{
		public ReadOnlyRichTextBox()
		{
			ReadOnly = true;
			Cursor = Cursors.Arrow;
			GotFocus += ReadOnlyRichTextBox_GotFocus;
		}

		// Prevent the ReadOnlyRichTextBox from getting focus, which shows up as a pulsing IBeam cursor.
		private void ReadOnlyRichTextBox_GotFocus(object sender, System.EventArgs e)
		{
			Control ctrl = (Control) sender;
			ctrl.FindForm().ActiveControl = null;
		}

		//protected override void WndProc(ref Message m)
		//{
		//	// Ignore all messages that try to set the focus. Prevents the pulsing IBeam cursor from showing up.
		//	if (m.Msg != 0x7)
		//	{
		//		base.WndProc(ref m);
		//	}
		//}
	}
}