using System;

namespace Comparing_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число для сравнения: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для сранения: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }

        }
    }
}