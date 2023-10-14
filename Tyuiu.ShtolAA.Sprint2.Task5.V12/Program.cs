using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShtolAA.Sprint2.Task5.V12.Lib;

namespace Tyuiu.ShtolAA.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Штоль А.А. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры  C#                           *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Штоль Александра Алексеевна | ИИПБ-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            int n = Convert.ToInt32(Console.ReadLine());


            if (((n < 1) || (n > 31)) || ((m < 1) || (m > 12)))
            {
                Console.WriteLine("Запись некорректна!");
            }
            else
            {
                string func = ds.FindDateOfPreviousDay(g, m, n);
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine($"Дата предыдущего дня:  {func}"); ;
            }
                
            Console.ReadLine();
        }
    }
}


