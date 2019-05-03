using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EEmovel.Data.Model.Nai
{
	public class SetorCensitario
	{
		[BsonId]
		public ObjectId ID { get; set; }

		[BsonElement("RendaDomiciliarMedia2018")]
		public string RendaDomiciliarMedia2018 { get; set; }

		[BsonElement("DomiciliosAte1Salario")]
		public Double DomiciliosAte1Salario { get; set; }

		[BsonElement("DomiciliosAte2Salario")]
		public string DomiciliosAte2Salario { get; set; }

		[BsonElement("DomiciliosAte3Salario")]
		public string DomiciliosAte3Salario { get; set; }

		[BsonElement("DomiciliosAte5Salario")]
		public string DomiciliosAte5Salario { get; set; }

		[BsonElement("DomiciliosAte10Salario")]
		public string DomiciliosAte10Salario { get; set; }

		[BsonElement("DomiciliosMais10Salario")]
		public string DomiciliosMais10Salario { get; set; }

		[BsonElement("DomiciliosSemRenda")]
		public string DomiciliosSemRenda { get; set; }

		[BsonElement("RendaMediaPessoas2018")]
		public string RendaMediaPessoas2018 { get; set; }

		[BsonElement("PessoasAte1Salario")]
		public Double PessoasAte1Salario { get; set; }

		[BsonElement("Pessoas1a2Salario")]
		public string Pessoas1a2Salario { get; set; }

		[BsonElement("Pessoas2a3Salario")]
		public string Pessoas2a3Salario { get; set; }

		[BsonElement("Pessoas3a5Salario")]
		public string Pessoas3a5Salario { get; set; }

		[BsonElement("Pessoas5a10Salario")]
		public string Pessoas5a10Salario { get; set; }

		[BsonElement("Pessoas10a15Salario")]
		public string Pessoas10a15Salario { get; set; }

		[BsonElement("Pessoas15a20Salario")]
		public string Pessoas15a20Salario { get; set; }

		[BsonElement("PessoasMais20Salario")]
		public string PessoasMais20Salario { get; set; }

		[BsonElement("PessoasSemRenda")]
		public string PessoasSemRenda { get; set; }

		[BsonElement("Longevidade")]
		public Double Longevidade { get; set; }

		[BsonElement("Pessoas0a18Anos")]
		public Double Pessoas0a18Anos { get; set; }

		[BsonElement("Pessoas19a25Anos")]
		public Double Pessoas19a25Anos { get; set; }

		[BsonElement("Pessoas26a35Anos")]
		public Double Pessoas26a35Anos { get; set; }

		[BsonElement("Pessoas36a45Anos")]
		public Double Pessoas36a45Anos { get; set; }

		[BsonElement("Pessoas46a59Anos")]
		public Double Pessoas46a59Anos { get; set; }

		[BsonElement("PessoasMais60Anos")]
		public Double PessoasMais60Anos { get; set; }

		[BsonElement("Alfabetizacao")]
		public Double Alfabetizacao { get; set; }

		[BsonElement("Alfabetizados5a18Anos")]
		public Double Alfabetizados5a18Anos { get; set; }

		[BsonElement("Alfabetizados19a25Anos")]
		public Double Alfabetizados19a25Anos { get; set; }

		[BsonElement("Alfabetizados26a35Anos")]
		public Double Alfabetizados26a35Anos { get; set; }

		[BsonElement("Alfabetizados36a45Anos")]
		public Double Alfabetizados36a45Anos { get; set; }

		[BsonElement("Alfabetizados46a59Anos")]
		public Double Alfabetizados46a59Anos { get; set; }

		[BsonElement("AlfabetizadosMais60Anos")]
		public Double AlfabetizadosMais60Anos { get; set; }

		[BsonElement("TesteQ")]
		public Double TesteQ { get; set; }

		[BsonElement("NotaRegiao")]
		public string NotaRegiao { get; set; }

		[BsonElement("Distrito")]
		public string Distrito { get; set; }

		[BsonElement("geometry")]
		public SetorCensitarioGeometry Geometry { get; set; }
	}
}
