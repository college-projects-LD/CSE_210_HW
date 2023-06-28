using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public string Mood { get; set; }
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
        Console.WriteLine("How are you feeling today?");
        var mood = Console.ReadLine();
        Entries.Add(new Entry { Prompt = prompt, Response = response, Date = DateTime.Now, Mood = mood });
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}, Mood: {entry.Mood}");
        }
    }

    public void SaveToFile(string filename)
    {
        var csv = new List<string> { "Date,Prompt,Response,Mood" };
        csv.AddRange(Entries.Select(entry => $"{entry.Date},{entry.Prompt},{entry.Response},{entry.Mood}"));
        File.WriteAllLines(filename, csv);
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines.Skip(1))
        {
            var parts = line.Split(',');
            var date = DateTime.Parse(parts[0]);
            var prompt = parts[1];
            var response = parts[2];
            var mood = parts[3];
            Entries.Add(new Entry { Date = date, Prompt = prompt, Response = response, Mood = mood });
        }
    }

    public void SaveToJson(string filename)
    {
        var json = JsonSerializer.Serialize(Entries);
        File.WriteAllText(filename, json);
    }

    public void LoadFromJson(string filename)
    {
        var json = File.ReadAllText(filename);
        Entries = JsonSerializer.Deserialize<List<Entry>>(json);
    }
}

public class Program
{
    static void Main()
    {
        var journal = new Journal();
        while (true)
        {
            Console.WriteLine("1. Write a new entry\n2. Display the journal\n3. Save the journal to a file\n4. Load the journal from a file\n5. Save the journal to a JSON file\n6. Load the journal from a JSON file\n7. Exit");
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
                    Console.WriteLine("Enter a filename:");
                    var jsonSaveFilename = Console.ReadLine();
                    journal.SaveToJson(jsonSaveFilename);
                    break;
                case "6":
                    Console.WriteLine("Enter a filename:");
                    var jsonLoadFilename = Console.ReadLine();
                    journal.LoadFromJson(jsonLoadFilename);
                    break;
                case "7":
                    return;
            }
        }
    }
}



/*1. Saves the journal entries as a CSV file.
2. Saves additional information in the journal entry, such as the user's mood.
3. Uses JSON for storage.*/