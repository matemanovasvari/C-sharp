Student geza = new Student
{
    Name = "Géza",
    //School = "" nem fugg az osztalypeldanytol ezert az objektumbam nem is allitható az ertke
};

Student bela = new Student
{
    Name = "Béla",
    //School = "" nem fugg az osztalypeldanytol ezert az objektumbam nem is allitható az ertke
};

Student.School = "Vasvari Pál";

Console.WriteLine($"{geza.Name} a {Student.School}-ba jár");
Console.WriteLine($"{bela.Name} a {Student.School}-ba jár");

//statikus osztályt nem lehet példányosítani
//Professor professor = new Professor();

Professor.Name = "Hapci Vidor";

Console.WriteLine($"{Professor.Name} tanit a {Professor.School}-ban");