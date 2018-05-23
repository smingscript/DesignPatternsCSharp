using System;

class Program
{
    static void Main(string[] args)
    {
        Marine marine = new Marine();

        CommandManager.Instance.Add(new UpgradeWeaponCommand());
        CommandManager.Instance.Add(new MoveCommand(50,100));
        CommandManager.Instance.Add(new UpgradeArmorCommand());
        
//        marine.UpgradeWeapon();
//        marine.Move(50, 100);
//        marine.UpgradeArmor();
        
        // 조건에 따른 명령 관리
        if (marine.Armor > 1)
            CommandManager.Instance.CancelLast();
        
        // 지연 실행 가능
        CommandManager.Instance.ExecuteAll(marine);
    }
}