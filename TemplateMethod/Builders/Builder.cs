#region
using System;
using System.Collections.Generic;
#endregion

public class Builder
{
    private static Dictionary<UnitType, Builder> _instances;

    public static Dictionary<UnitType, Builder> Instances
    {
        get
        {
            if (_instances == null)
            {
                _instances = new Dictionary<UnitType, Builder>();
                _instances.Add(UnitType.Marine, new MarineBuilder());
                _instances.Add(UnitType.Hydralisk, new HydraliskBuilder());
            }
            
            return _instances;
        }
    }

    protected Builder()
    {
    }

    public Builder this[UnitType unitType]
    {
        get { return _instances[unitType]; }
    }
    
    protected Unit _unit = new Unit();

    public virtual void SetHP()
    {
        throw new NotImplementedException("Builder.SetHP");
    }

    public virtual void SetAttributes()
    {
        throw new NotImplementedException("Builder.SetAttributes");
    }

    public Unit Create()
    {
        SetHP();
        SetAttributes();

        return _unit;
    }
}

public enum UnitType
{
    Marine,
    Hydralisk
}