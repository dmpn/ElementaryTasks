using System;


namespace Tickets
{

    public class Checker
    {
        public static (bool isValid, int min, int max) ArgsCheck (string [] args)
        {            
            (bool isValid, int min, int max) result ;
            result.min = result.max = 0;
            result.isValid = false;
            switch (args.Length)
            {
                case 2:
                    {
                        
                        if (Int32.TryParse(args[0], out result.min) && Int32.TryParse(args[1], out result.max) &&
                            Limits (result.min, result.max) )
                            result.isValid = true;
                            return result;
                    }
            }
            return result;
        }
               

        public static bool Limits(int min, int max)
        {
            int minLimit = 1;
            int maxLimit = 999999;
            return ((min >= minLimit && min <= maxLimit &&
                     max >= minLimit && max <= maxLimit &&
                     min < max));
        }

        //public static bool GetInt (string value, out int intResult)
        //{
        //    if (!Int32.TryParse(value, out intResult))
        //    {
        //        intResult = 0;
        //        return false;
        //    }
        //    return true;
        //}
    }
}
