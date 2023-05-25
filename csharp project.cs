using System;
using System.Collections.Generic;

class Note
{
    public string Title { get; set; }
    public string Content { get; set; }
}

class NoteTakingApp
{
    private List<Note> notes;

    public NoteTakingApp()
    {
        notes = new List<Note>();
    }

    public void AddNote()
    {
        Console.Write("Enter note title: ");
        string title = Console.ReadLine();

        Console.Write("Enter note content: ");
        string content = Console.ReadLine();

        Note note = new Note
        {
            Title = title,
            Content = content
        };

        notes.Add(note);

        Console.WriteLine("Note added successfully!");
    }

    public void DisplayNotes()
    {
        if (notes.Count == 0)
        {
            Console.WriteLine("No notes found!");
            return;
        }

        Console.WriteLine("Notes:");

        foreach (Note note in notes)
        {
            Console.WriteLine($"Title: {note.Title}");
            Console.WriteLine($"Content: {note.Content}");
            Console.WriteLine("-------------------------");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        NoteTakingApp app = new NoteTakingApp();

        while (true)
        {
            Console.WriteLine("1. Add a note");
            Console.WriteLine("2. Display notes");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    app.AddNote();
                    break;
                case "2":
                    app.DisplayNotes();
                    break;
                case "3":
                    Console.WriteLine("Exiting the application...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
