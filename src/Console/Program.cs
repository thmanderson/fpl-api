using System;
using System.Collections.Generic;
using FPL.Core;
using FPL.Core.Model;
namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerFactory = new PlayerGetter();
            var myPlayers = new List<IPlayer>();

            var myPlayerNames = new List<string> {
                "Thibaut Courtois",
                "Phil Jones",
                "Mohamed Salah",
                "Raheem Sterling",
                "Harry Kane",
                "Marko Arnautovic",
                "Pascal Groß"
            };

            foreach (var player in myPlayerNames)
            {
                var firstName = player.Split(' ')[0];
                var secondName = player.Split(' ')[1];
                var newPlayer = playerFactory.CreatePlayer(firstName, secondName, true);
                Console.WriteLine("Player: {0} {1}, {2}", firstName, secondName, newPlayer.PointsPerNinetyPerMillion);
                myPlayers.Add(newPlayer);
            }

            Console.ReadLine();
        }
    }
}
