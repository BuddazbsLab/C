﻿using System;

namespace EnumDays
{
    class Program
    {
        enum Days
        { 
            Mon,
            Tru,
            Wed,
            Tro,
            Fri,
            Sut,
            Sun

        }

        static void Main(string[] args)
        {
            Console.WriteLine(Days.Fri);
            Console.ReadLine();

        }
    }
}
// Enum это пользовательский тип данных, представляющий собой набор именованных целочисленных констант.