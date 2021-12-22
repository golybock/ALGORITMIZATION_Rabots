using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            if (x <= 7)
            {
                Console.WriteLine($"F(x) = {3 * Math.Pow(x, 2) - 9}");
            }
            else
            {
                Console.WriteLine($"F(x) = {1/(Math.Pow(x, 2)) - 4}");
            }
        }
    }
}