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

            //// Q9 - Print the count of even and odd numbers
            //int inputNumberB = 0;
            //int evenNumberCount = 0;
            //int oddNumberCount = 0;

            //Console.WriteLine("Please enter a number");
            //inputNumberB = int.Parse(Console.ReadLine());

            //while (inputNumberB != 0)
            //{
            //    if (inputNumberB % 2 == 0)
            //    {
            //        evenNumberCount++;
            //    }
            //    else
            //    {
            //        oddNumberCount++;
            //    }
            //    Console.WriteLine("Please enter a number");
            //    inputNumberB = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Even numbers count is " + evenNumberCount + "\n" + "Odd numbers count is " + oddNumberCount);

            //// Q10 - Print the number's backwards binary representation
            //int inputNumberC = 0;
            //string binary = null;
            //string reverseBinary = null;

            //do
            //{
            //    Console.WriteLine("Please enter a number");
            //    inputNumberC = int.Parse(Console.ReadLine());
            //    binary = Convert.ToString(inputNumberC, 2);
            //    reverseBinary = new string(binary.ToCharArray().Reverse().ToArray());
            //    Console.WriteLine(binary);
            //    Console.WriteLine(reverseBinary);
            //} while (inputNumberC > 0);

            //// Q11 - Print the count of positive and negative numbers. Exit program when the entered number is 0
            //int inputNumberD = 0;
            //int positiveCount = 0;
            //int negativeCount = 0;
            //Console.WriteLine("Please enter a number");
            //inputNumberD = int.Parse(Console.ReadLine());
            //while (inputNumberD != 0)
            //{
            //    if (inputNumberD > 0)
            //    {
            //        positiveCount++;
            //    }
            //    else
            //    {
            //        negativeCount++;
            //    }
            //    Console.WriteLine("Please enter a number");
            //    inputNumberD = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Positive Numbers: " + positiveCount + "\n" + "Negative Numbers: " + negativeCount);

            // Q12 - Print the highest and the lowest number. Exit program when the entered number is 0
            int inputNumber1 = 0;
            int inputNumber2 = 0;
            int highestNumber = 0;
            int lowestNumber = 0;

            Console.WriteLine("Please enter two numbers");
            inputNumber1 = int.Parse(Console.ReadLine());
            inputNumber2 = int.Parse(Console.ReadLine());


            while (inputNumber1 != 0 || inputNumber2 != 0)
            {
                if (inputNumber1 > inputNumber2)
                {
                    highestNumber = inputNumber1;
                    lowestNumber = inputNumber2;
                }

            }


            Console.WriteLine("The highest number is " + highestNumber + "\n" + "The lowest number is " + lowestNumber);







            //// Q13 - Print the number of times the number "10" was entered. Exit program when the entered number is 12
            //int inputNumberF = 0;
            //int tenCount = 0;
            //Console.WriteLine("Please enter a number");
            //inputNumberF = int.Parse(Console.ReadLine());
            //while (inputNumberF != 12)
            //{
            //    if (inputNumberF == 10)
            //    {
            //        tenCount++;
            //    }
            //    Console.WriteLine("Please enter a number");
            //    inputNumberF = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("The number of times the number 10 was entered is " + tenCount);

            //// Q21 - Print the result of "y=0.5x+60". Exit program if y=100

            //int x = 0;
            //double y = 0;

            //while (y != 100)
            //{
            //    Console.WriteLine("Please enter x value");
            //    x = int.Parse(Console.ReadLine());
            //    y = (0.5 * x) + 60;
            //    Console.WriteLine("y is " + y);
            //}
            //Console.WriteLine("y " + " = " + y + " . " + " Quit!");




            //// Q23 - Print how many Oranges or Lemons. Exit program with the word "Stop"
            //int lemonsCount = 0;
            //int orangesCound = 0;

            //Console.WriteLine("Do you want lemon or orange?");
            //string fruit = Console.ReadLine();
            //while (fruit != "stop")
            //{
            //    if (fruit == "lemon")
            //    {
            //        lemonsCount++;
            //    }
            //    else
            //    {
            //        orangesCound++;
            //    }
            //    Console.WriteLine("Do you want lemon or orange?");
            //    fruit = Console.ReadLine();
            //}
            //Console.WriteLine("Number of lemons: " + lemonsCount + "\n" + "Number of oranges: " + orangesCound);

            //// Q24 - Print only the first name of the pepole with the last name of "Cohen". Exit program when pepole with last name of "Levi" was entered. 
            //Console.WriteLine("Please enter first name");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Please enter last name");
            //string lastName = Console.ReadLine();

            //while (lastName != "Levi")
            //{
            //    if (lastName == "Cohen")
            //    {
            //        Console.WriteLine("The first name is " + firstName);
            //        Console.WriteLine("Please enter first name");
            //        firstName = Console.ReadLine();
            //        Console.WriteLine("Please enter last name");
            //        lastName = Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter first name");
            //        firstName = Console.ReadLine();
            //        Console.WriteLine("Please enter last name");
            //        lastName = Console.ReadLine();
            //    }
            //}

            //// Q25 - Print the the lowercase and uppercase count. Exit program when a number is entered. 
            //int upperCount = 0;
            //int lowerCount = 0;

            //Console.WriteLine("Please enter a letter");
            //string letter = Console.ReadLine();

            //while (letter.Any(char.IsUpper) && letter.Any(char.IsLower))
            //{
            //    if (letter.Any(char.IsUpper))
            //    {
            //        upperCount++;
            //    }
            //    Console.WriteLine("Please enter a letter");
            //    letter = Console.ReadLine();
            //}

        }
    }
}
