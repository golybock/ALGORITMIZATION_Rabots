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

            Console.WriteLine("Введите значность чисел(n): ");
            int n = Int32.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите первое число: ");
            int x = Int32.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите 2 число: ");
            int y = Int32.Parse(Console.ReadLine() ?? String.Empty);

            if (NumIsNNumeral(x, n) && NumIsNNumeral(y, n))
            {
                if (AllIsNotEven(x) && AllIsNotEven(y))
                {
                    Console.WriteLine($"Сумма чисел {x} и {y}: {Sum(x, y)}");
                    Console.WriteLine($"Число четных чисел в сумме: {HowManyEven(Sum(x, y))}");
                }
                else
                {
                    Console.WriteLine("В числах есть четные цифры");
                }
            }
            else
            {
                Console.WriteLine($"Введены не {n}-значные числа");
            }
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public  static bool AllIsNotEven(int a)
        {
            foreach (var num in a.ToString())
            {
                if (num % 2 == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool NumIsNNumeral(int x, int n)
        {
            return x.ToString().Length == n;
        }

        public static int HowManyEven(int x)
        {
            int count = 0;
            foreach (var num in x.ToString())
            {
                if (num % 2 == 0) count++;
            }

            return count;
        }
    }
    
    
    

}