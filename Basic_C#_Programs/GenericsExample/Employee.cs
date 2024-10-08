using System;
using System.Collections.Generic;
using System.Text;
/*
 
Make the Employee class take a generic type parameter.

Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class.

 */
namespace GenericsExample
{
    // generic class employee
    public class Employee<T>
    {

        //Property "Things" wich is a generic list of type T
       public List<T> Things { get; set; }


        //Constructor to initialize the "Things" list 
        public Employee() { 
            
        
            Things = new List<T>();
        }

    }
}
