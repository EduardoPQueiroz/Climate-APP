using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClimateApp.Models
{
    public class WeatherResponse
    {
        [JsonPropertyName("coord")]
        public Coordinates Coord {  get; set; }

        [JsonPropertyName("weather")]
        public List<Weather> Weather { get; set; }

        [JsonPropertyName("main")]
        public Main Main { get; set; }

    }
}

