using System;

public class Kerrigan
{
    public void LaunchNuclear()
    {
        Console.WriteLine("nuclear launch detected.");
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"to ({x}, {y})");
    }
}