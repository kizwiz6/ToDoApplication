using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    internal class TaskManager
    {
        public static List<string> toDoList = new List<string>();

        public void AddTasks(string task)
        {
            toDoList.Add(task);
        }

        public List<string> GetTasks()
        {
            return toDoList;
        }

        public bool MarkTaskAsCompleted(int taskNumber)
        {
            if (taskNumber >= 1 && taskNumber <= toDoList.Count)
            {
                string completedTask = toDoList[taskNumber - 1];
                toDoList.RemoveAt(taskNumber - 1);
                Console.WriteLine($"Task '{completedTask} marked as completed!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid task number. Please enter a valid task number.");
                return false;
            }
        }
    }
}
