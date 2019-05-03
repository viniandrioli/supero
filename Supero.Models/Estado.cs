//---------------------------------------------------------------------------------
// <copyright file="Estado.cs" company="EEmovel">
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
	/// The Estado model.
	/// </summary>
	public class Estado
	{
		public Estado()
		{
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
		/// Gets or sets UF.
		/// </summary>
		public string UF { get; set; }

		/// <summary>
		/// Gets or sets cidades.
		/// </summary>
		public IEnumerable<Cidade> Cidades { get; set; }
	}
}
