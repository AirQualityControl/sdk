using Newtonsoft.Json;

namespace AirSnitch.SDK
{
    /// <summary>
    /// Abstract class that represent abstract air quality index
    /// </summary>
    public class AQIndexValue
    {
        /// <summary>
        /// Index value
        /// </summary>
        [JsonProperty("value")]
        public int IndexValue { get; set; }

        /// <summary>
        /// Human-readable index name
        /// </summary>
        [JsonProperty("type")]
        public string IndexName { get; set; }
    }
}