using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class View
    {
        public static void Greeting ()
        {
            
            Console.WriteLine("Программа определяет, какой из используемых способов подсчёта счастливых билетов \n" +
                            "даст их большее количество на заданном интервале. \n" +
                            "Входные параметры: min и max номер билета \n" +
                            "Выход: информация о победившем методе и количестве счастливых билетов \n" +
                            "для каждого способа подсчёта.");
        }

        public (int min, int max) numbers;
        public static void IncorrectValue ()
        {
            Console.WriteLine("Номер билета должен быть в диапазоне от 000001 до 999999: ");
        }

        public static void Firstway(int number)
        {
            Console.WriteLine($"Простой способ обнаружил {number} счастливых билетов.");
        }

        public static void SecondWay(int number)
        {
            Console.WriteLine($"Сложный способ обнаружил {number} счастливых билетов.");
        }

        public static void Winner(int win)
        {
            if (win != 2)
            {
                List<string> ways = new List<string>() { "Первый", "Второй" };
                Console.WriteLine($"{ways[win]} способ победил!");
            }
            else
            {
                Console.WriteLine("Способы равны.");    
            }
        }
        public static bool Resume()
        {
            Console.WriteLine("Ввести новые билеты (y/yes)?");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                case "yes":
                   
                    return true;
                default:
                   
                    return false;
            }
        }
        public static string[] ReadNumber()
        {
            string [] limits = new string [2];
            Console.Write("Введите начало диапазона:");
            limits[0]=Console.ReadLine();
            Console.Write("Введите конец диапазона:");
            limits[1] = Console.ReadLine();
            return limits;
        }

    }
}
