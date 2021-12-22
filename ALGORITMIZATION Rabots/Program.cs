using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер квадратной матрицы");
            int m = int.Parse(Console.ReadLine()); //размер матрицы
            int[,] matrix = new int[m, m];
            Random rnd = new Random();
            int sum = 0;
            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(100);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i+1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[j, i] % 2 != 0)
                    {
                        sum += matrix[j, i];
                    }
                }    
            }
            Console.WriteLine($"сумма нечетных элементов нижнего треугольника:{sum}");
        }
    }
}