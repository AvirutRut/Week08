using System;
using System.Linq;
using System.Collections;

namespace Week08
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] gps = new double[8];
            float g;
            float s = 0;
            float cr = 0;
            int c;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Credit = ");
                c = int.Parse(Console.ReadLine());
                cr += c;
                Console.Write("GPS = ");
                g = float.Parse(Console.ReadLine());
                s = s + g * c;
            }
            Console.WriteLine("GPA = {0:F2} ", s / cr);
        }
    }
}