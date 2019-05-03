//---------------------------------------------------------------------------------
// <copyright file="ImovelType.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.Enumerator
{
	/// <summary>
	/// Enumerator que define o tipo do imóvel.
	/// </summary>
	public enum ImovelType
	{
		/// <summary>
		/// Opção default.
		/// </summary>
		None = 0,

		Apartamento = 1,

		Casa = 2,

		Terreno = 3,

		Sobrado = 4,

		SalaComercial = 5,

		Barracao = 6
	}
}
