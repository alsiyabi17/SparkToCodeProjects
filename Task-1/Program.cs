using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Personal Info Card
            //string Name = "Mohammed";
            //int Age = 23;
            //double hight = 175;
            //bool student = true;

            //Console.WriteLine(Name);
            //Console.WriteLine(Age);
            //Console.WriteLine(hight);
            //Console.WriteLine(student);

            // Task 2 - Rectangle Calculator
            //Console.WriteLine("Enter the length");
            //float length = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the width");
            //float width = float.Parse(Console.ReadLine());

            //float Area = length * width;
            //float Perimeter = 2 * (length + width);

            //Console.WriteLine("Area: " + Area);
            //Console.WriteLine("Perimeter: " + Perimeter);

            // Task 3 - Even or Odd Checker
            //Console.WriteLine("Enter Number");
            //int number = int.Parse(Console.ReadLine());

            //int CheckNumber = number % 2;

            //if (CheckNumber == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            // Task 4 - Voting Eligibility
            //Console.WriteLine("Enter Age");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have a valid national ID (yes/no)?");
            //string vID = (Console.ReadLine());

            //bool yes = vID == "yes";
            //bool no = vID == "no";

            //if (Age >= 18 && yes)
            //{
            //    Console.WriteLine("You are eligible to vote");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote");
            //}

            // Task 5 - Grade Letter Lookup
            //Console.WriteLine("1.A");
            //Console.WriteLine("1.B");
            //Console.WriteLine("1.C");
            //Console.WriteLine("1.D");
            //Console.WriteLine("1.F");

            //Console.WriteLine("Chosse a single character representing a grade: ('A', 'B', 'C', 'D', or 'F')");
            //int grade = int.Parse(Console.ReadLine());

            //switch (grade)
            //{
            //    case 1:
            //        Console.WriteLine("Excellent");
            //        break;


            //    case 2:
            //        Console.WriteLine("Very Good");
            //        break;


            //    case 3:
            //        Console.WriteLine("Good");
            //        break;


            //    case 4:
            //        Console.WriteLine("Pass");
            //        break;


            //    case 5:
            //        Console.WriteLine("Fail");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;
            //}

            // Task 6 - Temperature Converter 
            //Console.WriteLine("enter a temperature in Celsius");
            //int Celsius = int.Parse(Console.ReadLine());

            //int Fahrenheit = (Celsius * 9 / 5) + 32;
            //Console.WriteLine("Fahrenheit: " + Fahrenheit);

            //if (Fahrenheit > 10)
            //{
            //    Console.WriteLine("Cold");
            //}
            //else if (Fahrenheit >= 10 && Fahrenheit <= 30)
            //{
            //    Console.WriteLine("Mild");
            //}
            //else
            //{
            //    Console.WriteLine("Hot");
            //}

            // Task 7 - Movie Ticket Pricing 

            //Console.WriteLine("Enter your age: ");
            //int Age = int.Parse(Console.ReadLine());

            //if (Age >= 0 && Age <= 12)
            //{
            //    Console.WriteLine("Children: 2000 OMR");
            //}
            //else if (Age >= 13 && Age <= 59)
            //{
            //    Console.WriteLine("Adults: 5000 OMR");
            //}
            //else
            //{
            //    Console.WriteLine("Senior: 3000 OMR");

            //}

            // Task 8 - Restaurant Bill with Membership Discount
            //Console.WriteLine("Are you a loyalty member (yes/no)?");
            //string LM = (Console.ReadLine());

            //bool yes = LM == "yes";
            //bool no = LM == "no";

            //Console.WriteLine("Enter the total bill amount: ");
            //int billAmount = int.Parse(Console.ReadLine());

            //int discount = billAmount * 15 / 100;

            //if (billAmount > 20 && yes)
            //{
            //    Console.WriteLine("orginal bill = " + billAmount);
            //    Console.WriteLine("Discount 15% = " + discount);
            //    Console.WriteLine("Total bill after discount = " + (billAmount - discount));
            //}
            //else
            //{
            //    Console.WriteLine("orginal bill = " + billAmount);
            //}

            // Task 9 - Day Name Finder
            //Console.WriteLine("Enter a number from 1 to 7 representing a day of the week");
            //int dayNumber = int.Parse(Console.ReadLine());

            //switch (dayNumber)
            //    {
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default: 
            //        Console.WriteLine("Invalid day number");
            //        break;
            //}

            // Task 10 - Mini Calculator
            //Console.WriteLine("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Choose an operation (+, -, *, /,%): ");
            //int operation = Console.ReadLine()[0];

            //if (num2 == 0)
            //{
            //    Console.WriteLine("Cannot divide by Zero");
            //}
            //else if (operation != '+' && operation != '-' && operation != '*' && operation != '/' && operation != '%')
            //{
            //    Console.WriteLine("Invalid operation");
            //}
            //else
            //{
            //    switch (operation)
            //    {
            //        case '+':
            //            Console.WriteLine("Result: " + (num1 + num2));
            //            break;

            //        case '-':
            //            Console.WriteLine("Result: " + (num1 - num2));
            //            break;

            //        case '*':
            //            Console.WriteLine("Result: " + (num1 * num2));
            //            break;

            //        case '/':
            //            Console.WriteLine("Result: " + (num1 / num2));
            //            break;

            //        case '%':
            //            Console.WriteLine("Result: " + (num1 % num2));
            //            break;
            //    }
            //}

            // Task 11 - Loan Eligibility System
            //Console.WriteLine("Enter your age: ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your monthly income: ");
            //int income = int.Parse(Console.ReadLine());
            //Console.WriteLine("Do you have existing loan (yes/no)");
            //string existingLoan = Console.ReadLine();

            //bool yes = existingLoan == "yes";
            //bool no = existingLoan == "no";

            //if (Age >= 21 && Age <= 60 && income >= 400 && no)
            //{
            //    Console.WriteLine("You are eligible for a loan");
            //}
            //else
            //{
            //    if (Age < 21 || Age > 60)
            //    {
            //        Console.WriteLine("Age out of range");
            //    }
            //    if (income < 400)
            //    {
            //        Console.WriteLine("income too low");
            //    }
            //    if (yes)
            //    {
            //        Console.WriteLine("has an existing loan");
            //    }
            //}

            // Task 12 - Shipping Cost Calculator
            //Console.WriteLine("Enter the destination country: ");
            //Console.WriteLine("1. local");
            //Console.WriteLine("2. national");
            //Console.WriteLine("3. international");

            //int country = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the weight of the package in kg: ");
            //int weight = int.Parse(Console.ReadLine());

            //double baseCost = 0;
            //double extraCharge = 0;

            //switch (country)
            //{
            //    case 1:
            //        baseCost = 1.000;
            //        if (weight > 10)
            //        {
            //            extraCharge = 5.000;
            //        }
            //        else if (weight > 5)
            //        {
            //            extraCharge = 2.000;
            //        }
            //        else
            //        {
            //            extraCharge = 0;
            //        }
            //        break;
            //    case 2:
            //        baseCost = 3.000;

            //        if (weight > 10)
            //        {
            //            extraCharge = 5.000;
            //        }
            //        else if (weight > 5)
            //        {
            //            extraCharge = 2.000;
            //        }
            //        else
            //        {
            //            extraCharge = 0;
            //        }
            //        break;
            //    case 3:
            //        baseCost = 7.000;
            //        if (weight > 10)
            //        {
            //            extraCharge = 5.000;
            //        }
            //        else if (weight > 5)
            //        {
            //            extraCharge = 2.000;
            //        }
            //        else
            //        {
            //            extraCharge = 0;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid region");
            //        break;
            //}
            //if (country == 1 || country == 2 || country == 3)
            //{
            //    double total = baseCost + extraCharge;

            //    Console.WriteLine("Base cost: " + baseCost + " OMR");
            //    Console.WriteLine("Extra charge: " + extraCharge + " OMR");
            //    Console.WriteLine("Total shipping cost: " + total + " OMR");
            //}

            // Task 13 - Triangle Type Classifier
            Console.WriteLine("Enter side 1: ");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter side 2: ");
            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter side 3: ");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 + side2 > side3 &&
                side1 + side3 > side2 &&
                side2 + side3 > side1)
            {
                Console.WriteLine("Valid triangle");

                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Equilateral triangle");
                }
                else
                {
                    if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("Isosceles triangle");
                    }
                    else
                    {
                        Console.WriteLine("Scalene triangle");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid triangle");
            }

        }

    }
}
            