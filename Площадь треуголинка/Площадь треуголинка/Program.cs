using System;

namespace Площадь_треуголинка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            double a, b, c;
            //ввод данных
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            //Проверка существования треугольника
            if (a > 0 & b > 0 & c > 0 & a + c > b & b + c > a & a + b > c)
            {
                //Вычесление знаков косинуса
                double cosC = a * a + b * b - c * c;
                double cosA = c * c + b * b - a * a;
                double cosB = a * a + c * c - b * b;
                // Анализ треугольника
                if (cosC < 0 | cosA < 0 | cosB < 0)
                    Console.WriteLine("Тупо-уголный");
                else if (cosC > 0 & cosA > 0 & cosB > 0)
                    Console.WriteLine("Остроугольный");
                else if (cosC == 0 | cosA == 0 | cosB == 0)
                    Console.WriteLine("Прямоугольный");
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("S = {0:F3}", s);
                //Сортировка a, b, c
                double t;
                if (a < b)
                {
                    t = a;
                    a = b;
                    b = t;
                }

                if (b < c)
                {
                    t = c;
                    c = b;
                    b = t;
                }

                Console.WriteLine("a = {0} b = {1} c = {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("Не треугольник");
            }

            Console.ReadKey();
        }
    }
}