using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClimateApp.Models
{
    public class Sys
    {
        [JsonPropertyName("type")]
        public int Type {  get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }
        
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("sunrise")]
        public long Sunrise {  get; set; }

        [JsonPropertyName("sunset")]
        public long Sunset {  get; set; }
    }
}
