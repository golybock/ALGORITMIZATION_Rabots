using System;
using System.Collections.Generic;
using System.IO;


namespace ALGORITMIZATION_Rabots
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // списки на стипендии
            List<string> commonStipendy = new List<string>();
            List<string> niceStipendy = new List<string>();
            Console.WriteLine("Чтобы прекратить ввод студентов, введите пустую строку в роли имени.");
            // ввод студентов
            for(;;)
            {
                // ввод информации о студенте
                Console.WriteLine("Введите имя студента");
                string name = Console.ReadLine();
                if (name == string.Empty) break;
                Console.WriteLine("Введите оценки ученика по одной за строку, чтобы завершить ввод, введите пустую строку:");
                List<int> grades = new List<int>();
                for(;;)
                {
                    string grade = Console.ReadLine();
                    if (grade == string.Empty) break;
                    if (grade != null) grades.Add(Int32.Parse(grade));
                }
                // добавление в списки стипендий в зависимости от оценок
                if (CheckStependy(grades) == 1) commonStipendy.Add(name);
                if (CheckStependy(grades) == 2) niceStipendy.Add(name);
                // запись студента в файл
                WriteInfo(name, StringGrades(grades), AverageGrade(grades), @"D:\dan.txt");
                Console.WriteLine("Данные записаны в файл");
            }
            // запись списков стипендии
            FileStream fileStream;
            fileStream = File.Open(@"D:\dan.txt", FileMode.Append); 
            StreamWriter output = new StreamWriter(fileStream);
            if (commonStipendy.Count != 0)
            {
                output.WriteLine("Обычная стипендия:");
                foreach (var name in commonStipendy)
                {
                    output.WriteLine(name);
                }
            }

            if (niceStipendy.Count != 0)
            {
                output.WriteLine("Повышенная стипендия:");
                foreach (var name in niceStipendy)
                {
                    output.WriteLine(name);
                }
            }
            output.Close();
            // завершение
            Console.WriteLine("Итоговый файл находится на диске D, под именем dan.txt");
        }
        
        // складывает все оценки и делит на их кол-во
        private static double AverageGrade(List<int> list)
        {
            double value = 0;
            foreach (var grade in list)
            {
                value += grade;
            }
            return value / list.Count;
        }
        // перевод список оценок в стрку, где все оценки через пробел
        public static string StringGrades(List<int> list)
        {
            string strGrades = String.Empty;
            foreach (var grade in list)
            {
                strGrades += " " + grade;
            }
            return strGrades;
        }
        // записывает всю информацию о студенте в файл
        public static void WriteInfo(string name, string grades, double averageGrade, string filePath)
        {
            FileStream fileStream;
            // проверяем существует ли файл файл
            if (!File.Exists(filePath))
                // создаем файл
                fileStream = File.Create(filePath);
            else
                fileStream = File.Open(filePath, FileMode.Append); 
            StreamWriter output = new StreamWriter(fileStream);
            // записываем данные
            output.WriteLine($"{name}: {grades}, Средний балл: {averageGrade}");
            // закрываем поток
            output.Close();
        }
        public static int CheckStependy(List<int> grades)
        {
            if (grades.Contains(3)) return 0;  // если в оценках есть 3
            if (grades.Contains(4)) return 1;  // если в оценках нет 3 и есть 4
            return 2;  // все оценки 5
        }
        
    }
}
        