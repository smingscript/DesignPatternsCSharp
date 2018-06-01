using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IUpgradable m1 = new Marine();
            m1 = new WeaponUpgrader(m1);
            m1 = new WeaponUpgrader(m1);
            m1 = new ArmorUpgrader(m1);
            
            IUpgradable m2 = new ArmorUpgrader(
                                new WeaponUpgrader(
                                    new WeaponUpgrader(
                                        new Marine()
                                        )
                                    )
                );
            
            
        }
    }
}