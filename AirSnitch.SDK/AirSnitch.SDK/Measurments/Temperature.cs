namespace AirSnitch.SDK.Measurments
{
    public class Temperature : Measurement<int>
    {
        public override int Value { get; set; }
        public override string Name { get; set; }
        protected internal override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}