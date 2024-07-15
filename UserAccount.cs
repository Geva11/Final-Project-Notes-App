using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Notes_App
{
    internal class UserAccount
    {
        public static void RegisterUser(List<User> users)
        {
            Console.Write("Enter your username: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (email == "" || password == "")
            {
                Console.WriteLine("\nIncorrect Credentials. Put an email and password with letters.");
                Console.WriteLine("\nPress any key to try again...");
                Console.ReadKey();
                Console.Clear();

                RegisterUser(users);
            }
            else
            {
                users.Add(new User(email, password));
                Console.WriteLine("\nRegistered successfulyl!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static User Login(List<User> users)
        {
            Console.Clear();
            Console.Write("Enter your username: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            
            foreach (User user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    Console.WriteLine("\nLoggedIn Successfully!");
                    Console.ReadKey(true);
                    Console.Clear();
                    return user;
                }
            }
            return null;
        }
    }
}
