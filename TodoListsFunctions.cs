using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Notes_App
{
    internal class TodoListsFunctions
    {
        public static void DisplayTasks(TodoLists todoList)
        {
            Console.WriteLine("Tasks in the TodoList:");
            for (int i = 0; i < todoList.Tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList.Tasks[i]}");
            }
        }

        public static void AddTasks(TodoLists todoList, User user)
        {
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
                    todoList.Tasks.Add(task);
                }
            }

            Console.WriteLine("Task(s) added successfully!");
            Console.Clear();
            TodoListsFunctions.DisplayTasks(todoList);

            // Loop for asking further actions
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Delete Task");
                Console.WriteLine("3. Delete TodoList");
                Console.WriteLine("4. Go back");
                Console.WriteLine("------------------------");
                Console.Write("Do you want to: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        TodoListsFunctions.AddTasks(todoList, user);
                        break;
                    case 2:
                        Console.Clear();
                        TodoListsFunctions.DeleteTask(todoList, user); // Pass 'user' to DeleteTask
                        break;
                    case 3:
                        user.TodoLists.Remove(todoList);
                        Console.WriteLine("TodoList deleted successfully!\n");
                        Console.Clear();
                        ShowRemainingTodoLists(user);
                        return;
                    case 4:
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        Console.Clear();
                        break;
                }
            }
        }

        public static void DeleteTask(TodoLists todoList, User user)
        {
            if (todoList.Tasks.Count == 0)
            {
                Console.WriteLine("No tasks to delete.");
            }
            else
            {
                bool deletingTasks = true;
                while (deletingTasks)
                {
                    for (int i = 0; i < todoList.Tasks.Count; i++)
                    {
                        Console.Write("Select a task number to delete: ");
                        Console.WriteLine($"{i + 1}. {todoList.Tasks[i]}");
                    }

                    int taskNumber = int.Parse(Console.ReadLine());

                    if (taskNumber > 0 && taskNumber <= todoList.Tasks.Count)
                    {
                        todoList.Tasks.RemoveAt(taskNumber - 1);
                        Console.WriteLine("\nTask deleted successfully!");
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid task number.");
                        Console.Clear();
                    }

                    DisplayTasks(todoList);

                    // Loop for asking further actions
                    Console.WriteLine();
                    Console.WriteLine("------------------------");
                    Console.WriteLine("1. Add Task");
                    Console.WriteLine("2. Delete Task");
                    Console.WriteLine("3. Delete TodoList");
                    Console.WriteLine("4. Go back");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Do you want to:");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            TodoListsFunctions.AddTasks(todoList, user);
                            deletingTasks = false;
                            break;
                        case 2:
                            // Continue deleting tasks
                            break;
                        case 3:
                            user.TodoLists.Remove(todoList);
                            Console.WriteLine("\nTodoList deleted successfully!");
                            Console.Clear();
                            ShowRemainingTodoLists(user);
                            return;
                        case 4:
                            deletingTasks = false;
                            break;
                        default:
                            Console.WriteLine("\nInvalid choice. Please try again.");
                            Console.Clear();
                            break;
                    }
                }
            }
        }

        public static void ShowRemainingTodoLists(User user)
        {
            if (user.TodoLists.Count > 0)
            {
                Console.WriteLine("\nRemaining TodoLists:");
                for (int i = 0; i < user.TodoLists.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {user.TodoLists[i].Title} \n");
                }
            }
            else
            {
                EmptyTodoLists(user);
            }
        }

        public static void EmptyTodoLists(User user)
        {
            Console.WriteLine("TodoList is empty.");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Make a new TodoList");
            Console.WriteLine("2. Go back");
            Console.WriteLine("----------------------");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    TodoListManager.CreateTodoList(user);
                    break;
                case 2:
                    Console.Clear();
                    break;
                default:
                    if (choice < 1 || choice > 2)
                    {
                        Console.WriteLine("\nInvalid Input");
                        Console.Clear();
                    }
                    break;

            }
        }
    }
}
