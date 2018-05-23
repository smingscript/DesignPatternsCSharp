using System;

class Program
{
    static void Main(string[] args)
    {
        Marine marine = new Marine();
        MakeItFast(new MarineAdapter(marine));
        Console.WriteLine(marine.Speed);

        Zealot zealot = new Zealot();
        MakeItFast(new ZealotAdapter(zealot));
        Console.WriteLine(zealot.Speed);
    }

    private static void MakeItFast(ISpeedAdapter adapter)
    {
        adapter.SpeedUp();
    }
}