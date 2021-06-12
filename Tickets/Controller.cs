using System;


namespace Tickets
{
    class Controller
    {
        private string[] limits { get; set; }
        private bool resume { get; set; } = false;
        public Controller (string [] args)
        {
            limits = args;
        }
        public void Run ()
        {
            Tickets tickets = new Tickets();
            do
            {
                (int winner, int firstAmount, int secondAmount) result;
                if (Checker.ArgsCheck(limits).isValid)
                {
                    result.firstAmount = tickets.Count(Checker.ArgsCheck(limits).min, Checker.ArgsCheck(limits).max, false);
                    result.secondAmount = tickets.Count(Checker.ArgsCheck(limits).min, Checker.ArgsCheck(limits).max, true);
                    result.winner = tickets.Compare(result.firstAmount, result.secondAmount);
                    View.Firstway(result.firstAmount);
                    View.SecondWay(result.secondAmount);
                    View.Winner(result.winner);
                }
                else
                {
                    View.IncorrectValue();
                }
                if (View.Resume())
                {
                    resume = true;
                    limits = View.ReadNumber();
                }
                else
                 {
                    resume = false;
                }
            }
            while (resume);
        }

    }
}
