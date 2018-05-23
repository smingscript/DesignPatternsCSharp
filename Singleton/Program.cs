using System;

class Program
{
    static void Main(string[] args)
    {
        // kerrigan을 지역변수로 생성
        Kerrigan kerrigan = new Kerrigan();

        MoveAndLauncherNuclear(kerrigan);
    }

    // 매 함수마다 kerrigan을 매개변수로 전달하여야 함
    private static void MoveAndLauncherNuclear(Kerrigan kerrigan)
    {
        Move(kerrigan);
        LauncherNuclear(kerrigan);
        LauncherNuclear(kerrigan);
    }

    // 매 함수마다 kerrigan을 매개변수로 전달하여야 함
    private static void Move(Kerrigan kerrigan)
    {
        kerrigan.Move(1, 2);
    }

    // 매 함수마다 kerrigan을 매개변수로 전달하여야 함
    private static void LauncherNuclear(Kerrigan kerrigan)
    {
        kerrigan.LaunchNuclear();
    }
}