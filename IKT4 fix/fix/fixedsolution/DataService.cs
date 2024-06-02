namespace DataService;

public class DataServices
{
    public static async void MenuSelect(List<JoinedData> studentAndSubjects)
    {
        int operation = ExtendedConsole.ReadInteger("Choose a task from the following:\n\t1 - Add new student to database" +
                                                                      "\n\t2 - Add new subject and marks to student" +
                                                                      "\n\t3 - Add new marks to subject\n\t4 - Modify student name" +
                                                                      "\n\t5 - Modify marks\n");
        switch (operation)
        {
            case 1:
                await AddNewStudent(studentAndSubjects);
                break;
            case 2:
                await AddNewSubjectAndMarks(studentAndSubjects);
                break;
            case 3:
                await AddNewMarksToAlreadyExistingSubject(studentAndSubjects);
                break;
            case 4:
                await ModifyStudentName(studentAndSubjects);
                break;
            case 5:
                await ModifyMark(studentAndSubjects);
                break;
            default:
                Console.WriteLine("No operation like that");
                break;
        }
    }

    public static async void Save(List<JoinedData> studentAndSubjects)
    {
        List<Student> students = studentAndSubjects.Select(x => new Student
        {
            Name = x.Name,
            ID = x.ID
        }).ToList();

        List<Subjects> subjects = studentAndSubjects.Select(x => new Subjects
        {
            StudentID = x.ID,
            SubjectNameAndMarks = x.Subjects
        }).ToList();

        await FileService.WriteToFileAsync(students, "diakok");
        await FileService.WriteToFileAsync(subjects, "tantargyak");
    }

    public static async Task<List<JoinedData>> AddNewStudent(List<JoinedData> studentAndSubjects)
    {
        string name = ExtendedConsole.ReadString("Type in the student's name!: ");
        string subjectName = ExtendedConsole.ReadString("Type in the name of the subject!: ");
        List<int> marks = new List<int>();
        int inputedMark;

        do
        {
            Console.WriteLine("Type in a mark(If you want to exit type 0)!: ");
            inputedMark = int.Parse(Console.ReadLine());
            if(inputedMark != 0)
            {
            marks.Add(inputedMark);
            }
        } while (inputedMark != 0);



        studentAndSubjects.Add(new JoinedData
        {
            ID = studentAndSubjects.Count() + 1,
            Name = name,
            Subjects = new Dictionary<string, List<int>>
            {
                { subjectName, marks }
            }
        });

        Save(studentAndSubjects);
        SystemExtensions.WriteCollectionToConsole(studentAndSubjects);
        MenuSelect(studentAndSubjects);

        return studentAndSubjects;
    }

    public static async Task<List<JoinedData>> AddNewSubjectAndMarks(List<JoinedData> studentAndSubjects)
    {
        foreach (var student in studentAndSubjects)
        {
            Console.WriteLine(student.Name);
        }

        string inputedName = ExtendedConsole.ReadString("Choose a student to add new subject and marks!: ");
        string inputedSubject = ExtendedConsole.ReadString("Type in the new subject's name!: ");

        int inputedMark;
        List<int> marks = new List<int>();

        do
        {
            Console.WriteLine("Type in a mark(If you want to exit type 0)!: ");
            inputedMark = int.Parse(Console.ReadLine());
            if (inputedMark != 0)
            {
                marks.Add(inputedMark);
            }

        } while (inputedMark != 0);

        var studentToUpdate = studentAndSubjects.FirstOrDefault(x => x.Name == inputedName);
        if (studentToUpdate != default)
        {
                studentToUpdate.Subjects.Add(inputedSubject, marks);
                Console.WriteLine("Subject and marks added successfully!");   
        }
        else
        {
            Console.WriteLine("No student under that name!");
        }

        Save(studentAndSubjects);
        SystemExtensions.WriteCollectionToConsole(studentAndSubjects);
        MenuSelect(studentAndSubjects);

        return studentAndSubjects;
    }

