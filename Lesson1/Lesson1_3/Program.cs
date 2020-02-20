using System;

namespace Lesson1_3
{
    /* [Sergej Solodukho]
     а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
     по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя 
     спецификатор формата .2f (с двумя знаками после запятой);
     б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "«Расстояние между точками». Сергей Солодухо";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("Для рассчёта расстояния между точками введите \nкоординату х первой точки: ");
            double х1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nкоординату y первой точки: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nкоординату х второй точки: ");
            double х2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nкоординату y второй точки: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // а)
            double r = Math.Sqrt(Math.Pow(х2 - х1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("а) расстояние между этими точками = {0:F2}", r);
            Console.ReadKey();

            // б)
            Console.WriteLine("б) расстояние между этими точками = {0:F2}", GetDistance(х1, y1, х2, y2));
            Console.ReadKey();
        }

        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
