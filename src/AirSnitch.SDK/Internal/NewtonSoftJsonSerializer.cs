using System.Text.Json;
using Newtonsoft.Json;

namespace AirSnitch.SDK.Internal
{
    internal class NewtonSoftJsonSerializer : ISerializer
    {
        public string Serialize(object target)
        {
            return JsonConvert.SerializeObject(target);
        }
    }
}