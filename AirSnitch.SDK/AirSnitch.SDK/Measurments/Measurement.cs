namespace AirSnitch.SDK
{
    public abstract class Measurement<TValue>
    {
        public abstract TValue Value { get; set; }
        
        public abstract string Name { get; set; }

        protected internal abstract bool IsValid();
    }
}