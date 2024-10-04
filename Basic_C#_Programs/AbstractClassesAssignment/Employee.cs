using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAssignment
{
    //Created the class Employee inheriting from Person class.
    public class Employee : Person
    {
        //Implement the method SayName inside the Employee class.
        public override void SayName()
        {
            
            Console.WriteLine("Name: " + FirstName + " " + LastName);

        }

    }
}
