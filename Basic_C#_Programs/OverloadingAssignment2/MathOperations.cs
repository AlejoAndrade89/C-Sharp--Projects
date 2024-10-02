using System;
using System.Collections.Generic;
using System.Text;
/*
 Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. 
Have the method do a math operation and return an integer result.
 
 */
namespace OverloadingAssignment2
{
    public class MathOperations
    {
        public int performOperation(int num1, int num2 = 10) { 
        
           int result = num1 + num2;
            return result;
        
        }
    }
}
