public class Firebat
{
    public int X { get; private set; }
    public int Y { get; private set; }    
    
    public override string ToString()
    {
        return $"{X},{Y}";
    }
}