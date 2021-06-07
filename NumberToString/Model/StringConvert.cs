using System;
using System.Collections.Generic;
using System.Text;


namespace NumberToString.Model
{
   public class StringConvert
    {
        //NumbersClass[] numbers;

        public static void Print (string userInput)
        {
            Stack<NumbersClass> numbers = new Stack<NumbersClass>();

            for (int i = userInput.Length - 1, j = 0; i >= 0; i -= 3, j++)
            {
                StringBuilder tempString = new StringBuilder();
                tempString.Append(userInput[i - 2]);
                tempString.Append(userInput[i - 1]);
                tempString.Append(userInput[i]);
                numbers.Push(new NumbersClass(j, tempString.ToString()));
                
            }

            foreach (NumbersClass number in numbers)
            {
                Console.Write(number.text);
                Console.WriteLine();
            }
        }
    }
}
