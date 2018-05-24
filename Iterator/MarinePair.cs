public class MarinePair
{
    public MarinePair(Marine first, Marine second)
    {
        First = first;
        Second = second;
    }

    public Marine First { get; private set; }
    
    public Marine Second { get; private set; }
}