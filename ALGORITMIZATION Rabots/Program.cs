using System;

namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ввод строки
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            bool test = false;
            // проверка на наличие нужных символов
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ':' | str[i] == '!')
                {
                    test = true;
                }

            }
            // разделение строки на 2 половины
            string str1 = str.Substring(0, str.Length/2);
            string str2 = str.Substring(str.Length / 2);
            // если в строке есть нужные символы
            if (test)
            {
                Console.WriteLine(str1.Replace(':', '.') + str2.Replace('!', '.') );
            }
            // если таких символов нет
            else
            {
                Console.WriteLine("В строке нет нужных символов");
            }
        }
    }
}