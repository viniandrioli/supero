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
	public class Geometry
	{
		[BsonElement("type")]
		public string Type { get; set; }

		[BsonElement("coordinates")]
		public IEnumerable<Double> Coordinates { get; set; }
	}
}
