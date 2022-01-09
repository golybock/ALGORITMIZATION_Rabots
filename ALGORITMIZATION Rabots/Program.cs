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
            Random rnd = new Random();
            int[] X = new int[rnd.Next(10)];
            int[] Y = new int[rnd.Next(10)];
            Console.WriteLine("Множество X: ");
            for (var i = 0; i < X.Length; i++)
            {
                X[i] = rnd.Next(10);
                Console.Write(X[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Множество Y: ");
            for (var i = 0; i < Y.Length; i++)
            {
                Y[i] = rnd.Next(10);
                Console.Write(Y[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Четные элементы из пересечения множеств X и Y:");
            var Z = X.Intersect(Y);
            int count = 0;
            foreach (var VARIABLE in Z)
            {
                if (VARIABLE % 2 == 0)
                {
                    count++;
                    Console.Write(VARIABLE + " ");
                }
            }
            if (count == 0) Console.WriteLine("Таких элементов нет");
            
        }
    }
}
        