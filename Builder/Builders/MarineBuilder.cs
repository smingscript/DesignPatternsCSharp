public class MarineBuilder : Builder
{
    public override void SetHP()
    {
        _unit.HP = 50;
    }

    public override void SetAttributes()
    {
        _unit.CanAttack = true;
        _unit.CanFly = false;
    }
}