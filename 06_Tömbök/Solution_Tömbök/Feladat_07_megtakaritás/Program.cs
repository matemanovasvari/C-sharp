using Custom.Library.ConsoleExtension;

const int NUMBER_OF_STUDENTS  = 10;

Student[] students = GetStudents();

double sumOfSavings = students.Sum(x => x.Saving);
Console.WriteLine($"A megtakarítások összege: {sumOfSavings}");

double averageSaving = students.Average(x => x.Saving);
Console.WriteLine($"Az átlagos megtakarítás: {averageSaving}");

double maxSaving = students.Max(x => x.Saving);
Student[] studentWithMaxSaving = students.Where(x => x.Saving == maxSaving).ToArray();

Console.WriteLine("A legnagyobb megtakarítással rendelkező tanuló");
PrintStudentsToConsole(studentWithMaxSaving);

double minSaving = students.Min(x => x.Saving);
Student[] studentWithMinSaving = students.Where(x => x.Saving == minSaving).ToArray();

Console.WriteLine("A legkisebb megtakarítással rendelkező tanuló: ");
PrintStudentsToConsole(studentWithMinSaving);

int numberOfStudentsWithMoreThan2000Savings = students.Count(x => x.Saving > 2000);
Console.WriteLine($"2000 forintnál magasabb megtakarítású tanulók száma: {numberOfStudentsWithMoreThan2000Savings}");

bool noSavingStudent = students.Any(x => x.Saving == 0);
Console.WriteLine($"{(noSavingStudent ? "Van" : "Nincs")} olyan tanuló akinek nincs megtakarítása.");

Student[] studentsWithBelowAverageSaving = students.Where(x => x.Saving < averageSaving).ToArray();
Console.WriteLine("Átlag alatti megtakarítású tanulók neve:");
PrintStudentNameToConsole(studentsWithBelowAverageSaving);

Student[] GetStudents()
{
    Student[] students = new Student[NUMBER_OF_STUDENTS];

    for (int i = 0; i < NUMBER_OF_STUDENTS; i++)
    {
        string name = ExtendedConsole.ReadString("Adja meg a tanuló nevét: ");
        double savings = ExtendedConsole.ReadDouble("Adja meg a tanuló megtakarításait");

        students[i] = new Student(name, savings);
    }

    return students;
}

void PrintStudentsToConsole(Student[] students)
{
    foreach (Student student in students)
    {
        Console.WriteLine($"{student.Name} : {student.Saving}");
    }
}

void PrintStudentNameToConsole(Student[] students)
{
    foreach (Student student in students)
    {
        Console.WriteLine(student.Name);
    }
}