using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {x - 10*Math.Sin(x) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5))}");
        }
    }
}