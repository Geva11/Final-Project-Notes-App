using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Notes_App
{
    internal class ViewAllNotes
    {
        public static void UsersAllNotes(List<User> users)
        {
            if (users.Count == 0)
            {
                
                Console.WriteLine("No users registered yet.\n");
                return;
            }
            else
            {
                Console.WriteLine("All User(s)'s Notes:");
                int noteNumber = 1;
                foreach (User user in users)
                {
                    Console.WriteLine($"User: {user.Email}");
                    foreach (Note note in user.Notes)
                    {
                        Console.WriteLine(noteNumber + ". " + note.Title);
                    }
                    
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
