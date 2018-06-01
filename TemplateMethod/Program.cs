class Program
{
    static void Main(string[] args)
    {
        Unit m = Builder.Instances[UnitType.Marine].Create();

        Unit h = Builder.Instances[UnitType.Hydralisk].Create();
    }
}