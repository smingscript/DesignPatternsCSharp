namespace AdapterPattern.Library
{
    public class Marine
    {
        public Marine()
        {
            Speed = 1;
        }

        public int Speed { get; private set; }

        public void RunSteamPack()
        {
            Speed = 2;
        }
    }
}