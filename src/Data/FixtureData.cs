using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FPL.Data
{
    [Serializable]
    public class FixtureData
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("kickoff_time_formatted")]
        public string KickoffTimeFormatted { get; set; }

        [JsonProperty("started")]
        public bool Started { get; set; }

        [JsonProperty("event_day")]
        public int EventDay { get; set; }

        [JsonProperty("deadline_time")]
        public string DeadlineTime { get; set; }

        [JsonProperty("deadline_time_formatted")]
        public string DeadlineTimeFormatted { get; set; }

        [JsonProperty("team_h_difficulty")]
        public int TeamHDifficulty { get; set; }

        [JsonProperty("team_a_difficulty")]
        public int TeamADifficulty { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("kickoff_time")]
        public string KickoffTime { get; set; }

        [JsonProperty("team_h_score")]
        public int? TeamHScore { get; set; }

        [JsonProperty("team_a_score")]
        public int? TeamAScore { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("provisional_start_time")]
        public bool ProvisionalStartTime { get; set; }

        [JsonProperty("finished_provisional")]
        public bool FinishedProvisional { get; set; }

        [JsonProperty("event")]
        public int Event { get; set; }

        [JsonProperty("team_a")]
        public int TeamA { get; set; }

        [JsonProperty("team_h")]
        public int TeamH { get; set; }
    }
}
