using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c:");
            c = Convert.ToDouble(Console.ReadLine());
            if (a >= b && b >= c)
            {
                a -= 5;
                b -= 5;
                c -= 5;
                Console.WriteLine($"а = {a}, b = {b}, c = {c}");            }
            else
            {
                Console.WriteLine((a + b + c) / 2);
            }
        }
    }
}