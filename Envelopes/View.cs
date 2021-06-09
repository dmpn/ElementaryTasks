using System;


namespace Envelopes
{
    public class View
    {
        public void Start ()
        {
            Console.WriteLine("Программа определяет, можно ли один конверт (a, b) вложить в другой (c, d). ");

        }
        public float EnterSides (string message)
        {
            float currentSize;
            Console.Write (message);

            while (!float.TryParse(Console.ReadLine(), out currentSize) )
            {
                Console.WriteLine("Необходимо ввести число в диапазоне 1 - 3.4e38f");
            }
            return currentSize;         

        }

        public bool PrintResult (int result)
        {
            switch (result)
            {
                case 1:
                    Console.WriteLine("Первый конверт может быть помещен во второй");
                    break;
                case 2:
                    Console.WriteLine("Второй конверт может быть помещен в первый");
                    break;
                default:
                    Console.WriteLine("Ни один конверт не может быть помещен в другой");
                    break;
            }

            Console.WriteLine("Проверить другие конверты (y/yes)?");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                case "yes":
                    return true;
                default:
                    return false;                  
            }
                
        }
    }
}
