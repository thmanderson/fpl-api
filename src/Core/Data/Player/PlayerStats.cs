using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FPL.Core.Data.Detailed
{
    /// <summary>
    /// Summary of the stats for the current player, for the current fixture.
    /// </summary>
    public class PlayerStats
    {
        /// <summary>
        /// Bonus Points.
        /// </summary>
        [JsonProperty("bonus")]
        public PlayerStat Bonus { get; set; }

        /// <summary>
        /// Clean Sheets.
        /// </summary>
        [JsonProperty("clean_sheets")]
        public PlayerStat CleanSheets { get; set; }

        /// <summary>
        /// Minutes played.
        /// </summary>
        [JsonProperty("minutes")]
        public PlayerStat Minutes { get; set; }
    }

}
