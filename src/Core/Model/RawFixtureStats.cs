using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Core.Model
{
    [Serializable]
    public class RawFixtureStats
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("kickoff_time_formatted")]
        public string kickoff_time_formatted;

        [JsonProperty("started")]
        public string started;

        [JsonProperty("event_day")]
        public int event_day;

        [JsonProperty("deadline_time")]
        public string deadline_time;

        [JsonProperty("deadline_time_formatted")]
        public string deadline_time_formatted;
    }
}
