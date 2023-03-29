using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demchenko_BCSH1_SP.Entities;

public record Ammotype : WeaponField
{
    public string Caliber { get; private set; }

    public Ammotype(string name, string Caliber) : base(name)
    {
        this.Caliber = Caliber;
    }

    public override string ToString()
    {
        return base.ToString() + " ; " + Caliber;
    }
}
