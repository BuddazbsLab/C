using System;

namespace Вывод_чисел_кратные_трем_и_замена_их_на_звезду
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write('*');
                    continue;
                }
                Console.Write(i);

            }
        }
    }
}
