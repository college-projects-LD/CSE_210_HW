public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int value) : base(name, description, value)
    {
    }

    public override void MarkComplete()
    {
        IsComplete = false; // Eternal goals are never complete
    }
}
