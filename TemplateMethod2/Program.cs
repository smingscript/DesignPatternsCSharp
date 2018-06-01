#region
using System;
#endregion

class Program
{
    static void Main(string[] args)
    {
        Marine m =new Marine();
        m.Move(100,100);

        Tank t = new Tank();
        t.Move(100,100);
    }
}