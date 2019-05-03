//---------------------------------------------------------------------------------
// <copyright file="Grafico.cs" company="EEmovel">
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
	/// Modelo de gráfico.
	/// </summary>
	public class Grafico
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public Grafico() { }

		/// <summary>
		/// Gets or sets titulo.
		/// </summary>
		public string Titulo { get; set; }

		/// <summary>
		/// Gets or sets item grafico X.
		/// </summary>
		public ItemGrafico ItemGraficoX { get; set; }

		/// <summary>
		/// Gets or sets item grafico Y.
		/// </summary>
		public ItemGrafico ItemGraficoY { get; set; }

		/// <summary>
		/// Gets or sets itens.
		/// </summary>
		public IEnumerable<EstatisticasGrafico> Itens { get; set; }
	}
}