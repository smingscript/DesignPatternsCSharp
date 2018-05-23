using System;
using System.Collections.Generic;

public class Marine
{
    public Marine()
    {
        Weapon = 1;
        Armor = 1;
    }

    public int Weapon { get; private set; }
    public int Armor { get; private set; }

    private readonly Stack<UpgradeInfo> _snapshots = new Stack<UpgradeInfo>();

    public void UpgradeWeapon()
    {
        UpgradeInfo snapshot = new UpgradeInfo(Weapon, Armor);
        _snapshots.Push(snapshot);

        Weapon++;
    }

    public void UpgradeArmor()
    {
        UpgradeInfo snapshot = new UpgradeInfo(Weapon, Armor);
        _snapshots.Push(snapshot);

        Armor++;
    }

    public void Revert()
    {
        UpgradeInfo snapshot = _snapshots.Pop();

        Weapon = snapshot.Weapon;
        Armor = snapshot.Armor;
    }
}