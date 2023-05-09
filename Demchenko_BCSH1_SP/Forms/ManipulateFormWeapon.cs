using Demchenko_BCSH1_SP.Entities;

namespace Demchenko_BCSH1_SP.Forms;

public partial class ManipulateFormWeapon : Form
{
    private MainForm _form;
    private readonly Weapon _initWep;

    private Manufacturer SelectedManufacturer => (Manufacturer)cBoxManufacturer.SelectedItem;
    private WeaponType SelectedWT => (WeaponType)cBoxWT.SelectedItem;
    private AmmoType SelectedAT => (AmmoType)cBoxAT.SelectedItem;

    public Weapon? Result { get; protected set; }
    public ManipulateFormWeapon(MainForm form, Weapon? initWep = null)
    {
        InitializeComponent();

        this._form = form;
        _initWep = initWep;

        ucName.LabelText = "Name";
        ucPrice.LabelText = "Price";
        ucWeight.LabelText = "Weight";

        //manufacturers
        cBoxManufacturer.DataSource = form.manufacturers;
        cBoxManufacturer.DisplayMember = "Name";
        cBoxManufacturer.ValueMember = "Name";
        ucManName.LabelText = "Name";
        ucManCountry.LabelText = "Country";
        ucManYear.LabelText = "F. Year";

        //ammotypes
        cBoxAT.DataSource = form.ammoTypes;
        cBoxAT.DisplayMember = "Name";
        cBoxAT.ValueMember = "Name";
        ucATName.LabelText = "Name";
        ucATCaliber.LabelText = "Caliber";

        //weapontypes
        cBoxWT.DataSource = form.weaponTypes;
        cBoxWT.DisplayMember = "Name";
        cBoxWT.ValueMember = "Name";
        ucWTName.LabelText = "Name";
        ucWTWeaponType.LabelText = "Spec.";

        if (_initWep != null)
        {
            cBoxManufacturer.SelectedItem = _initWep.Manufacturer;
            cBoxAT.SelectedItem = _initWep.Ammotype;
            cBoxWT.SelectedItem = _initWep.Weapontype;
            ucName.TextBoxText = _initWep.Name;
            ucPrice.TextBoxText = _initWep.Price.ToString();
            ucWeight.TextBoxText = _initWep.Weight.ToString();
        }
    }

    private void OnBtnOkClick(object sender, EventArgs e)
    {
        String name = ucName.TextBoxText;
        bool isPriceInt = int.TryParse(ucPrice.TextBoxText, out int price);
        bool isWeightFloat = float.TryParse(ucWeight.TextBoxText, out float weight);
        Manufacturer man = (Manufacturer)cBoxManufacturer.SelectedItem;
        AmmoType at = (AmmoType)cBoxAT.SelectedItem;
        WeaponType wt = (WeaponType)cBoxWT.SelectedItem;
        if (name != null && isPriceInt && isWeightFloat)
        {
            if (man != null && at != null && wt != null)
            {
                Result = new Weapon(name, weight, price, man, at, wt);
                Close();
            }
            else
            {
                AlertDialog.Show("Problem with one of the three sister objects");
            }
        }
        else
        {
            AlertDialog.Show("Problematic values in Weapon's parameters (name, price, weight)");
        }

    }

    private void OnBtnCancelClick(object sender, EventArgs e)
    {
        Result = null;
        Close();
    }

    private void OnCBoxManufacturerChanged(object sender, EventArgs e)
    {
        ucManName.TextBoxText = SelectedManufacturer.Name;
        ucManCountry.TextBoxText = SelectedManufacturer.Country;
        ucManYear.TextBoxText = SelectedManufacturer.YearOfCreation.ToString();

    }

    private void OnCBoxATChanged(object sender, EventArgs e)
    {
        ucATName.TextBoxText = SelectedAT.Name;
        ucATCaliber.TextBoxText = SelectedAT.Caliber;
    }

    private void OnCBoxWTChanged(object sender, EventArgs e)
    {
        ucWTName.TextBoxText = SelectedWT.Name;
        ucWTWeaponType.TextBoxText = SelectedWT.Specification;
    }
}
