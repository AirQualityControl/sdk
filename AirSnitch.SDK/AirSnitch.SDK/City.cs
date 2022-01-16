using System.Text.Json.Serialization;

namespace AirSnitch.SDK
{
    public class City
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}