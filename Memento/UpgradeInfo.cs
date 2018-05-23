public class UpgradeInfo
{
    public UpgradeInfo(int weapon, int armor)
    {
        Weapon = weapon;
        Armor = armor;
    }

    public int Weapon { get; private set; }
    public int Armor { get; private set; }
}