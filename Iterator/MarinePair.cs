public class MarinePair : IIteratable
{
    public MarinePair(Marine first, Marine second)
    {
        First = first;
        Second = second;
    }

    public Marine First { get; private set; }

    public Marine Second { get; private set; }

    public IIterator Iterator
    {
        get {return new MarineIterator(this);}
    }
    
    public class MarineIterator : IIterator
    {
        private MarinePair _pair;

        public MarineIterator(MarinePair pair)
        {
            _pair = pair;
        }

        private int _index = 1;

        public bool HasNext()
        {
            return _index <= 2;
        }

        public Marine GetCurrent()
        {
            switch (_index)
            {
                case 1:
                    _index++;
                    return _pair.First;
                case 2:
                    _index++;
                    return _pair.Second;
                default:
                    return null;
            }
        }
    }    
}

