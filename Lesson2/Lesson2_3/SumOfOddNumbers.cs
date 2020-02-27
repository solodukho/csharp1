using System;

namespace Lesson2_3
{
    /* [Sergej Solodukho] 
     * 3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел. */
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int input = 0;
            int sum = 0;            
            do
            {
                Console.WriteLine("Введите число: ");
                input = int.Parse(Console.ReadLine());
                if (input > 0 && IsOdd(input))
                    sum += input;
            }
            while (input != 0);

            Console.WriteLine("Сумма введённых нечетных положительных чисел = " + sum);
            Console.ReadKey();
        }

        private static bool IsOdd(int input)
        {
            return input % 2 != 0;
        }
    }
}
