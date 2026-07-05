namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference
            //Console.WriteLine("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //double Result = Math.Abs(num2 - num1);
            //Console.WriteLine(Result);
            // -----------------------------------------------------------------------------
            // Task 2 - Power & Root Explorer
            //Console.WriteLine("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int square = (int)Math.Pow(num, 2);
            //int squareRoot = (int)Math.Sqrt(num);

            //Console.WriteLine("The square of " + num + " is: " + square);
            //Console.WriteLine("The square root of " + num + " is: " + squareRoot);
            // -----------------------------------------------------------------------------
            // Task 3 - Name Formatter
            //Console.WriteLine("Enter your full name: ");
            //string fullName = Console.ReadLine();

            //string nameUpper = fullName.ToUpper();
            //string nameLower = fullName.ToLower();
            //string nameLength = fullName.Length.ToString();

            //Console.WriteLine("Your name in uppercase: " + nameUpper);
            //Console.WriteLine("Your name in lowercase: " + nameLower);
            //Console.WriteLine("The length of your name is: " + nameLength);
            // -----------------------------------------------------------------------------
            // Task 4 - Subscription End Date
            //Console.WriteLine("Enter the day's of free trial: ");
            //int freeTrialDays = Convert.ToInt32(Console.ReadLine());

            //DateTime startDate = DateTime.Today;
            //DateTime endDate = startDate.AddDays(freeTrialDays);

            //Console.WriteLine("Trial End Date: " + endDate.ToString("yyyy-MM-dd"));
            // -----------------------------------------------------------------------------
            // Task 5 - Grade Rounding System
            //Console.WriteLine("enter your raw exam score as a decimal number: ");
            //float rawScore = Convert.ToSingle(Console.ReadLine());

            //float roundedScore = (float)Math.Round(rawScore, 1);
            //if (roundedScore >= 60)
            //{
            //    Console.WriteLine("Your rounded score is: " + roundedScore + " You passed the exam.");

            //}
            //else
            //{
            //    Console.WriteLine("Your rounded score is: " + roundedScore + " You failed the exam.");

            //}
            // -----------------------------------------------------------------------------
            // Task 6 - Password Strength Checker
            //Console.Write("Enter your password: ");
            //string password = Console.ReadLine();

            //if (password.Length >= 8 && !password.ToLower().Contains("password"))
            //{
            //    Console.WriteLine("Strong");
            //}
            //else
            //{
            //    Console.WriteLine("Weak:");

            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("It must be at least 8 characters");
            //    }

            //    if (password.ToLower().Contains("password"))
            //    {
            //        Console.WriteLine("It must not contain the word \"password\"");
            //    }
            //}
            // -----------------------------------------------------------------------------
            // Task 7 - Clean Name Comparator
            //Console.Write("Enter first name: ");
            //string name1 = Console.ReadLine();

            //Console.Write("Enter second name: ");
            //string name2 = Console.ReadLine();

            //name1 = name1.Trim().ToLower();
            //name2 = name2.Trim().ToLower();

            //if (name1 == name2)
            //{
            //    Console.WriteLine("Match");
            //}
            //else
            //{
            //    Console.WriteLine("No Match");
            //}
            // -----------------------------------------------------------------------------
            // Task 8 - Membership Expiry Checker
            //try
            //{
            //    Console.Write("Enter membership start date (yyyy-MM-dd): ");
            //    string inputDate = Console.ReadLine();

            //    Console.Write("Enter number of valid membership days: ");
            //    int days = int.Parse(Console.ReadLine());

            //    DateTime startDate = DateTime.Parse(inputDate);

            //    DateTime expiryDate = startDate.AddDays(days);

            //    if (expiryDate >= DateTime.Today)
            //    {
            //        Console.WriteLine("Active");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Expired");
            //    }
            //    Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input...");
            //}
            // -----------------------------------------------------------------------------
            // Task 9 - Round Up / Round Down Explorer
            //Console.Write("Enter a decimal number: ");
            //double number = double.Parse(Console.ReadLine());

            //double rounded = Math.Round(number);
            //double roundedUp = Math.Ceiling(number);
            //double roundedDown = Math.Floor(number);

            //Console.WriteLine("Nearest Whole Number: " + rounded);
            //Console.WriteLine("Always Rounded Up: " + roundedUp);
            //Console.WriteLine("Always Rounded Down: " + roundedDown);
            // -----------------------------------------------------------------------------
            // Task 10 - Word Position Finder
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //Console.Write("Enter a word to search for: ");
            //string word = Console.ReadLine();

            //int firstIndex = sentence.IndexOf(word);
            //int lastIndex = sentence.LastIndexOf(word);

            //if (firstIndex == -1)
            //{
            //    Console.WriteLine("Word not found.");
            //}
            //else
            //{
            //    Console.WriteLine("First occurrence: " + firstIndex);
            //    Console.WriteLine("Last occurrence: " + lastIndex);
            //}
            // -----------------------------------------------------------------------------
            // Task 11 - One-Time Password (OTP) Generator
            Random random = new Random();
            int otp = random.Next(1000, 10000);

            Console.WriteLine("Your OTP is: " + otp);
            int attempts = 3;
            while (attempts > 0)
            {
                try
                {
                    Console.Write("Enter the OTP: ");
                    int userOtp = int.Parse(Console.ReadLine());
                    if (userOtp == otp)
                    {
                        Console.WriteLine("Verified");
                        return;
                    }
                    else
                    {
                        attempts--;
                        if (attempts > 0)
                        {
                            Console.WriteLine("Incorrect OTP. Attempts left: " + attempts);
                        }
                    }
                }
                catch (FormatException)
                {
                    attempts--;
                    if (attempts > 0)
                    {
                        Console.WriteLine("Invalid input. Please enter numbers only.");
                        Console.WriteLine("Attempts left: " + attempts);
                    }
                }
            }
            Console.WriteLine("Verification Failed");
        }
    }
}
