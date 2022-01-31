using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n = Int32.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine($"Факториал {n}: {Factorial(n)}");
        }

        public static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}
        