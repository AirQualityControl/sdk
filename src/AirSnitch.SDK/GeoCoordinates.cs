using System;
using Newtonsoft.Json;

namespace AirSnitch.SDK
{
    public struct GeoCoordinates
    {
        private const int LatitudeMinValue = 0;
        private const int LatitudeMaxValue = 90;
        private const int LongitudeMinValue = 0;
        private const int LongitudeMaxValue = 180;

        private double _longitudeValue;
        private double _latitudeValue;

        /// <summary>
        /// Longitude value of the point
        /// Value shout be in range between 0 and 90 degree
        /// </summary>
        [JsonProperty("long")]
        public double Longitude
        {
            get => _longitudeValue;
            set
            {
                ValidateLongitude(value);
                _longitudeValue = value;
            }
        }

        /// <summary>
        /// Latitude value of the point
        /// Value should be in range between 0 and 180
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude
        {
            get => _latitudeValue;
            set
            {
                ValidateLatitude(value);
                _latitudeValue = value;
            }
        }

        private void ValidateLatitude(double latitudeValue)
        {
            if (!(latitudeValue > LatitudeMinValue && latitudeValue < LatitudeMaxValue))
            {
                throw new ArgumentException(
                    $"Latitude value is invalid. Value should range from 0 to 90. Received value is {latitudeValue}");
            }
        }

        private void ValidateLongitude(double longitudeValue)
        {
            if (!(longitudeValue > LongitudeMinValue && longitudeValue < LongitudeMaxValue))
            {
                throw new ArgumentException(
                    $"Longitude value is invalid. Value should range from 0 to 180. Received value is {longitudeValue}");
            }
        }
    }
}