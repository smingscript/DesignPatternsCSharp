using System;

public class Marine
{
    public Marine()
    {
        Weapon = 1;
        Armor = 1;
    }

    public int Weapon { get; private set; }
    public int Armor { get; private set; }

    public void UpgradeWeapon()
    {
        Weapon++;
    }

    public void UpgradeArmor()
    {
        Armor++;
    }

    public void Revert()
    {
        throw new NotImplementedException("Marine.Revert");
    }
}