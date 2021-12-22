using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ряда чисел");
            int dlina = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int biba = 0;
            while (i < dlina)
            {
                Console.WriteLine($"Введите число");
                int boba = Convert.ToInt32(Console.ReadLine());
                i++;
                if (boba % 2 != 0 && boba < 0)
                {
                    biba++;
                }
            }
            Console.WriteLine($"Отрицательный нечетных чисел:{biba}");
        }
    }
}