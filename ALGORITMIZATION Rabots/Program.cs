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
            Console.WriteLine("Введите количество магазинов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n==0) Console.WriteLine("Страны отсутствуют");
            Console.WriteLine("0-Хлеб, 1-Молоко, 2-Мыло, 3-Колбаса, 4-Шоколад");
            int[,] mas = new int[n,5];
            int bread = 0;
            int milk = 0;
            int soup = 0;
            int sausage = 0;
            int chocolate = 0;
            string povtor;
            for (int i = 0; i < n; i++)
            {
                povtor = "";
                for(int j=0; j<5;j++)
                {
                    mas[i, j] = new Random().Next(0, 5);
                    if (povtor.Contains(mas[i, j].ToString())) continue;
                    povtor += mas[i, j] + " ";
                }
                Console.Write($"в {i+1} магазине вот такие товары: {povtor}" + '\n');
                bread += GetCount(povtor, "0");
                milk += GetCount(povtor, "1");
                soup += GetCount(povtor, "2");
                sausage += GetCount(povtor, "3");
                chocolate += GetCount(povtor, "4");
            }

            Fin("Хлеб" ,bread, n);
            Fin("Молоко",milk, n);
            Fin("Мыло",soup, n);
            Fin("Колбаса",sausage, n);
            Fin("Шоколад",chocolate, n);
            
            
        }
        static void Fin(string name, int p, int n)
        {
            if (p >= n) Console.WriteLine($"{name} есть во всех магазинах");
            else if (p == 0)  Console.WriteLine($"{name} нет ни в одном магазине");
            else  Console.WriteLine($"{name} есть в некоторых магазинах");
        }

        static int GetCount(string str, string w)
        {
            var result = 0;
            for (int i = 0; i < str.Length; i++) for (int j = 0; j < w.Length; j++) if (w[j] == str[i]) result++;
            return result;
        }
    }
}
        