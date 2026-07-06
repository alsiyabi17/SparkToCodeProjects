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
        // -----------------------------------------------------
        // For task 2
        //static int Square(int number)
        //{
        //    return number * number;
        //}
        // -----------------------------------------------------
        // for task 3
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        static void Main(string[] args)
        {
            // Task 1 - Personalized Welcome Function
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //PrintWelcome(name);
            // ---------------------------------------
            // Task 2 - Square Number Function 
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int result = Square(number);

            //Console.WriteLine("The square is: " + result);
            // ---------------------------------------
            // Task 3 - Celsius to Fahrenheit Function
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

        }
    }
}
