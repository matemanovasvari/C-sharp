using System.Collections.Generic;

public class Worker
{
    public string Name { get; set; }

    public string ProjectName { get; set; }

    public int WorkHours { get; set; }


    public Worker() { }

    public Worker(string Name, string ProjectName, int workHours)
    {
        this.Name = Name;
        this.ProjectName = ProjectName;
        this.WorkHours = workHours;
    }

    public override string ToString()
    {
        return $"{Name}\t{ProjectName}{WorkHours}";
    }
}