class UpgradeArmorCommand : Command
{
    public override void Execute(Marine marine)
    {
        marine.Armor++;
    }
}