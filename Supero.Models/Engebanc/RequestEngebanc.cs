using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc
{
	public class RequestEngebanc
	{
		public string type { get; set; }
		public ObjectId Id { get; set; }
	}
}
