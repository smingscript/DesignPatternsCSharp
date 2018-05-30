using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Unit
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }

        public void Move(int x, int y)
        {
         
            X = x;
            Y = y;
            foreach (var unit in units)
            {
                unit.Move(x, y);
            }
        }

        List<Unit> units = new List<Unit>();

        public void AddUnits(Marine marine)
        {
            units.Add(marine);
        }
        public void AddUnits(Firebat firebat)
        {
            units.Add(firebat);
        }
        public void AddUnits(Marine marine, Firebat firebat)
        {
            units.Add(marine);
            units.Add(firebat);
            
        }
    }
}
