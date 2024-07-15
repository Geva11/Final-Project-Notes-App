using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Notes_App
{
    internal class NotesFunctions
    {
        public static void EditNote(Note notes, User user)
        {
            Console.Write("Enter the new content for the note: ");
            string newContent = Console.ReadLine();
            notes.Content = newContent;
            Console.WriteLine("Note updated successfully!\n");
            Console.Clear();

            Console.WriteLine($"\n** {notes.Title} **");
            Console.WriteLine(notes.Content);

            NotesManager.Shortcut(notes, user);
        }


        public static void ShowRemainingNotes(User user)
        {
            if (user.Notes.Count > 0)
            {
                NotesManager.ViewNotes(user);
            }
            else
            {
                Console.WriteLine("Notes list is empty.");
                Console.WriteLine("1. Make a new Notes");
                Console.WriteLine("2. Go back");
                Console.WriteLine("--------------------------");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        NotesManager.CreateNote(user);
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
}
