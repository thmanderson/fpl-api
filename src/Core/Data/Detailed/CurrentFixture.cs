using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FPL.Core.Data.Detailed
{
    /// <summary>
    /// Summary of the current fixture - i.e. the most recent result, or the fixture currently being played.
    /// </summary>
    public class CurrentFixture
    {
        /// <summary>
        /// Summary of statistics for this player, for this specific fixture.
        /// </summary>
        [JsonProperty("explain")]
        public PlayerStats PlayerStats { get; set; }

        /// <summary>
        /// Summary of the overall statistics for this specific fixture.
        /// </summary>
        [JsonProperty("fixture")]
        public Fixture FixtureStats { get; set; }
    }
}
