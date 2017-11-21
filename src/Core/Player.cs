﻿using System;
using FPL.Data;

namespace FPL.Core
{
    /// <summary>
    /// Represents an individual football player. Wraps around and expands on instances of <see cref="PlayerDataSummary"/> and <see cref="PlayerDataDetailed"/>.
    /// </summary>
    public class Player
    {
        public readonly PlayerDataDetailed DataDetailed;
        public readonly PlayerDataSummary DataSummary;

        /// <summary>
        /// Creates an instance of player, using only summary data. This will be able to provide totals for the season, but not fixture-by-fixture, or totals for previous seasons.
        /// </summary>
        /// <param name="dataSummary">Player summary.</param>
        public Player(PlayerDataSummary dataSummary)
        {
            this.DataSummary = dataSummary ?? throw new ArgumentNullException(nameof(dataSummary));
        }

        /// <summary>
        /// Creates a detailed instance of a player.
        /// </summary>
        /// <param name="dataSummary">Player summary.</param>
        /// <param name="dataDetailed">Detailed player data.</param>
        public Player(PlayerDataSummary dataSummary, PlayerDataDetailed dataDetailed)
        {
            this.DataSummary = dataSummary ?? throw new ArgumentNullException(nameof(dataSummary));
            this.DataDetailed = dataDetailed ?? throw new ArgumentNullException(nameof(dataDetailed));
        }

        /// <summary>
        /// Points per game for this player - not including games missed.
        /// </summary>
        /// <returns>The average number of points per game.</returns>
        public double PointsPerGame()
        {
            double result = double.Parse(this.DataSummary.PointsPerGame);

            return result;
        }

        /// <summary>
        /// Points for every 90 minutes played for this player.
        /// </summary>
        /// <returns>The average number of points for every 90 minutes played in total.</returns>
        public double PointsPer90()
        {
            double points = this.DataSummary.TotalPoints;
            double minutes = this.DataSummary.Minutes;

            if (minutes == 0) return 0;

            return (points * 90) / minutes;
        }

        /// <summary>
        /// Points per 90 <see cref="PointsPer90"/> per £1m of player cost.
        /// </summary>
        /// <returns>The average number of points for every 90 minutes played, for every £1m player cost.</returns>
        public double PointsPer90PerMillion()
        {
            double PP90 = this.PointsPer90();
            double price = this.DataSummary.NowCost;

            if (price == 0) return 0;

            return PP90 / price;
        }
    }
}