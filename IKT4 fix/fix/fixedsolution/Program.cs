List<Student> students = await FileService.ReadFromFileAsync<Student>("diakok");
List<Subjects> subjects = await FileService.ReadFromFileAsync<Subjects>("tantargyak");

var query = from student in students
            join subject in subjects
            on student.ID equals subject.StudentID
            select new JoinedData
            {
                ID = student.ID,
                Name = student.Name,
                Subjects = subject.SubjectNameAndMarks
            };

List<JoinedData> studentAndSubjects = query.ToList();

SystemExtensions.WriteCollectionToConsole(studentAndSubjects);
DataServices.MenuSelect(studentAndSubjects);