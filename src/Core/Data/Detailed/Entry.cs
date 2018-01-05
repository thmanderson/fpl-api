using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FPL.Core.Data.Detailed
{
    public class Entry
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("player_first_name")]
        public string player_first_name { get; set; }

        [JsonProperty("player_last_name")]
        public string player_last_name { get; set; }

        [JsonProperty("player_region_id")]
        public int player_region_id { get; set; }

        [JsonProperty("player_region_name")]
        public string player_region_name { get; set; }

        [JsonProperty("player_region_short_iso")]
        public string player_region_short_iso { get; set; }

        [JsonProperty("summary_overall_points")]
        public int summary_overall_points { get; set; }

        [JsonProperty("summary_overall_rank")]
        public int summary_overall_rank { get; set; }

        [JsonProperty("summary_event_points")]
        public int summary_event_points { get; set; }

        [JsonProperty("summary_event_rank")]
        public int summary_event_rank { get; set; }

        [JsonProperty("joined_seconds")]
        public int joined_seconds { get; set; }

        [JsonProperty("current_event")]
        public int current_event { get; set; }

        [JsonProperty("total_transfers")]
        public int total_transfers { get; set; }

        [JsonProperty("total_loans")]
        public int total_loans { get; set; }

        [JsonProperty("total_loans_active")]
        public int total_loans_active { get; set; }

        [JsonProperty("transfers_or_loans")]
        public string transfers_or_loans { get; set; }

        [JsonProperty("deleted")]
        public bool deleted { get; set; }

        [JsonProperty("email")]
        public bool email { get; set; }

        [JsonProperty("joined_time")]
        public DateTime joined_time { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("bank")]
        public int bank { get; set; }

        [JsonProperty("value")]
        public int value { get; set; }

        [JsonProperty("kit")]
        public string kit { get; set; }

        [JsonProperty("event_transfers")]
        public int event_transfers { get; set; }

        [JsonProperty("event_transfers_cost")]
        public int event_transfers_cost { get; set; }

        [JsonProperty("extra_free_transfers")]
        public int extra_free_transfers { get; set; }

        [JsonProperty("strategy")]
        public object strategy { get; set; }

        [JsonProperty("favourite_team")]
        public int favourite_team { get; set; }

        [JsonProperty("started_event")]
        public int started_event { get; set; }

        [JsonProperty("player")]
        public int player { get; set; }
    }
}
