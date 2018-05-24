using System.Collections;
using System.Collections.Generic;

public class MarinePair : IEnumerable<Marine>
{
    public MarinePair(Marine first, Marine second)
    {
        First = first;
        Second = second;
    }

    public Marine First { get; private set; }

    public Marine Second { get; private set; }

    public IEnumerator<Marine> GetEnumerator()
    {
        yield return First;
        yield return Second;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

