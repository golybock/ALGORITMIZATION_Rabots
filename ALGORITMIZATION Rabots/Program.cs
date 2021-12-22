using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Значение аргумента:                Значение функции:");
            double a, b, n, h, f;
            a = -1 * (Math.PI / 6);
            b = (Math.PI / 6);
            n = 15;
            h = (b - a) / n;
            for (double i = a; i <= b; i += h)
            {
                f = 2 * Math.Cos(5 * i) - 3;
                Console.WriteLine(i + "                " + f);
            }
        }
    }
}