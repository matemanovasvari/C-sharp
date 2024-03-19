using System.Collections.Generic;

public class Worker
{
    public string Name { get; set; }

    public string ProjectName { get; set; }

    public List<int> WorkHours { get; set; }

    public Worker() { }

    public Worker(string Name, string ProjectName, List<int> workHours)
    {
        this.Name = Name;
        this.ProjectName = ProjectName;
        this.WorkHours = workHours;
    }
}