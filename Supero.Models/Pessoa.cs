//---------------------------------------------------------------------------------
// <copyright file="Pessoa.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	using EEmovel.Common.Enum;
using System;
using System.Collections;
using System.Collections.Generic;

	/// <summary>
	/// The Pessoa model.
	/// </summary>
	public class Pessoa
	{
		public Pessoa()
		{
			this.PessoaCredencial = new PessoaCredencial();
		}

		/// <summary>
		/// Gets or sets Id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets Nome.
		/// </summary>
		public string Nome { get; set; }

		/// <summary>
		/// Gets or sets Email.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets Sexo.
		/// </summary>
		public char Sexo { get; set; }

		/// <summary>
		/// Gets or sets data criação.
		/// </summary>
		public DateTime DataCriacao { get; set; }

		/// <summary>
		/// Gets or sets data atualização.
		/// </summary>
		public DateTime DataAtualizacao { get; set; }

		/// <summary>
		/// Gets or sets Status.
		/// </summary>
		public int Status { get; set; }

		/// <summary>
		/// Gets or sets Creci.
		/// </summary>
		public string Creci { get; set; }

		/// <summary>
		/// Gets or sets Cpf/Cnpj.
		/// </summary>
		public string CpfCnpj { get; set; }

		/// <summary>
		/// Gets or sets Imobiliaria identifier.
		/// </summary>
		public int? ImobiliariaId { get; set; }

		/// <summary>
		/// Gets or sets tipo perfil de usuário.
		/// </summary>
		public TipoPerfilUsuario TipoPerfil { get; set; }

        /// <summary>
        /// Gets or sets Hash de confirmacao de email.
        /// </summary>
        public string ValidacaoHash { get; set; }

        /// <summary>
        /// Gets or sets Id do gestor.
        /// </summary>
        public int? GestorId { get; set; }

        /// <summary>
        /// Gets or sets Telefone.
        /// </summary>
        public string Telefone { get; set; }

        public bool? Excluido { get; set; }

        public AssinaturaPessoa AssinaturaPessoa { get; set; }

        public PessoaCredencial PessoaCredencial { get; set; }

        public Endereco Endereco { get; set; }
	}
}
