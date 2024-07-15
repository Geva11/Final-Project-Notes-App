using System;


namespace Final_Project_Notes_App
{
    internal class Program
    {
        static List<User> users = new List<User>();

        public static void Main(string[] args)
        {
            bool running = true;

            while (true)
            {
                Console.WriteLine("Welcome to Notes & TodoLists App!");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.WriteLine("4. View All Registered User(s)'s Notes");
                Console.WriteLine("---------------------------------------------");
                Console.Write("Choose in the options: ");
                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please choose from [1-4] only");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("1. Register");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("4. View All Registered User(s)'s Notes");
                    Console.WriteLine("---------------------------------------------");
                    Console.Write("Choose in the options: ");
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        UserAccount.RegisterUser(users);
                        break;
                    case 2:
                        LoggingIn();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Thank you for using Notes & TodoLists App!\n");
                        Environment.Exit(0);
                        break;
                    case 4:
                        Console.Clear();
                        ViewAllNotes.UsersAllNotes(users);
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        public static void LoggingIn()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("\nRegister an account first before logging in.\n");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                User loggedInUser = UserAccount.Login(users);
                if (loggedInUser != null)
                {
                    bool isLoggedIn = true;

                    while (isLoggedIn)
                    {
                        Console.Clear();
                        Console.WriteLine("1. Create Note");
                        Console.WriteLine("2. View Notes");
                        Console.WriteLine("3. Create Todo List");
                        Console.WriteLine("4. View Todo List");
                        Console.WriteLine("5. Logout");
                        Console.WriteLine("------------------------------");
                        Console.Write("What would you like to do?: ");

                        int input = int.Parse(Console.ReadLine());

                        switch (input)
                        {
                            case 1:
                                Console.Clear();
                                NotesManager.CreateNote(loggedInUser);
                                break;
                            case 2:
                                Console.Clear();
                                NotesManager.ViewNotes(loggedInUser);
                                break;
                            case 3:
                                Console.Clear();
                                TodoListManager.CreateTodoList(loggedInUser);
                                break;
                            case 4:
                                Console.Clear();
                                TodoListManager.ViewTodoList(loggedInUser);
                                break;
                            case 5:
                                Console.WriteLine("Logging out...");
                                Console.ReadKey();
                                Console.Clear();
                                isLoggedIn = false; // Update login status to false
                                break;
                            default:
                                Console.WriteLine("\nInvalid choice. Please try again.");
                                Console.Clear();
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid email or password. Please try again.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
