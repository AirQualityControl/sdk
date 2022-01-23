using System;
using System.Text.Json.Serialization;

namespace AirSnitch.SDK
{
    /// <summary>
    /// ADT that represent an information about station (AQ Controller) who sends a data
    /// </summary>
    public class StationInfo
    {
        private string _stationId;
        
        /// <summary>
        /// Unique station identifier
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        [JsonPropertyName("id")]
        public string StationId
        {
            get => _stationId;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Station id could not be empty");
                }
                _stationId = value;
            }
        }

        /// <summary>
        /// Human readable station name
        /// </summary>
        [JsonPropertyName("name")]
        public string StationName { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonPropertyName("cityName")] 
        public string CityName { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        [JsonPropertyName("countryName")] 
        public string CountryName { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        [JsonPropertyName("countryCode")] 
        public string CountryCode { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
        
        /// <summary>
        /// Geo-coordinates of the station
        /// </summary>
        [JsonPropertyName("geoCoordinates")]
        public GeoCoordinates GeoCoordinates { get; set; }
    }
}