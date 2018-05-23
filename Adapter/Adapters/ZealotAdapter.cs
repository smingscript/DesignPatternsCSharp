public class ZealotAdapter : ISpeedAdapter
{
    private readonly Zealot _unit;

    public ZealotAdapter(Zealot unit)
    {
        _unit = unit;
    }

    public void SpeedUp()
    {
        _unit.Charge();
    }
}