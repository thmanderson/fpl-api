using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Core.Helpers;

namespace Core
{
    public static class PlayerCalculation
    {
        public static double PointsPerGame(Player player)
        {
            double result = double.Parse(player.Data.PointsPerGame);

            return result;
        }

        public static double PointsPer90(Player player)
        {
            double points = player.Data.TotalPoints;
            double minutes = player.Data.Minutes;

            if (minutes == 0) return 0;

            return (points * 90) / minutes;
        }

        public static double PointsPer90PerMillion(Player player)
        {
            double PP90 = PointsPer90(player);
            double price = player.Data.NowCost;

            if (price == 0) return 0;

            return PP90 / price;
        }

        public static List<Player> GetPlayerByName(string name)
        {
            var players = DataRetriever.GetAllPlayers();
            List<Player> playersList = players.ToList<Player>();
            var test = playersList.FindAll(x => x.Data.FirstName == name);
            return test;
        }
    }
}
