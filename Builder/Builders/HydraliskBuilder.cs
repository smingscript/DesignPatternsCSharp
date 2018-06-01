public class HydraliskBuilder : Builder
{
    public override void SetHP()
    {
        _unit.HP = 70;
    }

    public override void SetAttributes()
    {
        _unit.CanAttack = true;
        _unit.CanFly = true;
    }
}