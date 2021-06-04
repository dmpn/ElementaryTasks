using System;


namespace ChessBoard.Model
{

    public static class Checker
    {
        
        public static bool CheckWidth (int width)
        {
            if (width >= 1 && width <= Console.WindowWidth)
            {                
                return true;                
            }
            Console.WriteLine("Ширина может быть от 1 до " + Console.WindowWidth);
            return false;
        }

        public static bool CheckHeight(int height)
        {
            if (height >= 1 && height <= Console.WindowHeight)
            {
                return true;
            }
            Console.WriteLine("Высота может быть от 1 до "+ Console.WindowHeight);
            return false;
        }
        public static bool CheckArgs (string [] args)
        {
            
            return false;
        }


        
    }
}
