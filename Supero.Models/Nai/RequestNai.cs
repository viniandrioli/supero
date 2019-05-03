using Newtonsoft.Json;

namespace EEmovel.Data.Model.Nai
{
	public class RequestNai
	{
		[JsonProperty("tipo")]
		public string Tipo { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("building")]
		public string Building { get; set; }
	}
}
