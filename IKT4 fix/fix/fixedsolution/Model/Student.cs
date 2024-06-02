namespace Model;

public class Student
{

    public string Name { get; set; }
    public int ID { get; set; }

    public override string ToString()
    {
        return $"{ID} - {Name}";
    }
    public Student()
    {
    }

    public Student(string name, int iD)
    {
        Name = name;
        ID = iD;
    }
}

public class Subjects
{

    public int StudentID { get; set; }
    public Dictionary<string, List<int>> SubjectNameAndMarks { get; set; } = new Dictionary<string, List<int>>();

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var subject in SubjectNameAndMarks)
        {
            sb.AppendLine($"{subject.Key}: ");
            foreach (var mark in subject.Value)
            {
                sb.AppendLine($"\t-{mark}");
            }
        }
        return sb.ToString();
    }
    public Subjects()
    {
    }

    public Subjects(int studentID, Dictionary<string, List<int>> subjectNameAndMarks)
    {
        StudentID = studentID;
        SubjectNameAndMarks = subjectNameAndMarks;
    }
}