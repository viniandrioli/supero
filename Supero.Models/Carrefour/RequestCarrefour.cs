using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Carrefour
{
	public class RequestCarrefour
	{
		[JsonProperty("tipo")]
		public string Tipo { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("building")]
		public string Building { get; set; }

		[JsonProperty("Type")]
		public string Type { get; set; }

		[JsonProperty("Coordinates")]
		public double[] Coordinates { get; set; }
	}
}
