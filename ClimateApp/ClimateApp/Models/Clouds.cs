using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClimateApp.Models
{
    public class Clouds
    {
        [JsonPropertyName("all")]
        public int All {  get; set; }
    }
}
