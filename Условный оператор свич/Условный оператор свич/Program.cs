using System;

namespace Условный_оператор_свич
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            //var s = input == 10 ? "да" : "нет";
            Console.WriteLine(input == 10 ? "да" : "нет");
            switch (input)
            {
                case 1:
                    //действия 1
                   break; // оператор выхода
                case 2:
                   break;
                case 3:
                   break;
                default:
                    break;
            }
        }
    }
}
