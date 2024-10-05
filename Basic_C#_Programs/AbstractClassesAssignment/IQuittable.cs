using System;
using System.Collections.Generic;
using System.Text;
/*
 Create an interface called IQuittable and have it define a void method called Quit().

 Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

 Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.

 Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. 
 
 
 */
namespace AbstractClassesAssignment
{

    // Creation of interface called IQuittable.
    public interface IQuittable
    {
        // void method creation.
        public void Quit();

    }
}
