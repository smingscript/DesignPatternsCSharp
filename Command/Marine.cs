public class Marine
{
    public Marine()
    {
        X = 1;
        Y = 1;
        Weapon = 1;
        Armor = 1;
    }

    public int X { get; set; }
    public int Y { get; set; }

    public int Weapon { get; set; }
    public int Armor { get; set; }

    public void Move(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void UpgradeWeapon()
    {
        Weapon++;
    }

    public void UpgradeArmor()
    {
        Armor++;
    }
}