using System;

class Program
{
    static void Main(string[] args)
    {
        Marine marine = new Marine();
        marine.UpgradeWeapon();    
        marine.UpgradeArmor();     
        marine.UpgradeWeapon();        
        ShowUpgradeInfo(marine);    // W3, A:2

        marine.Revert();
        ShowUpgradeInfo(marine); // W2, A:2
        
        marine.Revert();
        ShowUpgradeInfo(marine); // W2, A:1
    }

    private static void ShowUpgradeInfo(Marine marine)
    {
        Console.WriteLine($"W:{marine.Weapon}, A:{marine.Armor}");
    }
}