using System;
using Newtonsoft.Json;

namespace fpl_api.Model
{
    [Serializable]
    public class RawTeamStats
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("short_name")]
        public string ShortCode { get; set; }

        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("played")]
        public int Played { get; set; }

        [JsonProperty("win")]
        public int Win { get; set; }

        [JsonProperty("draw")]
        public int Draw { get; set; }

        [JsonProperty("loss")]
        public int Loss { get; set; }

        [JsonProperty("strength")]
        public int Strength { get; set; }

        [JsonProperty("strength_overall_home")]
        public int StrengthOverallHome { get; set; }

        [JsonProperty("strength_overall_away")]
        public int StrengthOverallAway { get; set; }

        [JsonProperty("strength_attack_home")]
        public int StrengthAttackHome { get; set; }

        [JsonProperty("strength_attack_away")]
        public int StrengthAttackAway { get; set; }

        [JsonProperty("strength_defence_home")]
        public int StrengthDefenceHome { get; set; }

        [JsonProperty("strength_defence_away")]
        public int StrengthDefenceAway { get; set; }

    }
}
