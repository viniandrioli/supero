using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EEmovel.Data.Model.Carrefour
{
	public class TerrenosCarrefour
	{
		[BsonId]
		public ObjectId ID { get; set; }

		[BsonElement("Endereco")]
		public string Endereco { get; set; }

		[BsonElement("AreaTerreno")]
		public string AreaTerreno { get; set; }

		[BsonElement("Bairro")]
		public string Bairro { get; set; }

		[BsonElement("CEP")]
		public string CEP { get; set; }

		[BsonElement("Latitude")]
		public string Latitude { get; set; }

		[BsonElement("Longitude")]
		public string Longitude { get; set; }

		[BsonElement("NomeProprietario")]
		public string NomeProprietario { get; set; }

		[BsonElement("TipoPessoa")]
		public string TipoPessoa { get; set; }

		[BsonElement("TipoDeImovel")]
		public string TipoDeImovel { get; set; }

		[BsonElement("location")]
		public PointGeometry Location { get; set; }

		[BsonElement("SetorCensitarioId")]
		public ObjectId SetorCensitarioId { get; set; }

		[BsonElement("CPF/CNPJ")]
		public string Documento { get; set; }

		[BsonElement("Email")]
		public string Email { get; set; }

		[BsonElement("Telefone")]
		public string Telefone { get; set; }
	}
}