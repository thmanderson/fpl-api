using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Core.Data.Detailed
{
    public class PlayerStat
    {
        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
