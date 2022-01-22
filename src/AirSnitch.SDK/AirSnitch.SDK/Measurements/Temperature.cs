namespace AirSnitch.SDK.Measurements
{
    public class Temperature : Measurement
    {
        protected internal override bool IsValid()
        {
            throw new System.NotImplementedException();
        }

        public Temperature(object value) : base(value, "Temperature")
        {
        }
    }
}