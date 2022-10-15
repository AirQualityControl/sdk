using System.Text.Json.Serialization;

namespace AirSnitch.SDK.Measurements
{
    public class Measurement
    {
        private readonly object _value;
        private readonly string _name;

        protected Measurement(object value, string name)
        {
            _value = value;
            _name = name;
        }
        
        [JsonPropertyName("value")]
        public object Value => _value;

        [JsonPropertyName("name")]
        public string Name => _name;

        protected internal virtual bool IsValid()
        {
            return true;
        }
    }
}