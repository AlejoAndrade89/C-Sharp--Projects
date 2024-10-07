using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorAssignment
{

    // Employee class with properties Id, FirstName, and LastName
    public class Employee
    {
        // Auto-implemented properties for Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects based on their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, they are considered equal
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // If one is null and the other is not, they are considered different
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare their Id properties
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator to complement the == operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Reuse the logic of the == operator, returning the opposite
            return !(emp1 == emp2);
        }

       
    }
}
