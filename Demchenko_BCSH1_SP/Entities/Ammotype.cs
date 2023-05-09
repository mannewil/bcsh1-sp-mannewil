using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demchenko_BCSH1_SP.Entities;

public class AmmoType : WeaponField, IComparable<AmmoType>
{
    public string Caliber { get; set; }

    public AmmoType(string name, string Caliber) : base(name)
    {
        this.Caliber = Caliber;
    }

    public override string ToString()
    {
        return base.ToString() + ";" + Caliber;
    }

    public int CompareTo(AmmoType? other)
    {
        if (this.ID < other.ID) return 1;
        else if (this.ID > other.ID)
            return -1;
        else return 0;
    }
}
