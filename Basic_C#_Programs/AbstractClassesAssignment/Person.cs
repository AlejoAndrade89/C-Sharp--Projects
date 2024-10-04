using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAssignment
{
    // Abstract class created with 2 properties (FirstName & LastName).
    public abstract class Person
    {
    
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Give it the method SayName. 
        public abstract void SayName();

    }

   
}
