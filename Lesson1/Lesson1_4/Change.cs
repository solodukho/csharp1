using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_4
{
    class Change
    {
        /* [Sergej Solodukho]
          * 4. Написать программу обмена значениями двух переменных.
             а) с использованием третьей переменной;
             б) *без использования третьей переменной.
          */
        static void Main(string[] args)
        {
            Console.Write("Введите значение первой переменной (x): ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение второй переменной (y): ");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели: x = {x}, y = {y}");

            // а) с использованием третьей переменной;
            //var temp = x;
            //x = y;
            //y = temp;

            // б) *без использования третьей переменной.
            //x += y - (y = x);
            // или
            x ^= y ^ (y = x);

            Console.WriteLine($"Результат обмена значениями: x = {x}, y = {y}");
            Console.ReadKey();
        }
    }
}
