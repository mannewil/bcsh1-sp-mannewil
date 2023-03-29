using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demchenko_BCSH1_SP.Entities;

public record Weapontype : WeaponField
{
    public string WeaponClass { get; private set; }
    public Weapontype(string name, string? WeaponClass) : base(name)
    {
        this.WeaponClass = WeaponClass;
    }
    public override string ToString()
    {
        return base.ToString() + " ; " + WeaponClass;
    }
}
