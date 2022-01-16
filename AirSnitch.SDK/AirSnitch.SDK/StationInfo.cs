using System;
using System.Text.Json.Serialization;

namespace AirSnitch.SDK
{
    public class StationInfo
    {
        private string _stationId;
        
        [JsonPropertyName("id")]
        public string StationId
        {
            get => _stationId;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("");
                }
                _stationId = value;
            }
        }

        [JsonPropertyName("name")]
        public string StationName { get; set; }

        [JsonPropertyName("cityName")] 
        public string CityName { get; set; }

        [JsonPropertyName("countryName")] 
        public string CountryName { get; set; }

        [JsonPropertyName("countryCode")] 
        public string CountryCode { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }
        
        [JsonPropertyName("geoCoordinates")]
        public GeoCoordinates GeoCoordinates { get; set; }
    }
}