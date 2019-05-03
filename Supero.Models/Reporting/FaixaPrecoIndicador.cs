//---------------------------------------------------------------------------------
// <copyright file="FaixaPrecoIndicador.cs" company="EEmovel">
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
	/// Modelo de faixa preço indicador.
	/// </summary>
	public class FaixaPrecoIndicador
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public FaixaPrecoIndicador() { }

		/// <summary>
		/// Gets or sets nome indicador.
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
		/// Gets or sets volume do mercado.
		/// </summary>
		public int VolumeMercado { get; set; }

		/// <summary>
		/// Gets or sets volume imobiliária.
		/// </summary>
		public int VolumeImobiliaria { get; set; }

		/// <summary>
		/// Gets or sets volume participação.
		/// </summary>
		public decimal VolumeParticipacao { get; set; }

		/// <summary>
		/// Gets or sets Ranking.
		/// </summary>
		public int Ranking { get; set; }
	}
}