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
            Console.Write("Введите номер билета от 000001 до 999999: ");
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
    }
}
