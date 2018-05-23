using System;

public class Kerrigan
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
        Weapon = 1;
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

    public int Weapon { get; set; }
}