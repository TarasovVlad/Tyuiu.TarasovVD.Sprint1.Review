using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint1.TaskReview.V10.Lib;

namespace Tyuiu.TarasovVD.Sprint1.TaskReview.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#1 | Выполнил: Тарасов.В.Д | ПКТб-23-2";
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                 *");
            Console.WriteLine("* Тема:Создание итогового решения по спринту                                                *");
            Console.WriteLine("* Задание #8                                                                                *");
            Console.WriteLine("* Вариант #10                                                                               *");
            Console.WriteLine("* Выполнил: Тарасов.В.Д | ПКТб-23-2                                                         *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Написать консольную программу C#,которая запрашивает данные,выполняет данное выражение и  *");
            Console.WriteLine("* выводит на экран результат *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("Введите значение переменной x:");
            double x = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine();
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                                                 *");
            Console.WriteLine("*********************************************************************************************");

            Console.WriteLine(" Значение данного выражения: " + ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
