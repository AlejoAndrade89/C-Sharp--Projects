using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {
        //This is a List
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Dan");
            intList.Remove("Dan");

            Console.WriteLine(intList[0]);
            Console.ReadLine();



        // Below we have an Array
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //Same thing but cleaner
            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; 

            Console.WriteLine(numArray[3]);
            Console.ReadLine();
        }   
    }
}
