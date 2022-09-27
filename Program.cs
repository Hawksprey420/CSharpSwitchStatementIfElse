using System;
namespace SwitchStatmentIfElse
{
    class Program
    {
      static void Main(string[]args)
        {
            Console.WriteLine("Which day in a week you want to type and see?");
           int date = Convert.ToInt32((Console.ReadLine()));

            switch (date)
            {
                case 0:
                    Console.WriteLine("Sunday");
                        break;

                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid week number. Try again later");
                    break;
        
            }
        }
    }
}