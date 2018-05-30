#region
using System.Collections.Generic;
#endregion

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

        foreach (var unit in _units)
        {
            unit.Move(x, y);
        }
    }

    readonly List<Unit> _units = new List<Unit>();

    public void AddUnits(params Unit[] units)
    {
//            foreach (var unit in units)
//                _units.Add(unit);

        _units.AddRange(units);
    }
}