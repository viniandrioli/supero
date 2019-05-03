//---------------------------------------------------------------------------------
// <copyright file="ImovelFotos.cs" company="EEmovel">
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
	/// The Imovel fotos model.
	/// </summary>
	public class ImovelFotos
	{
		public ImovelFotos()
		{ }

		/// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets imovel identifier.
		/// </summary>
		public long ImovelId { get; set; }

		/// <summary>
		/// Gets or sets URL.
		/// </summary>
		public string Url { get; set; }
	}
}
