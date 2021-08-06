using System;

namespace Object_OOP
{
    class PersonClass
    {
        static void Main(string[] args)
        {
            Person p = new Person("Михаил", "Фленов"); 
            Console.WriteLine(p.ToString());  // ToString - превращает класс в строку

            Object o = p;
            Console.WriteLine(o.ToString());
            // Equals - сравнение свойств переменных тип bool
            Person p1 = new Person("Михаил", "Фленов");
            Person p2 = new Person("Михаил", "Фленов");
            // p1 и p2 имеют одинаковые значения свойств
            Person p3 = p1;
            Console.WriteLine(p1.Equals(p2)); // False/  После переопределения Equals возращает True
            Console.WriteLine(p1.Equals(p3)); // True 
        }
    }
}