using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FPL.Core.Data.Detailed
{
    public class Pick
    {
        [JsonProperty("id")]
        public int PlayerId { get; set; }

        [JsonProperty("selling_price")]
        public int SellingPrice { get; set; }

        [JsonProperty("multiplier")]
        public int Multiplier { get; set; }

        [JsonProperty("purchase_price")]
        public int PurchasePrice { get; set; }

        [JsonProperty("purchase_date")]
        public string PurchaseData { get; set; }

        [JsonProperty("is_captain")]
        public bool Captain { get; set; }

        [JsonProperty("is_vice_captain")]
        public bool ViceCaptain { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("element")]
        public int Element { get; set; }

        [JsonProperty("entry")]
        public int Entry { get; set; }
    }
}
