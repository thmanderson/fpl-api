using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FPL.Core.Data.Detailed
{
    public class PlayerEvent
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("element")]
        public int Element { get; set; }
    }
}
