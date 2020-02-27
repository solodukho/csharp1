using System;

namespace Lesson2_7
{
    /* [Sergej Solodukho] 
     * 7.	a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
     *      б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("числа от a до b (a<b): ");
            Loop(1, 5);

            Console.WriteLine("\n");

            Console.Write("сумму чисел от a до b = ");
            Console.Write(Sum(1, 5));

            Console.ReadKey();
        }

        /// <summary>
        /// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Loop(int a, int b)
        {
            char suffix = a < b ? ',' : ' ';
            if (a <= b)
            {
                Console.Write($"{a}{suffix} ");
                Loop(a + 1, b);
            }
        }

        /// <summary>
        /// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            if (a < b) return Sum(a + 1, b) + a;
            else return b;
        }
    }
}
