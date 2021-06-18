/*За прохождение первого уровня видеоигры игрок получает 1 очко. За каждый последующий пройденный уровень получаемые очки увеличиваютя на 1. 
Дана программа, которая принимает на входе колличество пройденных уровней. Дополните данную функцию, чтобы она принимала количество уровней в качестве аргумента, затем рекурсивоно
вычисляла и возращала общее колличество очков, полученное за все пройденные уровни.*/

using System;

namespace Reqursia
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Points(levels));
        }

        static int Points(int levels)
        {
            if (levels == 1)
            {
                return 1;
            }

            return levels + Points(levels - 1);
        }
    }
}