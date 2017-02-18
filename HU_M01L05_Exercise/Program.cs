using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HU_M01L05_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Q1 - If diffrent then my name, continue to ask for a name
            //Console.WriteLine("What is my name?");
            //string myName = (Console.ReadLine());
            //while (myName != "Lior")
            //{
            //    Console.WriteLine("What is my name?");
            //    myName = (Console.ReadLine());
            //}
            //Console.WriteLine("Correct!");

            //// Q2 - Get numbers and sum it, stop it when the user enter -1
            //Console.WriteLine("Please enter a number");
            //int theNumber = int.Parse(Console.ReadLine());
            //int theSum = 0;
            //while (theNumber != -1)
            //{
            //    theSum = theSum + theNumber;
            //    Console.WriteLine("Please enter another number");
            //    theNumber = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("The sum is " + theSum);

            // Q3 - Get two numbers and calculate their average until the "average = 2"

            double num1 = 0;
            double num2 = 0;
            double theAverage = 0;
            do
            {
                Console.WriteLine("Please enter two numbers");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
                theAverage = (num1 + num2) / 2;
                Console.WriteLine("The numbers average is " + theAverage);
            } while ( theAverage != 2);


        }
    }
}
