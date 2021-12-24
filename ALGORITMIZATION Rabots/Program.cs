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
            // создание 2 множеств длинной от 2 до 10 элементов
            int[] X = new int[rnd.Next(1,10)];
            int[] Y = new int[rnd.Next(1,10)];
            int count = 0; //счетчик
            Console.WriteLine("Первое множество:");
            // создание 1 множества и его вывод
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rnd.Next(0, 10);
                Console.Write(X[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Второе множество:");
            // создание и вывод 2 множества
            for (int i = 0; i < Y.Length; i++)
            {
                Y[i] = rnd.Next(0, 10);
                Console.Write(Y[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Кол-во общих четных элементов:");
            // создание множества из общих элементов множеств X и Y
            IEnumerable<int> Z = X.Intersect(Y);
            // подсчет четных элементов в этом множестве
            foreach (var ident in Z)
            {
                if (ident % 2 == 0) count++;
            }
            // вывод кол-ва четных элементов
            Console.WriteLine(count);
        }
    }
}