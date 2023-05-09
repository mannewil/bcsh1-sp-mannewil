using Demchenko_BCSH1_SP.Entities;
using Demchenko_BCSH1_SP.Filework;
using Demchenko_BCSH1_SP.Forms;
using System.Windows.Forms;

namespace Demchenko_BCSH1_SP;

public partial class MainForm : Form
{
    private string SelectedType => comboBoxListSelection.SelectedItem.ToString() ?? "Weapon";
    private string SelectedSortType => comboBoxSorting.SelectedItem.ToString() ?? "Name (asc)";

    public List<Weapon> weapons = new();
    public List<Manufacturer> manufacturers = new();
    public List<AmmoType> ammoTypes = new();
    public List<WeaponType> weaponTypes = new();

    public MainForm()
    {
        InitializeComponent();

        // DEBUG FUNCTION
        // COMMENT/REMOVE IF YOU DON'T WANT YOUR LISTS BE FILLED WITH NUMBERS
        DBGPopLists(8);

        comboBoxListSelection.SelectedIndexChanged += OnComboBoxListSelectionChanged;
        comboBoxListSelection.SelectedIndex = 0;
        comboBoxSorting.SelectedIndexChanged += OnComboBoxSortingSelectionChanged;
        comboBoxSorting.SelectedIndex = 0;
        btnClear.MouseUp += OnBtnClearRightClick;
        RefreshListView();
    }



    private void OnBtnAddClick(object sender, EventArgs e)
    {
        if (SelectedType == "Weapon")
        {
            ManipulateFormWeapon formWeapon = new(this);
            AddNewWeapon(formWeapon);
            return;
        }

        switch (SelectedType)
        {
            case "Ammo type":
                ManipulateFormAmmotype formA = new();
                AddNewAmmotype(formA);
                break;
            case "Manufacturer":
                ManipulateFormManufacturer formM = new();
                AddNewManufacturer(formM);
                break;
            case "Weapon type":
                ManipulateFormWeaponType formW = new();
                AddNewWeaponType(formW);
                break;
        }

    }

    private void OnBtnEditClick(object sender, EventArgs e)
    {
        if (listViewMain.SelectedItems.Count < 1)
        {
            AlertDialog.Show("Choose something to edit!");
            return;
        }

        if (SelectedType == "Weapon")
        {
            Weapon w = (Weapon)listViewMain.SelectedItems[0].Tag;

            bool res = AddNewWeapon(new ManipulateFormWeapon(this, w));

            if (res) weapons.Remove(w);
            RefreshListView();

            return;
        }

        WeaponField selected = (WeaponField)listViewMain.SelectedItems[0].Tag;
        int success = 0;

        switch (SelectedType)
        {
            case "Manufacturer":
                ManipulateFormManufacturer formM = (new ManipulateFormManufacturer((Manufacturer)selected));
                AddNewManufacturer(formM);
                if (formM.Result != null)
                    success = 1;
                break;
            case "Ammo type":
                ManipulateFormAmmotype formA = new ManipulateFormAmmotype((AmmoType)selected);
                AddNewAmmotype(formA);
                if (formA.Result != null)
                    success = 2;
                break;
            case "Weapon type":
                ManipulateFormWeaponType formW = (new ManipulateFormWeaponType((WeaponType)selected));
                AddNewWeaponType(formW);
                if (formW.Result != null)
                    success = 3;
                break;
            default: break;
        }
        switch (success)
        {
            case 1: manufacturers.Remove((Manufacturer)selected); break;
            case 2: ammoTypes.Remove((AmmoType)selected); break;
            case 3: weaponTypes.Remove((WeaponType)selected); break;
            default: break;
        }
        RefreshListView();
    }

    private void OnBtnRemoveClick(object sender, EventArgs e)
    {
        if (listViewMain.SelectedItems.Count < 1)
        {
            return;
        }

        object item = listViewMain.SelectedItems[0].Tag;

        switch (SelectedType)
        {
            case "Weapon":
                weapons.Remove((Weapon)item);
                break;
            case "Manufacturer":
                manufacturers.Remove((Manufacturer)item);
                break;
            case "Weapon type":
                weaponTypes.Remove((WeaponType)item);
                break;
            case "Ammo type":
                ammoTypes.Remove((AmmoType)item);
                break;
            default: break;
        }
        RefreshListView();
    }

