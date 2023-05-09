using Demchenko_BCSH1_SP.Entities;
using System.Numerics;
using System.Text;
using System.Text.Json;

namespace Demchenko_BCSH1_SP.Filework;

public class SerializeDeserializer
{
    private readonly List<Weapon> ws;
    private readonly List<Manufacturer> ms;
    private readonly List<WeaponType> wts;
    private readonly List<AmmoType> ats;
    private readonly string filename;

    //never null
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public SerializeDeserializer(List<Weapon> weapons, string filename)

    {
        ws = weapons;
        this.filename = filename;
    }

    public SerializeDeserializer(List<Manufacturer> manufacturers, string filename)
    {
        ms = manufacturers;
        this.filename = filename;
    }

    public SerializeDeserializer(List<WeaponType> weapontypes, string filename)
    {
        wts = weapontypes;
        this.filename = filename;
    }

    public SerializeDeserializer(List<AmmoType> ammotypes, string filename)
    {
        ats = ammotypes;
        this.filename = filename;
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public void SaveWeapons()
    {

        StringBuilder strBuilder = new();

        int records = 0;

        foreach (Weapon weapon in ws)
        {
            strBuilder.AppendLine(Serialize(weapon));
            records++;
        }

        strBuilder.Insert(0, records + "\n");

        using TextWriter writer = new StreamWriter(filename);
        writer.Write(strBuilder.ToString());
    }

    public void SaveManufacturers()
    {

        StringBuilder strBuilder = new();

        int records = 0;

        foreach (Manufacturer man in ms)
        {
            strBuilder.AppendLine(Serialize(man));
            records++;
        }

        strBuilder.Insert(0, records + "\n");

        using TextWriter writer = new StreamWriter(filename);
        writer.Write(strBuilder.ToString());
    }
    public void SaveAmmotypes()
    {

        StringBuilder strBuilder = new();

        int records = 0;

        foreach (AmmoType at in ats)
        {
            strBuilder.AppendLine(Serialize(at));
            records++;
        }

        strBuilder.Insert(0, records + "\n");

        using TextWriter writer = new StreamWriter(filename);
        writer.Write(strBuilder.ToString());
    }
    public void SaveWeapontypes()
    {

        StringBuilder strBuilder = new();

        int records = 0;

        foreach (WeaponType wt in wts)
        {
            strBuilder.AppendLine(Serialize(wt));
            records++;
        }

        strBuilder.Insert(0, records + "\n");

        using TextWriter writer = new StreamWriter(filename);
        writer.Write(strBuilder.ToString());
    }


    public List<Weapon> LoadWeapons()
    {
        using TextReader textReader = new StreamReader(filename);

        bool result = int.TryParse(textReader.ReadLine(), out int arrLength);

        if (!result) return null;

        Weapon[] arrWeapons = new Weapon[arrLength];

        string? readLine = textReader.ReadLine();

        for (int i = 0; i < arrLength; i++)
        {
            arrWeapons.SetValue(DeserializeWeapons(readLine), i);
            readLine = textReader.ReadLine();
        }
        return arrWeapons.Cast<Weapon>().ToList();
    }

    public List<Manufacturer> LoadManufacturers()
    {
        using TextReader textReader = new StreamReader(filename);

        bool result = int.TryParse(textReader.ReadLine(), out int arrLength);

        if (!result) return null;

        Manufacturer[] arrManufacturers = new Manufacturer[arrLength];

        string? readLine = textReader.ReadLine();

        for (int i = 0; i < arrLength; i++)
        {
            arrManufacturers.SetValue(DeserializeManufacturers(readLine), i);
            readLine = textReader.ReadLine();
        }
        return arrManufacturers.Cast<Manufacturer>().ToList();
    }

    public List<AmmoType> LoadAmmotypes()
    {
        using TextReader textReader = new StreamReader(filename);

        bool result = int.TryParse(textReader.ReadLine(), out int arrLength);

        if (!result) return null;

        AmmoType[] arrAmmotypes = new AmmoType[arrLength];

        string? readLine = textReader.ReadLine();

        for (int i = 0; i < arrLength; i++)
        {
            arrAmmotypes.SetValue(DeserializeAmmotypes(readLine), i);
            readLine = textReader.ReadLine();
        }
        return arrAmmotypes.Cast<AmmoType>().ToList();
    }

    public List<WeaponType> LoadWeapontypes()
    {
        using TextReader textReader = new StreamReader(filename);

        bool result = int.TryParse(textReader.ReadLine(), out int arrLength);

        if (!result) return null;

        WeaponType[] arrWeaponTypes = new WeaponType[arrLength];

        string? readLine = textReader.ReadLine();

        for (int i = 0; i < arrLength; i++)
        {
            arrWeaponTypes.SetValue(DeserializeWeapontypes(readLine), i);
            readLine = textReader.ReadLine();
        }
        return arrWeaponTypes.Cast<WeaponType>().ToList();
    }

    private static string Serialize(Object o)
    {
        return JsonSerializer.Serialize(o);
    }

    private static Object DeserializeWeapons(string s)
    {
        return JsonSerializer.Deserialize<Weapon>(s);
    }

    private static Object DeserializeManufacturers(string s)
    {
        return JsonSerializer.Deserialize<Manufacturer>(s);
    }

    private static Object DeserializeAmmotypes(string s)
    {
        return JsonSerializer.Deserialize<AmmoType>(s);
    }

    private static Object DeserializeWeapontypes(string s)
    {
        return JsonSerializer.Deserialize<WeaponType>(s);
    }
}
