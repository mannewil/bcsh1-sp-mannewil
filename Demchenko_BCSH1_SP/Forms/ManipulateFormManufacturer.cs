using Demchenko_BCSH1_SP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demchenko_BCSH1_SP.Forms;

public partial class ManipulateFormManufacturer : Form
{
    public WeaponField? Result { get; protected set; }
    public ManipulateFormManufacturer(Manufacturer? initMan = null)
    {
        InitializeComponent();

        if (initMan != null)
        {
            tbName.Text = initMan.Name;
            tbCountry.Text = initMan.Country;
            tbFYear.Text = initMan.YearOfCreation.ToString();
        }
    }

    private void OnBtnOkClick(object sender, EventArgs e)
    {
        bool isYearANumber = int.TryParse(tbFYear.Text, out int year);
        if (!string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbCountry.Text) && isYearANumber == true)
        {
            Result = new Manufacturer(tbName.Text, tbCountry.Text, year);
            Close();
        }
        else
        {
            AlertDialog.Show("Parameters are incorrect.");
        }

    }

    private void OnBtnCancelClick(object sender, EventArgs e)
    {
        Result = null;
        Close();
    }
}
