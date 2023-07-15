using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create events
        Event lecture = new Lecture("Lecture 1", "A lecture on programming.", DateTime.Now.AddDays(7), "10:00 AM", new Address("123 Main St", "New York", "NY", "USA"), "John Doe", 100);
        Event reception = new Reception("Reception 1", "A reception for networking.", DateTime.Now.AddDays(14), "6:00 PM", new Address("456 Elm St", "Los Angeles", "CA", "USA"), "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Outdoor Gathering 1", "A gathering in the park.", DateTime.Now.AddDays(21), "12:00 PM", new Address("789 Pine St", "San Francisco", "CA", "USA"), "Sunny");

        // Display event details
        Event[] events = { lecture, reception, outdoorGathering };
        foreach (Event eventItem in events)
        {
            Console.WriteLine("Standard Details:\n" + eventItem.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n" + eventItem.GetFullDetails());
            Console.WriteLine("\nShort Description:\n" + eventItem.GetShortDescription());
            Console.WriteLine();
        }
    }
}
