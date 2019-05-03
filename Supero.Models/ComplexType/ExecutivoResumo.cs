//---------------------------------------------------------------------------------
// <copyright file="ExecutivoResumo.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.ComplexType
{
	/// <summary>
	/// The relatório executivo resumo model.
	/// </summary>
	public class ExecutivoResumo
	{
		/// <summary>
		/// Gets or sets imobiliaria.
		/// </summary>
		public string Imobiliaria { get; set; }

		/// <summary>
		/// Gets or sets tipo imovel.
		/// </summary>
		public string TipoImovel { get; set; }

		/// <summary>
		/// Gets or sets total mes corrente.
		/// </summary>
		public int TotalMesCorrente { get; set; }

		/// <summary>
		/// Gets or sets total mes anterior.
		/// </summary>
		public int TotalMesAnterior { get; set; }
	}
}
