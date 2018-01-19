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
            var playerFactory = new PlayerFactory();
            var myPlayerNames = new List<string> { "Thibaut Courtois", "Phil Jones", "Mohamed Salah", "Raheem Sterling" };
            var myPlayers = new List<IPlayer>();

            foreach (var player in myPlayerNames)
            {
                var firstName = player.Split(' ')[0];
                var secondName = player.Split(' ')[1];
                myPlayers.Add(playerFactory.CreatePlayer(firstName, secondName, true));
            }

            Console.WriteLine("Done");
        }
    }
}
