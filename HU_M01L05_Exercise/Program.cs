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

            //// Q3 - Get two numbers and calculate their average until the "average = 2"
            //double num1 = 0;
            //double num2 = 0;
            //double theAverage = 0;
            //do
            //{
            //    Console.WriteLine("Please enter two numbers");
            //    num1 = double.Parse(Console.ReadLine());
            //    num2 = double.Parse(Console.ReadLine());
            //    theAverage = (num1 + num2) / 2;
            //    Console.WriteLine("The numbers average is " + theAverage);
            //} while (theAverage != 2);

            //// Q4 - Print students grades as long as the grade is not "-1"  
            //double gradeInputA = 0;
            //do
            //{
            //    Console.WriteLine("Please enter a grade");
            //    gradeInputA = double.Parse(Console.ReadLine());
            //    if (gradeInputA >= 80)
            //    {
            //        Console.WriteLine("The grade is " + gradeInputA);
            //    }
            //} while (gradeInputA != -1);

            //// Q5 - Print student grades average as long as the grades average is higher or equal to 70.Exit program when the entered grade is "101"
            //double gradeInputB = 0;
            //double gradesSumB = 0;
            //int counterB = 0;
            //while (gradeInputB != 101)
            //{
            //    Console.WriteLine("Please enter a grade");
            //    gradeInputB = double.Parse(Console.ReadLine());
            //    if (gradeInputB >= 70 && gradeInputB != 101)
            //    {
            //        gradesSumB += gradeInputB; // gradesSum = gradeSum + gradeInputB 
            //        counterB++; // counter = counter +1
            //    }
            //}
            //Console.WriteLine("The grades average is " + gradesSumB / counterB);

            //// Q6 - Print student grades average. Exit program when the entered grade is "0" 
            //double gradeInputC = 0;
            //double gradesSumC = 0;
            //int counterC = 0;
            //do
            //{
            //    Console.WriteLine("Please enter a grade");
            //    gradeInputC = double.Parse(Console.ReadLine());
            //    if (gradeInputC > 0)
            //    {
            //        gradesSumC += gradeInputC;
            //        counterC++;
            //    }
            //} while (gradeInputC > 0);
            //Console.WriteLine("The grades average is " + gradesSumC / counterC);

            //// Q7 - Print the number of negetive grades. Exit program when the entered grade is out of "0-100" range
            //int gradeInputD = 0;
            //int negetiveNumCounter = 0;
            //while (gradeInputD > 0 && gradeInputD < 100)
            //{
            //    Console.WriteLine("Please enter a grade");
            //    gradeInputD = int.Parse(Console.ReadLine());
            //    if (gradeInputD > 0 && gradeInputD < 100)
            //    {

            //    }
            //}

            //// Q8 - Print only the 2-digit numbers which devided by 3 without modulu.  Exit program when the entered number is 1000
            //int inputNumberA = 0;
            //int length = 0;
            //int modulu = 0;

            //Console.WriteLine("Please enter a number");
            //inputNumberA = int.Parse(Console.ReadLine());

            //while (inputNumberA != 1000)
            //{
            //    length = inputNumberA.ToString().Length;
            //    modulu = inputNumberA % 3;
            //    if (length == 2 && modulu == 0)
            //    {
            //        Console.WriteLine("The number " + inputNumberA + " is a 2-digit number divides by 3");
            //    }
            //    Console.WriteLine("Please enter a number");
            //    inputNumberA = int.Parse(Console.ReadLine());
            //}

            // Q9 - Print the number of even and odd numbers
            int inputNumberB = 0;
            int evenNumberCount = 0;
            int oddNumberCount = 0;

            Console.WriteLine("Please enter a number");
            inputNumberB = int.Parse(Console.ReadLine());

            while (inputNumberB != 0)
            {
                if (inputNumberB % 2 == 0)
                {
                    evenNumberCount++;
                }
                else
                {
                    oddNumberCount++;
                }
                Console.WriteLine("Please enter a number");
                inputNumberB = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Even numbers count is " + evenNumberCount + "\n" + "Odd numbers count is " + oddNumberCount);


        }
    }
}
