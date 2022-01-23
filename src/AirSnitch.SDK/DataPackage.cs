using System.Collections;
using System.Collections.Generic;
using AirSnitch.SDK.Internal;

namespace AirSnitch.SDK
{
    /// <summary>
    /// Represent a collection of measurements(data points) that could be send in single request.
    /// Number of data point in package is limited. Take a look at property MaxCapacity.
    /// This ADT is not thread-safe, so please avoid sharing it between threads!!
    /// </summary>
    public class DataPackage : IEnumerable<DataPoint>
    {
        private LinkedList<DataPoint> _dataPoints;
        private LinkedListNode<DataPoint> _lastNode;

        public DataPackage()
        {
            _dataPoints = new LinkedList<DataPoint>();
        }

        /// <summary>
        /// Add a new data point to current instance of DataPackage.
        /// Method is not thread-safe, so please avoid sharing it between multiple threads
        /// </summary>
        /// <param name="dataPoint"></param>
        public void Add(DataPoint dataPoint)
        {
            if (_lastNode == null)
            {
                _dataPoints.AddFirst(dataPoint);
                return;
            }
            _lastNode = _dataPoints.AddAfter(_lastNode, dataPoint);
        }

        /// <summary>
        /// Returns a serializable representation of current DataPackage instance as a string
        /// </summary>
        /// <returns></returns>
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