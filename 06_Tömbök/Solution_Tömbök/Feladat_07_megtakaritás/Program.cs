using Custom.Library.ConsoleExtension;

const int NUMBER_OF_STUDENTS  = 10;

Student[] students = GetStudents();

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