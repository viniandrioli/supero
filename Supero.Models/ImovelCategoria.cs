//---------------------------------------------------------------------------------
// <copyright file="ImovelCategoria.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	/// <summary>
	/// The Imovel categoria model.
	/// </summary>
	public class ImovelCategoria
	{
		public ImovelCategoria()
		{ }

		/// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets nome.
		/// </summary>
		public string Nome { get; set; }
	}
}
