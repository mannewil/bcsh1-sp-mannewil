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

public partial class ManipulateFormWeaponType : Form
{
    public WeaponField? Result { get; protected set; }
    public ManipulateFormWeaponType(WeaponType? initWT = null)
    {
        InitializeComponent();

        if (initWT != null)
        {
            tbName.Text = initWT.Name;
            tbWeaponType.Text = initWT.Specification;
        }
    }

    private void OnBtnOkClick(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbWeaponType.Text))
        {
            Result = new WeaponType(tbName.Text, tbWeaponType.Text);
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
