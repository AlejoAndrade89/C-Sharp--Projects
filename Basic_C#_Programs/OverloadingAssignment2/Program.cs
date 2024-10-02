using System;

namespace OverloadingAssignment2
{

    /*
     In the Main() method of the console app, instantiate the class.

    Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

    Call the method in the class, passing in the one or two numbers entered.

Try various combinations of numbers on the code, including having no second number.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
           MathOperations mathOperations = new MathOperations();

            Console.WriteLine("please enter the first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number, or just press enter...");

            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = mathOperations.performOperation(num1, num2);
                Console.WriteLine($" the sum of {num1} & {num2} is {result}");
            }
            catch
            {
                int result = mathOperations.performOperation(num1);
                Console.WriteLine($"{num1} + Default 10 = {result}");
                
            
            }
        }
    }
}
