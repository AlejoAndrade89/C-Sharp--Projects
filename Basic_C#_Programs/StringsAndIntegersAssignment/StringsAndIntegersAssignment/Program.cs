using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment
{

    /*
     Create a list of integers. Ask the user for a number to divide each number in the list by. 
    Write a loop that takes each integer in the list, divides it by the number the user entered, 
    and displays the result to the screen.

    Run the code, entering in non-zero numbers as the user. Look at the displayed results.
    
    Run the code again, entering in zero as the number to divide by. Note any error messages you get.

    Run the code once again, entering in a string as the number to divide by. Note any error messages you get.

    Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.
    In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

    Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


     
     */
    internal class Program
    {
        static void Main()
        {
            // Create a list of integers
            List<int> numbersList = new List<int> { 10, 20, 30, 40, 50 };

            // Ask the user for a number to divide each number in the list by
            Console.WriteLine("Enter a number to divide each element of the list by: ");
            string userInput = Console.ReadLine();

            // Try-catch block to handle exceptions
            try
            {
                // Convert the user input to a number (decimal in this case to allow floating-point division)
                decimal divisor = Convert.ToDecimal(userInput);

                // Loop through each number in the list
                foreach (int number in numbersList)
                {
                    // Perform the division and display the result
                    decimal result = number / divisor;
                    Console.WriteLine($"{number} divided by {divisor} is {result}");
                }
            }
            catch (DivideByZeroException)
            {
                // Handle division by zero
                Console.WriteLine("Error: You cannot divide by zero.");
            }
            catch (FormatException)
            {
                // Handle invalid input (like strings or other invalid data)
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }

            // This will always be printed, regardless of whether an exception occurred or not
            Console.WriteLine("Program has emerged from the try/catch block and continues execution.");
        }
    }
}