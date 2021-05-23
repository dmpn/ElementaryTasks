using System;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("This application prints a chessboard.");
                    Console.WriteLine("Start application with two integer args in range 1 - 100");
                    break;
                case 2:
                    int Height = 0, Width = 0;
                    if (int.TryParse(args[0], out Height) && int.TryParse(args[1], out Width))
                    {
                        if (0 < Height && Height <= 100 && 0 < Width && Width <= 100)
                        {
                            Board Board = new Board();
                            Board.Print(Height, Width);
                        }
                        else
                        {
                            Console.WriteLine("Incorrect params");
                        }
                    }
                    else
                        Console.WriteLine("Incorrect params"); 
                    break;
                default:
                    Console.WriteLine("Incorrect params");
                    break;
            }
           

           
        }
    }
}
  
       
