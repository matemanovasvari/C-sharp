public class Student
{

    public string Name { get; set; }

    public double Average { get; set; }

    public Grades Grade { 
        get
        {
            return this.Average switch
            {
                < 2 => Grades.Elegtelen,
                < 3 => Grades.Elegseges,
                < 4 => Grades.Jo,
                < 5 => Grades.Jeles,
                5 => Grades.Kituno,
                _ => throw new Exception("Ilyen atlag nem letezik!")
            };
        } 
    }
    public Student(string name, double average)
    {
        Name = name;
        Average = average;
    }

    public Student()
    {
    }

    public override string ToString()
    {
        return $"{this.Name} : {this.Average}";
    }
}