using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FPL.Core.Data.Detailed
{
    public class Chip
    {
        [JsonProperty("status_for_entry")]
        public string Status { get; set; }

        [JsonProperty("played_by_entry")]
        public List<object> PlayedByEntry { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("start_event")]
        public int StartEvent { get; set; }

        [JsonProperty("stop_event")]
        public int EndEvent { get; set; }
    }
}
