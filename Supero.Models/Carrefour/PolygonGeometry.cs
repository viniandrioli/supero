using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Carrefour
{
	[BsonIgnoreExtraElements]
	public class PolygonGeometry
	{
		[BsonElement("type")]
		public string Type { get; set; }

		[BsonElement("coordinates")]
		public double[][][][] Coordinates { get; set; }
	}
}
