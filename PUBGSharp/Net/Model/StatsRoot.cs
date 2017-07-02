﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PUBGSharp.Data;

namespace PUBGSharp.Net.Model
{
    public class StatsRoot
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Region Region { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Season Season { get; set; }

        [JsonProperty("Match")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Mode Mode { get; set; }

        [JsonProperty("Stats")]
        public List<StatModel> Stats { get; set; }
    }
}