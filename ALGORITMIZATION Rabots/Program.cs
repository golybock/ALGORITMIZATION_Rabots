using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Double x, y, z;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((2 * (1 / Math.Tan(3 * x))) - ((12 * Math.Pow(x, 2) + 7 * x - 5) / y));
        }
    }
}