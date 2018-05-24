using System;

namespace Prefab
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine m1 = new Marine();
            Marine m2 = new Marine();
            m1.Weapon++;
            m1.ShowUpgradeInfo();            
            m2.ShowUpgradeInfo();

            Marine p1 = m1.InstantiatePrefab();
            Marine p2 = m1.InstantiatePrefab();
            m1.Armor++;
            m1.ShowUpgradeInfo();
            p1.ShowUpgradeInfo();
            p2.ShowUpgradeInfo();
        }
    }
}