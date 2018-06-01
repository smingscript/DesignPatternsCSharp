public class Marine : IUpgradable
{
    public Marine()
    {
        Weapon = 1;
        Armor = 1;
    }

    public int Weapon { get; set; }
    public int Armor { get; set; }
}