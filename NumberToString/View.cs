using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString
{
    class View
    {
        public static void Start()
        {
            Console.WriteLine("   Приложение преобразовывает целое число в прописной вариант\n" +
                              "Для получения справки запустите приложение с параметром -help");
        }
        public static void Help()
        {
            Console.WriteLine("   Запустите приложение с параметром, который должен представлять\n" +
                              "целое число от 0 до 999999999999999999999 без разделителей");
        }
        public static void IncorrectValue()
        {
            Console.WriteLine("Введите целое число от 0 до 999999999999999999999 без разделителей");
        }
        public static string EnterNumber()
        {
            Console.Write("Введите число:");
            return (Console.ReadLine());
        }
        public static void Print (string value)
        {
            Console.WriteLine(value);
        }
        public static bool Resume()
        {
            Console.WriteLine("Ввести новое число (y/yes)?");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                case "yes":
                    
                    return true;
                default:
                    return false;
            }
        }
        public static void Zero ()
        {
            Console.WriteLine("ноль");
        }
        
    }
}
