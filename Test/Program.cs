using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string s1 = "1 2 3 4 5";
            string s2 = s1.Replace(' ', '_');
            Console.WriteLine($"s1: "+s1);
            Console.WriteLine($"s2: "+s2);


            int[][] nums = new int[3][];
            nums[0] = new int[3] { 1, 2, 3 };

        }
    }
}
