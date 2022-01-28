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
            List<int> L = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(10, 15); i++) L.Add(rnd.Next(-10, 10));
            Console.WriteLine("Исходный список(сгенерирован случайно): ");
            foreach (var num in L) Console.Write(num + " ");
            Console.WriteLine("\n" + "Этот же список, но перевернутый: ");
            foreach (var num in L.ToArray().Reverse()) Console.Write(num + " ");
        }
    }
}
        