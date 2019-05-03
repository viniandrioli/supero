//---------------------------------------------------------------------------------
// <copyright file="BuscaResumo.cs" company="EEmovel">
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
	/// The Usuario model.
	/// </summary>
	public class BuscaResumo
	{
		/// <summary>
		/// Gets or sets total.
		/// </summary>
		public int Total { get; set; }

        public decimal ValorMedio { get; set; }

	    public decimal ValorMetroMedio { get; set; }

        public List<CoordenadaImovel> CoordenadasImoveis { get; set; } 
	}

	public class CoordenadaImovel
	{
		public long ImovelId { get; set; }
		public string Longitude { get; set; }
		public string Latitude { get; set; }
	}
}
