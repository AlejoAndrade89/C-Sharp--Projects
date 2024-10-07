using System;

namespace OperatorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with different Ids and names
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };
            Employee emp3 = new Employee { Id = 1, FirstName = "Mike", LastName = "Brown" };

            // Compare emp1 and emp2 using the overloaded == operator
            if (emp1 == emp2)
            {
                // Since their Ids are different, this block will not be executed
                Console.WriteLine("Employee 1 and Employee 2 are the same.");
            }
            else
            {
                // This will be printed because emp1 and emp2 have different Ids
                Console.WriteLine("Employee 1 and Employee 2 are different.");
            }

            // Compare emp1 and emp3 using the overloaded == operator
            if (emp1 == emp3)
            {
                // Since emp1 and emp3 have the same Id, this block will be executed
                Console.WriteLine("Employee 1 and Employee 3 are the same.");
            }
            else
            {
                // This block will not be executed because their Ids are the same
                Console.WriteLine("Employee 1 and Employee 3 are different.");
            }
        }
    }
}