using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Feladat___01
{
    internal class Program
    {
        private static List<Player> _players = new List<Player>();

        private static void LoadData()
        {
            using (FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string jsonData = sr.ReadToEnd();

                    _players = JsonConvert.DeserializeObject<List<Player>>(jsonData);
                }
            }
        }

        private static void WriteToConsole(string text, ICollection<Player> players)
        {
            Console.WriteLine(text);
            Console.WriteLine(string.Join('\n', _players));
        }

        private static void WriteToConsole(string text, Player player)
        {
            Console.WriteLine(text);
            Console.WriteLine(player);
        }

        static void Main(string[] args)
        {
            LoadData();
            WriteToConsole("Data", _players);

            //hany jatekos van az adatbazisban
            int numberOfPlayers = _players.Count();

            //atlagos magassag
            double averageHeight = _players.Average(x => x.Height);

            //legalacsonyabb jatekos
            string shortestPlayerName = _players.MinBy(x => x.Height).Name;

            //azok a jatekosok akik 1980-ban születtek
            List<Player> playersBornIn1980 = _players.Where(x => DateTime.Parse(x.Birthday).Year == 1980)
                                                     .ToList();

            playersBornIn1980 = _players.Where(x => int.Parse(x.Birthday.Split('.')[0]) == 1980)
                                        .ToList();

            playersBornIn1980 = _players.Where(x => x.Birthday
                                        .Split('.')[0] == "1980")
                                        .ToList();

            //rendezzuk a jatekosokat ABC sorrendben, magassag szerint csokkenoben
            List<Player> playersOrderedByName = _players.OrderByDescending(x => x.Name)
                                                        .ThenByDescending(x => x.Height)
                                                        .ToList();

            //keressuk ki posztonkent hany jatekos van
            List<Posts> playersOrderedByPosts = _players.GroupBy(x => x.Position)
                                              .Select(x => new Posts { Position = x.Key, NumberOfPlayersInPosition = x.Count() })
                                              .ToList();

            //kik azok a jatekosok akik az 1990-es evekben szulettek
            List<string> playersBornIn1990 = _players.Where(x => DateTime.Parse(x.Birthday).Year >= 1990 && DateTime.Parse(x.Birthday).Year < 2000)
                                                     .Select(x => x.Name)
                                                     .ToList();

            List<TeamAndNames> playersInEachTeam = _players.GroupBy(x => x.Club)
                                              .Select(x => new TeamAndNames { Club = x.Key, PlayerName = x.Select(x => x.Name).ToList() })
                                              .ToList();
            
            void PrintPlayerNamesToConsole(List<TeamAndNames> playersInEachTeam)
            {
                foreach(List<TeamAndNames> player in playersInEachTeam)
                {
                    Console.WriteLine(player);
                }
            }
        }
    }
}
