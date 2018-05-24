using System;

public class Marine
{
    public Marine(string name)
    {
        _name = name;
    }

    public Marine InstantiatePrefab()
    {
        throw new NotImplementedException("Marine.InstantiatePrefab");
    }

    private string _name;
    
    private int _weapon;

    public int Weapon
    {
        get { return _weapon; }
        set { _weapon = value; }
    }

    private int _armor;
    
    public int Armor
    {
        get { return _armor; }
        set { _armor = value; }
    }

    public void ShowUpgradeInfo()
    {
        Console.WriteLine($"W:{Weapon}, A:{Armor}");
    }
}