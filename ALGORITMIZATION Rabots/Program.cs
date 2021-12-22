using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mas = new int[12];
            int res = 1;
            for(int i = 0; i < 12; i++)
            {
                mas[i] = rnd.Next(-10, 10);
                Console.WriteLine(mas[i]);
            }
            for(int k = 0; k < 12; k++)
            {
                if (mas[k] < 0)
                {
                    res *= mas[k];
                }
                else
                {
                    break;
                }
            }
            if (res == 1)
            {
                Console.WriteLine($"Произведение всех элементов до 1 положительного числа равна: 0");
            }
            else
            {
                Console.WriteLine($"Произведение всех элементов до 1 положительного числа равна:{res}");
            }
        }
    }
}