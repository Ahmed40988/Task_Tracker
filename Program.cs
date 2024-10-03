using System.Numerics;

namespace Task_Tracker
{
    public class Program
    {
        public static string[] Task_name = new string[100];
        public static bool[] Completed = new bool[100];
        public static int Task_count = 0;

        static void Main(string[] args)
        {
            welcome_user();

        }

        // Function to welcome user
        public static void welcome_user()
        {
            Console.Write("Welcome Mr...., Please Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, and Keep Going with your tasks!");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Task Tracker Menu ---");
                Console.WriteLine("1. Add New Task");
                Console.WriteLine("2. View All Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Remove Task");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Addnewtask();
                        break;
                    case "2":
                        print_tasks();
                        break;
                    case "3":
                        Marktask();
                        break;
                    case "4":
                        remove_task();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        // Function to add a new task
        public static void Addnewtask()
        {
            Console.Write("Add name of the New Task: ");
            Task_name[Task_count] = Console.ReadLine();
            ++Task_count;
            Console.WriteLine("Task is added successfully.");
        }

        // Function to mark a task as completed
        public static void Marktask()
        {
            Console.WriteLine("--------------------");
            print_tasks();
            Console.Write("Enter the task number that is completed: ");
            int num_id = int.Parse(Console.ReadLine());

            if (num_id > 0 && num_id <= Task_count)
            {
                Completed[num_id - 1] = true;
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        // Function to print all tasks
        public static void print_tasks()
        {
            Console.WriteLine("\nTask List:");

            for (int i = 0; i < Task_count; i++)
            {
                if (Completed[i] == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"|{i + 1}| {Task_name[i]} ____ Task is Completed!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"|{i + 1}| {Task_name[i]}");
                }
            }
            Console.WriteLine();
        }

        // Function to remove a task
        public static void remove_task()
        {
            Console.Write("Enter number of Task to remove: ");
            int num_de = int.Parse(Console.ReadLine());

            if (num_de > 0 && num_de <= Task_count)
            {
                string nam_dele = Task_name[num_de - 1];

                for (int i = num_de - 1; i < Task_count - 1; i++)
                {
                    Task_name[i] = Task_name[i + 1];
                    Completed[i] = Completed[i + 1];
                }

                --Task_count;
                Console.WriteLine($"Task: {nam_dele} is deleted successfully.");
            }
            else
            {
                Console.WriteLine("Task is not found !.");
                Console.WriteLine("Task is not found !.");
            }
        }
    }
}
