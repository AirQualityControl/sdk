using Newtonsoft.Json;
using NUnit.Framework;

namespace AirSnitch.SDK.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void JsonText_DeserializeToCorrectDataType()
        {
            var jsonText = "{\"station\":{\"id\":\"SAVEDNIPRO_001\",\"name\":\"SAVEDNIPRO_001\",\"cityName\":\"Dnipro\",\"countryCode\":\"UA\",\"address\":\"Geroev Avenue, 40\",\"geoCoordinates\":{\"long\":35.072505,\"lat\":48.408944}},\"measurements\":[{\"value\":4.15,\"name\":\"PM10\"},{\"value\":3.13,\"name\":\"PM25\"},{\"value\":72.22,\"name\":\"Humidity\"},{\"value\":13.79,\"name\":\"Temperature\"}],\"dateTime\":\"2022-10-15T14:00:00\",\"index\":{\"value\":15,\"type\":\"US_AIQ\"}}";

            var dataPoint = JsonConvert.DeserializeObject<DataPoint>(jsonText);
            
            Assert.IsNotNull(dataPoint);
            Assert.AreEqual(dataPoint.StationInfo.StationId, "SAVEDNIPRO_001");
            Assert.AreEqual(dataPoint.StationInfo.StationName, "SAVEDNIPRO_001");
            Assert.AreEqual(dataPoint.StationInfo.CityName, "Dnipro");
            Assert.AreEqual(dataPoint.StationInfo.CountryCode, "UA");
            Assert.AreEqual(dataPoint.StationInfo.Address, "Geroev Avenue, 40");
        }
    }
}