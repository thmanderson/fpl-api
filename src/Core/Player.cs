using System;
using FPL.Data;

namespace FPL.Core
{
    public class Player
    {
        public PlayerDataDetailed DataDetailed;
        public PlayerDataSummary DataSummary;

        public Player(PlayerDataSummary dataSummary)
        {
            this.DataSummary = dataSummary ?? throw new ArgumentNullException(nameof(dataSummary));
        }

        public Player(PlayerDataSummary dataSummary, PlayerDataDetailed dataDetailed)
        {
            this.DataSummary = dataSummary ?? throw new ArgumentNullException(nameof(dataSummary));
            this.DataDetailed = dataDetailed ?? throw new ArgumentNullException(nameof(dataDetailed));
        }

        public double PointsPerGame()
        {
            double result = double.Parse(this.DataSummary.PointsPerGame);

            return result;
        }

        public double PointsPer90()
        {
            double points = this.DataSummary.TotalPoints;
            double minutes = this.DataSummary.Minutes;

            if (minutes == 0) return 0;

            return (points * 90) / minutes;
        }

        public double PointsPer90PerMillion()
        {
            double PP90 = this.PointsPer90();
            double price = this.DataSummary.NowCost;

            if (price == 0) return 0;

            return PP90 / price;
        }
    }
}