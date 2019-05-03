//---------------------------------------------------------------------------------
// <copyright file="Cidade.cs" company="EEmovel">
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
	/// The LoginAuditoria model.
	/// </summary>
	public class LoginAuditoria
	{
		public LoginAuditoria()
		{
		}

		/// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets pessoa identifier.
		/// </summary>
		public long PessoaId { get; set; }

		/// <summary>
		/// Gets or sets data.
		/// </summary>
		public DateTime Data { get; set; }
	}
}
