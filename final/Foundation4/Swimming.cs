using System;

public class Swimming : Activity
{
    private int numberOfLaps;

    public Swimming(DateTime date, double durationInMinutes, int numberOfLaps)
        : base(date, durationInMinutes)
    {
        this.numberOfLaps = numberOfLaps;
    }

    public override double GetDistance() => (numberOfLaps * 50 / 1000) * 0.62;

    public override double GetSpeed() => (GetDistance() / base.durationInMinutes) * 60;

    public override double GetPace() => base.durationInMinutes / GetDistance();
}
