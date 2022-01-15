namespace AirSnitch.SDK.Measurements
{
    public class PM10 : Measurement
    {
        protected internal override bool IsValid()
        {
            throw new System.NotImplementedException();
        }

        public PM10(object value) : base(value, "PM10")
        {
        }
    }
}