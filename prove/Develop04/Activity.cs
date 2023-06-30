using System;

abstract class Activity
{
    protected string description;
    protected int duration;

    public string GetDescription()
    {
        return description;
    }

    public void Start()
    {
        Console.WriteLine("Starting " + description);
        while (true)
        {
            Console.Write("Enter the duration of the activity in seconds: ");
            if (int.TryParse(Console.ReadLine(), out duration))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        Console.WriteLine("This activity will last for " + duration + " seconds.");
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);
    }

    public abstract void DoActivity();

    public void End()
    {
        Console.WriteLine("Good job! You have completed the " + description + " for " + duration + " seconds.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
