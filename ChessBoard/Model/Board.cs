using ChessBoard.Model;

namespace ChessBoard
{
      struct Board
    {
        
        internal int height { get; set; }
        internal int width { get; set; }
        internal Cell[] cells { get; set; }

        public Board((int height, int width) size )
        {
            width = size.width;
            height = size.height;
            cells = new Cell[height * width];
        }
        internal void FillCells()
        {
            int currentNumber = 0;
            cells = new Cell[height*width];
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++, currentNumber++)
                {
                    if ((i + j)%2==0)
                    {
                        cells[currentNumber].symbol = " ";
                    }
                    else
                    {
                        cells[currentNumber].symbol = "*";
                    }
                }
                cells[currentNumber - 1].isLast = true;
            }          
        }
    }
}
