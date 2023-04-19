using Newtonsoft.Json;

namespace AirSnitch.SDK
{
	public class DataProviderInfo
	{
		[JsonProperty("id")]
		public string Tag { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("web-site")]
		public string Uri { get; set; }
	}
}