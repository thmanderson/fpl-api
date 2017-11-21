using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FPL.Data.Detailed
{
    /// <summary>
    /// Summary of a past season in FPL for a specific player, shown as "history_past" in the raw JSON.
    /// </summary>
    public class Season
    {
        /// <summary>
        /// Identifier for the FPL season.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Full name of the season, of the form "2013/14".
        /// </summary>
        [JsonProperty("season_name")]
        public string Name { get; set; }

        /// <summary>
        /// ID of this same player in this previous season. Doesn't seem to usually change but haven't looked into this much.
        /// </summary>
        [JsonProperty("element_code")]
        public int PlayerId { get; set; }

        /// <summary>
        /// Price of the player at the start of the season. A value of 10 is equivalent to £1.0m on the website.
        /// </summary>
        [JsonProperty("start_cost")]
        public int StartPrice { get; set; }

        /// <summary>
        /// Price of the player at the end of the season. A value of 10 is equivalent to £1.0m on the website.
        /// </summary>
        [JsonProperty("end_cost")]
        public int EndPrice { get; set; }

        /// <summary>
        /// Total number of points scored by the player during the season.
        /// </summary>
        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        /// <summary>
        /// Total number of minutes played by the player during the season.
        /// </summary>
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        /// <summary>
        /// Total number of goals scored by the player during the season.
        /// </summary>
        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }

        /// <summary>
        /// Total number of assists from the player during the season.
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        /// Total number of clean sheets kept by the player during the season.
        /// </summary>
        [JsonProperty("clean_sheets")]
        public int CleanSheets { get; set; }

        /// <summary>
        /// Total number of goals conceded by the player during the season.
        /// </summary>
        [JsonProperty("goals_conceded")]
        public int GoalsConceded { get; set; }

        /// <summary>
        /// Total number of own goals scored by the player during the season.
        /// </summary>
        [JsonProperty("own_goals")]
        public int OwnGoals { get; set; }

        /// <summary>
        /// Total number of penalties saved by the player during the season.
        /// </summary>
        [JsonProperty("penalties_saved")]
        public int PenaltiesSaved { get; set; }

        /// <summary>
        /// Total number of penalties missed by the player during the season.
        /// </summary>
        [JsonProperty("penalties_missed")]
        public int PenaltiesMissed { get; set; }

        /// <summary>
        /// Total number of yellow cards received by the player during the season.
        /// </summary>
        [JsonProperty("yellow_cards")]
        public int YellowCards { get; set; }

        /// <summary>
        /// Total number of red cards received by the player during the season.
        /// </summary>
        [JsonProperty("red_cards")]
        public int RedCards { get; set; }

        /// <summary>
        /// Total number of saves made by the player during the season.
        /// </summary>
        [JsonProperty("saves")]
        public int Saves { get; set; }

        /// <summary>
        /// Total number of bonus points received by the player during the season.
        /// </summary>
        [JsonProperty("bonus")]
        public int Bonus { get; set; }

        /// <summary>
        /// Total number of BPS accumulated by the player during the season.
        /// </summary>
        [JsonProperty("bps")]
        public int Bps { get; set; }

        /// <summary>
        /// Overall influence of the player during the season.
        /// </summary>
        [JsonProperty("influence")]
        public string Influence { get; set; }

        /// <summary>
        /// Overall creativity of the player during the season.
        /// </summary>
        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        /// <summary>
        /// Overall threat from the player during the season.
        /// </summary>
        [JsonProperty("threat")]
        public string Threat { get; set; }

        /// <summary>
        /// Overall ICT index of the player during the season (calculated using the 3 values, <see cref="Influence"/>, <see cref="Creativity"/>, and <see cref="Threat"/>, presumably.
        /// </summary>
        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        /// <summary>
        /// Not sure what this is. Another index to measure overall performance I think.
        /// </summary>
        [JsonProperty("ea_index")]
        public int EaIndex { get; set; }

        /// <summary>
        /// A second season ID? Not sure what this is.
        /// </summary>
        [JsonProperty("season")]
        public int Code { get; set; }
    }
}
