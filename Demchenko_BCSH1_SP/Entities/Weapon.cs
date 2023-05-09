using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demchenko_BCSH1_SP.Entities;

public class Weapon : IComparable<Weapon>
{
    public int ID { get; private set; }
    public string Name { get; set; }
    public float Weight { get; set; }
    public int Price { get; set; }
    private static int Counter = 0;

    public Manufacturer Manufacturer { get; set; }
    public AmmoType Ammotype { get; set; }
    public WeaponType Weapontype { get; set; }
    public Weapon(string name, float weight, int price, Manufacturer Manufacturer, AmmoType Ammotype, WeaponType Weapontype)
    {
        ID = ++Counter;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Weight = weight;
        Price = price;
        this.Manufacturer = Manufacturer;
        this.Ammotype = Ammotype;
        this.Weapontype = Weapontype;
    }

    public int CompareTo(Weapon? other)
    {
        if (this.ID < other.ID) return 1;
        else if (this.ID > other.ID)
            return -1;
        else return 0;
    }

    public override string ToString()
    {
        return Name + ";" + Weight.ToString() + ";" + Price.ToString() + ";" + Manufacturer.ToString() + ";" + Ammotype.ToString() + ";" + Weapontype.ToString();
    }
}
