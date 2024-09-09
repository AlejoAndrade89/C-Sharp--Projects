using System;
using System.Diagnostics;

namespace switchAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age;
            

            Console.WriteLine("What's your age ? :");
            age = Convert.ToInt32(Console.ReadLine());

            switch (age) {

                case 18:
                    Console.WriteLine("You are oldenough to have a drink");
                    break;
                case 17: Console.WriteLine("you are not allowed to have a drink");
                    break ;
                default:
                    Console.WriteLine("you are not old enough to be here come back later.");
                    break;
            }
          
        }
    }
}
