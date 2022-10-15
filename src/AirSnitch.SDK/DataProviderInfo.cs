using Newtonsoft.Json;

namespace AirSnitch.SDK
{
    public class DataProviderInfo
    {
        [JsonProperty("id")]
        public string Tag { get; set; }
    }
}