using System;


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
                result.firstAmount = tickets.Count(Checker.ArgsCheck(args).min, Checker.ArgsCheck(args).max, false);

                result.secondAmount = tickets.Count(Checker.ArgsCheck(args).min, Checker.ArgsCheck(args).max, true);

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
