using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main()
        {

            //  Exceptions Handling gives you the ability to put in Custom error messages, log information to a database, log errors. 
            try
            {

                Console.WriteLine("Pick a  number : ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number :");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing number " + numberOne + " by " + numberTwo);
                int numberDivided = numberOne / numberTwo;
                Console.WriteLine($" the result of dividing {numberOne} by {numberTwo} = {numberDivided}");
                Console.ReadLine();

            }
            catch (FormatException ex)
            {

                Console.WriteLine(" Please type a whole number ..");

            }

            catch (DivideByZeroException)
            {

                Console.WriteLine(" Don't divide by zero ....");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

            finally {

                Console.ReadLine();

            }
        }
    }
}
