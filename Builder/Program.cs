using System;
using Builder.Builders;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit m = Factory.Create(UnitType.Marine);
//            Unit m = Factory.Create(new MarineBuilder());

            Unit h = Factory.Create(UnitType.Hydralisk);
//            Unit h = Factory.Create(new HydraliskBuilder());
        }
    }
}