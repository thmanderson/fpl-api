using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Core.Data.Detailed
{
    public class FixtureStat
    {
        [JsonProperty("a")]
        public PlayerEvent[] Away { get; set; }

        [JsonProperty("h")]
        public PlayerEvent[] Home { get; set; }
    }
}
