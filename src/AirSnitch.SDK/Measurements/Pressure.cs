namespace AirSnitch.SDK.Measurements
{
    public class Pressure : Measurement
    {
        protected internal override bool IsValid()
        {
            throw new System.NotImplementedException();
        }

        public Pressure(object value) : base(value, "Pressure")
        {
        }
    }
}