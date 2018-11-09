using System;
using System.Linq;
using System.Collections;

namespace Week08
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, m;
            int s, n = 0;
            string[] day = { "sunday", "monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sat" };
            int[] monthday = new int[12];
            monthday[0] = 0;
            monthday[1] = 3;
            monthday[2] = 3;
            monthday[3] = 6;
            monthday[4] = 1;
            monthday[5] = 4;
            monthday[6] = 6;
            monthday[7] = 2;
            monthday[8] = 5;
            monthday[9] = 0;
            monthday[10] = 3;
            monthday[11] = 5;
            Console.Write("Date = ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Month = ");
            m = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                if (m == (i + 1))
                {
                    s = d + monthday[i] - 1;
                    n = s % 7;
                    Console.WriteLine("{0}/{1}/2017 is {2}", d, m, day[n]);
                }
            }
        }
    }
}
