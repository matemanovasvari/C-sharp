using IOLibrary;

string name = ExtendedConsole.ReadString("Adja meg a nevét: ");

int birthYear = ExtendedConsole.ReadInteger(DateTime.Now.Year, "Adja meg a születési évét: ");

int age = AgeCalculator(birthYear);
int AgeCalculator(int birthYear) => DateTime.Now.Year - birthYear;

Console.WriteLine($"{name} ön {age} éves");