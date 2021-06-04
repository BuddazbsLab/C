using System;

namespace Математические_операции
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string Name;
            Console.WriteLine("Введи свое имя Смертный:");
            Name = Console.ReadLine();
            Console.WriteLine("Сядь на бутылку" + " " + Name + " " +"и начинай вписывать цифры");
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}+{1} = {2}", a, b, a + b);
            Console.WriteLine("{0}-{1} = {2}", a, b, a - b);
            Console.WriteLine("{0}*{1} = {2}", a, b, a * b);
            Console.WriteLine("{0}/{1} = {2}", a, b, a / b);
            Console.WriteLine("{0}%{1} = {2}", a, b, a % b);
            Console.ReadKey();
        }
    }
}
