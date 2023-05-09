using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demchenko_BCSH1_SP.Entities;

public abstract class WeaponField
{
    public string Name { get; set; }
    public static int Counter { get; private set; } = 0;
    public int ID { get; private set; }

    protected WeaponField(string Name) {
        this.Name = Name ?? throw new ArgumentNullException(nameof(Name));
        ID = ++Counter;
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}
