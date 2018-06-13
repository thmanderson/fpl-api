using System;
using System.Runtime.CompilerServices;
using FPL.Core.Data;
using FPL.Core.Model;

namespace FPL.Core
{
    /// <summary>
    /// Represents an individual football player. Wraps around and expands on instances of <see cref="PlayerDataSummary"/> and <see cref="PlayerDataDetailed"/>.
    /// </summary>
    public class Player : IPlayer
    {
        /// <summary> Summary of this player for the current season. </summary>
        public PlayerDataSummary DataSummary { get; private set; }

        /// <summary> Detailed data for this player, for current and past seasons. </summary>
        public PlayerDataDetailed DataDetailed { get; set; }

        /// <summary> Player ID. </summary>
        public int Id => DataSummary.Id;

        /// <summary> Players first name. </summary>
        public string FirstName => DataSummary.FirstName;

        /// <summary> Players second name. </summary>
        public string SecondName => DataSummary.SecondName;

        ///<summary>Points per game for this player - not including games missed.</summary>
        public double PointsPerGame => double.Parse(this.DataSummary.PointsPerGame);

        ///<summary>Points for every 90 minutes played for this player.</summary>
        public double PointsPerNinety => this.DataSummary.Minutes == 0 ? 0 : (this.DataSummary.TotalPoints * 90) / this.DataSummary.Minutes;

        ///<summary>Points per 90 <see cref="PointsPer90"/> per £1m of player cost.</summary>
        public double PointsPerNinetyPerMillion => this.DataSummary.NowCost == 0 ? 0 : this.PointsPerNinety / this.DataSummary.NowCost;

        /// <summary> Internal constructor for testing with dummy data. </summary>
        /// <param name="DataSummary">Player summary with dummy values for testing.</param>
        public Player(PlayerDataSummary DataSummary, PlayerDataDetailed DataDetailed = null)
        {
            this.DataSummary = DataSummary;
            if (DataDetailed != null) this.DataDetailed = DataDetailed;
        }
    }
}