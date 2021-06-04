using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    class Controller
    {
        public void Run (string [] args)
        {
            
            Tickets tickets = new Tickets();
            (int winner, int firstAmount, int secondAmount) result;
            if (Checker.ArgsCheck(args).isValid)
            {
                result.firstAmount = tickets.FirstCount(Checker.ArgsCheck(args).min, Checker.ArgsCheck(args).max);

                result.secondAmount = tickets.SecondCount(Checker.ArgsCheck(args).min, Checker.ArgsCheck(args).max);

                result.winner = tickets.Compare(result.firstAmount, result.secondAmount);

                View.Firstway(result.firstAmount);
                View.SecondWay(result.secondAmount);
                View.Winner(result.winner);
            }
            while (false)
            {
                 View.Greeting();
                 
            }
            Console.ReadKey();

        }


    }
}
