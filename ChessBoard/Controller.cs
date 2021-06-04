using System;
using ChessBoard.Model;

namespace ChessBoard
{
    class Controller
    {

        public void Run(string [] args)
        {

            ushort width;
            ushort height;
            
            View.Greeting();

            //реализовать
            Checker.CheckArgs(args);

            //View.SetSize(out width, out height);
            Board board = new Board(View.SetSize());
            board.FillCells();
            View.PrintBoard(board.cells);           
            
        }
        
       
      

    }
   
}
