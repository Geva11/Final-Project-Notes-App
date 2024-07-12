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
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                users.Add(new User(email, password));
                Console.WriteLine("Registration successful!");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nEmail rejected. Email should only contain letters.");
                Console.Clear();
            }
        }

        public static User Login(List<User> users)
        {
            Console.Clear();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            return users.Find(u => u.Email == email && u.Password == password);
        }

        private static bool IsValidEmail(string email)
        {
            foreach (char c in email)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
