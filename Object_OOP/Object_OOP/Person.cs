using System;

namespace Object_OOP
{
    public class Person: System.Object  //Пример наследования от класса Object
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        
        // Переопределение метода ToString
        // override - полностью переопределяет метод
        //new - создаем свою независимуют от предка версию того же метода
        public override string ToString()  // override - объявляет что мы переопределяем метод. Тут мы переопределяем метод, который был у предка с таким же именем (ToString)
        {
            return FirstName + " " + LastName;
        }
        
        // Переопределение метода Equals через new
        public new bool Equals(Object obj) // Присваиваем объект obj переменной класса Person
        {
            Person person = (Person) obj;
            return (FirstName == person.FirstName) &&  // возращает результат сравнения двух свойств
                   (LastName == person.LastName);
        }

        public string ComparePerson(Person person)
        {
            bool equalParams = Equals(person);
            bool fullEqual = base.Equals(person); // через ключевое слово base обращаемся к методу предку. Base - указывает на предка текущего класса

            if (fullEqual)
            {
                return "Абсолютно одинаковые объекты";
            }

            if (equalParams)
            {
                return "Одинаковые свойства объектов";
            }

            return "Объекты разные";
        }
    }
}