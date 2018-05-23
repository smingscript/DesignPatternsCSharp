using System;
using AdapterPattern.Library;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine marine = new Marine();
            MakeItFast(marine);
            Console.WriteLine(marine.Speed);
            
            Zealot zealot = new Zealot();
            MakeItFast(zealot);
            Console.WriteLine(zealot.Speed);
        }

        private static void MakeItFast(Marine marine)
        {
            marine.RunSteamPack();
        }

        private static void MakeItFast(Zealot zealot)
        {
            zealot.Charge();
        }
    }
}