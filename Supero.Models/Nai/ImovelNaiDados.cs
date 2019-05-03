using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace EEmovel.Data.Model.Nai
{
	[BsonIgnoreExtraElements]
	public class ImovelNaiDados
	{
		[BsonId]
		public ObjectId ID { get; set; }

		[BsonElement("Edificio")]
		public string Edificio { get; set; }

		[BsonElement("Endereco")]
		public string Endereco { get; set; }

		[BsonElement("Ocupante")]
		public string Ocupante { get; set; }

		[BsonElement("Numero")]
		public double? Numero { get; set; }

		[BsonElement("Idade")]
		public string Idade { get; set; }

		[BsonElement("ValorMetroSubmercado")]
		public string ValorMetroSubmercado { get; set; }

		[BsonElement("ValorMedioConstrucaoSubmercado")]
		public string ValorMedioConstrucaoSubmercado { get; set; }

		[BsonElement("Elevadores")]
		public string Elevadores { get; set; }

		[BsonElement("Garagem")]
		public string Garagem { get; set; }

		[BsonElement("Piso")]
		public string Piso { get; set; }

		[BsonElement("Variantes")]
		public IEnumerable<Variantes> Variantes { get; set; }
	}

}
