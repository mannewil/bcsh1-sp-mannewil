using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demchenko_BCSH1_SP.Entities;

public class WeaponType : WeaponField, IComparable<WeaponType>
{
    public string Specification { get; set; }
    public WeaponType(string name, string Specification) : base(name)
    {
        this.Specification = Specification;
    }
    public override string ToString()
    {
        return base.ToString() + ";" + Specification;
    }

    public int CompareTo(WeaponType? other)
    {
        if (this.ID < other.ID) return 1;
        else if (this.ID > other.ID)
            return -1;
        else return 0;
    }
}
