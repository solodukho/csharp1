using System;

namespace Lesson2_2
{
    /* [Sergej Solodukho] 
     * 2.	Написать метод подсчета количества цифр числа. */
    class Excercise2 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Количество цифр в этом числе = {GetCountOfDigits(input)}");

            Console.ReadKey();
        }

        private static int GetCountOfDigits(string input)
        {
            int count = 0;
            foreach(char i in input)
            {
                if (char.IsDigit(i))
                    count++;
            }
            return count;
        }
    }
}
