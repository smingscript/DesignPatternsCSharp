class UpgradeWeaponCommand : Command
{
    public override void Execute(Marine marine)
    {
        marine.Weapon++;
    }
}