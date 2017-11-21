using System;
using System.Runtime.CompilerServices;
using FPL.Core.Data;
using FPL.Core.Helpers;
using FPL.Core.Model;

[assembly:InternalsVisibleTo("FPL.Core.Tests")]
namespace FPL.Core
{
    /// <summary>
    /// Represents an individual football player. Wraps around and expands on instances of <see cref="PlayerDataSummary"/> and <see cref="PlayerDataDetailed"/>.
    /// </summary>
    public class Player : IPlayer
    {
        public PlayerDataSummary DataSummary { get; private set; }
        public PlayerDataDetailed DataDetailed { get; private set; }
        public int Id => DataSummary.Id;
        public string FirstName => DataSummary.FirstName;
        public string SecondName => DataSummary.SecondName;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="PlayerId">Player ID from the official Fantasy Premier League API.</param>
        /// <param name="GetDetails">If true, will initialize additional details <see cref="PlayerDataDetailed"/>, such as week-by-week score.
        /// Not recommended if you are creating players in bulk, and these details can be initialized later, <see cref="UpdatePlayerDetails"/>.
        /// Defaults to <see cref="false"/>.</param>
        public Player(int PlayerId, bool GetDetails = false)
        {
            this.DataSummary = DataGetter.GetPlayerSummary(PlayerId);
            if(GetDetails) this.DataDetailed = DataGetter.GetPlayerDetails(PlayerId);
        }

        /// <summary>
        /// Internal constructor for testing with dummy data.
        /// </summary>
        /// <param name="dummySummary">Player summary with dummy values for testing.</param>
        public Player(PlayerDataSummary dummySummary)
        {
            this.DataSummary = dummySummary;
        }

        public void UpdatePlayerDetails()
        {
            this.DataDetailed = DataGetter.GetPlayerDetails(this.Id);
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
        public double PointsPerNinety()
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
        public double PointsPerNinetyPerMillion()
        {
            double PP90 = this.PointsPerNinety();
            double price = this.DataSummary.NowCost;

            if (price == 0) return 0;

            return PP90 / price;
        }
    }
}