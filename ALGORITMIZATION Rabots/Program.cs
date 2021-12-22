using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость лодки:");
            double v = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите скорость течения реки: ");
            double v1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Время движения по стоячей воде: ");
            double t = Double.Parse(Console.ReadLine());
            Console.WriteLine("Время переджвижения против течения реки:");
            double t1 = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Путь пройденный лодкой:{v * t + t1 * (v-v1)}");
        }
    }
}