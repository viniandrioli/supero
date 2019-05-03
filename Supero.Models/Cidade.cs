//---------------------------------------------------------------------------------
// <copyright file="Cidade.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	/// <summary>
	/// The Cidade model.
	/// </summary>
	public class Cidade
	{
		public Cidade()
		{
            this.Estado = new Estado();
        }

		/// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets nome.
		/// </summary>
		public string Nome { get; set; }
		
		/// <summary>
		/// Gets or sets EstadoId.
		/// </summary>
		public int EstadoId { get; set; }

        /// <summary>
        /// Gets or sets Estados.
        /// </summary>
        public Estado Estado { get; set; }

        /// <summary>
        /// Gets or sets Ponto Central Latitude.
        /// </summary>
        public decimal? PontoCentralLatitude{ get; set; }

        /// <summary>
        /// Gets or sets Ponto Central Longitude.
        /// </summary>
        public decimal? PontoCentralLongitude { get; set; }

        public string BoundBox { get; set; }
    }
}
