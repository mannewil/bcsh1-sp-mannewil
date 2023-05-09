namespace Demchenko_BCSH1_SP.Forms;

internal static class AlertDialog
{
    public static void Show(string message)
    {
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
