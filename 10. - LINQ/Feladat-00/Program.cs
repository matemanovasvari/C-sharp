using System.Linq;

List<Student> students = new List<Student>
{
    new Student("Hetfo Henrik", 10, 154),
    new Student("Kedd Kinga",13, 250),
    new Student("Szerda Szilard", 9, 98),
    new Student("Csütörtök Csongor", 11, 198),
    new Student("Péntek Petra", 13, 245),
    new Student("Szombat Szimonetta", 10, 152),
    new Student("Vasárnap Virág", 13 ,221)
};

//legnagyobb pontszám
int maxPoints = students.Max(x => x.Points);

//ki a legtobb pontszamot elert tanulo
Student bestStudent = students.MaxBy(x => x.Points);

//legkisebb pontszám
int minPoints = students.Min(x => x.Points);

//ki a legkisebb pontszamot elert tanulo
Student wordtStudent = students.MinBy(x => x.Points);

//keresse ki a diakok neveit
List<string> studentNames = students.Select(x => x.Name)
                                    .ToList();

//azon diakok nevei akik pontszama meghaladja a 200 pontot
List<string> studentsNameWithAbove200Points = students.Where(x => x.Points > 200)
                                                      .Select(x => x.Name)
                                                      .ToList();

//keressuk ki a diakok neveit ABC szerint novekvo sorrendben
List<string> orderedStudentNames = students.OrderBy(x => x.Name)
                                           .Select(x => x.Name)
                                           .ToList();


//keressuk ki a diakok neveit ABC szerint novekvo sorrendben, majd pontok alapjan csokkeno serrendbe
List<string> orderedStudentNamesWithPoints = students.OrderBy(x => x.Name)
                                                     .ThenByDescending(x => x.Points)
                                                     .Select(x => x.Name)
                                                     .ToList();

//rendezzuk osztalyok alapjan csokkeno sorrendbe
List<string> orderedStudentsByGradeAndPoints = students.OrderByDescending(x => x.Grade)
                                                       .ThenByDescending(x => x.Points)
                                                       .Select(x => x.Name)
                                                       .ToList();


//hf:evfolyamonkent elert pontszamok, evfolyam szerint csokkeno sorrendben

/*var pointsByEachGrade = students.GroupBy(x => x.Grade)
                                .Select(x => new {Id = x.Key, SumOfPoints = x.Sum(x => x.Points)})
                                .OrderByDescending(x => x.SumOfPoints);

foreach (var point in pointsByEachGrade)
{
    Console.WriteLine(point);
}
//Igy is jo, de a masik jobb
*/

//mashogy
List<GradeWithPoints> gradeWithPoints = students.GroupBy(x => x.Grade)
                                                .Select(x => new GradeWithPoints{Grade = x.Key, Points = x.Sum(x => x.Points)})
                                                .OrderByDescending(x => x.Grade)
                                                .ToList();

//milyen pontszamot kaptak az egyes evfolyamok, 1-szer jelenjen meg
List<int> distinctedPoints = students.Select(x => x.Points).Distinct().ToList();

//vagy

distinctedPoints = students.DistinctBy(x => x.Points).Select(x => x.Points).ToList();