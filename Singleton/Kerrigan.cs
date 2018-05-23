using System;

public class Kerrigan
{
    public Kerrigan()
    {
        Weapon = 1;
    }

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