using System;

namespace ClassMethodAssignment
{
/*
        In the Main() method, instantiate that class.

        Have the user enter a number. Call the method on that number. Display the output to the screen.
        It should be the entered number, divided by two. 

        Create a method with output parameters.

        Overload a method.

        Declare a class to be static.

        Add comments to each line or block of your code to explain what it does exactly, 
        so that another developer could read and understand your code.
*/
     
    
     class Program
    {
       
        static void Main(string[] args)
        {
          
            MathOperation mathOperation = new MathOperation();

            Console.WriteLine("Please enter an integer number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            MathOperation.DividedByTwo(input);

            int resultOut;

            MathOperation.DividedByTwo(input, out resultOut);
            Console.WriteLine($" Usingthe out parameter, the result of {input} divided by 2 is : {resultOut}");


            MathOperation.DividedByTwo();


        }


    }
}
