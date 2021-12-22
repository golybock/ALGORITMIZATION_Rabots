using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x, y, z, biba, boba;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z:");
            z = Convert.ToDouble(Console.ReadLine());
            if (x < z && x < y)
            {
                x = Math.Pow(x, 2);
            }
            else if (y < z && y < x)
            {
                y = Math.Pow(y, 2);
            }
            else if (z < x && z < y)
            {
                z = Math.Pow(z, 2);
            }
            else if (x == y && x < z)
            {
                x = Math.Pow(x, 2);
            }
            else if (x == z && x < y)
            {
                x = Math.Pow(x, 2);
            }
            else if (y == z && y < x)
            {
                x = Math.Pow(y, 2);
            }
            else if (y == z && y == x)
            {
                x = Math.Pow(x, 2);
            }
            biba = (x * ((x + y + z)) / 2) + 1;
            boba = (x * ((x * y * z)) / 2) + 1;
            Console.WriteLine(biba);
            Console.WriteLine(boba);
        }
    }
}