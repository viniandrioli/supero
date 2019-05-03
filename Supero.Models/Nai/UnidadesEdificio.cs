using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Nai
{
	[BsonIgnoreExtraElements]
	public class UnidadesEdificio
	{
		[BsonElement("Unidade")]
		public string Unidade { get; set; }

		[BsonElement("Andar")]
		public string Andar { get; set; }

		[BsonElement("AreaLocavel1Tri2018")]
		public string AreaLocavel1Tri2018 { get; set; }

		[BsonElement("AreaLocavel2Tri2018")]
		public string AreaLocavel2Tri2018 { get; set; }

		[BsonElement("AreaLocavel3Tri2018")]
		public string AreaLocavel3Tri2018 { get; set; }

		[BsonElement("AreaLocavel4Tri2018")]
		public string AreaLocavel4Tri2018 { get; set; }

		[BsonElement("AreaDisopnivel1Tri2018")]
		public string AreaDisopnivel1Tri2018 { get; set; }

		[BsonElement("AreaDisopnivel2Tri2018")]
		public string AreaDisopnivel2Tri2018 { get; set; }

		[BsonElement("AreaDisopnivel3Tri2018")]
		public string AreaDisopnivel3Tri2018 { get; set; }

		[BsonElement("AreaDisopnivel4Tri2018")]
		public string AreaDisopnivel4Tri2018 { get; set; }

		[BsonElement("AbsorcaoLiquida1Tri2018")]
		public string AbsorcaoLiquida1Tri2018 { get; set; }

		[BsonElement("AbsorcaoLiquida2Tri2018")]
		public string AbsorcaoLiquida2Tri2018 { get; set; }

		[BsonElement("AbsorcaoLiquida3Tri2018")]
		public string AbsorcaoLiquida3Tri2018 { get; set; }

		[BsonElement("AbsorcaoLiquida4Tri2018")]
		public string AbsorcaoLiquida4Tri2018 { get; set; }

		[BsonElement("AbsorcaoBruta1Tri2018")]
		public string AbsorcaoBruta1Tri2018 { get; set; }

		[BsonElement("AbsorcaoBruta2Tri2018")]
		public string AbsorcaoBruta2Tri2018 { get; set; }

		[BsonElement("AbsorcaoBruta3Tri2018")]
		public string AbsorcaoBruta3Tri2018 { get; set; }

		[BsonElement("AbsorcaoBruta4Tri2018")]
		public string AbsorcaoBruta4Tri2018 { get; set; }

		[BsonElement("Preco1Tri2018")]
		public string Preco1Tri2018 { get; set; }

		[BsonElement("Preco2Tri2018")]
		public string Preco2Tri2018 { get; set; }

		[BsonElement("Preco3Tri2018")]
		public string Preco3Tri2018 { get; set; }

		[BsonElement("Preco4Tri2018")]
		public string Preco4Tri2018 { get; set; }

		[BsonElement("Condominio1Tri2018")]
		public string Condominio1Tri2018 { get; set; }

		[BsonElement("Condominio2Tri2018")]
		public string Condominio2Tri2018 { get; set; }

		[BsonElement("Condominio3Tri2018")]
		public string Condominio3Tri2018 { get; set; }

		[BsonElement("Condominio4Tri2018")]
		public string Condominio4Tri2018 { get; set; }

		[BsonElement("IPTU1Tri2018")]
		public string IPTU1Tri2018 { get; set; }

		[BsonElement("IPTU2Tri2018")]
		public string IPTU2Tri2018 { get; set; }

		[BsonElement("IPTU3Tri2018")]
		public string IPTU3Tri2018 { get; set; }

		[BsonElement("IPTU4Tri2018")]
		public string IPTU4Tri2018 { get; set; }

		[BsonElement("PrecoTotal1Tri2018")]
		public string PrecoTotal1Tri2018 { get; set; }

		[BsonElement("PrecoTotal2Tri2018")]
		public string PrecoTotal2Tri2018 { get; set; }

		[BsonElement("PrecoTotal3Tri2018")]
		public string PrecoTotal3Tri2018 { get; set; }

		[BsonElement("PrecoTotal4Tri2018")]
		public string PrecoTotal4Tri2018 { get; set; }

		[BsonElement("CategoriaUso")]
		public string CategoriaUso { get; set; }

		[BsonElement("Proprietario3Tri2018")]
		public string Proprietario3Tri2018 { get; set; }

		[BsonElement("TipoProprietario3Tri2018")]
		public string TipoProprietario3Tri2018 { get; set; }
	}
}
