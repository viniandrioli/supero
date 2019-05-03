using MongoDB.Bson.Serialization.Attributes;

namespace EEmovel.Data.Model.Nai
{
	[BsonIgnoreExtraElements]
	public class Variantes
	{
		[BsonElement("Unidade")]
		public string Unidade { get; set; }

		[BsonElement("UsoUnidade")]
		public string UsoUnidade { get; set; }

		[BsonElement("Andares")]
		public string Andares { get; set; }

		[BsonElement("AreaLocavelPorAndar")]
		public string AreaLocavelPorAndar { get; set; }
	}
}
