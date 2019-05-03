//---------------------------------------------------------------------------------
// <copyright file="Usuario.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

using EEmovel.Common.Enum;

namespace EEmovel.Data.Model
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	/// <summary>
	/// The Usuario model.
	/// </summary>
	public class Usuario
	{
		public Usuario()
		{
		}

		/// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets nome.
		/// </summary>
		public string Nome { get; set; }
		
		// TODO: remover essa propriedade.
		/// <summary>
		/// Gets or sets login.
		/// </summary>
		public string Login { get; set; }

		/// <summary>
		/// Gets or sets email.
		/// </summary>
		public string Email { get; set;}

		/// <summary>
		/// Gets or sets confirmar email.
		/// </summary>
		public string ConfirmarEmail { get; set;}

		/// <summary>
		/// Gets or sets senha.
		/// </summary>
		public string Senha { get; set; }

		/// <summary>
		/// Gets or sets confirmar senha.
		/// </summary>
		public string ConfirmarSenha { get; set;}

		/// <summary>
		/// Gets or sets creci.
		/// </summary>
		public string Creci { get; set; }

		/// <summary>
		/// Gets or sets imobiliaria identifier.
		/// </summary>
		public int? ImobiliariaId { get; set; }

		/// <summary>
		/// Gets or sets imobiliaria.
		/// </summary>
		public string Imobiliaria { get; set; }

		// TODO: remover essa propriedade
		/// <summary>
		/// Gets or sets Investidor flag.
		/// </summary>
		public bool Investidor { get; set; }

		/// <summary>
		/// Gets or sets cpf ou cnpj.
		/// </summary>
		public string CpfCnpj { get; set; }

		/// <summary>
		/// Gets or sets endereço.
		/// </summary>
		public string Endereco { get; set; }

		/// <summary>
		/// Gets or sets número.
		/// </summary>
		public string Numero { get; set; }

		/// <summary>
		/// Gets or sets complemento.
		/// </summary>
		public string Complemento { get; set; }

		/// <summary>
		/// Gets or sets bairro.
		/// </summary>
		public string Bairro { get; set; }

		/// <summary>
		/// Gets or sets cep.
		/// </summary>
		public string Cep { get; set; }

		/// <summary>
		/// Gets or sets cidade id.
		/// </summary>
		public int CidadeId { get; set; }

        /// <summary>
		/// Gets or sets estado id.
		/// </summary>
		public int EstadoId { get; set; }

        /// <summary>
		/// Gets or sets Id Gestor.
		/// </summary>
        public int GestorId { get; set; }

        /// <summary>
        /// Gets or sets telefone;
        /// </summary>
        public string Telefone { get; set; }

		/// <summary>
		/// Gets or sets cidade;
		/// </summary>
		public string Cidade { get; set; }

		/// <summary>
		/// Gets or sets estado;
		/// </summary>
		public string Estado { get; set; }

        public TipoPerfilUsuario TipoPerfil { get; set; }
    }
}
