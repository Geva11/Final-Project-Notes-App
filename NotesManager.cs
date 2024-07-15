using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Notes_App
{
    internal class NotesManager
    {
        public static void CreateNote(User user)
        {
            Console.Write("Enter the title of the note: ");
            string title = Console.ReadLine();
            Console.Write("Enter the content of the note: ");
            string content = Console.ReadLine();

            // Create a new Note object with the provided title and content
            Note newNote = new Note(title, content);

            // Add the new note to the user's list of notes
            user.Notes.Add(newNote);

            // Display the newly created note
            Console.Clear();
            Console.WriteLine("\nNew Note Created Successfully:");
            Console.WriteLine($"Title: {newNote.Title}");
            Console.WriteLine($"Content: {newNote.Content}\n");

            Shortcut(newNote, user);
        }


        public static void ViewNotes(User user)
        {
            Console.WriteLine("List of Notes:");
            for (int i = 0; i < user.Notes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {user.Notes[i].Title}\n");
            }

            Console.Write("Enter the number of the note you want to view: ");
            int noteNumber = int.Parse(Console.ReadLine());

            if (noteNumber <= user.Notes.Count)
            {
                Note selectedNote = user.Notes[noteNumber - 1];
                Console.WriteLine($"\n** {selectedNote.Title} **");
                Console.WriteLine(selectedNote.Content);

                DisplayNotes(user);

                Shortcut(selectedNote, user);
            }
            else
            {
                Console.WriteLine("\nInvalid note number.");
                Console.Clear();
            }
        }

        public static void DisplayNotes(User user)
        {
            Console.WriteLine("\nList of Notes:");
            for (int i = 0; i < user.Notes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {user.Notes[i].Title}");
            }
        }

        public static void Shortcut(Note notes, User user)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1. Edit Note");
            Console.WriteLine("2. Delete Note");
            Console.WriteLine("3. Go back");
            Console.WriteLine("------------------------------------------------");
            Console.Write("What would you like to do with this note?: ");

            int actionChoice = int.Parse(Console.ReadLine());

            switch (actionChoice)
            {
                case 1:
                    Console.Clear();
                    NotesFunctions.EditNote(notes, user);
                    break;
                case 2:
                    user.Notes.Remove(notes);
                    Console.WriteLine("\nNote deleted successfully!");
                    Console.Clear();
                    NotesFunctions.ShowRemainingNotes(user);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    Console.Clear();
                    break;
            }
        }
    }
}
