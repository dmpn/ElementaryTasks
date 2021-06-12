using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace NumberToString.Model
{
    public class Numbers
    {
        private const int ranksInClass = 3;
        public bool isZero { get; } = true;
        private Stack<Number> numbers { get; } = new Stack<Number>();

        public IEnumerator GetEnumerator()
        {
            foreach (Number number in numbers)
            {
                yield return number; 
            }
        }
                        
        public Numbers (string originNumber)
        {
            
            while (originNumber.Length %3 > 0)
            {
                originNumber = "0" + originNumber;
            }
                for (int i = originNumber.Length - 1, j = 0; i >= 0; i -= ranksInClass, j++)
                {
                    StringBuilder tempString = new StringBuilder();
                    tempString.Append(originNumber[i - 2]);
                    tempString.Append(originNumber[i - 1]);
                    tempString.Append(originNumber[i]);
                    numbers.Push(new Number(j, tempString.ToString()));
                    if (numbers.Peek().ToString().Length>0)
                    {
                        isZero = false;
                    }
                }
        }
    }
}
