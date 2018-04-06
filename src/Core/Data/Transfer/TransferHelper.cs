using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FPL.Core.Data.Detailed
{
    public class TransferHelper
    {
        [JsonProperty("id")]
        public int TeamId { get; set; }

        [JsonProperty("name")]
        public string TeamName { get; set; }

        [JsonProperty("bank")]
        public int BankValue { get; set; }

        [JsonProperty("value")]
        public int TeamValue { get; set; }

        [JsonProperty("transfer_state")]
        public TransfersState TransfersState { get; set; }

        [JsonProperty("wildcare_status")]
        public string WildcardStatus { get; set; }

        [JsonProperty("freehit_status")]
        public string FreehitStatus { get; set; }
    }
}
