using System;

public class Kerrigan : Ghost
{
    #region singleton
    private static Kerrigan _instance;

    public static Kerrigan Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Kerrigan();
            return _instance;
        }
    }

    private Kerrigan()
    {
    }
    #endregion

    public void LaunchNuclear()
    {
        Console.WriteLine("nuclear launch detected.");
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"to ({x}, {y})");
    }

    public override int Weapon
    {
        get { return base.Weapon;}
        set { base.Weapon = value * 2; }
    }
}