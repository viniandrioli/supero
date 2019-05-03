//---------------------------------------------------------------------------------
// <copyright file="PessoaCredencial.cs" company="EEmovel">
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
	/// The PessoaCredencial model.
	/// </summary>
	public class PessoaCredencial
	{
		public PessoaCredencial()
		{
		}

		/// <summary>
		/// Gets or sets Pessoa id.
		/// </summary>
		public long PessoaId { get; set; }

		/// <summary>
		/// Gets or sets Senha.
		/// </summary>
		public string Senha { get; set; }

		/// <summary>
		/// Get or sets Data alteração.
		/// </summary>
		public DateTime DataAlteracao { get; set; }

		/// <summary>
		/// Gets or sets Suspenso.
		/// </summary>
		public bool Suspenso { get; set; }
	}
}
