using System;

namespace Lesson2_6
{
    /* [Sergej Solodukho] 
     * 6.	*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
     * «Хорошим» называется число, которое делится на сумму своих цифр. 
     * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
     */
    class CountOfGodNumbers
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            int counter = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (IsGoodNumber(i))
                    counter++;               
            }
            Console.WriteLine($"времени выполнения программы: {DateTime.Now - startTime}");
            Console.ReadKey();
        }

        /// <summary>
        /// «Хорошим» называется число, которое делится на сумму своих цифр.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool IsGoodNumber(int number)
        {
            return number % SummOfDigits(number) == 0;
        }

        private static int SummOfDigits(int number)
        {
            int summ = 0;
            while (number != 0)
            {
                summ = summ + number % 10;
                number = number / 10;
            }
            return summ;
        }
    }
}
