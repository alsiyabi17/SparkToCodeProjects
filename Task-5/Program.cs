namespace Task_4
{
    internal class Program
    {
        // For task 1
        //static void PrintWelcome(string name)
        //{
        //    Console.WriteLine("Welcome, " + name + "!");
        //    Console.WriteLine("We're glad to have you here.");
        //}

        // For task 2
        static int Square(int number)
        {
            return number * number;
        }
        static void Main(string[] args)
        {
            // Task 1 - Personalized Welcome Function
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //PrintWelcome(name);
            // ---------------------------------------
            // Task 2 - Square Number Function 
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("The square is: " + result);

        }
    }
}
