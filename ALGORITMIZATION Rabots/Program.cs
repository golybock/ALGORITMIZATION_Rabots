using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, содержащую хотя бы один пробел.");
            string s = Console.ReadLine();
            // индексы пробелов в строке(первого и последнего)
            int perviiProbel = s.IndexOf(" ");
            int posledniiProbel = s.LastIndexOf(" ");
            // длинна новой подстроки
            int len = posledniiProbel - perviiProbel;
            string result;
            // если в строке нет ничего между пробелами
            if (len <= 1) result = "";
            // создание подстроки
            else result = s.Substring(perviiProbel + 1, len - 1);
            // вывод результата
            Console.WriteLine(result);
        }
    }
}