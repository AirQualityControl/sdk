namespace AirSnitch.SDK
{
    /// <summary>
    /// ADT that represents air quality index vale according to USA standard (USAAQI)
    /// </summary>
    public class USAQIndex : AQIndexValue
    {
        public USAQIndex(int value, string name = "US_AIQ"): base(value, name)
        {
            
        }
    }
}