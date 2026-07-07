namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Fixed Grades Array
            //int[] grades = new int[5];
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write("Enter grade " + (i + 1) + ": ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\nStudent Grades:");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            // -------------------------------------------------------------

            // Task 2 - Dynamic To-Do List
            //List<string> todoList = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter task " + (i + 1) + ": ");
            //    todoList.Add(Console.ReadLine());
            //}

            //Console.WriteLine("\nTo-Do List:");
            //int taskNumber = 1;

            //foreach (string task in todoList)
            //{
            //    Console.WriteLine(taskNumber + ". " + task);
            //    taskNumber++;
            //}

            // -------------------------------------------------------------
            // Task 3 - Browsing History Stack
            //Stack<string> browserhistory = new Stack<string>();

            //Console.WriteLine("Enter 3 websites you visited: ");

            //Console.WriteLine("Enter website 1: ");
            //string website1 = Console.ReadLine();

            //Console.WriteLine("Enter website 2: ");
            //string website2 = Console.ReadLine();

            //Console.WriteLine("Enter website 3: ");
            //string website3 = Console.ReadLine();

            //browserhistory.Push(website1);
            //browserhistory.Push(website2);
            //browserhistory.Push(website3);

            //string result2 = browserhistory.Pop();
            //Console.WriteLine(browserhistory.Peek());

            // -------------------------------------------------------------
            // Task 4 - Customer Service Queue
            Queue<string> customerQueue = new Queue<string>();

            Console.Write("Enter customer 1 name: ");
            string customer1 = Console.ReadLine();

            Console.Write("Enter customer 2 name: ");
            string customer2 = Console.ReadLine();

            Console.Write("Enter customer 3 name: ");
            string customer3 = Console.ReadLine();

            customerQueue.Enqueue(customer1);
            customerQueue.Enqueue(customer2);
            customerQueue.Enqueue(customer3);

            string servedCustomer = customerQueue.Dequeue();

            Console.WriteLine("\nCustomer served: " + servedCustomer);

        }
    }
}
