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
    public class ImoveisEngebanc2
    {
        [BsonId]
        public ObjectId ID { get; set; }

		[BsonElement("ID")]
		public long Id { get; set; }

        [BsonElement("Planilha cidade sp_Rme Dom 2018")]
        public string RendaMediaDom { get; set; }

        [BsonElement("Planilha cidade sp_Rme Pessoas 2018")]
        public string RendaMediaPessoas { get; set; }

        [BsonElement("Planilha cidade sp Nota SC")]
        public string NotaSc { get; set; }


    }
}
