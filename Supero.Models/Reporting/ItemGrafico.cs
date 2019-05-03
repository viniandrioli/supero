//---------------------------------------------------------------------------------
// <copyright file="ItemGrafico.cs" company="EEmovel">
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
	/// Modelo de item do gráfico.
	/// </summary>
	public class ItemGrafico
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public ItemGrafico() { }

		/// <summary>
		/// Gets or sets nome indicador.
		/// </summary>
		public string NomeIndicador { get; set; }

		/// <summary>
		/// Gets or sets legenda.
		/// </summary>
		public string Legenda { get; set; }
	}
}