using MongoDB.Bson.Serialization.Attributes;

namespace EEmovel.Data.Model.Nai
{

	[BsonIgnoreExtraElements]
	public class SetorCensitarioGeometry
	{
		[BsonElement("type")]
		public string Type { get; set; }

		[BsonElement("coordinates")]
		public double[][][][] Coordinates { get; set; }
	}
}
