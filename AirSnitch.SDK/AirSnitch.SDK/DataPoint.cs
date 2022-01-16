using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AirSnitch.SDK.Internal;
using AirSnitch.SDK.Measurements;

namespace AirSnitch.SDK
{
    /// <summary>
    ///ADT that represent a data point that contains a single unit of
    /// data from station ot provider
    /// </summary>
    public class DataPoint
    {
        /// <summary>
        /// Information about station that sends the data
        /// </summary>
        [JsonPropertyName("station")]
        public StationInfo StationInfo { get; set; }
        
        /// <summary>
        /// Information about data provider or station
        /// </summary>
        [JsonPropertyName("dataProvider")]
        public DataProviderInfo DataProviderInfo { get; set; }
        /// <summary>
        /// A collection of measurements collected from station
        /// </summary>
        [JsonPropertyName("measurements")]
        public List<Measurement> Measurements { get; set; }
        
        /// <summary>
        /// Additional data that could be use to server
        /// </summary>
        [JsonPropertyName("additionalData")]
        public Dictionary<string, object> AdditionalData { get; set; }
        
        /// <summary>
        /// DateTime when measurements was collected
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Index value.Field is not mandatory.
        /// Some stations/providers might sent it while other is not
        /// </summary>
        [JsonPropertyName("index")]
        public AQIndexValue IndexValue { get; set; }

       
        /// <summary>
        /// Method that serialize request to a valid JSON request body
        /// </summary>
        /// <returns></returns>
        public string Serialize()
        {
            var serializer = ServiceLocator.GetSerializer();
            return serializer.Serialize(this);
        }
    }
}