using System.Collections.Generic;

public class MarineList : IIteratable
{
    public MarineList(params Marine[] marines)
    {
        _marines.AddRange(marines);

//        for (int i = 0; i < marines.Length; i++)
//            _marines.Add(marines[i]);
    }
    
    private List<Marine> _marines = new List<Marine>();

    public IIterator Iterator
    {
        get {return new MarineIterator(this);}
    }

    public int Size
    {
        get { return _marines.Count; }
    }

    public Marine Get(int index)
    {
        return _marines[index];
    }

    // indexer
    public Marine this[int index]
    {
        get { return _marines[index]; }
    }

    public class MarineIterator : IIterator
    {
        private MarineList _list;

        public MarineIterator(MarineList list)
        {
            _list = list;
        }

        private int _index;
        
        public bool HasNext()
        {
            return _index < _list.Size;
        }

        public Marine GetCurrent()
        {
//            return _list.Get(_index);
            return _list[_index++];
        }
    }
}