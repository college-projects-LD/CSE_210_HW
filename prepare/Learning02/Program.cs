using System;
using System.Collections.Generic;

public class Job
{
    public string Company { get; private set; }
    public string Title { get; private set; }
    public int StartYear { get; private set; }
    public int EndYear { get; private set; }

    public Job(string company, string title, int startYear, int endYear)
    {
        Company = company;
        Title = title;
        StartYear = startYear;
        EndYear = endYear;
    }

    public override string ToString()
    {
        return $"{Title} ({Company}) {StartYear}-{EndYear}";
    }
}

public class Resume
{
    public string Name { get; private set; }
    public List<Job> Jobs { get; private set; }

    public Resume(string name)
    {
        Name = name;
        Jobs = new List<Job>();
    }

    public void AddJob(Job job)
    {
        Jobs.Add(job);
    }

    public void DisplayResume()
    {
        Console.WriteLine("Resume for: " + Name);
        foreach (var job in Jobs)
        {
            Console.WriteLine(job.ToString());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume("John Doe");
        resume.AddJob(new Job("Microsoft", "Software Engineer", 2019, 2022));
        resume.AddJob(new Job("Google", "Senior Software Engineer", 2022, 2023));
        
        resume.DisplayResume();
    }
}