using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demchenko_BCSH1_SP.Entities;

public record Manufacturer : WeaponField
{
    public string Country { get; private set; }
    public int YearOfCreation { get; private set; } 

    public Manufacturer(string name, string Country, int YearOfCreation) : base(name) {
        this.Country = Country;
        this.YearOfCreation = YearOfCreation;
    }

    public override string ToString()
    {
        return base.ToString() + " ; " + Country + " ; " + YearOfCreation.ToString();
    }
}
