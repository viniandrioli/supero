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
	public class Properties
	{
		[BsonElement("ID")]
		public int? ID { get; set; }

		[BsonElement("CD_GEOCODI")]
		public string CD_GEOCODI { get; set; }

		[BsonElement("TIPO")]
		public string TIPO { get; set; }

		[BsonElement("Nome do Proponente")]
		public string NomeDoProponente { get; set; }

		[BsonElement("Tipo de Servico")]
		public string TipoDeServico { get; set; }

		[BsonElement("Regional")]
		public string Regional { get; set; }

		[BsonElement("Bairro do Imovel")]
		public string BairroDoImovel { get; set; }

		[BsonElement("Cep Imovel")]
		public string CepImovel { get; set; }

		[BsonElement("Cidade do Imovel")]
		public string CidadeDoImovel { get; set; }

		[BsonElement("Estado do Imovel")]
		public string EstadoDoImovel { get; set; }

		[BsonElement("Concatenar")]
		public string Concatenar { get; set; }

		[BsonElement("Logradouro do Imovel")]
		public string LogradouroDoImovel { get; set; }

		[BsonElement("Numero do Imovel")]
		public string NumeroDoImovel { get; set; }

		[BsonElement("latitude imovel")]
		public Double LatitudeImovel { get; set; }

		[BsonElement("longitude imovel")]
		public Double LongitudeImovel { get; set; }

		[BsonElement("Subtipo de Imovel")]
		public string SubtipoDeImovel { get; set; }

		[BsonElement("Tipo de Cliente")]
		public string TipoDeCliente { get; set; }

		[BsonElement("Tipo de Imovel")]
		public string TipoDeImovel { get; set; }

		//Type cannot be identified (Value is null)
		[BsonElement("Valor de Locacao")]
		public object ValorDeLocacao { get; set; }

		[BsonElement("Valor Adotado")]
		public Double ValorAdotado { get; set; }

		[BsonElement("Valor Laudo Estudo")]
		public Double ValorLaudoEstudo { get; set; }
	}

}
