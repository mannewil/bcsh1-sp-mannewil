using Demchenko_BCSH1_SP.Entities;

namespace Demchenko_BCSH1_SP.Forms;


public partial class ManipulateFormAmmotype : Form
{
    public WeaponField? Result { get; protected set; }
    public ManipulateFormAmmotype(AmmoType? initAT = null)
    {
        InitializeComponent();

        if (initAT != null)
        {
            tbName.Text = initAT.Name;
            tbAmmotype.Text = initAT.Caliber;
        }
    }

    private void OnBtnOkClick(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbAmmotype.Text))
        {
            Result = new AmmoType(tbName.Text, tbAmmotype.Text);
            Close();
        }
        else AlertDialog.Show("Parameters are incorrect.");
    }

    private void OnBtnCancelClick(object sender, EventArgs e)
    {
        Result = null;
        Close();
    }
}
