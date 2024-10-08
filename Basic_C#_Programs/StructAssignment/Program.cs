using System;

namespace StructAssignment
{
     class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type Number.
            Number number = new Number();
            // Assign a value to the amount property of the number struct
            number.amount = 325.75m;
            // Print the amount to the console.
            Console.WriteLine($" The assigned number is = {number.amount}");
        }

      
    }
}
