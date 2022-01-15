using System;
using System.Collections.Generic;
using AirSnitch.SDK;
using AirSnitch.SDK.Measurements;

namespace AirSnitchSDK.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataPoint = new DataPoint()
            {
                StationInfo = new StationInfo()
                {
                    City = new City()
                    {
                        Name = "Dnipro",
                    },
                    Country = Country.UA,
                    StationId = "224",
                    Address = "Dubrovskogo str",
                },
                DataProviderInfo = new DataProviderInfo()
                {
                    Tag = "SAVE_DNIPRO"
                },
                Measurements = new List<Measurement>(2)
                {
                    new PM25(10),
                    new PM10(70)
                },
                DateTime = DateTime.Now
            };

            string requestBody = dataPoint.Serialize();
            
            Console.WriteLine(requestBody);
        }
    }
}