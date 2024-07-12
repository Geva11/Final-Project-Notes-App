using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Notes_App
{
    internal class TodoLists
    {
        public string Title { get; set; }
        public List<string> Tasks { get; set; }

        public TodoLists(string title)
        {
            Title = title;
            Tasks = new List<string>();
        }
    }
}
