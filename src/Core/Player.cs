using System;
using Core.Data;

namespace Core
{
    public class Player
    {
        public PlayerDataSummary Data;
        public Player(PlayerDataSummary RawData)
        {
            Data = RawData ?? throw new ArgumentNullException(nameof(RawData));
        }

        public double PointsPerGame()
        {
            double result = double.Parse(this.Data.PointsPerGame);

            return result;
        }

        public double PointsPer90()
        {
            double points = this.Data.TotalPoints;
            double minutes = this.Data.Minutes;

            if (minutes == 0) return 0;

            return (points * 90) / minutes;
        }

        public double PointsPer90PerMillion()
        {
            double PP90 = this.PointsPer90();
            double price = this.Data.NowCost;

            if (price == 0) return 0;

            return PP90 / price;
        }
    }
}