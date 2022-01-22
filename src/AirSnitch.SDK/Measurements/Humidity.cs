using AirSnitch.SDK.Measurements;

namespace AirSnitch.SDK
{
    public class Humidity : Measurement
    {
        protected internal override bool IsValid()
        {
            throw new System.NotImplementedException();
        }

        public Humidity(object value, string name) : base(value, name)
        {
        }
    }
}