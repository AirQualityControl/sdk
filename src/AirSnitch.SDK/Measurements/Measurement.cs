using Newtonsoft.Json;

namespace AirSnitch.SDK.Measurements
{
    public class Measurement
    {
        [JsonProperty("value")] 
        public object Value { get; set; }

        [JsonProperty("name")] 
        public string Name { get; set; }
    }
}