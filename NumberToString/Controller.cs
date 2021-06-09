using NumberToString.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString
{
    class Controller
    {
        public void Start (string[] args)
        {
            if (args.Length == 1)
            {
                switch (args[0])
                {
                    case "-help":
                        View.Help();
                        break;
                    default:
                        Run(args [0]);
                        break;
                }
            }
            else
            {
                View.Start();            
            }
            while (View.Resume())
            {
                Run(View.EnterNumber());
            }
        }
        public void Run (string arg)
        {
            Numbers numbers;
            try
            {
                numbers = new Numbers(arg);
                if (numbers.isZero)
                {
                    View.Zero();
                }
                else
                {
                    foreach (Number number in numbers)
                    {
                        if (number.ToString().Length > 0)
                        {
                            View.Print(number.ToString());
                        }
                    }
                }
            }
            catch
            {
                View.IncorrectValue();
            } 
        }
    }
}
