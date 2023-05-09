using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demchenko_BCSH1_SP.Entities;

public class Manufacturer : WeaponField, IComparable<Manufacturer>
{
    public string Country { get; set; }
    public int YearOfCreation { get; set; }

    public Manufacturer(string name, string Country, int YearOfCreation) : base(name)
    {
        this.Country = Country;
        this.YearOfCreation = YearOfCreation;
    }

    public override string ToString()
    {
        return base.ToString() + ";" + Country + ";" + YearOfCreation.ToString();
    }

    public int CompareTo(Manufacturer? other)
    {
        if (this.ID < other.ID) return -1;
        else if (this.ID > other.ID)
            return 1;
        else return 0;
    }
}
