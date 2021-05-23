using System;

namespace ChessBoard
{
    public class Board
    {
        internal void Print(int Height, int Width)
        {
           






            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < Height; i++)
            {
                switch (i % 2)
                {
                    case 0:
                        for (int j = 0; j < Width; j++)
                        {
                            switch (j % 2)
                            {
                                case 0:
                                    Console.Write("*");
                                    break;
                                default:
                                    Console.Write(" ");
                                    break;
                            }                                                                                          
                        }
                        Console.WriteLine();
                        break;
                    default:
                        for (int j = 0; j < Width; j++)
                        {
                            switch (j % 2)
                            {
                                case 0:
                                    Console.Write(" ");
                                    break;
                                default:
                                    Console.Write("*");
                                    break;
                            }
                        }
                        Console.WriteLine();
                        break;
                }
                    
             
            }
    
        }
    }
}

