using System;
using System.Collections;
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
            // объявление множеств
            var x = new HashSet<int>();
            var y = new HashSet<int>();
            var z = new HashSet<int>();
            // заполнение множеств
            for (int i = 0; i < 15; i++) x.Add(rnd.Next(10));
            for (int i = 0; i < 15; i++) y.Add(rnd.Next(10));
            for (int i = 0; i < 15; i++) z.Add(rnd.Next(10));
            // Вывод множеств в консоль
            Console.WriteLine("X: ");
            OutSet(x);
            Console.WriteLine("Y: ");
            OutSet(y);
            Console.WriteLine("Z: ");
            OutSet(z);
            // 1
            Console.WriteLine("Задание А:");
            HashSet<int>[] array = new[] {x, y, z};
            // сортировка пузырьком по длине множеств 
            for (var i = 1; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - i; j++)
                {
                    if (array[j].Count > array[j + 1].Count)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
            // вывод отсортированного множества
            foreach (var mas in array)
            {
                OutSet(mas);
            }
            // 2
            Console.WriteLine("Задание Б:");
            Console.WriteLine("(X \\ Y) (пересечение этих множеств) Z U Y");
            // действия поэтапно
            // Console.WriteLine("X \\ Y:");
            // OutSet(Except(x, y));
            // Console.WriteLine("Z U Y:");
            // OutSet(Combine(z, y));
            // Console.WriteLine("Результат:");
            OutSet(Intersect(Combine(z, y), Except(x, y)));

        }

        private static void OutSet(HashSet<int> x)
        {
            foreach (var v in x) Console.Write(v + " ");
            Console.WriteLine();
        }
        
        public static HashSet<int> Combine(HashSet<int> x, HashSet<int> y)
        {
            return x.Union(y).ToHashSet();
        }
        
        public static HashSet<int> Intersect(HashSet<int> x, HashSet<int> y)
        {
            return x.Intersect(y).ToHashSet();
        }
        
        public static HashSet<int> Except(HashSet<int> x, HashSet<int> y)
        {
            return  x.Except(y).ToHashSet();
        }
        
        public static bool Contain(HashSet<int> x, int y)
        {
            return x.Contains(y);
        }
        
        public static bool IsSubSet(HashSet<int> x, HashSet<int> y)
        {
            for (int i = 0; i < y.Count; i++)
                if (!x.Contains(y.ElementAt(i)))
                    return false;
            return true;
        }
        
    }
}
        