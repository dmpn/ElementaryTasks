using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller(args);
            controller.Run();
        }
    }
}
