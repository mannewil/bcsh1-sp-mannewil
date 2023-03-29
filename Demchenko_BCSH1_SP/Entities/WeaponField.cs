using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demchenko_BCSH1_SP.Entities;

public abstract record WeaponField
{
    
    public string Name { get; private set; }

    protected WeaponField(string name) {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}
