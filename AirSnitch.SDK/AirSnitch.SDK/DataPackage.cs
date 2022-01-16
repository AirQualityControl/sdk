using System.Collections;
using System.Collections.Generic;
using AirSnitch.SDK.Internal;

namespace AirSnitch.SDK
{
    public class DataPackage : IEnumerable<DataPoint>
    {
        private List<DataPoint> _dataPoints;

        public DataPackage(int size = 10)
        {
            _dataPoints = new List<DataPoint>(size);
        }

        public void Add(DataPoint dataPoint)
        {
            _dataPoints.Add(dataPoint);
        }

        public string Serialize()
        {
            var serializer = ServiceLocator.GetSerializer();
            return serializer.Serialize(this);
        }

        public IEnumerator<DataPoint> GetEnumerator()
        {
            return _dataPoints.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dataPoints.GetEnumerator();
        }
    }
}