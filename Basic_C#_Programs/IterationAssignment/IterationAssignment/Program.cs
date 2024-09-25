using System;
using System.Collections.Generic;

namespace IterationAssignment
{
    internal class Program
    {
        static void Main()
        {
            // Step 1: Create a list of favorite car brands with dynamic elements
            List<string> favCars = new List<string> { "Mazda", "Nissan", "Acura", "Honda" };

            // Step 2: Ask the user to input a new car brand and add it to the list
            Console.WriteLine("Add another Brand of cars to the list: ");
            string newBrand = Console.ReadLine();  // Input from user

            // Step 3: Add the user's input to the car list
            favCars.Add(newBrand);

            // Step 4: Print the updated list of car brands
            Console.WriteLine("\nUpdated list of cars:");
            foreach (string car in favCars)
            {
                Console.WriteLine(car);  // Print each car brand
            }

            // Step 5: Demonstration of an infinite loop (commented out for practical purposes)
            // while (true)
            // {
            //    Console.WriteLine("This is an infinite loop. Press CTRL+C to stop.");
            //    System.Threading.Thread.Sleep(1000);  // Pause the loop for 1 second
            // }

            // Step 6: Fixed loop to run exactly 5 times using a "<" operator
            Console.WriteLine("\nFixed loop - running 5 times:");
            int loopCounter = 0;  // Counter to keep track of loop iterations

            while (loopCounter < 5)  // Loop will run until the counter reaches 5
            {
                Console.WriteLine($"Iteration {loopCounter + 1}: This loop will stop after 5 iterations.");
                loopCounter++;  // Increment the counter after each loop iteration
                System.Threading.Thread.Sleep(1000);  // Wait for 1 second between iterations
            }

            Console.WriteLine("The loop has ended.");

            // Step 7: Loop using "<" operator to print car list with indices
            Console.WriteLine("\nLoop using the '<' operator:");
            for (int i = 0; i < favCars.Count; i++)  // Loop as long as 'i' is less than the list count
            {
                Console.WriteLine($"Car {i + 1}: {favCars[i]}");  // Print car brand with index
            }

            // Step 8: Loop using "<=" operator to achieve the same as above
            Console.WriteLine("\nLoop using the '<=' operator:");
            for (int i = 0; i <= favCars.Count - 1; i++)  // Loop while 'i' is less than or equal to list count - 1
            {
                Console.WriteLine($"Car {i + 1}: {favCars[i]}");
            }

            // Step 9: Create a list of names with at least one duplicate
            List<string> listOfNames = new List<string> { "Amanda", "Josh", "Jhon", "Daniel", "Ethan", "Andrew", "Elizabeth", "Josh" };

            // Step 10: Ask the user to search for a name in the list
            Console.WriteLine("Search for a name in our database: ");
            string inputName = Console.ReadLine();  // Input from the user

            // Step 11: Search for the name in the list using a for loop, and check if it matches
            bool nameMatch = false;  // Boolean to track if the name was found
            for (int i = 0; i < listOfNames.Count; i++)  // Loop through the list
            {
                if (listOfNames[i].Equals(inputName, StringComparison.OrdinalIgnoreCase))  // Compare ignoring case
                {
                    Console.WriteLine($"The name '{inputName}' was found at index {i} ");  // Print match and index
                    nameMatch = true;  // Set flag to true if found
                }
            }

            // Step 12: If no match was found, print that the name was not found
            if (!nameMatch)
            {
                Console.WriteLine($"The name '{inputName}' was not found on the list");
            }

            // Step 13: Create a list of last names with at least one duplicate
            List<string> listOfLastNames = new List<string> { "Smith", "Jameson", "Mcabbe", "Richards", "Smith" };

            // Step 14: Create a HashSet to track unique last names
            HashSet<string> encounteredLastNames = new HashSet<string>();

            // Step 15: Loop through each last name to check for uniqueness or duplication
            foreach (string lastName in listOfLastNames)
            {
                if (encounteredLastNames.Contains(lastName))  // If last name has already been seen
                {
                    Console.WriteLine($"{lastName} - this item is a duplicate ");  // Print it's a duplicate
                }
                else
                {
                    Console.WriteLine($"{lastName} - this item is unique ");  // Print it's unique
                    encounteredLastNames.Add(lastName);  // Add the unique last name to the HashSet
                }
            }
        }
    }
}
