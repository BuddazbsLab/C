using System;

namespace ConsoleApp1Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortRes, shortVal = 4;
            int intVal = 67;
            long longRes;
            float floatVal = 10.5F;
            double doubleRes, doubleVal = 99.999;
            string strRes, strVal = "17";
            bool boolVal = true;
            Console.WriteLine(" Примеры преобразования ");
            Console.WriteLine();
            // Примеры преобразованич переменных
            doubleRes = floatVal * shortVal;
            Console.WriteLine("Неявные (double) : {0}*{1} -> {2}",
                floatVal, shortVal, doubleRes);
            shortRes = (short)floatVal;
            Console.WriteLine("Явные (short) : {0} -> {1}",
                floatVal, shortRes);
            strRes = Convert.ToString(boolVal) +
                Convert.ToString(doubleVal);
            Console.WriteLine("Явные (string): \"{0} \"+\"{1}\" -> {2}", boolVal, doubleVal, strRes);
            longRes = intVal + Convert.ToInt64(strVal);
            Console.WriteLine("Смешанные (long) : {0} + {1} -> {2}", intVal, strVal, longRes);
            Console.ReadKey();
        }
    }
}
// Преобразования типы данных