using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EEmovel.Data.Model.Nai
{
	public class Geometry
	{
		[JsonProperty("type")]
		[BsonElement("type")]
		public string Type { get; set; }

		[JsonProperty("coordinates")]
		[BsonElement("coordinates")]
		public IEnumerable<Double> coordinates { get; set; }
		
	}
}
