using System;
using System.Collections.Generic;
using System.Text;
using Core.Model;

namespace Core
{
    public static class PlayerCalculations
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

            return (points * 90) / minutes;
        }

        public static double PointsPer90PerMillion(Player player)
        {
            double PP90 = PointsPer90(player);
            double price = player.Data.NowCost;

            return PP90 / price;
        }
    }
}
