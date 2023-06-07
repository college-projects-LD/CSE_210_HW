using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();
    private List<string> Prompts { get; set; } = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void WriteEntry()
    {
        var random = new Random();
        var prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        var response = Console.ReadLine();
        Entries.Add(new Entry { Prompt = prompt, Response = response, Date = DateTime.Now });
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
        }
    }

    public void SaveToFile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        using (var reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(new[] { ", Prompt: ", ", Response: " }, StringSplitOptions.None);
                var date = DateTime.Parse(parts[0].Replace("Date: ", ""));
                var prompt = parts[1];
                var response = parts[2];
                Entries.Add(new Entry { Date = date, Prompt = prompt, Response = response });
            }
        }
    }
}

public class Program
{
    static void Main()
    {
        var journal = new Journal();
        while (true)
        {
            Console.WriteLine("1. Write a new entry\n2. Display the journal\n3. Save the journal to a file\n4. Load the journal from a file\n5. Exit");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.WriteLine("Enter a filename:");
                    var saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "4":
                    Console.WriteLine("Enter a filename:");
                    var loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
