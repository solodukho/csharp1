using System;

namespace Lesson2
{
    /* [Sergej Solodukho] 
     * 1.	Написать метод, возвращающий минимальное из трёх чисел. */
    class Excercise1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Минимальное из трёх чисел: " + GetMinFromThree(a, b, c));

            Console.ReadKey();
        }

        private static int GetMinFromThree(int a, int b, int c)
        {
            return (a < b && a < c) ? a : (b < c) ? b : c;
        }
    }

}
