public class Upgrader : IUpgradable
{
    public Upgrader(IUpgradable upgradable)
    {
        Weapon = upgradable.Weapon;
        Armor = upgradable.Armor;
    }
        
    public int Weapon { get; protected set; }
    public int Armor { get; protected set;}
}

public class WeaponUpgrader : Upgrader
{
    public WeaponUpgrader(IUpgradable upgradable) : base(upgradable)
    {
        Weapon = upgradable.Weapon + 1;
    }

    
}

public class ArmorUpgrader : Upgrader
{
    public ArmorUpgrader(IUpgradable upgradable) : base(upgradable)
    {
        Armor = upgradable.Armor + 1;
    }
}

