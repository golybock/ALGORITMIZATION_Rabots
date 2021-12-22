using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(2, -x) - Math.Sin(x) + Math.Cos(2 * x * y));
        }
    }
}