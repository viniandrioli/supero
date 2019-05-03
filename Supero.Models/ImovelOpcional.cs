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
	/// The ImovelOpcional categoria model.
	/// </summary>
	public class ImovelOpcional
	{
		public ImovelOpcional()
		{ }

		public int Id { get; set; }

		public string Opcional { get; set; }
	}
}
