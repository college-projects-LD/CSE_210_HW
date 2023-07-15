using System;

public abstract class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails() => $"{title}\n{description}\n{date.ToShortDateString()}, {time}\n{address.GetFullAddress()}";

    public abstract string GetFullDetails();

    public string GetShortDescription() => $"{GetType().Name}: {title}, {date.ToShortDateString()}";
}
