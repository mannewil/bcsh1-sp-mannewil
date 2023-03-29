using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demchenko_BCSH1_SP.Entities;

public class Weapon
{
    public int ID { get; private set; }
    public string Name { get; set; }
    public float Weight { get; set; }
    public int Price { get; set; }
    public Weapon(string name) {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        ID = new Random().Next(int.MaxValue);
    }
}
