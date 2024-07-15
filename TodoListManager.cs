using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Notes_App
{
    internal class TodoListManager
    {
        public static void CreateTodoList(User user)
        {
            Console.Write("Enter todo list title: ");
            string title = Console.ReadLine();

            TodoLists newTodoList = new TodoLists(title);

            bool addingTasks = true;
            while (addingTasks)
            {
                Console.Write("Add a task to the TodoList (or 'done' to finish): ");
                string task = Console.ReadLine();

                if (task.ToLower() == "done")
                {
                    addingTasks = false;
                }
                else
                {
                    newTodoList.Tasks.Add(task);
                }
            }

            user.TodoLists.Add(newTodoList);
            Console.WriteLine("Todo list created successfully!");
            Console.Clear();

            TodoListsFunctions.DisplayTasks(newTodoList);

            Shortcut(newTodoList, user);

            // Add tasks to the new todo list
            // Implement functionality to add, edit, and delete tasks
        }


        public static void ViewTodoList(User user)
        {
            if (user.TodoLists.Count == 0)
            {
                TodoListsFunctions.EmptyTodoLists(user);
            }
            else
            {
                Console.WriteLine("List of TodoLists:");
                for (int i = 0; i < user.TodoLists.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {user.TodoLists[i].Title}\n");
                }

                Console.Write("Enter the number of the todolist you want to view: ");
                int todoListNumber = int.Parse(Console.ReadLine());
                Console.Clear();

                if (todoListNumber > 0 && todoListNumber <= user.TodoLists.Count)
                {
                    TodoLists selectedTodoList = user.TodoLists[todoListNumber - 1];
                    Console.WriteLine($"\n** {selectedTodoList.Title} **");

                    TodoListsFunctions.DisplayTasks(selectedTodoList);

                    Shortcut(selectedTodoList, user);

                }
                else
                {
                    Console.WriteLine("\nInvalid todolist number.");
                    Console.Clear();
                }

                // Display tasks in a selected todo list
                // Implement options for adding, editing, or deleting tasks
            }
        }
                

        public static void Shortcut(TodoLists todoList, User user)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Delete Task");
            Console.WriteLine("3. Delete TodoList");
            Console.WriteLine("4. Go back");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("What would you like to do with this TodoList?: ");

            int actionChoice = int.Parse(Console.ReadLine());

            switch (actionChoice)
            {
                case 1:
                    Console.Clear();
                    TodoListsFunctions.AddTasks(todoList, user);
                    break;
                case 2:
                    Console.Clear();
                    TodoListsFunctions.DeleteTask(todoList, user);
                    break;
                case 3:
                    user.TodoLists.Remove(todoList);
                    Console.WriteLine("\nTodoList deleted successfully!");
                    Console.Clear();

                    // Show remaining TodoLists or prompt to create a new TodoList
                    TodoListsFunctions.ShowRemainingTodoLists(user);
                    break;
                case 4:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    Console.Clear();
                    break;
            }
        }
    }
}
