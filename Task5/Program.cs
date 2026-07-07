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
            //Queue<string> customerQueue = new Queue<string>();

            //Console.Write("Enter customer 1 name: ");
            //string customer1 = Console.ReadLine();

            //Console.Write("Enter customer 2 name: ");
            //string customer2 = Console.ReadLine();

            //Console.Write("Enter customer 3 name: ");
            //string customer3 = Console.ReadLine();

            //customerQueue.Enqueue(customer1);
            //customerQueue.Enqueue(customer2);
            //customerQueue.Enqueue(customer3);

            //string servedCustomer = customerQueue.Dequeue();

            //Console.WriteLine("\nCustomer served: " + servedCustomer);

            // -------------------------------------------------------------
            // Task 5 - Array Grade Range
            //int[] grades = new int[5];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write("Enter grade " + (i + 1) + ": ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(grades);

            //int total = 0;

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    total += grades[i];
            //}

            //double average = total / 5;

            //Console.WriteLine("Grade Results:");
            //Console.WriteLine("Lowest Grade: " + grades[0]);
            //Console.WriteLine("Highest Grade: " + grades[grades.Length - 1]);
            //Console.WriteLine("Average Grade: " + average);

            // -------------------------------------------------------------
            // Task 6 - Filtered Shopping List
            //List<string> shoppingList = new List<string>();

            //string item;
            //while (true)
            //{
            //    Console.WriteLine("Enter shopping item (type 'done' to finish): ");
            //    item = Console.ReadLine();

            //    if (item.ToLower() == "done")
            //    {
            //        break;
            //    }

            //    shoppingList.Add(item); 
            //}

            //Console.WriteLine("Shopping List Before Removal:");

            //foreach (string shoppingItem in shoppingList)
            //{
            //    Console.WriteLine("- " + shoppingItem);
            //}

            //Console.WriteLine("Enter item name to remove: ");
            //string removeItem = Console.ReadLine();

            //shoppingList.Remove(removeItem);

            //Console.WriteLine("Shopping List After Removal:");

            //foreach (string shoppingItem in shoppingList)
            //{
            //    Console.WriteLine("- " + shoppingItem);
            //}

            // -------------------------------------------------------------
            // Task 7 - Stack Reversal
            //List<int> gameScores = new List<int>();

            //for (int counter = 0; counter < 5; counter++)
            //{
            //    Console.WriteLine("Enter game score " + (counter + 1));
            //    gameScores.Add(int.Parse(Console.ReadLine()));
            //}
            //gameScores.Sort();
            //gameScores.Reverse();

            //Console.WriteLine("High Score : ");
            //Console.WriteLine("1st Place: " + gameScores[0]);
            //Console.WriteLine("2nd Place: " + gameScores[1]);
            //Console.WriteLine("3rd Place: " + gameScores[2]);

            // -------------------------------------------------------------
            // Task 8 - Undo Last Action
            Stack<string> editorActions = new Stack<string>();

            string action;
            while (true)
            {
                Console.Write("Enter an action (type 'stop' to finish): ");
                action = Console.ReadLine();

                if (action.ToLower() == "stop")
                {
                    break;
                }

                editorActions.Push(action);
            }

            Console.WriteLine("Undone: " + editorActions.Pop());
            Console.WriteLine("Undone: " + editorActions.Pop());

            Console.WriteLine("Remaining Actions:");

            foreach (string item in editorActions)
            {
                Console.WriteLine(item);
            }
        }
    } 
}
