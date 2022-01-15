using System;

namespace AirSnitch.SDK
{
    public class StationInfo
    {
        private string _stationId;
        public string StationId
        {
            get => _stationId;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("");
                }
                _stationId = value;
            }
        }

        public string StationName { get; set; }

        public City City { get; set; }

        public Country Country { get; set; }

        public string Address { get; set; }
    }
}