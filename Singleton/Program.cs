using System;

class Program
{
    // kerrigan을 멤버변수로 생성
    private static Kerrigan _kerrigan = new Kerrigan();

    static void Main(string[] args)
    {
        MoveAndLauncherNuclear();
        
        // 다른 클래스에는 kerrigan을 매개변수로 전달하여야 함
        KerriganUpgrader upgrader = new KerriganUpgrader(_kerrigan);
        upgrader.UpgradeWeapon();
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
        _kerrigan.Move(1, 2);
    }

    // kerrigan을 매개변수로 전달할 필요 없음
    private static void LauncherNuclear()
    {
        _kerrigan.LaunchNuclear();
    }
}

public class KerriganUpgrader
{
    private Kerrigan _kerrigan;

    public KerriganUpgrader(Kerrigan kerrigan)
    {
        _kerrigan = kerrigan;
    }

    public void UpgradeWeapon()
    {
        _kerrigan.Weapon++;
    }
}