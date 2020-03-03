using System;

namespace Lesson3_2
{
    /* [Sergej Solodukho]
     * 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
     *       Требуется подсчитать сумму всех нечетных положительных чисел. 
     *       Сами числа и сумму вывести на экран, используя tryParse;
     *    б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
     *       При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
     */
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            int input = 0;
            int sum = 0;
            string inputNumbers = "";
            bool isParseSeccessful = false;
            do
            {
                Console.WriteLine("Введите число: ");
                isParseSeccessful = int.TryParse(Console.ReadLine(), out input);
                if (!isParseSeccessful)
                    ShowExceptionMasage();

                if (input > 0 && IsOdd(input))
                {
                    inputNumbers += input.ToString() + " + ";
                    sum += input;
                }
            }
            while (input != 0 || isParseSeccessful);
            
            Console.WriteLine($"Сумма введённых нечетных положительных чисел: \n{inputNumbers.Remove(inputNumbers.Length - 2)}= {sum}");
            Console.ReadKey();
        }

        private static void ShowExceptionMasage()
        {            
              Console.WriteLine("Это не число!");
        }

        private static bool IsOdd(int input)
        {
            return input % 2 != 0;
        }
    }
}
