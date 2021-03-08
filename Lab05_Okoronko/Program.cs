using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Okoronko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Циклы с контролем за монотонной велечиной";
            Console.Write("Введите переменную х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точность: ");
            double точность = Convert.ToDouble(Console.ReadLine());
            double a = x;
            double a1 = 0;
            while ( Math.Abs(a1-a)> точность)
            {
                a1 = a;
                a=Math.Pow((Math.Abs(4 * Math.Pow(a, 2) - 2 * x)), 1.0/3.0);  // При заданном условии задачи функция расходящаяся и стремится к бесконечности, что не дают правильно определить первый член последовательности. Поэтому сделала сходящуюся функцию, заменив корень квадратный на корень 3 степени.
            }

            string txt = "Первое число последновательности равно: ";
            Console.WriteLine(txt + a);
            Console.ReadLine();
        }
        
    }
}
