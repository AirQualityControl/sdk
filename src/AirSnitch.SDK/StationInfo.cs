using System;
using Newtonsoft.Json;

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
        [JsonProperty("id")]
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
        [JsonProperty("name")]
        public string StationName { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("cityName")] 
        public string CityName { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        [JsonProperty("countryName")] 
        public string CountryName { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        [JsonProperty("countryCode")] 
        public string CountryCode { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
        
        /// <summary>
        /// Geo-coordinates of the station
        /// </summary>
        [JsonProperty("geoCoordinates")]
        public GeoCoordinates GeoCoordinates { get; set; }
    }
}