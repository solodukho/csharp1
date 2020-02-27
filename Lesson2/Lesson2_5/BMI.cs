using System;

namespace Lesson2_5
{
    /* [Sergej Solodukho] 
     * 5.	а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
     *      б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
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

            double i = Math.Round( m / (h * h) );
            string text = GetBmiDescription(i, h);

            Console.WriteLine($"Ваш BMI = {i}. {text}");
            Console.ReadKey();
        }

        private static string GetBmiDescription(double bmi, double h)
        {
            string description = string.Empty;
            string toGrow = $"\nВам необходимо набрать {(24.99 - bmi) * h * h} кг для нормализации веса.";
            string toReduce = $"\nВам необходимо похудеть на {Math.Round((bmi - 24.99) * h * h)} кг для нормализации веса.";

            if (bmi <= 16)
            {
                description = $"Выраженный дефицит массы тела!!{toGrow}";
            }
            else if (bmi > 16 && bmi <= 18.5)
            {
                description = $"Недостаточная (дефицит) масса тела!{toGrow}";
            }
            else if (bmi > 18.5 && bmi <= 24.99)
            {
                description = "Поздравляю, Ваша масса тела находится в норме!";
            }
            else if (bmi > 25 && bmi <= 30)
            {
                description = $"Избыточная масса тела (предожирение).{toReduce}";
            }
            else if (bmi > 30 && bmi <= 35)
            {
                description = $"Ожирение!{toReduce}";
            }
            else if (bmi > 35 && bmi <= 40)
            {
                description = $"Ожирение резкое!!{toReduce}";
            }
            else if (bmi > 40)
            {
                description = $"Очень резкое ожирение!!!{toReduce}";
            }
            return description;
        }
    }
}
