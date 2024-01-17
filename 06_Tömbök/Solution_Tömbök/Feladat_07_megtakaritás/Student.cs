public class Student
{
    public string Name { get; set; }

    public double Saving { get; set; }

    public Student(string name, double saving)
        {
            Name = name;
            Saving = saving;
        }

    public Student()
    {
    }
}
