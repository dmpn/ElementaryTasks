using System;


namespace Envelopes.Model
{

    public static class Checker
    {
        public static float minSize = 1f;
        public static float maxSize = 3.4e38f;
        public static bool CheckSize (float userInput)
        {
            if (userInput >= minSize && userInput <= maxSize)
            {                
                return true;                
            }
            return false;
        }
        public static bool CheckArgs (string [] args)
        {
            return false;
        }
    }
}
