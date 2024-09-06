using System;
/*
 The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”

The user must then be prompted for the package weight.

If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.

The user must then be prompted for the package width.

Then the package height.

Then the package length.

If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.

Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.

The result of that calculation is the quote.

Display the quote to the user as a dollar amount.
 */
namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of the package you wanto to send? : ");
            int packgWeight = Convert.ToInt32(Console.ReadLine());

            if (packgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.WriteLine("Please Provide the width of your package : ");
            int packgWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Provide the height of your package : ");
            int packgHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Provide the length of your package : ");
            int packgLength = Convert.ToInt32(Console.ReadLine());

            if (packgWidth + packgHeight + packgLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            int calcDimensions = packgHeight * packgWidth * packgLength;
            double quote = (calcDimensions * packgWeight) / 100;

            Console.WriteLine($"The total price to pay for your shipment is : ${quote:F2}");
        }
    }
}