using System;

namespace MonthlyCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool exitProgram = true;
         
          
            do
            {
                Console.WriteLine("Please select a number of a month.");
                string month = Console.ReadLine();
                Int32.TryParse(month, out int month2);

              
                switch (month2)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;

                    default:
                        Console.WriteLine("You haven't selected a valid number");
                        exitProgram = false;
                        break;

                }
            } while (true);

        }

        private static string GetMonth(string month)
        {
            return month;
        }
    }
}
