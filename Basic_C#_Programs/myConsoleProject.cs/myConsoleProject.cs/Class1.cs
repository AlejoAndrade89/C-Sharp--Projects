using System;

public class CarInsurance
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Car Insurance Application");
        Console.WriteLine(" What is your age ?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Have you ever had a DUI? , Yes or No ");
        string answer = Console.ReadLine().ToLower();
        bool dui = answer == "yes";
        Console.WriteLine(" How many speeding tickets do you have? ");
        int tickets = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Qualified for insurance? ");
        bool qualified= ( age > 15) && !dui && ( tickets < 3);
        Console.WriteLine(qualified);

    }
}


/*
 Use the following qualification rules to determine if the applicant qualifies for car insurance:

Applicants must be over 15 years old.

Applicants must not have any DUI’s.

Applicants must not have more than 3 speeding tickets.


 
 */