    private bool AddNewAmmotype(ManipulateFormAmmotype form)
    {
        form.ShowDialog();
        if (form.Result != null)
        {
            ammoTypes.Add((AmmoType)form.Result);
            RefreshListView();
            return true;
        }
        // AlertDialog.Show("Something went wrong.");
        return false;
    }

    private bool AddNewManufacturer(ManipulateFormManufacturer form)
    {
        form.ShowDialog();
        if (form.Result != null)
        {
            manufacturers.Add((Manufacturer)form.Result);
            RefreshListView();
            return true;
        }
        // AlertDialog.Show("Something went wrong.");
        return false;
    }

    private bool AddNewWeaponType(ManipulateFormWeaponType form)
    {
        form.ShowDialog();
        if (form.Result != null)
        {
            weaponTypes.Add((WeaponType)form.Result);
            RefreshListView();
            return true;
        }
        //  AlertDialog.Show("Something went wrong.");
        return false;
    }

    private bool AddNewWeapon(ManipulateFormWeapon form)
    {
        form.ShowDialog();

        if (form.Result != null)
        {
            weapons.Add(form.Result);
            RefreshListView();
            return true;
        }
        // AlertDialog.Show("Something went wrong.");
        return false;
    }
    private void OnComboBoxListSelectionChanged(object sender, EventArgs e)
    {
        if (comboBoxListSelection.SelectedIndex == 0)
        {

            comboBoxSorting.Items.Clear();
            comboBoxSorting.Items.AddRange(new string[] { "Name (asc)", "Name (desc)", "By manufacturer", "By ammotype", "By weapontype" });
            comboBoxSorting.SelectedIndex = 0;
        }
        else
        {
            comboBoxSorting.Items.Clear();
            comboBoxSorting.Items.AddRange(new string[] { "Name (asc)", "Name (desc)" });
            comboBoxSorting.SelectedIndex = 0;
        }
        RefreshListView();
    }

    private void OnComboBoxSortingSelectionChanged(object sender, EventArgs e)
    {
        ListSort();
    }

    private void RefreshListView()
    {
        int width = (int)Math.Round((listViewMain.Width - 12) / 3f);
        int widthWeapon = (int)Math.Round(width / 1.8);
        listViewMain.Items.Clear();
        listViewMain.Columns.Clear();

        // Populate the ListView based on the selected variable
        switch (SelectedType)
        {
            case "Weapon":
                // Display all Weapon objects in the list
                listViewMain.Columns.Add("Manufacturer", widthWeapon);
                listViewMain.Columns.Add("Name", widthWeapon);
                listViewMain.Columns.Add("Caliber", widthWeapon);
                listViewMain.Columns.Add("Specification", widthWeapon);
                listViewMain.Columns.Add("Price", widthWeapon);
                foreach (Weapon weapon in weapons)
                {
                    ListViewItem item = new(weapon.Manufacturer.Name);
                    item.SubItems.Add(weapon.Name);
                    item.SubItems.Add(weapon.Ammotype.Caliber);
                    item.SubItems.Add(weapon.Weapontype.Specification);
                    item.SubItems.Add(weapon.Price.ToString());
                    item.Tag = weapon;
                    listViewMain.Items.Add(item);
                }
                break;

            case "Manufacturer":
                // Display all Manufacturer objects in the list
                listViewMain.Columns.Add("Name", width);
                listViewMain.Columns.Add("Country", width);
                listViewMain.Columns.Add("Year", width);
                foreach (Manufacturer manufacturer in manufacturers)
                {
                    ListViewItem item = new(manufacturer.Name);
                    item.SubItems.Add(manufacturer.Country);
                    item.SubItems.Add(manufacturer.YearOfCreation.ToString());
                    item.Tag = manufacturer;
                    listViewMain.Items.Add(item);
                }
                break;

            case "Ammo type":
                // Display all Caliber objects in the list
                listViewMain.Columns.Add("Name", width);
                listViewMain.Columns.Add("Caliber", width);
                foreach (AmmoType ammotype in ammoTypes)
                {
                    ListViewItem item = new(ammotype.Name);
                    item.SubItems.Add(ammotype.Caliber);
                    item.Tag = ammotype;
                    listViewMain.Items.Add(item);
                }
                break;

            case "Weapon type":
                // Display all WeaponType objects in the list
                listViewMain.Columns.Add("Name", width);
                listViewMain.Columns.Add("Classification", width);
                foreach (WeaponType weaponType in weaponTypes)
                {
                    ListViewItem item = new(weaponType.Name);
                    item.SubItems.Add(weaponType.Specification);
                    item.Tag = weaponType;
                    listViewMain.Items.Add(item);
                }
                break;

            default:
                break;
        }
    }

