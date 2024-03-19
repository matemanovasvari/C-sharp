using System.Text.RegularExpressions;

List<Worker> workers = await FileService.ReadFromFileAsync("munkaber.txt");

int wageSum = workers.Sum(x => x.WorkHours * 10000);

Console.WriteLine($"Összesen {wageSum} HUF munkabért kell kifizetni.");

int maxHours = workers.Max(x => x.WorkHours);

string workerWithMaxHours = workers.Where(x => x.WorkHours == maxHours).Select(x => x.Name);

Console.WriteLine($"A héten a legtöbb munkaórát {workerWithMaxHours} dolgozta ({maxHours}óra).");

List<NameAndWage> nameAndWages = workers.Select(x => new NameAndWage
                                            {
                                                Name = x.Name,
                                                Wage = x.WorkHours * 10000
                                            }).ToList();

FileService.WriteToFileAsync("fizetes_2024-03.txt", nameAndWages);