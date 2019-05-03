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
	public class SetorCensitarioCarrefour
	{
		[BsonId]
		public ObjectId ID { get; set; }

		[BsonElement("Id")]
		public Double Id { get; set; }

		[BsonElement("CdGeocodi")]
		public Int64 CdGeocodi { get; set; }

		[BsonElement("RendaMediaDomicilio2018")]
		public string RendaMediaDomicilio2018 { get; set; }

		[BsonElement("DomicilioAte1Salario")]
		public Double DomicilioAte1Salario { get; set; }

		[BsonElement("DomiciliosAte2Salarios")]
		public string DomiciliosAte2Salarios { get; set; }

		[BsonElement("DomicilioAte3Salarios")]
		public string DomicilioAte3Salarios { get; set; }

		[BsonElement("DomiciliosAte5Salarios")]
		public string DomiciliosAte5Salarios { get; set; }

		[BsonElement("DomiciliosAte10Salarios")]
		public string DomiciliosAte10Salarios { get; set; }

		[BsonElement("DomiciliosComMaisDe10Salarios")]
		public string DomiciliosComMaisDe10Salarios { get; set; }

		[BsonElement("DomiciliosPessoasSemRenda")]
		public string DomiciliosPessoasSemRenda { get; set; }

		[BsonElement("RendaMediaPessoas2018")]
		public string RendaMediaPessoas2018 { get; set; }

		[BsonElement("PessoasComAte1Salario")]
		public Double PessoasComAte1Salario { get; set; }

		[BsonElement("PessoasEntre1E2Salarios")]
		public string PessoasEntre1E2Salarios { get; set; }

		[BsonElement("PessoasEntre2E3Salarios")]
		public string PessoasEntre2E3Salarios { get; set; }

		[BsonElement("PessoasEntre3E5Salarios")]
		public string PessoasEntre3E5Salarios { get; set; }

		[BsonElement("PessoasEntre5E10Salarios")]
		public string PessoasEntre5E10Salarios { get; set; }

		[BsonElement("PessoasEntre10E15Salarios")]
		public string PessoasEntre10E15Salarios { get; set; }

		[BsonElement("PessoasEntre15E20Salarios")]
		public string PessoasEntre15E20Salarios { get; set; }

		[BsonElement("PessoasComMaisDe20Salarios")]
		public string PessoasComMaisDe20Salarios { get; set; }

		[BsonElement("PessoasSemRenda")]
		public string PessoasSemRenda { get; set; }

		[BsonElement("IndividuosDependentes0A18Anos")]
		public Double IndividuosDependentes0A18Anos { get; set; }

		[BsonElement("IndividuosEntre19A25Anos")]
		public Double IndividuosEntre19A25Anos { get; set; }

		[BsonElement("IndividuosEntre26A35Anos")]
		public Double IndividuosEntre26A35Anos { get; set; }

		[BsonElement("IndividuosEntre36A45Anos")]
		public Double IndividuosEntre36A45Anos { get; set; }

		[BsonElement("IndividuosEntre46A59Anos")]
		public Double IndividuosEntre46A59Anos { get; set; }

		[BsonElement("IndividuosComMaisDe60Anos")]
		public Double IndividuosComMaisDe60Anos { get; set; }

		[BsonElement("NotaDoSetorCensitarios")]
		public string NotaDoSetorCensitarios { get; set; }

		[BsonElement("Distrito")]
		public string Distrito { get; set; }

		[BsonElement("geometry")]
		public PolygonGeometry Geometry { get; set; }
	}
}
