using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] chisl = new double[n];
            double sum = 0;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                chisl[i] = rnd.Next(0, 10);
                if (i != 0 && (i%i) == 0)
                {
                    sum += chisl[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}