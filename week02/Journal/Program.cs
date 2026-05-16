using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date;
    public string Prompt;
    public string Response;

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Entry> journal = new List<Entry>();

        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What made me smile today?"
        };

        Random random = new Random();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice: ");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // WRITE ENTRY
            if (choice == 1)
            {
                string prompt = prompts[random.Next(prompts.Count)];

                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry.Date = DateTime.Now.ToShortDateString();
                newEntry.Prompt = prompt;
                newEntry.Response = response;

                journal.Add(newEntry);

                Console.WriteLine();
            }

            // DISPLAY JOURNAL
            else if (choice == 2)
            {
                foreach (Entry entry in journal)
                {
                    entry.Display();
                }
            }

            // LOAD JOURNAL
            else if (choice == 3)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();

                if (File.Exists(filename))
                {
                    journal.Clear();

                    string[] lines = File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("|");

                        Entry loadedEntry = new Entry();
                        loadedEntry.Date = parts[0];
                        loadedEntry.Prompt = parts[1];
                        loadedEntry.Response = parts[2];

                        journal.Add(loadedEntry);
                    }

                    Console.WriteLine("Journal loaded successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }

                Console.WriteLine();
            }

            // SAVE JOURNAL
            else if (choice == 4)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in journal)
                    {
                        outputFile.WriteLine(entry.ToFileString());
                    }
                }

                Console.WriteLine("Journal saved successfully.");
                Console.WriteLine();
            }

            // QUIT
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            // INVALID INPUT
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.WriteLine();
            }
        }
    }
}