    private void DBGPopLists(int count)
    {
        int iterations = 0;
        do
        {
            manufacturers.Add(new((iterations + 4).ToString(), iterations.ToString(), iterations));
            weaponTypes.Add(new((iterations + 1).ToString(), (iterations*2).ToString()));
            ammoTypes.Add(new((iterations + 1).ToString(), (iterations*3).ToString()));
            weapons.Add(new((iterations + 1).ToString(), iterations, iterations, manufacturers.ElementAt(iterations), ammoTypes.ElementAt(iterations), weaponTypes.ElementAt(iterations)));
            iterations++;
        } while (iterations != count);
    }

    private void ListSort()
    {
        if (SelectedType == "Weapon")
        {
            switch (SelectedSortType)
            {
                case "Name (asc)":
                    List<Weapon> sortedListAsc = weapons.OrderBy(o => o.Name).ToList();
                    weapons = sortedListAsc;
                    break;
                case "Name (desc)":
                    List<Weapon> sortedListDesc = weapons.OrderByDescending(o => o.Name).ToList();
                    weapons = sortedListDesc;
                    break;
                case "By manufacturer":
                    List<Weapon> sortedListMan = weapons.OrderBy(o => o.Manufacturer.Name).ToList();
                    weapons = sortedListMan;
                    break;
                case "By ammotype":
                    List<Weapon> sortedListAT = weapons.OrderBy(o => o.Ammotype.Caliber).ToList();
                    weapons = sortedListAT;
                    break;
                case "By weapontype":
                    List<Weapon> sortedListWT = weapons.OrderBy(o => o.Weapontype.Specification).ToList();
                    weapons = sortedListWT;
                    break;
                default: break;
            }

            RefreshListView();
            return;
        }

        switch (SelectedType)
        {
            case "Manufacturer":
                if (SelectedSortType == "Name (asc)")
                {
                    List<Manufacturer> sortedList = manufacturers.OrderBy(o => o.Name).ToList();
                    manufacturers = sortedList;
                }
                else
                {
                    List<Manufacturer> sortedList = manufacturers.OrderByDescending(o => o.Name).ToList();
                    manufacturers = sortedList;
                }
                break;
            case "Ammo type":
                if (SelectedSortType == "Name (asc)")
                {
                    List<AmmoType> sortedList = ammoTypes.OrderBy(o => o.Name).ToList();
                    ammoTypes = sortedList;
                }
                else
                {
                    List<AmmoType> sortedList = ammoTypes.OrderByDescending(o => o.Name).ToList();
                    ammoTypes = sortedList;
                }
                break;
            case "Weapon type":
                if (SelectedSortType == "Name (asc)")
                {
                    List<WeaponType> sortedList = weaponTypes.OrderBy(o => o.Name).ToList();
                    weaponTypes = sortedList;
                }
                else
                {
                    List<WeaponType> sortedList = weaponTypes.OrderByDescending(o => o.Name).ToList();
                    weaponTypes = sortedList;
                }
                break;
            default: break;
        }
        RefreshListView();
    }

