//---------------------------------------------------------------------------------
// <copyright file="ImovelCaracteristicaHistorico.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	using System;

	/// <summary>
	/// The Imovel caracteristica historico model.
	/// </summary>
	public class ImovelHistoricoAlteracao
	{
		public ImovelHistoricoAlteracao()
		{ }

		public long Id { get; set; }

		public long ImovelId { get; set; }

		public string TipoCaracteristica { get; set; }

		public string ValorAntigo { get; set; }

		public string ValorNovo { get; set; }

		public DateTime DataModificacao { get; set; }
	}
}
