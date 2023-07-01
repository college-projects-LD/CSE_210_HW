using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    static void Main()
    {
        LoadGoals();
        while (true)
        {
            Console.WriteLine("1. View goals");
            Console.WriteLine("2. Add simple goal");
            Console.WriteLine("3. Add eternal goal");
            Console.WriteLine("4. Add checklist goal");
            Console.WriteLine("5. Mark goal as complete");
            Console.WriteLine("6. Delete goal");
            Console.WriteLine("7. Save goals");
            Console.WriteLine("8. Load goals");
            Console.WriteLine("9. Exit");
            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ViewGoals();
                    break;
                case 2:
                    AddSimpleGoal();
                    break;
                case 3:
                    AddEternalGoal();
                    break;
                case 4:
                    AddChecklistGoal();
                    break;
                case 5:
                    MarkGoalAsComplete();
                    break;
                case 6:
                    DeleteGoal();
                    break;
                case 7:
                    SaveGoals();
                    break;
                case 8:
                    LoadGoals();
                    break;
                case 9:
                    return;
            }
        }
    }

    private static void ViewGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine($"Name: {goal.Name}, Description: {goal.Description}, Value: {goal.Value}, IsComplete: {goal.IsComplete}");
        }
    }

    private static void AddSimpleGoal()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());
        goals.Add(new SimpleGoal(name, description, value));
    }

    private static void AddEternalGoal()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());
        goals.Add(new EternalGoal(name, description, value));
    }

    private static void AddChecklistGoal()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Enter target count: ");
        int targetCount = int.Parse(Console.ReadLine());
        goals.Add(new ChecklistGoal(name, description, value, targetCount));
    }

    private static void MarkGoalAsComplete()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        foreach (var goal in goals)
        {
            if (goal.Name == name)
            {
                goal.MarkComplete();
                score += goal.Value;
                Console.WriteLine($"Goal marked as complete. Current score: {score}");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    private static void DeleteGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        for (int i = 0; i < goals.Count; i++)
        {
            if (goals[i].Name == name)
            {
                goals.RemoveAt(i);
                Console.WriteLine("Goal deleted.");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    private static void SaveGoals()
    {
        string json = JsonSerializer.Serialize(goals);
        File.WriteAllText("goals.json", json);
        Console.WriteLine("Goals saved successfully.");
    }

    private static void LoadGoals()
    {
        if (File.Exists("goals.json"))
        {
            string json = File.ReadAllText("goals.json");
            goals = JsonSerializer.Deserialize<List<Goal>>(json);
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
