using System;

namespace CallingMethodsAssignment
{
    /*
     
* Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. 
   The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.

* In the Main() program, ask the user what number they want to do the math operations on.

* Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

* Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Operations operations = new Operations();



                Console.WriteLine("enter the first number for the operation: ");
                int userInput1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number for the operation: ");
                int userInput2 = int.Parse(Console.ReadLine());

                
                int summValues = Operations.Sum(userInput1, userInput2);
            Console.WriteLine($"The sum of {userInput1} and {userInput2} is {summValues}");

            int modulus = Operations.Mod(userInput1, userInput2);
            Console.WriteLine($"The Modulus of number {userInput1} and {userInput2} have a remainder of {modulus}");

            int exponential = Operations.PowerOf(userInput1, userInput2);
            Console.WriteLine($"The result of the exponential operation is that {userInput1} to the power of {userInput2} is {exponential}");

        }
    }
}
