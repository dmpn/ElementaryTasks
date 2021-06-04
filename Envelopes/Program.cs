using System;

namespace Envelopes
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            View view = new View();
            view.Start("Программа определяет, можно ли один конверт (a, b) вложить в другой (c, d). ");
            controller.Run(view);
        }
    }
}
