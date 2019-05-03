using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Carrefour
{
	[BsonIgnoreExtraElements]
	public class EmpreendimentosCarrefour
	{
		[BsonId]
		public ObjectId ID { get; set; }

		[BsonElement("endereco")]
		public string Endereco { get; set; }

		[BsonElement("latitude")]
		public Double Latitude { get; set; }

		[BsonElement("longitude")]
		public Double Longitude { get; set; }

		[BsonElement("nome")]
		public string Nome { get; set; }

		[BsonElement("tipo")]
		public string tipo { get; set; }

		[BsonElement("avaliacao")]
		public string Avaliacao { get; set; }

		[BsonElement("location")]
		public PointGeometry Location { get; set; }
	}
}