    public static async Task<List<JoinedData>> AddNewMarksToAlreadyExistingSubject(List<JoinedData> studentAndSubjects)
    {
        foreach (var student in studentAndSubjects)
        {
            Console.WriteLine(student.Name);
        }

        string inputedName = ExtendedConsole.ReadString("Choose a student to add new marks to a subject!: ");

        var studentToUpdate = studentAndSubjects.FirstOrDefault(x => x.Name == inputedName);
        if (studentToUpdate != default)
        {
            Console.WriteLine($"Subjects for {inputedName}:");
            foreach (var subjectName in studentToUpdate.Subjects.Keys)
            {
                Console.WriteLine(subjectName);
            }

            string inputedSubject = ExtendedConsole.ReadString("Choose a subject to add new marks to: ");
            if (studentToUpdate.Subjects.ContainsKey(inputedSubject))
            {
                int inputedMark;
                List<int> marks = new List<int>();

                do
                {
                    Console.WriteLine("Type in a mark(If you want to exit type 0)!: ");
                    inputedMark = int.Parse(Console.ReadLine());
                    studentToUpdate.Subjects[inputedSubject].Add(inputedMark);

                } while (inputedMark != 0);

                Console.WriteLine("Marks added successfully!");
            }
            else
            {
                Console.WriteLine("Subject does not exist for this student!");
            }
        }
        else
        {
            Console.WriteLine("No student under that name!");
        }

        Save(studentAndSubjects);
        SystemExtensions.WriteCollectionToConsole(studentAndSubjects);
        MenuSelect(studentAndSubjects);

        return studentAndSubjects;
    }

    public static async Task<List<JoinedData>> ModifyStudentName(List<JoinedData> studentAndSubjects)
    {
        foreach (var student in studentAndSubjects)
        {
            Console.WriteLine(student.Name);
        }

        string studentToModifyName = ExtendedConsole.ReadString("Choose a student to modify hes/hers name!: ");

        var studentToUpdate = studentAndSubjects.FirstOrDefault(x => x.Name == studentToModifyName);
        if (studentToUpdate != default)
        {
            string newName = ExtendedConsole.ReadString("Type in the new name");
            studentToUpdate.Name = newName;
            Console.WriteLine("Subject and marks added successfully!");
        }
        else
        {
            Console.WriteLine("No student under that name!");
        }

        Save(studentAndSubjects);
        SystemExtensions.WriteCollectionToConsole(studentAndSubjects);
        MenuSelect(studentAndSubjects);

        return studentAndSubjects;
    }

    public static async Task<List<JoinedData>> ModifyMark(List<JoinedData> studentAndSubjects)
    {
        foreach (var student in studentAndSubjects)
        {
            Console.WriteLine(student.Name);
        }

        string inputedName = ExtendedConsole.ReadString("Choose a student to modify marks: ");

        var studentToModify = studentAndSubjects.FirstOrDefault(x => x.Name == inputedName);
        if (studentToModify != default)
        {
            Console.WriteLine($"Subjects for {inputedName}:");
            foreach (var subject in studentToModify.Subjects.Keys)
            {
                Console.WriteLine(subject);
            }

            string inputedSubject = ExtendedConsole.ReadString("Choose a subject to modify marks: ");
            if (studentToModify.Subjects.ContainsKey(inputedSubject))
            {
                Console.WriteLine($"Marks for {inputedSubject}: {string.Join(", ", studentToModify.Subjects[inputedSubject])}");

                int indexOfMarkToModify = ExtendedConsole.ReadInteger("Enter the index of the mark to modify: ") - 1;
                if (indexOfMarkToModify >= 0 && indexOfMarkToModify < studentToModify.Subjects[inputedSubject].Count)
                {
                    int newMark = ExtendedConsole.ReadInteger("Enter the new mark: ");
                    studentToModify.Subjects[inputedSubject][indexOfMarkToModify] = newMark;
                    Console.WriteLine("Mark modified successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid mark index!");
                }
            }
            else
            {
                Console.WriteLine("Subject does not exist for this student!");
            }
        }
        else
        {
            Console.WriteLine("No student under that name!");
        }

        Save(studentAndSubjects);
        SystemExtensions.WriteCollectionToConsole(studentAndSubjects);
        MenuSelect(studentAndSubjects);

        return studentAndSubjects;
    }

    
}