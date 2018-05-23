using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine marine = new Marine();

            marine.UpgradeWeapon();
            marine.Move(50,100);
            marine.UpgradeArmor();
            
            // 지연 실행 불가
            // 조건에 따른 명령 관리 불가
        }
    }
}