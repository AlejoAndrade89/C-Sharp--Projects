using System;

namespace doWhileAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            bool isValidHeight = false;

            Console.WriteLine("Welcome to Wonderland's park!");
            Console.WriteLine("All attractions are for people with a MAX height of 195 cm or a MIN height of 165 cm");

            do
            {
                Console.WriteLine("Please provide your height in cm: ");
                height = Convert.ToInt32(Console.ReadLine());

                if (height < 165)
                {
                    Console.WriteLine("You are too short for the games");
                }
                else if (height > 195)
                {
                    Console.WriteLine("You are too tall for the games");
                }
                else
                {
                    isValidHeight = true;
                }

            } while (!isValidHeight);

            Console.WriteLine("Welcome to Wonderland's park");
        }
    }
}
