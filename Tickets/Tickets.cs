using System;


namespace Tickets
{
    public class Tickets
    {
        //int minNumber { get; set; }
        //int maxNumber { get; set; }
        //int ticketsAmount { get; set; }
        //public Tickets(int min, int max)
        //{
        //    minNumber = min;
        //    maxNumber = max;
        //}

        // ticketsAmount = maxNumber - minNumber;
        public int[] GetNumbers(int number)
        {
            //Console.Write(number + " ----- ");
            int[] digits = new int[6];
            digits[0] = number / 100000;
            
            digits[1] = (number / 10000) % 10;
            
            digits[2] = (number / 1000) % 10;
            
            digits[3] = (number / 100) % 10;
            
            digits[4] = (number / 100) % 10;
            
            digits[5] = number % 10;
            
            return digits;
        }
        public bool FirstWay (int [] digits)
        {
            return ((digits[0] + digits[1]+digits[2]) == (digits[3] + digits [4] + digits[5]));
        }

        public bool SecondWay(int[] digits)
        {
            return ((digits[0] + digits[2] + digits[4]) == (digits[1] + digits[3] + digits[5]));
        }
        public int FirstCount (int minNumber, int maxNumber)
        {
            int count=0;
            for (int ticket=minNumber; ticket<=maxNumber; ticket++)
            {
                if (FirstWay(GetNumbers(ticket)))
                {
                    
                    count++;
                   
                }
            }
            return count;
        }

        public int SecondCount(int minNumber, int maxNumber)
        {
            int count = 0;
            for (int ticket = minNumber; ticket <= maxNumber; ticket++)
            {
                if (SecondWay(GetNumbers(ticket)))
                {
                    count++;
                }
            }
            return count;
        }

        //public (int, int, int) CompareTo (int minNumber, int maxNumber)
        //{
        //    return (    )
        //}

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
