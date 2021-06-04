using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString
{
    class View
    {
        public static bool ArgsLenght(string[] args)
        {
            switch (args.Length)
            {
                case 1:
                    {
                        return true;
                    }
                default:
                    {
                        Console.WriteLine("Программа преобразовывает переданное в параметре целое число \n" +
                            "в прописной вариант (12 – двенадцать)");
                        return false;
                    }
            }
        }
    }
}
