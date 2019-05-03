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
	public class PointGeometry
	{
		[BsonElement("type")]
		[JsonProperty("Type")]
		public string Type { get; set; }

		[BsonElement("coordinates")]
		[JsonProperty("Coordinates")]
		public double[] Coordinates { get; set; }
	}
}