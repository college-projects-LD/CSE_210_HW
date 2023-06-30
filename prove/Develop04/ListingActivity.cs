using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        description = "Listing Activity";
        duration = 60; // Set your duration
    }

    public override void DoActivity()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
         PauseWithAnimation(10);;

        List<string> items = new List<string>();
        for (int i = 0; i < duration / 10; i++)
        {
            Console.Write("Enter an item: ");
            items.Add(Console.ReadLine());
             PauseWithAnimation(10);;
        }

        Console.WriteLine("You listed " + items.Count + " items:");
        foreach (string item in items)
        {
            Console.WriteLine("- " + item);
        }
    }
}
