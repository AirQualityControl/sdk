using System.Text.Json.Serialization;

namespace AirSnitch.SDK
{
    public abstract class AQIndexValue
    {
        private readonly int _value;
        private readonly string _indexName;

        public AQIndexValue(int value, string indexName)
        {
            _value = value;
            _indexName = indexName;
        }

        [JsonPropertyName("value")]
        public int IndexValue
        {
            get => _value;
        }

        [JsonPropertyName("type")]
        public string IndexName
        {
            get => _indexName;
        }
    }
}