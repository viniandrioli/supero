using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Nai
{
	[BsonIgnoreExtraElements]
	public class EdificioNai
	{
		[BsonId]
		public ObjectId ID { get; set; }

		[BsonElement("ID")]
		public string EdificioID { get; set; }

		[BsonElement("Edificio")]
		public string Edificio { get; set; }

		[BsonElement("Submercado")]
		public string Submercado { get; set; }

		[BsonElement("Classe")]
		public string Classe { get; set; }

		[BsonElement("Segmento")]
		public string Segmento { get; set; }

		[BsonElement("AnoEntrega")]
		public string AnoEntrega { get; set; }

		[BsonElement("TrimestreEntrega")]
		public string TrimestreEntrega { get; set; }

		[BsonElement("DataCriacao")]
		public DateTime DataCriacao { get; set; }

		[BsonElement("Unidades")]
		public IEnumerable<UnidadesEdificio> Unidades { get; set; }

	}
}
