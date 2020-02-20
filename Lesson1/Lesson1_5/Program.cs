using System;

namespace Lesson1_5
{
    class Program
    {
        /* [Solodukho]
        * 5.
           а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
           б) Сделать задание, только вывод организуйте в центре экрана
           в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
       */
        static void Main(string[] args)
        {
            string output = "Bill Gates. Seattle";

            // а)
            //Console.WriteLine($"{name} {surname}. {city}");
            //Console.ReadKey();

            // б) Сделать задание, только вывод организуйте в центре экрана      
            //Console.SetCursorPosition((Console.WindowWidth - output.Length) / 2, Console.WindowHeight / 2);
            //Console.WriteLine(output);
            //Console.ReadKey();

            // в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
            Print(output, (Console.WindowWidth - output.Length) / 2, Console.WindowHeight / 2);
            Console.ReadKey();
        }

        private static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
    }
}
