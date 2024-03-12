using Custom.Library.ConsoleExtension;
using System;

List<Person> people = await FileService.ReadFromFileV2Async("balkezesek");

int numberOfRows = people.Count;
Console.WriteLine($"3. feladat: {numberOfRows}");

List<NameAndCm> nameAndCms = people.Where(x => x.First.Year == 1999)
                                    .Select(x => new NameAndCm
                                    {
                                        Name = x.Name,
                                        HeightInCM = x.HeightInCm

                                    }).ToList();

Console.WriteLine("4. feladat");
nameAndCms.WriteCollectionToConsole();

Console.WriteLine("5. feladat");
int inputedDate = ExtendedConsole.ReadInteger(1990, 1999, "Adjon meg egy évszámot: ");

double averageWeight = people.Where(x => x.First.Year == inputedDate).Average(x => x.Weight);
Console.WriteLine($"6. feladat: {averageWeight:F2} font");