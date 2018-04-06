using System;
using System.Collections.Generic;
using System.Text;
using FPL.Core.Data.Detailed;
using Newtonsoft.Json;

namespace FPL.Core.Data
{
    public class TransferData
    {
        [JsonProperty("entry")]
        public Entry Entry { get; set; }

        [JsonProperty("chips")]
        public List<Chip> Chips { get; set; }

        [JsonProperty("helper")]
        public TransferHelper TransferHelper { get; set; }

        [JsonProperty("ce")]
        public int CurrentEntry { get; set; }

        [JsonProperty("picks")]
        public List<Pick> Picks { get; set; }
    }
}
