using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    internal class UserInterface
    {
        private TaskManager taskManager;

        public UserInterface(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }
        public void Start()
        {
            Console.WriteLine("Welcome to the To Do List Manager!");

            while (true)
            {
                ViewMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTasks();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        MarkTaskAsCompleted();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the To-Do List Manager. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        private void ViewMenu()
        {
            Console.WriteLine("\n1. Add task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Delete tasks");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");
        }

        private void AddTasks()
        {
            Console.Write("Enter a new task: ");
            string task = Console.ReadLine();
            TaskManager.toDoList.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        private void ViewTasks()
        {
            List<string> tasks = taskManager.GetTasks();

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found. Add some tasks first!");
            }
            else
            {
                Console.WriteLine("To Do list: ");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}, {tasks[i]}");
                }
            }
        }

        public void MarkTaskAsCompleted()
        {
            ViewTasks();

            if (taskManager.GetTasks().Count == 0)
            {
                Console.WriteLine("No tasks to mark as completed.");
                return;
            }

            Console.Write("Enter the number of the task to mark as completed: ");

            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                taskManager.MarkTaskAsCompleted(taskNumber);
            }
            else
            {
                Console.WriteLine("Invalid task number. Please enter a valid task number.");
            }
        }
    }
}
