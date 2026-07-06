namespace Task_4
{
    internal class Program
    {
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
            Console.WriteLine("We're glad to have you here.");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);
        }
    }
}
