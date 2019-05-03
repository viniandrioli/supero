//---------------------------------------------------------------------------------
// <copyright file="OperationType.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.Enumerator
{
	/// <summary>
	/// Enumerator que define o tipo de negócio.
	/// </summary>
	public enum OperationType
	{
		/// <summary>
		/// Opção default.
		/// </summary>
		None = 0,

		Venda = 1,

		Locacao = 2
	}
}
