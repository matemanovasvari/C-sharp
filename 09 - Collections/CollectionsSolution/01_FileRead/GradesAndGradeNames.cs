public class GradesAndGradeNames
{
    public static Dictionary<string, int> GetNumberOfGradesPerType(List<Student> students)
    {
        Dictionary<string, int> gradesPerType = new Dictionary<string, int>
        {
            {"elégtelen", 0},
            {"elégséges", 0},
            {"jó", 0},
            {"jeles", 0},
            {"kitűnő", 0},
        };


        foreach (Student student in students)
        {
            switch (student.Average)
            {
                case < 2:
                    gradesPerType["elégtelen"]++;
                    break;
                case < 3:
                    gradesPerType["elégséges"]++;
                    break;
                case < 4:
                    gradesPerType["jó"]++;
                    break;
                case < 5:
                    gradesPerType["jeles"]++;
                    break;
                case 5:
                    gradesPerType["kitűnő"]++;
                    break;
            }
        }

        return gradesPerType;
    }
}