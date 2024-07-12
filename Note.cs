using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Notes_App
{
    internal class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Note(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
