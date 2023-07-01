public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string name, string description, int value, int targetCount) : base(name, description, value)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override void MarkComplete()
    {
        CurrentCount++;
        if (CurrentCount >= TargetCount)
        {
            IsComplete = true;
        }
    }
}
