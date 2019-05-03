//---------------------------------------------------------------------------------
// <copyright file="ImovelClicksResumo.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2017-07-20</date>
//---------------------------------------------------------------------------------
namespace EEmovel.Data.Model.ComplexType
{
	public class ImovelClicksResumo
	{
		public long Id { get; set; }
		public string Imobiliaria { get; set; }
		public string TipoImovel { get; set; }
		public string TipoNegocio { get; set; }
		public string Bairro { get; set; }
		public decimal Valor { get; set; }
		public decimal Area { get; set; }
		public string Link { get; set; }
		public long Clicks { get; set; }
	}
}
