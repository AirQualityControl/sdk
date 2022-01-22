namespace AirSnitch.SDK.Measurements
{
    public class PM25 : Measurement
    {
        protected internal override bool IsValid()
        {
            throw new System.NotImplementedException();
        }

        public PM25(object value) : base(value, "PM25")
        {
        }
    }
}