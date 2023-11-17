using System.Runtime;
using System.Runtime.CompilerServices;

namespace ToDoApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            UserInterface userInterface = new UserInterface(taskManager);

            userInterface.Start();

        }
    }
}