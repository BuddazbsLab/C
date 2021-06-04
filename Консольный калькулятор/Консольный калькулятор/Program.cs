using System;
using Консольный_калькулятор;

public abstract class Program
{
    static void Main()
    {
        string again = "да";
        while (again == "да")
        {
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Консольный калькулятор (версия 0.0000001 Gamma)");
                Console.WriteLine(' ');
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"Выберите что нужно от меня:
                                    - Кого умножить (введите 1)
                                    - Что разделить (введите 2)
                                    - Сложить что-то (введите 3)
                                    - У кого вычесть (введите 4)
                                    - Процент от деления (введите 5)");
                Console.ForegroundColor = ConsoleColor.Red;
                string type = Console.ReadLine();
                double a, b;
                Console.WriteLine(' ');
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Тыкай пальчиками и вводи первое число");
                Console.ForegroundColor = ConsoleColor.Red;
                a = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Тыкай пальчиками и вводи второе число");
                Console.ForegroundColor = ConsoleColor.Red;
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(' ');
                switch (type)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Результат приумножения = {0}", MathOperations.Multiply(a, b));
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Результат деления = {0}", MathOperations.Division(a, b));
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Результат сложения = {0}", MathOperations.Sum(a, b));
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Результат вычитания = {0}", MathOperations.Minus(a, b));
                        break;

                    case "5":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Результат возведения числа в степень = {0}", MathOperations.Percentage_of_separation(a, b));
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Тыкнул не туда и не скажу где именно не туда ахахахаха");
                        break;
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (да/нет)");
                again = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
