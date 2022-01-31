using System;
using Microsoft.Win32;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Int32.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine("Введите в какую степень его возвести:");
            int b = Int32.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine(Pow(a,b));
        }

        public static int Pow(int n, int power)
        {
            if (power == 1)
                return n;
            return n * Pow(n, --power);
        }
        
    }
}
        