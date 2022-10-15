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
            var dataPackage = new DataPackage();
            var dataPoint = new DataPoint()
            {
                StationInfo = new StationInfo()
                {
                    CityName = "Dnipro",
                    CountryName = "Ukraine",
                    CountryCode = "UA",
                    StationId = "224",
                    Address = "Dubrovskogo str",
                    GeoCoordinates = new GeoCoordinates()
                    {
                        Latitude = 50.450001,
                        Longitude = 30.523333
                    }
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
                IndexValue = new USAQIndex(68),
                DateTime = DateTime.Now,
            };
            dataPackage.Add(dataPoint);
            string requestBody = dataPackage.Serialize();
            
            Console.WriteLine(requestBody);
        }
    }
}