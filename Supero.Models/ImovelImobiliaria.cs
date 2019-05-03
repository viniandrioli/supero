//---------------------------------------------------------------------------------
// <copyright file="ImovelImobiliaria.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	/// <summary>
	/// The ImovelImobiliaria model.
	/// </summary>
	public class ImovelImobiliaria
	{
		public ImovelImobiliaria()
		{

		}

		/// <summary>
		/// Gets or sets imobiliaria identifier.
		/// </summary>
		public int ImobiliariaId { get; set; }

		/// <summary>
		/// Gets or sets imovel identifier.
		/// </summary>
		public long ImovelId { get; set; }

		/// <summary>
		/// Gets or sets referencia.
		/// </summary>
		public string Referencia { get; set; }
	}
}
