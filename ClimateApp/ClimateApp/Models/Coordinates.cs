using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClimateApp.Models
{
    public class Coordinates
    {
        [JsonPropertyName("lon")]
        public double Lon {  get; set; }
        
        [JsonPropertyName("lat")]
        public double Lat { get; set; }
    }
}
