using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassAssignmentSubmission
{

    /*
     
    Create a class. In that class, create a void method that takes two integers as parameters. 
    Have the method do a math operation on the first integer and display the second integer to the screen. 
     
     */

    // Clas that contains a method that performs a math operation.
    class Operations
    {
        //void method that takes 2 integeres as parameters.
        public void MathOp(int num1, int num2)
        {
            //Perform a math operation on the first integer
            int result = num1 * 5;

            //Display the result of the operation
            Console.WriteLine($"The result of the operation on the first number is {result} where {num1} is Multiplied by 5 ");

            //Display the second integer as it was passed.
            Console.WriteLine($"The second number is {num2}");
        }


    }
}
