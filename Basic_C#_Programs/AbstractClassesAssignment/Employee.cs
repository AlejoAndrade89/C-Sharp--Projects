using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAssignment
{
    //Created the class Employee inheriting from Person class.
    // Employee class inherit the interface IQuittable.
    public class Employee : Person, IQuittable
    {
        //Implement the method SayName inside the Employee class.
        public override void SayName()
        {
            
            Console.WriteLine("Name: " + FirstName + " " + LastName);

        }
        // Quit method implemented.
        public void Quit() {

            Console.WriteLine(" I Quit this job..");
        
        }

    }
}
