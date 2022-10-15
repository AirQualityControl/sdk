using System;
using System.Collections.Generic;
using AirSnitch.SDK.Internal;
using AirSnitch.SDK.Measurements;
using Newtonsoft.Json;

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
        [JsonProperty("station")]
        public StationInfo StationInfo { get; set; }
        
        /// <summary>
        /// Information about data provider or station
        /// </summary>
        [JsonProperty("dataProvider")]
        public DataProviderInfo DataProviderInfo { get; set; }
        /// <summary>
        /// A collection of measurements collected from station
        /// </summary>
        [JsonProperty("measurements")]
        public List<Measurement> Measurements { get; set; }
        
        /// <summary>
        /// Additional data that could be use to server
        /// </summary>
        [JsonProperty("additionalData")]
        public Dictionary<string, object> AdditionalData { get; set; }
        
        /// <summary>
        /// DateTime when measurements was collected
        /// </summary>
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Index value.Field is not mandatory.
        /// Some stations/providers might sent it while other is not
        /// </summary>
        [JsonProperty("index")]
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