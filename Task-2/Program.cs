namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Countdown Timer
            //Console.WriteLine("Enter the starting number:");
            //int start = int.Parse(Console.ReadLine());

            //for (int i = start; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Liftoff!");
            //////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 2 - Sum of Numbers 1 to N
            //Console.WriteLine("Enter a positive whole number:");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    sum = sum + i;
            //}

            //Console.WriteLine("The sum is: " + sum);
            //////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 3 - Multiplication Table
            //Console.WriteLine("Enter a number:");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(number + " x " + i + " = " + (number * i));
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 4 - Password Retry
            //string correctPassword = "Spark2026";

            //Console.WriteLine("Enter password:");
            //string password = Console.ReadLine();

            //while (password != correctPassword)
            //{
            //    Console.WriteLine("Incorrect password, try again");
            //    password = Console.ReadLine();
            //}

            //Console.WriteLine("Access Granted");
            //////////////////////////////////////////////////////////////////////////////////////////////////


            // Task 5 - Number Guessing Game
            //int secretNumber = 42;
            //int guess;
            //int attempts = 0;

            //do
            //{
            //    Console.WriteLine("Guess the secret number: ");
            //    guess = int.Parse(Console.ReadLine());
            //    attempts++;

            //    if (guess > secretNumber)
            //    {
            //        Console.WriteLine("Too high");
            //    }
            //    else if (guess < secretNumber)
            //    {
            //        Console.WriteLine("Too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Correct!");
            //    }
            //} while (guess != secretNumber);
            //Console.WriteLine("You took " + attempts + " attempts.");
            //////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 6 - Safe Division Calculator

            try
            {
                Console.WriteLine("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
