//---------------------------------------------------------------------------------
// <copyright file="ExecutivoResumo.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.Reporting
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	/// <summary>
	/// The relatório executivo resumo model.
	/// </summary>
	public class ExecutivoResumo
	{
		/// <summary>
		/// Gets or sets imobiliaria.
		/// </summary>
		public string Imobiliaria {  get; set; }

		/// <summary>
		/// Gets or sets tipo imovel.
		/// </summary>
		public string TipoImovel { get; set; }

		/// <summary>
		/// Gets or sets total mes corrente.
		/// </summary>
		public int TotalApartamentosMesCorrente {  get; set; }

		/// <summary>
		/// Gets or sets total mes anterior.
		/// </summary>
		public int TotalApartamentosMesAnterior { get; set; }

		/// <summary>
		/// Gets or sets total mes corrente.
		/// </summary>
		public int TotalCasasMesCorrente { get; set; }

		/// <summary>
		/// Gets or sets total mes anterior.
		/// </summary>
		public int TotalCasasMesAnterior { get; set; }

		/// <summary>
		/// Gets or sets total mes corrente.
		/// </summary>
		public int TotalSobradosMesCorrente { get; set; }

		/// <summary>
		/// Gets or sets total mes anterior.
		/// </summary>
		public int TotalSobradosMesAnterior { get; set; }

		/// <summary>
		/// Gets or sets total mes corrente.
		/// </summary>
		public int TotalTerrenosMesCorrente { get; set; }

		/// <summary>
		/// Gets or sets total mes anterior.
		/// </summary>
		public int TotalTerrenosMesAnterior { get; set; }

		/// <summary>
		/// Gets or sets total geral mes corrente.
		/// </summary>
		public int TotalGeralApartamentosMesCorrente { get; set; }

		/// <summary>
		/// Gets or sets total geral mes anterior.
		/// </summary>
		public int TotalGeralApartamentosMesAnterior { get; set; }

		/// <summary>
		/// Gets or sets total geral mes corrente.
		/// </summary>
		public int TotalGeralCasasMesCorrente { get; set; }

		/// <summary>
		/// Gets or sets total geral mes anterior.
		/// </summary>
		public int TotalGeralCasasMesAnterior { get; set; }

		/// <summary>
		/// Gets or sets total geral mes corrente.
		/// </summary>
		public int TotalGeralSobradosMesCorrente { get; set; }

		/// <summary>
		/// Gets or sets total geral mes anterior.
		/// </summary>
		public int TotalGeralSobradosMesAnterior { get; set; }

		/// <summary>
		/// Gets or sets total geral mes corrente.
		/// </summary>
		public int TotalGeralTerrenosMesCorrente { get; set; }

		/// <summary>
		/// Gets or sets total geral mes anterior.
		/// </summary>
		public int TotalGeralTerrenosMesAnterior { get; set; }
	}
}
