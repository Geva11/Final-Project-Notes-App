using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Notes_App
{
    internal class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Note> Notes { get; set; }
        public List<TodoLists> TodoLists { get; set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
            Notes = new List<Note>();
            TodoLists = new List<TodoLists>();
        }
    }
}
