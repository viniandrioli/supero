using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace EEmovel.Data.Model.Nai
{
	public class ImovelNai
	{

		[BsonId]
		[JsonProperty("_id")]
		public ObjectId Id { get; set; }

		[JsonProperty("Nome")]
		[BsonElement("Nome")]
		public string Nome { get; set; }

		[JsonProperty("Tipo")]
		[BsonElement("Tipo")]
		public string Tipo { get; set; }

		[BsonElement("geometry")]
		[JsonProperty("geometry")]
		public Geometry Geometry { get; set; }

		[BsonElement("SetorCensitarioId")]
		[JsonProperty("SetorCensitarioId")]
		public ObjectId SetorCensitarioId { get; set; }
	}
}
