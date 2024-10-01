using System;

namespace MethodOverloadingAssignmnet
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // Instansiate the MathOps class
           MathOps mathOps = new MathOps();

            // Call the first method 
            Console.WriteLine(mathOps.MathOp(20));
            // Call the second method 
            Console.WriteLine(mathOps.MathOp(10));
            // Call the third method
            Console.WriteLine(mathOps.MathOp("38"));
        }
    }
}
