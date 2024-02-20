using System;

List<Student> students = await FileService.ReadFromFileV2Async("adatok.txt");

//1 - Írjuk ki minden diák adatát a képernyőre!
students.WriteCollectionToConsole<Student>();

//2 - Hány diák jár az osztályba?
Console.WriteLine($"\nAz osztalyba {students.Count} diak jar\n");

//3 - Mennyi az osztály átlaga?
double average = students.Average(x => x.Average);
Console.WriteLine($"Az osztaly atlaga {average:F2}\n");

//4 - Keressük a legtöbb pontot elért érettségizőt és írjuk ki az adatait a képernyőre.
Student bestStudent = students.MaxBy(x => x.Average);
Console.WriteLine($"Az osztaly legjobb tanulója {bestStudent}\n");

//5 - atlagfelett.txt allományba
//keressük ki azon tanulókat kiknek pontjai meghaladják az átlagot!
List<Student> studentsAboveAverage = students.Where(x => x.Average > average).ToList();
FileService.WriteToFileAsync("atlagfelett", studentsAboveAverage);


//6 - Van e kitünő tanulónk?
bool isThereAPerfectStudent = students.Any(x => x.Average == 5.00);
Console.WriteLine($"{(isThereAPerfectStudent ? "Van" : "Nincs")} kitűnő tanuló\n");
Console.WriteLine();

/*7 - Hány elégtelen, elégséges, jó, jeles és kitünő tanuló van az osztályban?
    Értékhatárok:
	-elégtelen, ha: 0.00 - 1.99
    - elégséges, ha: 2.00 - 2.99
    - jó, ha: 3.00 - 3.99
    - jeles, ha: 4.00 - 4.99
    - kitünő, ha: 5.00
*/

Dictionary<string, int> gradesPerType = GradesAndGradeNames.GetNumberOfGradesPerType(students);
//gradesPerType.WriteCollectionToConsole();

//máshogy
Dictionary<Grades, int> gradesCountV1 = new Dictionary<Grades, int>()
{
    [Grades.Elegtelen] = students.Count(x => x.Grade == Grades.Elegtelen),
    [Grades.Elegseges] = students.Count(x => x.Grade == Grades.Elegseges),
    [Grades.Jo] = students.Count(x => x.Grade == Grades.Jo),
    [Grades.Jeles] = students.Count(x => x.Grade == Grades.Jeles),
    [Grades.Kituno] = students.Count(x => x.Grade == Grades.Kituno)
};

/*-------------------------------------------------------------------------------------------*/
Dictionary<Grades, int> gradesCountV2 = new Dictionary<Grades, int>();

foreach(Grades grade in Enum.GetValues<Grades>())
{
    gradesCountV2[grade] = students.Count(x => x.Grade == grade);
}
/*-------------------------------------------------------------------------------------------*/
foreach(KeyValuePair<Grades, int> grade in gradesCountV2)
{
    Console.WriteLine($"{grade.Key} : {grade.Value} db");
}

Console.ReadKey();