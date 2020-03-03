using System;

namespace Lesson3_1
{
    /*   [Sergej Solodukho]
     *   1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
     *      б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
     *      в) Добавить диалог с использованием switch демонстрирующий работу класса.
     */
    struct ComplexStruct
    {
        /*  ------------------------------------------------------------------------------------------
         *  Ко́мпле́ксные чи́сла (от лат. complex — совокупный, тесно связанный) — числа вида a+bi, 
         *  где a,b — вещественные числа, i — мнимая единица, 
         *  то есть число, для которого выполняется равенство: i²=-1. 
         *  Множество комплексных чисел обычно обозначается символом C.
         *  
         *  Комплексное число — это выражение вида a + bi, где a, b — действительные числа, 
         *  а i — так называемая мнимая единица, символ, квадрат которого равен –1, то есть i² = –1
         *  
         *  комплексное число z = a + bi состоит из двух компонентов:
         *  - Величина a называется вещественной частью числа z и согласно международным стандартам ISO 31-11 и ISO 80000-2 обозначается Re z или Re (z).
         *  - Величина b называется мнимой частью числа z и согласно международным стандартам ISO 31-11 и ISO 80000-2 обозначается Im z или Im (z).
         *  
         *  Re — реактанс, обозначение для действительной части комплексного числа, помимо 
         *  Im — его мнимой части (аббревиатура от английского слова Instant messenger).
         *  ------------------------------------------------------------------------------------------
         */
        public double im; // Мнимая часть
        public double re; // Вещественная/действительная часть

        // (a + bi) + (c + di) = (a + c) + (b + d)i
        // (complex1) + (complex2) = (complex1.re + complex2.re) + (complex1.im + complex2.im)i
        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y; // result
            y.im = im + x.im; // y.im = 1 + 2;
            y.re = re + x.re; // y.re = 1 + 2;
            return y;
        }

        // (a + bi) - (c + di) = (a - c) + (b - d)i
        // (complex1) - (complex2) = (complex1.re - complex2.re) + (complex1.im -complex2.im)i
        public ComplexStruct Subtract(ComplexStruct x)
        {
            ComplexStruct y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        //  (a+bi) * (c+di) = ac + bci + adi + bdi² = (ac + bdi²) + (bc + bd)i = (ac - bd) + (bc + bd)i
        public ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = re * x.im + im * x.re; // y.im = 1 * 2 + 1 * 2;
            y.re = re * x.re - im * x.im; // y.re = 1 * 2 - 1 * 2;
            return y;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    public class ComplexClass
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public ComplexClass(double re, double im)
        {
            Re = re;
            Im = im;
        }
        /// <summary>
        /// Сложение: (a + bi) + (c + di) = (a + c) + (b + d)i
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static ComplexClass operator + (ComplexClass x, ComplexClass y)
        {
            return new ComplexClass(x.Re + y.Re, x.Im + y.Im);
        }
        /// <summary>
        /// Вычитание: (a + bi) - (c + di) = (a - c) + (b - d)i
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static ComplexClass operator - (ComplexClass x, ComplexClass y)
        {
            return new ComplexClass(x.Re - y.Re, x.Im - y.Im);
        }
        /// <summary>
        /// Умножение: (a+bi) * (c+di) = ac + bci + adi + bdi² = (ac + bdi²) + (bc + bd)i = (ac - bd) + (bc + bd)i
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static ComplexClass operator * (ComplexClass x, ComplexClass y)
        {
            return new ComplexClass(x.Re * y.Re - x.Im * y.Im, x.Re * y.Im + y.Re * x.Im);
        }
        /// <summary>
        /// Деление: (a + bi) / (c + di) = ((ac + bd) / c² + d²) + ((bc - ad) / c² + d²)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static ComplexClass operator / (ComplexClass x, ComplexClass y)
        {
            if(y.Re * y.Re + y.Im * y.Im == 0)
                throw new Exception("На ноль делить нельзя!");

            return new ComplexClass((x.Re * y.Re + x.Im * y.Im) / (y.Re * y.Re + y.Im * y.Im), (x.Im * y.Re - x.Re * y.Im) / (y.Re * y.Re + y.Im * y.Im));
        }
    }

    class ProgramComplex
    {
        static void Main(string[] args)
        {
            ComplexStruct complex1;
            complex1.re = 2;
            complex1.im = 1;

            ComplexStruct complex2;
            complex2.re = 4;
            complex2.im = 3;

            string a = $"({complex1.re} + {complex1.im}i)";
            string b = $"({complex2.re} + {complex2.im}i)";

            Console.WriteLine("Вычисления с использованием Структуры:");
            ComplexStruct result = complex1.Plus(complex2);
            Console.WriteLine($"{a} + {b} = {result.ToString()}");

            result = complex1.Subtract(complex2);
            Console.WriteLine($"{a} - {b} = {result.ToString()}");

            result = complex1.Multi(complex2);
            Console.WriteLine($"{a} * {b} = {result.ToString()}");

            Console.WriteLine("\n------------------------------------\nДалее с использованием Класса:");
            ComplexClass x = new ComplexClass(8, 4);
            ComplexClass y = new ComplexClass(10, -3);

            string a1 = $"({x.Re} + {x.Im}i)";
            string b1 = $"({y.Re} + {y.Im}i)";

            ComplexClass plus = x + y;
            Console.WriteLine($"{a1} + {b1} = {plus}\n.......\n.....\n...");

            Console.ReadKey();
        }
    }
}
