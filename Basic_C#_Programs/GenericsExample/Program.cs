using System;


/*
 
 Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.

Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.

Create a loop that prints all of the Things to the Console.
 
 */
namespace GenericsExample
{
     class Program
    {
        static void Main(string[] args)
        {

            //instantiate an emloyee object with a String as the generic type
            Employee<string> employee = new Employee<string>();
            //Asign a list of strings to the "Things " Property
            employee.Things.Add("Notbook");
            employee.Things.Add("Pen");
            employee.Things.Add("Laptop");


            //instantiate an employee object with an int as the generic type 
            Employee<int> employee1 = new Employee<int>();
            // Assign a list of int to the " Things " property
            employee1.Things.Add(0);
            employee1.Things.Add(1);
            employee1.Things.Add(2);

            // Looping through the  string  list
            foreach (var thing in employee.Things)
            {   //print list
                Console.WriteLine(thing);
            }
            // Looping through the int list 
            foreach (var thing in employee1.Things)
            {   // print list
                Console.WriteLine(thing);
            }
        }
    }
}
