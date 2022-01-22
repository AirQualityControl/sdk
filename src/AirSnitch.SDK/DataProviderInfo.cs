using System.Text.Json.Serialization;

namespace AirSnitch.SDK
{
    public class DataProviderInfo
    {
        [JsonPropertyName("id")]
        public string Tag { get; set; }
    }
}