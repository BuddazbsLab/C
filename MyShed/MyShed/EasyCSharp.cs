using System;
using System.Collections.Generic;
using System.Text;



namespace MyShed
{
    class EasySHarp
    {
        static void Main(string[] args)
        {
            // Создаем объект 

            Shed myFirstShed = new Shed();
            // Создаем объект 
            Shed shed = new Shed();
            //shed.Width = 2;
            //shed.Height = 1;
            //shed.Lengthwise = 3;
            Console.WriteLine(shed.GetObjectNumber());
            Shed shed1 = new Shed();
            Console.WriteLine(shed1.GetObjectNumber());
            
            // Вызов метода ExpandSize
           // shed.ExpandSize(2, 4, 6);
            //Console.WriteLine("Новая ширина: " + shed.Width);
           // int vx = 2;
           // int vy = 4;
           // int vz = 6;
           // shed.ExpandAndGetSize(ref vx, ref vy, ref vz);
           // Console.WriteLine("Размеры 1: " + vx + " " + vy + " " + vz);

           // shed.ExpandAndGetSize2(10, out vx, out vy, out vz);
           // Console.WriteLine("Размеры 2: " + vx + " " + vy + " " + vz);
            
            
            // Задаем значения свойств

            myFirstShed = new Shed();
            // Вызов метода ExpandSize
            shed = new Shed();
            shed.Width = 2;
            shed.Height = 1;
            shed.Lengthwise = 3;

            shed.ExpandSize(2, 4, 6);
            Console.WriteLine("Новая ширина: " + shed.Width);
            int vx = 2;
            int vy = 4;
            int vz = 6;
            shed.ExpandAndGetSize(ref vx, ref vy, ref vz);
            Console.WriteLine("Размеры 1: " + vx + " " + vy + " " + vz);

            shed.ExpandAndGetSize2(10, out vx, out vy, out vz);
            Console.WriteLine("Размеры 2: " + vx + " " + vy + " " + vz);
            
            
            
            
            
            
                // Задаем значения свойств

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Тыкай пальчиками и введи Высоту сарая");
            myFirstShed.Height = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Тыкай пальчиками и введи Ширину сарая");
            myFirstShed.Width = int.Parse(Console.ReadLine());
            myFirstShed.Lengthwise = myFirstShed.Width;
            
            // Вывод параметров сарая
            Console.WriteLine("А вот и параметры твоего кривого сарая:");
            Console.WriteLine("Высота: " + myFirstShed.Height);
            Console.WriteLine("Ширина: " + myFirstShed.Width);
            Console.WriteLine("Глубина: " + myFirstShed.Lengthwise);

            int size = myFirstShed.GetSize();    //Через Переменная = имя_объекта.Имя_метода  - вызов через переменную
            Console.WriteLine("Объем: " + size);
            Console.WriteLine("Объем: " + myFirstShed.GetSize()); // Через имя_объекта.Имя_метода 

            //int size = myFirstShed.GetSize();    Переменная = имя_объекта.Имя_метода  - вызов через переменную
            //Console.WriteLine("Объем: " + size);
            Console.WriteLine("Объем: " + myFirstShed.GetSize()); // имя_объекта.Имя_метода 
            Console.ReadLine();
        }
    }
}