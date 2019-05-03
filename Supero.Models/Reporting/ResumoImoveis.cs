//---------------------------------------------------------------------------------
// <copyright file="ResumoImoveis.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2017-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.Reporting
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	/// <summary>
	/// The Resumo imoveis model.
	/// </summary>
	public class ResumoImoveis
	{
		/// <summary>
		/// Gets or sets tipo imovel.
		/// </summary>
		public string TipoImovel { get; set; }

		/// <summary>
		/// Gets or sets total venda.
		/// </summary>
		public int TotalVenda { get; set; }

		/// <summary>
		/// Gets or sets total locacao.
		/// </summary>
		public int TotalLocacao { get; set; }
	}
}
