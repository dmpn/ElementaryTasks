using NumberToString.Model;
using System;

namespace NumberToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Start(args);
        }
    }
}