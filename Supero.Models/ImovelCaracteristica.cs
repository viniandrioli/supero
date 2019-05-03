//---------------------------------------------------------------------------------
// <copyright file="ImovelCaracteristica.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	using System;

	/// <summary>
	/// The Imovel caracteristica model.
	/// </summary>
	public class ImovelCaracteristica
	{
		public ImovelCaracteristica()
		{ }

		/// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Gets or sets imovel identifier.
		/// </summary>
		public long ImovelId { get; set; }

		/// <summary>
		/// Gets or sets caracteristica tipo identifier.
		/// </summary>
		public int CaracteristicaTipoId { get; set; }

		/// <summary>
		/// Gets or sets valor.
		/// </summary>
		public string Valor { get; set; }
	}
}
