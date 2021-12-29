namespace AirSnitch.SDK
{
    public class DataPoint
    {
        public StationId StationId { get; set; }

        public DataProviderId DataProviderId { get; set; }

        public Location Location { get; set; }

        public void Serialize()
        {
            
        }
    }
}