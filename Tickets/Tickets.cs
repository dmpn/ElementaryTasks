using System;


namespace Tickets
{
    public class Tickets
    {

        public int[] GetNumbers(int number)
        {
            int[] digits = new int[6];
            digits[0] = number / 100000;
            digits[1] = (number / 10000) % 10;
            digits[2] = (number / 1000) % 10;
            digits[3] = (number / 100) % 10;
            digits[4] = (number / 10) % 10;
            digits[5] = number % 10;
            return digits;
        }
        public bool FirstWay(int[] digits)
        {
            return ((digits[0] + digits[1] + digits[2]) == (digits[3] + digits[4] + digits[5]));
        }

        public bool SecondWay(int[] digits)
        {
        
           return ((digits[0] + digits[2] + digits[4]) == (digits[1] + digits[3] + digits[5]));
        }

        public delegate bool Ways(int[] digits);
       
        public int Count(int minNumber, int maxNumber, bool checkWay)
        {
            Ways way;
            way = FirstWay;
            if (checkWay)
            {
                way = SecondWay;
            }
            int count = 0;
            for (int ticket = minNumber; ticket <= maxNumber; ticket++)
            {
                if ( way (GetNumbers(ticket)))
                {
                    count++;
                }
            }
            return count;
        }

        public int Compare(int firstCount, int secondCount)
        {
            if ( firstCount > secondCount  )
            {
                return 0;
            }
            else if (firstCount < secondCount)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
