namespace CsharpFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //built-in functios call
            //className.FunctionName(parameters);

            double result = Math.Pow(2, 3);      // 2^3
            Console.WriteLine(result);

            Math.Cos(90);

            Console.WriteLine("hello");
            Console.Clear();

            double r = Math.Cos(90);
            Console.WriteLine(r);

            Console.WriteLine(Math.Pow(2, 3));

            ///////////////////////////////////////////////////////////////
            ///

            Console.WriteLine("enter number: ");
            float userInput = float.Parse(Console.ReadLine());

            double m = Math.Cos(userInput);
            Console.WriteLine(m);

            //////////////////////////////////////////////////////////////
            ///

            Console.WriteLine("enter base number: ");
            float baseNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("enter power number: ");
            float powerNumber = float.Parse(Console.ReadLine());

            double thth = Math.Pow(baseNumber, powerNumber);
            Console.WriteLine(thth);


            /////////////////////////////////////////////////////////////
            ///

            DateTime currenttime = DateTime.Now;
            Console.WriteLine(currenttime);

            DateTime timing = DateTime.Today;
            Console.WriteLine(timing);

            DateTime startsubscription = DateTime.Today;
            DateTime endsubscription = startsubscription.AddDays(30);

            Console.WriteLine("your subscription end " + endsubscription);

            // later we will take array functions and string functions

            /////////////////////////////////////////////////////////////////
            ///

            string word = "Hello, World!";
            int length = word.Length;                // returns 13
            word.Substring(7, 5);       // returns "World"
            word.ToUpper(); // returns "HELLO, WORLD!"
            word.ToLower(); // returns "hello, world!"

            // -- substring )))) returns "World" //we cutted the word from index 7 and took 5 characters after it


            // a is different than A in C# because C# is case sensitive language
            // ahmed is equal to AHMED is equal to Ahmed  -- we understand this but computer sees it as 3 different things - because computer is case sensitive language

            string name = "Ahmed";
            Console.WriteLine("enter your name: ");
            string input = Console.ReadLine();    //ahmed => AHMED 

            if (input.ToUpper() == name.ToUpper())
            {
                Console.WriteLine("welcome to application" + name);
            }
            else
            {
                Console.WriteLine("invalid name, please try again");
            }

            bool containsresult = word.Contains("hi");

            // functions are ideas in a program that we can use to do a specific task, and we can use it multiple times in the program without writing the same code again and again.
        }
    }
}