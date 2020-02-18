using System;

namespace Lesson1
{
    class Anketa
    {
        /*
         Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
         В результате вся информация выводится в одну строчку:
            а) используя  склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.
         */
        static void Main(string[] args)
        {
            Console.Title = "«Анкета». Сергей Солодухо";
            /* Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40); */
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("имя:");
            string name = Console.ReadLine();

            Console.Write("фамилия:");
            string surname = Console.ReadLine();

            Console.Write("возраст:");
            string age = Console.ReadLine();

            Console.Write("рост:");
            string size = Console.ReadLine();

            Console.Write("вес:");
            string weight = Console.ReadLine();

            Console.WriteLine();

            // а) используя  склеивание
            Console.WriteLine("а) имя: " + name + ", фамилия: " + surname + ", возраст: " + age + ", рост: " + size + ", вес: " + weight);

            // б) используя форматированный вывод
            Console.WriteLine("б) имя: {0}, фамилия: {1}, возраст: {2}, рост: {3}, вес: {4}", name, surname, age, size, weight);

            // в) используя вывод со знаком $
            Console.WriteLine($"в) имя: {name}, фамилия: {surname}, возраст: {age}, рост: {size}, вес: {weight}");

            Console.ReadKey();
        }

    }
}
