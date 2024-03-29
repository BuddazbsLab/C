﻿using System;

namespace Vision
{
    class Program
    {
        static int sum = 1, max = 6; //в данной видимсоти переменные доступны любому методу классу в независимости от используемых модификаторов доступа
        public static void Main(string[] args)
        {
            var i = 2;
            do
            {
                sum *= i;
                i++;
            } while (i <= max);

            Console.WriteLine(sum);
        }
    }
}


// Рассматриваем области видимости переменных внутри калсса и функций.
// Переменная sum и mux объявлены внутри класса, но не внутри функции Main