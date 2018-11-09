using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month2 = new string[12];
            string[] month3 = new string[12];
            string[] month1 = { "January", "February", "March", "April", "May", "June",
                               "July", "August", "September", "October", "November", "Desember" };
            string[] mc1 = Array.FindAll(month1, m1 => m1.EndsWith("ry", StringComparison.Ordinal));
            string[] mc2 = Array.FindAll(month1, m2 => m2.EndsWith("ber", StringComparison.Ordinal));
            month3 = mc1;
            month2 = mc2;
            Console.WriteLine("========End ber=========");
            Console.WriteLine(string.Join(",", month2));
            Console.WriteLine("========End ry=========");
            Console.WriteLine(string.Join(",", month3));
        }
    }
}