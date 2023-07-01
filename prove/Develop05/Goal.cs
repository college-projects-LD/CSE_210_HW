using System;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
        IsComplete = false;
    }

    public abstract void MarkComplete();
}
