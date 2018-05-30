#region
using System;
#endregion

class Program
{
    static void Main(string[] args)
    {
        Marine m1 = new Marine();
        Firebat f1 = new Firebat();
        Firebat f2 = new Firebat();

        Marine m2 = new Marine();
        m2.AddUnits(m1, f1, f2);

        m2.Move(3, 4);

        Console.WriteLine(m1);
        Console.WriteLine(f1);
        Console.WriteLine(m2);
    }
}