using System;
using ChessBoard.Model;

namespace ChessBoard
{
    class View
    {      
        internal static void Greeting ()
        {
            Console.WriteLine("Программа выводит на экран шахматную доску");
        }

        internal static (int, int) SetSize()
        {
            (int, int) size;
            Console.WriteLine("Введите ширину шахматной доски");
            while (!(int.TryParse(Console.ReadLine(), out size.Item1)) || !Checker.CheckWidth(size.Item1))
            {               
                Console.WriteLine("Некорректный ввод");               
            }

            Console.WriteLine("Введите высоту шахматной доски");
            while (!(int.TryParse(Console.ReadLine(), out size.Item2)) || !Checker.CheckHeight(size.Item2))
            {
                Console.WriteLine("Некорректный ввод");
            }
            return size;
        }
        
        internal static void PrintBoard (Cell [] cells)
        {
            foreach (Cell cell in cells)
            {               
                Console.Write(cell.symbol);
                if (cell.isLast)
                    Console.WriteLine();
            }
        }      

    }
}
