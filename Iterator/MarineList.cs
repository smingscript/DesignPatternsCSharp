using System.Collections.Generic;

public class MarineList
{
    public MarineList(params Marine[] marines)
    {
        _marines.AddRange(marines);

//        for (int i = 0; i < marines.Length; i++)
//            _marines.Add(marines[i]);
    }
    
    private List<Marine> _marines = new List<Marine>();
}