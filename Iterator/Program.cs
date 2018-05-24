using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine m1 = new Marine("m1");
            Marine m2 = new Marine("m2");
            Marine m3 = new Marine("m3");

            MarinePair pair = new MarinePair(m3, m1);
            IterateMarines(pair);
            
            MarineList list = new MarineList(m1, m2, m3);
            IterateMarines(list);
        }

        // MarinePair와 MarineList가 동일한 방법으로 각각 포함하고 있는 마린을 순회하여야 함
        private static void IterateMarines(IIteratable marines)
        {
            
        }
    }
}