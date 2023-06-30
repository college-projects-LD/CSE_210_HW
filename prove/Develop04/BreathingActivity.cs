using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        description = "Breathing Activity";
        duration = 60; // Set your duration
    }

    public override void DoActivity()
    {
        for (int i = 0; i < duration; i += 5)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(2);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(2);
        }
    }
}

