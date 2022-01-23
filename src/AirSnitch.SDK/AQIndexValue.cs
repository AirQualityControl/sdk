using System.Text.Json.Serialization;

namespace AirSnitch.SDK
{
    /// <summary>
    /// Abstract class that represent abstract air quality index
    /// </summary>
    public abstract class AQIndexValue
    {
        private readonly int _value;
        private readonly string _indexName;

        public AQIndexValue(int value, string indexName)
        {
            _value = value;
            _indexName = indexName;
        }

        /// <summary>
        /// Index value
        /// </summary>
        [JsonPropertyName("value")]
        public int IndexValue
        {
            get => _value;
        }

        /// <summary>
        /// Human-readable index name
        /// </summary>
        [JsonPropertyName("type")]
        public string IndexName
        {
            get => _indexName;
        }
    }
}