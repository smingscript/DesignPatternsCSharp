using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine m1 = new Marine();
            Firebat f1 = new Firebat();
            
            Marine m2 = new Marine();
            m2.AddUnits(m1, f1);

            m2.Move(3, 4);
            Console.WriteLine(m1);
            Console.WriteLine(f1);
            Console.WriteLine(m2);


            Firebat f2 = new Firebat();
            f2.AddUnits(m2);
            f2.Move(9, 7);
            Console.WriteLine(f2);
            Console.WriteLine(m1);
            Console.WriteLine(f1);
            Console.WriteLine(m2);
        }
    }
}