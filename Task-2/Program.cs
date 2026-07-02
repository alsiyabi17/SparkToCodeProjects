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

            //try
            //{
            //    Console.WriteLine("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine("Result: " + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero.");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input.");
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////

            // Task 7 - Repeating Menu with Exit Option
            //bool n = true;

            //while (n)
            //{
            //    try
            //    {
            //        Console.WriteLine("Welcome To Menu ");
            //        Console.WriteLine("1) Say Hello");
            //        Console.WriteLine("2) Show Greeting");
            //        Console.WriteLine("3) Exit");
            //        Console.WriteLine("Enter your choice:");

            //        int choice = int.Parse(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case 1:
            //                Console.WriteLine("Hello!");
            //                break;
            //            case 2:
            //                Console.WriteLine("Hope you're having a great time.");
            //                break;
            //            case 3:
            //                Console.WriteLine("Exiting...");
            //                n = false;
            //                break;
            //            default:
            //                Console.WriteLine("Invalid choice. Please select 1, 2, or 3");
            //                break;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input");
            //    }
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////


            // Task 8 - Sum of Even Numbers Only
            //Console.WriteLine("Enter a positive whole number:");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum = sum + i;
            //    }
            //}
            //Console.WriteLine("Sum of even numbers: " + sum);
            //////////////////////////////////////////////////////////////////////////////////////////////

            // Task 9 - Validated Positive Number Input
            //int n = 0;
            //bool valid = false;

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter a number:");
            //        n = int.Parse(Console.ReadLine());

            //        if (n <= 0)
            //        {
            //            Console.WriteLine("Number must be greater than 0");
            //        }
            //        else
            //        {
            //            valid = true;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a real number.");
            //    }
            //} while (!valid);

            //int sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine("Sum from 1 to " + n + " is: " + sum);
            //////////////////////////////////////////////////////////////////////////////////////////////


            // Task 10 - Simple ATM Simulation

            int CP = 1234;
            int attempts = 0;
            bool authenticated = false;
            double balance = 100.00;

            while (attempts < 3)
            {
                try
                {
                    Console.WriteLine("Enter your PIN:");
                    int pin = int.Parse(Console.ReadLine());
                    
                    if (pin == CP)
                    {
                        authenticated = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Numbers Only");
                }
                attempts++;
            }
            if (!authenticated)
            {
                Console.WriteLine("Card Blocked");
                return;
            }
            // Atm Menu
            bool n = true;

            while (n)
            {
                Console.WriteLine("Welcom To ATM Menu");
                Console.WriteLine("1) Deposit");
                Console.WriteLine("2) Withdraw");
                Console.WriteLine("3) Check Balance");
                Console.WriteLine("4) Exit");
                Console.WriteLine("Choose option:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("enter deposit amount : ");
                            double deposit = double.Parse(Console.ReadLine());

                            if (deposit < 0)
                            {
                                Console.WriteLine("Invalid amount");
                            }
                            else
                            {
                                balance += deposit;
                                Console.WriteLine("Deposit successful. New balance: " + balance);
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("enter withdraw amount : ");
                            double withdraw = double.Parse(Console.ReadLine());
                            if (withdraw < 0)
                            {
                                Console.WriteLine("Invalid amount");
                            }
                            else if (withdraw > balance)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else
                            {
                                balance -= withdraw;
                                Console.WriteLine("Withdrawal successful. New balance: " + balance);
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Current balance: " + balance);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        n = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
