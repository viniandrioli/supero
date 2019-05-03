//---------------------------------------------------------------------------------
// <copyright file="Imovel.cs" company="EEmovel">
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
	/// Modelo de Imovel.
	/// </summary>
	public class Imobiliaria
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public Imobiliaria() { }

		/// <summary>
		/// Gets or sets código da imobiliária.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets imobiliaria.
		/// </summary>
		public string Nome { get; set; }
	}
}