using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FPL.Core.Data.Detailed
{
    public class FutureFixture
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("kickoff_time_formatted")]
        public string KickoffTimeFormatted { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("opponent_name")]
        public string OpponentName { get; set; }

        [JsonProperty("opponent_short_name")]
        public string OpponentShortName { get; set; }

        [JsonProperty("is_home")]
        public bool IsHome { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("kickoff_time")]
        public string KickoffTime { get; set; }

        [JsonProperty("team_h_score")]
        public int TeamHScore { get; set; }

        [JsonProperty("team_a_score")]
        public int TeamAScore { get; set; }

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