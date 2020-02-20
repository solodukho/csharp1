using System;

namespace Lesson1_2
{
    /*  [Sergej Solodukho]
     * И́ндекс ма́ссы те́ла (англ. body mass index (BMI), ИМТ).
     Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
     где m — масса тела в килограммах, h — рост в метрах.
     */
    class BMI
    {
        static void Main(string[] args)
        {
            Console.Title = "«Рассчёт массы тела». Сергей Солодухо";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("И́ндекс ма́ссы те́ла (англ. body mass index (BMI), ИМТ) — величина, позволяющая оценить степень соответствия массы человека и его роста и тем самым косвенно оценить, является ли масса недостаточной, нормальной или избыточной.\n");
            Console.Write("Для рассчёта индекса массы Вашего тела введите \nВаш вес в килограммах: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nи Ваш рост в метрах: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double i = m / (h * h);
            string text = GetBmiDescription(i);

            Console.WriteLine($"Ваш BMI = {i}. {text}");
            Console.ReadKey();
        }

        private static string GetBmiDescription(double bmi)
        {
            string description = string.Empty;
            if (bmi <= 16)
            {
                description = "Выраженный дефицит массы тела!!";
            }
            else if (bmi > 16 && bmi <= 18.5)
            {
                description = "Недостаточная (дефицит) масса тела!";
            }
            else if (bmi > 18.5 && bmi <= 24.99)
            {
                description = "Норма";
            }
            else if (bmi > 25 && bmi <= 30)
            {
                description = "Избыточная масса тела (предожирение)";
            }
            else if (bmi > 30 && bmi <= 35)
            {
                description = "Ожирение!";
            }
            else if (bmi > 35 && bmi <= 40)
            {
                description = "Ожирение резкое!!";
            }
            else if (bmi > 40)
            {
                description = "Очень резкое ожирение!!!";
            }
            return description;
        }
    }
}
