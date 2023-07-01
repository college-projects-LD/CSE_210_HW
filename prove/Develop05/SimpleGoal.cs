public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int value) : base(name, description, value)
    {
    }

    public override void MarkComplete()
    {
        IsComplete = true;
    }
}
