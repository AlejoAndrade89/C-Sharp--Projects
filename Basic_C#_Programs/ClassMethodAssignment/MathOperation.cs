using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodAssignment
{

    /*
     
      Create a class. In that class, create a void method that outputs an integer. 
      Have the method divide the data passed to it by 2.
     
     */
     class MathOperation
    {

        public static void DividedByTwo(int numA)
        {
            int result = numA / 2;
            Console.WriteLine($" The result of {numA} divided by 2 is : {result}");
        }


        public static void DividedByTwo(int numA, out int result)
        {
            result = numA / 2;

        }

        public static void DividedByTwo()
        {
            Console.WriteLine(" You must provide a number to divide!...");
        }

    }
}
