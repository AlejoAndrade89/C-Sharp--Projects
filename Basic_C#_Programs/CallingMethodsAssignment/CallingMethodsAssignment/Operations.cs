using System;
using System.Collections.Generic;
using System.Text;
/*
 * Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. 
   The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.

* In the Main() program, ask the user what number they want to do the math operations on.

* Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

* Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


 
 
 */
namespace CallingMethodsAssignment
{
    public class Operations
    {


        public static int Sum (int a, int b)
        {
            int sumOfTwo = a + b;
            return sumOfTwo;
        }

        public static int Mod(int b, int c)
        {
           int  remainder = b % c;

            return remainder;
        }

        public static int PowerOf(int baseNum, int exponent ) {
            
         

           int result = (int)Math.Pow(baseNum, exponent);
            return result;


        
        }  

    }
}
