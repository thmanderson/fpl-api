using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Core.Model
{
    [Serializable]
    public class RawFixtureData
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

        [JsonProperty("team_h_difficulty")]
        public int home_team_difficulty;

        [JsonProperty("team_a_difficulty")]
        public int away_team_difficulty;

        [JsonProperty("code")]
        public int code;

        [JsonProperty("kickoff_time")]
        public string kickoff_time;

        [JsonProperty("team_h_score")]
        public int? home_team_score;

        [JsonProperty("team_a_score")]
        public int? away_team_score;

        [JsonProperty("finished")]
        public bool finished;

        [JsonProperty("minutes")]
        public int minutes;

        [JsonProperty("provisional_start_time")]
        public bool provisional_start_time;

        [JsonProperty("finished_provisional")]
        public bool finished_provisional;

        [JsonProperty("event")]
        public int event_id;
    }
}
