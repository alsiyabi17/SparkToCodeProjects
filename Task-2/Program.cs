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
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + (number * i));
            }


        }
    }
}
