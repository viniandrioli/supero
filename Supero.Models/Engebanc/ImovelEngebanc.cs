using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebank
{
	[BsonIgnoreExtraElements]
	public class ImovelEngebanc
	{
		[BsonId]
		public ObjectId ID { get; set; }

		[BsonElement("type")]
		public string Type { get; set; }

		[BsonElement("properties")]
		public Properties Properties { get; set; }

		[BsonElement("geometry")]
		public Geometry Geometry { get; set; }
	}
}
