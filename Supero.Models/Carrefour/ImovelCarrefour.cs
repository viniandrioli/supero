using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Carrefour
{
	[BsonIgnoreExtraElements]
	public class ImovelCarrefour
	{
		[BsonId]
		public ObjectId ID { get; set; }

		[BsonElement("CPF/CNPJ")]
		public string Documento { get; set; }

		[BsonElement("NomeProprietario")]
		public string NomeProprietario { get; set; }

		[BsonElement("Email")]
		public string Email { get; set; }

		[BsonElement("Telefone")]
		public string Telefone { get; set; }

		[BsonElement("Valor")]
		public string Valor { get; set; }

		[BsonElement("ValorM2Util")]
		public string ValorM2Util { get; set; }

		[BsonElement("AreaTotal")]
		public string AreaTotal { get; set; }

		[BsonElement("AreaUtil")]
		public string AreaUtil { get; set; }

		[BsonElement("Bairro")]
		public string Bairro { get; set; }

		[BsonElement("CEP")]
		public string CEP { get; set; }

		[BsonElement("DataAnuncio")]
		public string DataAnuncio { get; set; }

		[BsonElement("Endereco")]
		public string Endereco { get; set; }

		[BsonElement("Garagem")]
		public string Garagem { get; set; }

		[BsonElement("Imobiliaria")]
		public string Imobiliaria { get; set; }

		[BsonElement("TipoDeImovel")]
		public string TipoDeImovel { get; set; }

		[BsonElement("TipoDeTransacao")]
		public string TipoDeTransacao { get; set; }

		[BsonElement("Quarto")]
		public string Quarto { get; set; }

		[BsonElement("ValorM2Total")]
		public string ValorM2Total { get; set; }

		[BsonElement("Link")]
		public string Link { get; set; }

		[BsonElement("StatusGeo")]
		public Int32 StatusGeo { get; set; }

		[BsonElement("Latitude")]
		public string Latitude { get; set; }

		[BsonElement("Longitude")]
		public string Longitude { get; set; }

		[BsonElement("location")]
		public PointGeometry Location { get; set; }

		[BsonElement("SetorCensitarioId")]
		public ObjectId SetorCensitarioId { get; set; }

		public List<EmpreendimentosCarrefour> PontosDeInteresse { get; set; }
	}
}
