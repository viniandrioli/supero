//---------------------------------------------------------------------------------
// <copyright file="Imobiliaria.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	/// <summary>
	/// The Imobiliaria model.
	/// </summary>
	public class Imobiliaria
	{
		public Imobiliaria()
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

		/// <summary>
		/// Gets or sets razao social
		/// </summary>
		public string RazaoSocial { get; set; }

		/// <summary>
		/// Gets or sets Cnpj.
		/// </summary>
		public string Cnpj { get; set; }

		/// <summary>
		/// Gets or sets creci.
		/// </summary>
		public string Creci { get; set; }

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
		/// Gets or sets primary telefone.
		/// </summary>
		public string Telefone1 { get; set; }

		/// <summary>
		/// Gets or sets secundary telefone.
		/// </summary>
		public string Telefone2 { get; set; }

		/// <summary>
		/// Gets or sets website URL.
		/// </summary>
		public string WebsiteUrl { get; set; }

		/// <summary>
		/// Gets or sets cidade id.
		/// </summary>
		public int CidadeId { get; set; }
	}
}
