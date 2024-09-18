using System;
using System.Collections.Generic;
/*
 Create a console app that does/contains the following:

Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

Add in a message that displays when the user selects an index that doesn’t exist.

Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.

Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. 

Upload your code to GitHub.
 */
namespace AppArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a string array of food products
            string[] selectProduct = { "Cheese Burger", "Chicken Fingers", "Lettuce Burrito", "Oreo Milkshake", "Fries" };

            // Prompt user to select an index
            Console.WriteLine("Select a number between 0 to 4 to make a selection..");
            int selection = Convert.ToInt32(Console.ReadLine());

            // Loop until a valid selection is made
            bool validString = false;
            while (!validString)
            {
                try
                {
                    // Attempt to access and display the selected product
                    Console.WriteLine("The food of your selection is " + selectProduct[selection]);
                    validString = true; // Exit the loop if successful
                }
                catch
                {
                    // Handle out-of-range index
                    Console.WriteLine("Sorry but the number you selected is incorrect..");
                    selection = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Create a list of vegetables
            List<string> vegetables = new List<string>()
            {
                "Tomato",
                "Onion",
                "Cucumber",
                "Spinach",
                "Lettuce"
            };

            // Prompt user to select a vegetable
            Console.WriteLine("Select the number for the veggie you like.. 0.Tomato, 1.Onion, 2.Cucumber, 3.Spinach, 4.Lettuce");
            int selectedVeggie = Convert.ToInt32(Console.ReadLine());

            // Loop until a valid selection is made
            bool validVeggie = false;
            while (!validVeggie)
            {
                try
                {
                    // Attempt to access and display the selected vegetable
                    Console.WriteLine("The veggie of your selection is : " + vegetables[selectedVeggie]);
                    validVeggie = true; // Exit the loop if successful
                }
                catch
                {
                    // Handle out-of-range index
                    Console.WriteLine("Sorry, that selected number is invalid, select only from 0 to 4...");
                    selectedVeggie = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Your Total order is : " + selectProduct[selection] + " with " + vegetables[selectedVeggie]);
            }
        }
    }
}