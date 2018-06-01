public class Unit
{
    public int X { get; set; }    
    public int Y { get; set; }

    protected virtual void MoveCore(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int x, int y)
    {
        MoveCore(x, y);
    }
}