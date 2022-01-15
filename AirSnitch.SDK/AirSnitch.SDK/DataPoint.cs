using System;
using System.Collections.Generic;
using AirSnitch.SDK.Internal;
using AirSnitch.SDK.Measurements;

namespace AirSnitch.SDK
{
    public class DataPoint
    {
        public StationInfo StationInfo { get; set; }
        public DataProviderInfo DataProviderInfo { get; set; }
        public List<Measurement> Measurements { get; set; }
        
        public Dictionary<string, object> AdditionalData { get; set; }
        public DateTime DateTime { get; set; }

        public AQIndexValue Value { get; set; }

        public string Serialize()
        {
            var serializer = ServiceLocator.GetSerializer();
            return serializer.Serialize(this);
        }
    }
}