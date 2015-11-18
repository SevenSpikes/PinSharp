﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PinSharp.Models.Counts;

namespace PinSharp.Models
{
    public class BoardDetails : Board
    {
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        public User Creator { get; set; }

        public string Description { get; set; }

        public BoardCounts Counts { get; set; }

        [JsonProperty("image")]
        public IDictionary<string, PinterestImage> Images { get; set; }

        public string Reason { get; set; }

        public string Privacy { get; set; }
    }
}
