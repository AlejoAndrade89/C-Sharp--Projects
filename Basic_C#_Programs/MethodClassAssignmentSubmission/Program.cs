using System;

namespace MethodClassAssignmentSubmission
{

    /*
     
    In the Main() method of the console app, instantiate the class.

    Call the method in the class, passing in two numbers. 

    Call the method in the class, specifying the parameters by name.

    
     
     */
     class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class.
           Operations operations = new Operations();
            //Call the method with two numbers, passing them directly.
            Console.WriteLine("Calling method with direct arguments: ");
            operations.MathOp(10,5);
            // Call the method with named parameters.
            Console.WriteLine("Calling methos with named parameters:");
            operations.MathOp(num1:20, num2: 5);
            // Keep the console window open.
            Console.ReadLine();
        }
    }
}
