namespace AirSnitch.SDK
{
    public class Pressure : Measurement<int>
    {
        public override int Value { get; set; }
        public override string Name { get; set; }
        protected internal override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}