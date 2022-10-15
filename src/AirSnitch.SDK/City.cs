using Newtonsoft.Json;

namespace AirSnitch.SDK
{
    public class City
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}