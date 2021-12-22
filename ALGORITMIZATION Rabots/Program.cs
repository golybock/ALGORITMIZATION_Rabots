using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите n(размер матрицы)");
            int n = int.Parse(Console.ReadLine()); //размер матрицы
            int[,] matrix = new int[n, n]; //создание матрицы
            Random rnd = new Random();
            //генерация исходной матрицы 
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
            //обмен значений строки n и столбца n
            int b = 0;
            int a = 0;
            while (b < matrix.GetLength(0) && a < matrix.GetLength(1))
            {
                (matrix[n-1, b], matrix[a,n-1]) = (matrix[a, n-1], matrix[n-1,b]);
                b++;
                a++;
            }
            Console.WriteLine("Матрица с изменениями: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}