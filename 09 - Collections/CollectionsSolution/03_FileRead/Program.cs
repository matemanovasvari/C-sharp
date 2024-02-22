using System;

List<Player> players = await FileService.ReadFromFileV2Async("adatok");

//1 - Írjuk ki a képernyőre az össz adatot
players.WriteCollectionToConsole();

//2 - Keressük ki az ütő játékosokat az utok.txt állömányba
List<Player> hitters = players.Where(x => x.Position == "ütő").ToList();
await FileService.WriteToFileV2Async("utok", hitters);

//3 - A csapattagok.txt állományba mentsük a csapatokat és a hozzájuk tartozó játékosokat a következő formában:
//Telekom Baku: Yelizaveta Mammadova, Yekaterina Gamova,
List<TeamAndNames> teamAndNames = players.GroupBy(x => x.Team)
                                        .Select(x => new TeamAndNames
                                        {
                                            Team = x.Key,
                                            Names = x.Select(y => y.Name).ToList()

                                        }).ToList();

await FileService.WriteToFileV2Async("csapattagok", teamAndNames);

//4 - Rendezzük a játékosokat magasság szerint növekvő sorrendbe és a magaslatok.txt állományba mentsük el.
List<Player> playersOrderedByHeight = players.OrderBy(x => x.Height).ToList();
await FileService.WriteToFileV2Async("magaslatok", playersOrderedByHeight);

//5 - Mutassuk be a nemzetisegek.txt állományba, hogy mely nemzetiségek képviseltetik magukat a röplabdavilágban mint játékosok és milyen számban.
List<NationalityAndAmount> nationalityAndAmounts = players.GroupBy(x => x.Nationality)
                                                        .Select(x => new NationalityAndAmount
                                                        {
                                                            Nationality = x.Key,
                                                            Amount = x.Count()
                                                        }).ToList();
await FileService.WriteToFileV2Async("nemzetisegek", nationalityAndAmounts);

//6 - atlagnalmagasabbak.txt állományba keressük azon játékosok nevét és magasságát akik magasabbak mint
//az „adatbázisban” szereplő játékosok átlagos magasságánál.
double averageHeight = players.Average(x => x.Height);

List<Player> playersAboveAverageHeight = players.Where(x => x.Height > averageHeight).ToList();

await FileService.WriteToFileV3Async("atlagnalmagasabb", playersAboveAverageHeight);

//7 - Állítsa növekvő sorrendbe a posztok szerint a játékosok ösz magasságát.
List<PostAndSumWeight> postAndSumWeights = players.GroupBy(x => x.Position)
                                                .Select(x => new PostAndSumWeight
                                                {
                                                    Position = x.Key,
                                                    SumWeight = x.Sum(x => x.Height)

                                                }).OrderBy(x => x.Position).ToList();

//8 - Egy szöveges állományba, „alacsonyak.txt” keresse ki a játékosok átlagmagasságától alacsonyabb játékosokat.  
//Az állomány tartalmazza a játékosok nevét, magasságát és hogy mennyivel alacsonyabbak az átlagnál, 2 tizedes pontossággal.
