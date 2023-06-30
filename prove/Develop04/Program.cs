using System;
using System.Collections.Generic;

class MindfulnessApp
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };

        Console.WriteLine("Welcome to the Mindfulness App. Please select an activity:");
        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + activities[i].GetDescription());
        }

        int choice = Convert.ToInt32(Console.ReadLine()) - 1;
        activities[choice].Start();
        activities[choice].DoActivity();
        activities[choice].End();
    }
}
