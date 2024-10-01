using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloadingAssignmnet
{
    public class MathOps
    {
        // A function thats subtract the number recieved as a parameter -1
        public int MathOp(int a)
        {
            int subtraction = a - 1;
            return subtraction;
        }
        // recieves a decimal number , then converts it to an int then multiply * 10 
        public int MathOp(decimal b)
        {

            int decNum = Convert.ToInt32(b);
            return decNum * 10;
        }

        // A function that recieve a String , convert it to int , then sum +2
        public int MathOp(string number) { 
        
            int convertedNum = Convert.ToInt32(number);
            return convertedNum + 2;
        
        }

    }
}