using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FPL.Core.Data.Detailed
{
    public class TransfersState
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cost")]
        public int CostPerTransfer { get; set; }

        [JsonProperty("free")]
        public int FreeTransferCount { get; set; }

        [JsonProperty("made")]
        public int TransfersMade { get; set; }
    }
}
