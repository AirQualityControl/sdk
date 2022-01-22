using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AirSnitch.SDK.Internal
{
    internal class NewtonSoftJsonSerializer : ISerializer
    {
        public string Serialize(object target)
        {
            return JsonSerializer.Serialize(target, new JsonSerializerOptions()
            {
                IgnoreNullValues = true,
                PropertyNameCaseInsensitive = true,
            });
        }
    }
}