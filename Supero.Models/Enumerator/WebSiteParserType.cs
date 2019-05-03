//---------------------------------------------------------------------------------
// <copyright file="WebSiteParserType.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.Enumerator
{
	/// <summary>
	/// Enumerator que define o tipo de parser de acordo com o website.
	/// </summary>
	public enum WebSiteParserType
	{
		/// <summary>
		/// Opção default.
		/// </summary>
		Default = 0,

		/// <summary>
		/// Imobiliaria Cidade.
		/// </summary>
		Cidade = 1,

		/// <summary>
		/// Imobiliaria Lokatell.
		/// </summary>
		Lokatell = 2
	}
}
