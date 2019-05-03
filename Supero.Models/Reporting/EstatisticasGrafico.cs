//---------------------------------------------------------------------------------
// <copyright file="EstatisticasGrafico.cs" company="EEmovel">
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
	/// Modelo de estatísticas do gráfico.
	/// </summary>
	public class EstatisticasGrafico
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public EstatisticasGrafico() { }

		/// <summary>
		/// Gets or sets rotulo.
		/// </summary>
		public int Posicao { get; set; }

		/// <summary>
		/// Gets or sets rotulo.
		/// </summary>
		public string Rotulo { get; set; }

		/// <summary>
		/// Gets or sets valor 1.
		/// </summary>
		public decimal Valor1 { get; set; }

		/// <summary>
		/// Gets or sets valor 2.
		/// </summary>
		public decimal Valor2 { get; set; }
	}
}