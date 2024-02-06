using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Feladat___03
{
    internal class Program
    {
        private static List<Motorcycle> _motorcycles = new List<Motorcycle>();
        private static void LoadData()
        {
            using (FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string jsonData = sr.ReadToEnd();

                    _motorcycles = JsonSerializer.Deserialize<List<Motorcycle>>(jsonData);
                }
            }
        }

        private static void WriteToConsole(string text, ICollection<Motorcycle> motorcycles)
        {
            Console.WriteLine(text);
            Console.WriteLine(string.Join('\n', motorcycles));
        }

        private static void WriteToConsole(string text, Motorcycle motorcycle)
        {
            Console.WriteLine(text);
            Console.WriteLine(motorcycle);
        }

        static void Main(string[] args)
        {
            LoadData();
            WriteToConsole("Data", _motorcycles);

            // 1 - Hány motorkerékpár van az 'adatbázisban' ?
            int numberOfMotorcycles = _motorcycles.Count;

            // 2 - Hány 'Honda' gyártmányú motorkerékpár van az 'adatbázisban' ?
            int numberOfHondaMotorcycles = _motorcycles.Count(m => m.Brand == "Honda");

            // 3 - Mekkora a legnyaobb köbcenti az 'adatbázisban' ?
            int biggestCubicMeter = _motorcycles.Max(x => x.Cubic);

            // 4 - Melyik a legkisebb végsebesség az 'adatbázisban' ?
            int smallestTopSpeed = _motorcycles.Min(x => x.TopSpeed);

            // 5 - Van e olyan motorkerékpár az 'adatbázisban' amelyet 1960 előtt gyártottak?
            bool isThereAMotorcycleManufacturedBefore1960 = _motorcycles.Any(x => x.ReleaseYear < 1960);

            // 6 - Van-e 'Honda' gyártmányú motorkerképár az 'adatbázisban' melynek beceneve 'Hornet' ?
            bool isThereHondaWithNicknameHornet = _motorcycles.Any(x => x.Brand == "Honda" && x.Nickname == "Hornet");

            // 7 - Keressük ki a 'Yamaha' gyártmányú motorkerékpárokat!
            List<Motorcycle> yamahaMotorcycles = _motorcycles.Where(x => x.Brand == "Yamaha").ToList();

            // 8 -Keressük a 'Suzuki' gyártotmányú motorkerékpárokat melyek 600ccm felett vannak!
            List<Motorcycle> suzukiMotorcyclesAbove600ccm = _motorcycles.Where(x => x.Brand == "Suzuki" && x.Cubic > 600)
                                                                        .ToList();

            // 9 - Keressük ki a 'Kawasaki' gyártotmányú motorkerékpárokat, melyek sebesságe nagyobb min 150km/h!
            List<Motorcycle> kawasakiMotorcyclesAbove150TopSpeed = _motorcycles.Where(x => x.Brand == "Kawasaki" && x.TopSpeed > 150)
                                                                        .ToList();

            // 10 - Keressük ki a 'BMW' gyártotmányú motorkerékpárokat, melyeket 2010 előtt gyárottak és a motor köbcentije minimum 1000!
            List<Motorcycle> bmwMotorcyclesBefore2010Cubic1000 = _motorcycles.Where(x => x.Brand == "BMW" 
                                                                                    && x.ReleaseYear < 2010 && x.Cubic >= 1000)
                                                                             .ToList();

            // 12 - Keressük ki a motorkerékpárok beceneveit (nickname)!
            List<string> motorcycleNicknames = _motorcycles.Select(x => x.Nickname).ToList();

            // 13 - Keressük azokat a motorkerékpárokat, melyek neveiben szerepel 'FZ' kifejezés!
            List<Motorcycle> motorcyclesThatsNameContainsFZ = _motorcycles.Where(x => x.Nickname.Contains("FZ")).ToList();


            // 14 - Keressük azokat a motorkerékpárokat, melyek nevei 'C' betűvel kezdődnek!
            List<Motorcycle> motorcyclesThatsNameStartsWithC = _motorcycles.Where(x => x.Nickname.StartsWith("C")).ToList();


            // 15 - Keressük az első motorkerékpárt az 'adatbázisunkból'!
            Motorcycle firstMotorcycle = _motorcycles.First();

            // 16 - Keressük az utolsó motorkerékpárt az 'adatbázisunkból'!
            Motorcycle lastMotorcycle = _motorcycles.Last();

            // 17 - Rendezzük növekvő sorrendbe gyártási év alapján az 'adatbázisban' szereplő motorkerékpárokat.
            List<Motorcycle> motorcyclesOrderedByReleaseDate = _motorcycles.OrderBy(x => x.ReleaseYear).ToList();

            // 18 - Rendezzük csökkenő sorrendbe a 'Honda' által gyártott motorkerékpárokat,
            // melyek teljesítménye legalább 25kW és 2005 után gyártották őket.
            List<Motorcycle> descendingHonda = _motorcycles.Where(x => x.Brand == "Honda" && x.KW >= 25 && x.ReleaseYear > 2005)
                                                           .OrderByDescending(x => x.KW).ToList();

            // 19 - Melyek azok a motorkerékpárok, melyek nem rendelkeznek becenévvel?
            List<Motorcycle> motorcyclesWithNoNickname = _motorcycles.Where(x => x.Nickname == "").ToList();

            // 20 - Mekkora az 'adatbázisban' szereplő motorkerékpárok sebességének az átlaga?
            double averageSpeed = _motorcycles.Average(x  => x.TopSpeed);

            // 21 - Melyik a legyorsabb motorkerékpár? Feltételezzük, hogy csak egy ilyen van!
            Motorcycle fastestMotor = _motorcycles.MaxBy(x => x.TopSpeed);

            // 22 - Hány kategória található meg az 'adatbázisban'?
            int numberOfCategories = _motorcycles.Select(x => x.Category).Distinct().Count();

            // 23 - Határozza meg az 'adatbázisban' talalható motorkerékpárok átlag életkorát!
            double averageAge = _motorcycles.Average(x => DateTime.Now.Year - x.ReleaseYear);

            // 24 - Van-e 'Java' gyártmányú motorkerékpár az 'adatbázisban'?
            bool isThereAJavaMotorcycle = _motorcycles.Any(x => x.Brand == "Java");

            // 25 - Rendezzül növekvő sorrende az 5 betűvel rendelkező gyártók motorkerékpárjait,
            //         majd csökkenő sorrendbe gyártási év alapján és az eredményben csak a nevet és
            //         a gyártási évet jelenítse meg!
            List<NameAndReleaseDate> orderedMotorcycles = _motorcycles.Where(x => x.Brand.Length == 5)
                                                                      .OrderBy(x => x.Brand)
                                                                      .ThenByDescending(x => x.ReleaseYear)
                                                                      .Select(x => new NameAndReleaseDate
                                                                      {
                                                                          Name = x.Nickname,
                                                                          ReleaseDate = x.ReleaseYear
                                                                      })
                                                                      .ToList();

            Console.ReadLine();
        }
    }
}
