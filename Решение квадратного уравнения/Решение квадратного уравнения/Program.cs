using System;

namespace Решение_квадратного_уравнения
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double a, b, c;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        Console.WriteLine("x - любое");
                    else
                        Console.WriteLine("Нет корней");
                else
                    Console.WriteLine("x = {0}", -c / b);
            else
            {
                double d = b * b - 4 * a * c;
                if (d > 0)
                {
                    d = Math.Sqrt(d);
                    Console.WriteLine("x1 = {0}", (-b + d) / (2 * a));
                    Console.WriteLine("x1 = {0}", (-b - d) / (2 * a));
                }
                else
                    Console.WriteLine("Нет вещественных корней");
            }

            Console.ReadKey();
        }
    }
}
            