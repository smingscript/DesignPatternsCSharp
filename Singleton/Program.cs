using System;

class Program
{
    // kerrigan을 생성할 필요 없음

    static void Main(string[] args)
    {
        MoveAndLauncherNuclear();
        
        // 다른 클래스에 kerrigan을 전달할 필요 없음
        KerriganUpgrader upgrader = new KerriganUpgrader();
        upgrader.UpgradeWeapon();

        Console.WriteLine(Kerrigan.Instance.Weapon);
    }

    // kerrigan을 매개변수로 전달할 필요 없음
    private static void MoveAndLauncherNuclear()
    {
        Move();
        LauncherNuclear();
        LauncherNuclear();
        
        // 멤버변수는 접근이 용이하기 때문에 실수로 핵을 발사할 수 있음
        // _kerrigan.LaunchNuclear();
    }

    // kerrigan을 매개변수로 전달할 필요 없음
    private static void Move()
    {
        Kerrigan.Instance.Move(1, 2);
    }

    // kerrigan을 매개변수로 전달할 필요 없음
    private static void LauncherNuclear()
    {
        Kerrigan.Instance.LaunchNuclear();
    }
}

public class KerriganUpgrader
{
    public KerriganUpgrader()
    {
    }

    public void UpgradeWeapon()
    {
        Kerrigan.Instance.Weapon++;
    }
}