public class MarineAdapter : ISpeedAdapter
{
    private readonly Marine _unit;

    public MarineAdapter(Marine unit)
    {
        _unit = unit;
    }

    public void SpeedUp()
    {
        _unit.RunSteamPack();
    }
}