public class Marine
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public override string ToString()
    {
        return $"{X},{Y}";
    }

    public void Move(int x, int y)
    {
        X = x;
        Y = y;
    }
}