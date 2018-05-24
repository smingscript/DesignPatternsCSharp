using System.Collections;
using System.Collections.Generic;

public class MarineList : IEnumerable<Marine>
{
    public MarineList(params Marine[] marines)
    {
        _marines.AddRange(marines);

//        for (int i = 0; i < marines.Length; i++)
//            _marines.Add(marines[i]);
    }
    
    private List<Marine> _marines = new List<Marine>();
    
    public IEnumerator<Marine> GetEnumerator()
    {
        foreach (Marine marine in _marines)
            yield return marine;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}