namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference
           
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double Result = Math.Abs(num2 - num1);
            Console.WriteLine(Result);

        }
    }
}
