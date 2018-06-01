#region
using System;
#endregion

public class Factory
{
    private static Random _random = new Random();

    private static Unit CreateCore(Builder builder)
    {
        builder.SetHP();
        builder.SetAttributes();

        return builder.Unit;
    }

    public static Unit Create(UnitType unitType)
    {
        switch (unitType)
        {
            case UnitType.Marine:
                return CreateCore(new MarineBuilder());
            case UnitType.Hydralisk:
                return CreateCore(new HydraliskBuilder());
            default:
                throw new NotImplementedException("Factory.Create");
        }

// 구린 코드 (bad smell code)
//            Unit unit = new Unit();
//
//            if (unitType == UnitType.Marine)
//            {
//                unit.HP = _random.Next(50,100);
//                unit.CanAttack = true;
//                unit.CanFly = false;
//            }
//            else if (unitType == UnitType.Hydralisk)
//            {
//                unit.HP = _random.Next(100, 200);
//                unit.CanAttack = true;
//                unit.CanFly = true;
//            }
//            
//
//            return unit;
    }
}

public enum UnitType
{
    Marine,
    Hydralisk
}