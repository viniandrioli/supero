//---------------------------------------------------------------------------------
// <copyright file="Endereco.cs" company="EEmovel">
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
	/// The Endereco model.
	/// </summary>
	public class Endereco
	{
		public Endereco()
		{
            this.Cidade = new Cidade();
        }

		/// <summary>
		/// Gets or sets id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets tipo objeto id.
		/// </summary>
		public int TipoObjetoId { get; set; }

		/// <summary>
		/// Gets or sets objeto id.
		/// </summary>
		public string ObjetoId { get; set; }

		/// <summary>
		/// Gets or sets logradouro.
		/// </summary>
		public string Logradouro { get; set; }

		/// <summary>
		/// Gets or sets numero.
		/// </summary>
		public string Numero { get; set; }

		/// <summary>
		/// Gets or sets complemento.
		/// </summary>
		public string Complemento { get; set; }

		/// <summary>
		/// Gets or sets cep.
		/// </summary>
		public string Cep { get; set; }

		/// <summary>
		/// Gets or sets bairro.
		/// </summary>
		public string Bairro { get; set; }

		/// <summary>
		/// Gets or sets cidade id.
		/// </summary>
		public int CidadeId { get; set; }

		/// <summary>
		/// Gets or sets cidades.
		/// </summary>
		public Cidade Cidade { get; set; }
	}
}
