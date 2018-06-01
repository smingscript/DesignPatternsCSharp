public class Tank : Unit
{
    public bool IsSiegeMode { get; set; }

    protected override void MoveCore(int x, int y)
    {
        if (IsSiegeMode)
            return;
        else
            base.MoveCore(x, y);
    }
}