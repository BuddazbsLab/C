using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShed
{ //// создаем класс сарая и доступ к переменным по ООП


    public class Shed
    {
        //Конструктор  контролирует устанавливаемые в свойства занчения. 
        public Shed(int w, int l, int height)
        {
            width = w; // нужно проиницилизировать переменную width и просто присваиваем значение
            Lengthwise = l; // необходимо изменить свойтсво, для которой нет переменной, потому что объявляли в сокращенно варианте и присваиваем заначение именно свойтсву 
            this.height = height; // переменная через которую передается занчение, имеет точно такое же имя, что и переменная класса.  
        }

        //Статичная переменная 
        static int _objectNumber = 0;
        public int GetObjectNumber()
        {
            return _objectNumber;
        }

        public Shed()
        {
            _objectNumber++;
        }



        // Переменные (Свойства сарая), хороший тон и не нарушает принципы безопастности, переменные должны быть закрыты (private или protected)
        private int width;
        private int height;

        // Создаем свойства для обращения к закрытым переменным. Свойтсва должн быть открытыми, что бы с ними можно было работать 
        public int Width
            // get и set это Аксессоры позволяют указать доступ к свойству на чтение (get) и запись (set)
        {
            get { return width; }
            set
            {
                if (value > 0 && value < 100)
                {
                    width = value;
                }
                else
                {
                    return;
                    Console.WriteLine("Сарай не может быть больше 100 и не может быть отрицательным\n" +
                                      "Мы строим нормальные сараи");
                }
            } // Виртуальная переменная имеет такойже тип данных что и свойстов. Ставим ее так как ранее ни где не инициализировал ее. 
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0 && value < 100)
                {
                    height = value;
                }
                else
                {
                    
                    Console.WriteLine("Сарай не может быть больше 100 и не может быть отрицательным\n" +
                                      "Мы строим нормальные сараи");
                    return;
                }
            }
        }

        public int Lengthwise { get; set; }

        // Метод возрата размеров (объем)
        public int GetSize()
        {
            return Width * Height * Lengthwise;
        }
        
        // Метод увелечения сарая
        public void ExpandSize(int x, int y, int h)
        {
            Width += x;
            Lengthwise += y;
            Height += h;
        }
        // Перегрузка метода 

        public void ExpandSize(int x, int y)
        {
            Width += x;
            Lengthwise += y;
        }

        // Метод который расширяет сарай и одновременно изменяет переданные значения 
        public void ExpandAndGetSize(ref int x, ref int y, ref int h)
        {
            ExpandSize(x, y, h);
            x = Width;
            y = Lengthwise;
            h = Height;
        }
        public void ExpandAndGetSize2(int inc, out int x, out int y, out int h)
        {
            ExpandSize(inc, inc, inc);
            x = Width;
            y = Lengthwise;
            h = Height;
        }



    }
}