    private void OnBtnSaveClick(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new()
        {
            FilterIndex = 2,
            RestoreDirectory = true
        };

        SerializeDeserializer serializeDeserializer;

        switch (SelectedType)
        {
            case "Weapon":
                saveFileDialog.Filter = "Weapons |*.wpns";
                break;
            case "Manufacturer":
                saveFileDialog.Filter = "Manufacturers |*.mans";
                break;
            case "Ammo type":
                saveFileDialog.Filter = "Ammo types |*.ats";
                break;
            case "Weapon type":
                saveFileDialog.Filter = "Weapon types |*.wts";
                break;
            default: break;

        }

        if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

        switch (SelectedType)
        {
            case "Weapon":
                serializeDeserializer = new(weapons, saveFileDialog.FileName);
                serializeDeserializer.SaveWeapons();
                break;
            case "Manufacturer":
                serializeDeserializer = new(manufacturers, saveFileDialog.FileName);
                serializeDeserializer.SaveManufacturers();
                break;
            case "Ammo type":
                serializeDeserializer = new(ammoTypes, saveFileDialog.FileName);
                serializeDeserializer.SaveAmmotypes();
                break;
            case "Weapon type":
                serializeDeserializer = new(weaponTypes, saveFileDialog.FileName);
                serializeDeserializer.SaveWeapontypes();
                break;
            default: break;
        }

    }

    private void OnBtnLoadClick(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new()
        {
            FilterIndex = 2,
            RestoreDirectory = true
        };

        SerializeDeserializer serializeDeserializer;

        switch (SelectedType)
        {
            case "Weapon":
                openFileDialog.Filter = "Weapons |*.wpns";
                break;
            case "Manufacturer":
                openFileDialog.Filter = "Manufacturers |*.mans";
                break;
            case "Ammo type":
                openFileDialog.Filter = "Ammo types |*.ats";
                break;
            case "Weapon type":
                openFileDialog.Filter = "Weapon types |*.wts";
                break;
            default: break;

        }

        if (openFileDialog.ShowDialog() != DialogResult.OK) return;

        switch (SelectedType)
        {
            case "Weapon":
                serializeDeserializer = new(weapons, openFileDialog.FileName);
                weapons = serializeDeserializer.LoadWeapons();
                break;
            case "Manufacturer":
                serializeDeserializer = new(manufacturers, openFileDialog.FileName);
                manufacturers = serializeDeserializer.LoadManufacturers();
                break;
            case "Ammo type":
                serializeDeserializer = new(ammoTypes, openFileDialog.FileName);
                ammoTypes = serializeDeserializer.LoadAmmotypes();
                break;
            case "Weapon type":
                serializeDeserializer = new(weaponTypes, openFileDialog.FileName);
                weaponTypes = serializeDeserializer.LoadWeapontypes();
                break;
            default: break;
        }

        RefreshListView();
    }

    private void OnListViewItemDoubleClick(object sender, EventArgs e)
    {
        OnBtnEditClick(sender, e);
    }

    private void OnListViewItemRightClick(object sender, EventArgs e)
    {
        MouseEventArgs me = (MouseEventArgs)e;
        if (me.Button == MouseButtons.Right)
        {
            OnBtnRemoveClick(sender, me);
        }
    }

    private void OnBtnClearClick(object sender, EventArgs e)
    {
        switch (SelectedType)
        {
            case "Weapon":
                weapons.Clear();
                break;
            case "Manufacturer":
                manufacturers.Clear();
                break;
            case "Weapon type":
                weaponTypes.Clear();
                break;
            case "Ammo type":
                ammoTypes.Clear();
                break;
            default: break;
        }
        RefreshListView();
    }

    private void OnBtnClearRightClick(object sender, MouseEventArgs e)
    {

        if (e.Button == MouseButtons.Right)
        {
            weapons.Clear();
            manufacturers.Clear();
            ammoTypes.Clear();
            weaponTypes.Clear();
            RefreshListView();
            return;
        }
    }
}