namespace AdapterPattern.Library
{
    public class Zealot
    {
        public Zealot()
        {
            Speed = 1;
        }

        public int Speed { get; private set; }

        public void Charge()
        {
            Speed = 3;
        }
    }
}