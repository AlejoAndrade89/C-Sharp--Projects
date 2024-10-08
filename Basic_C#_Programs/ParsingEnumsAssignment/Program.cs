using System;
using System.Globalization;
/*
 
 Create an enum for the days of the week.

Prompt the user to enter the current day of the week.

Assign the value to a variable of that enum data type you just created.

Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
 
 
 */
namespace ParsingEnumsAssignment
{

    enum DaysOfWeek
    {   Monday, 
        Tuesday, 
        Wednesday, 
        Friday, 
        Saturday, 
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {   // Prompt the user to enter the current day of the week
            Console.WriteLine("Enter the current day of the week...");

            try
            {   // Read user input and try to parse it into the DaysOfWeek enum
                string input = Console.ReadLine();
                DayOfWeek currentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input, true);

                // Output the day if parsing was successful
                Console.WriteLine($" You entered {currentDay}");    
            }
            catch
            {
                // Catch exception if the user input is not a valid day of the week
                Console.WriteLine(" Plese enter a current day of the week ..");

            }
        }
    }
}
