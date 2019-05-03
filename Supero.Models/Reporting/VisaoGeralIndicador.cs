//---------------------------------------------------------------------------------
// <copyright file="VisaoGeralIndicador.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.Reporting
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;

	/// <summary>
	/// Modelo de visao geral indicador.
	/// </summary>
	public class VisaoGeralIndicador
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public VisaoGeralIndicador() { }

		/// <summary>
		/// Gets or sets rotulo.
		/// </summary>
		public string NomeIndicador { get; set; }

		/// <summary>
		/// Gets or sets valor do mercado.
		/// </summary>
		public decimal ValorMercado { get; set; }

		/// <summary>
		/// Gets or sets valor imobiliária.
		/// </summary>
		public decimal ValorImobiliaria { get; set; }

		/// <summary>
		/// Gets or sets variação.
		/// </summary>
		public decimal Variacao { get; set; }

		/// <summary>
		/// Gets or sets ranking.
		/// </summary>
		public int Ranking { get; set; }
	}
}