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
            Console.WriteLine("Enter the day's of free trial: ");
            int freeTrialDays = Convert.ToInt32(Console.ReadLine());

            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddDays(freeTrialDays);

            Console.WriteLine("Trial End Date: " + endDate.ToString("yyyy-MM-dd"));

        }
    }
}
