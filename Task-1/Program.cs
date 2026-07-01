using Microsoft.VisualBasic.FileIO;

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
            Console.WriteLine("Are you a loyalty member (yes/no)?");
            string LM = (Console.ReadLine());

            bool yes = LM == "yes";
            bool no = LM == "no";

            Console.WriteLine("Enter the total bill amount: ");
            int billAmount = int.Parse(Console.ReadLine());
                
            int discount = billAmount * 15 / 100;

            if (billAmount > 20 && yes)
            {
                Console.WriteLine("orginal bill = " + billAmount);
                Console.WriteLine("Discount 15% = " + discount);
                Console.WriteLine("Total bill after discount = " + (billAmount - discount));
            }
            else
            {
                Console.WriteLine("orginal bill = " + billAmount);
            }

        }
    }
}