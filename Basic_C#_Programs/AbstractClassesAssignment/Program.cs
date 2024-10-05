using System;

namespace AbstractClassesAssignment
{


    /*
     
    1.Create an abstract class called Person with two properties: string firstName and string lastName.

    2.Give it the method SayName().

    3.Create another class called Employee and have it inherit from the Person class.

    4.Implement the SayName() method inside of the Employee class.

    5.Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            // Polymorphism in action, created an object of type IQuittable and called the Quit method on it.
            Employee employee = new Employee();

            IQuittable quittableEmployee = employee;

            quittableEmployee.Quit();

            // New Employee object instantiated.
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            // Call of the method on the object.
           // employee.SayName();
            //Console.ReadLine();

        }
    }
}
