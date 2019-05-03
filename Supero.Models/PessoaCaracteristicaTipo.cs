//---------------------------------------------------------------------------------
// <copyright file="PessoaCaracteristicaTipo.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2017-05-20</date>
//---------------------------------------------------------------------------------
namespace EEmovel.Data.Model
{
	/// <summary>
	/// The Pessoa caracteristica tipo model.
	/// </summary>
	public class PessoaCaracteristicaTipo
	{
		public PessoaCaracteristicaTipo()
		{ }

		/// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets nome.
		/// </summary>
		public string Nome { get; set; }

		/// <summary>
		/// Gets or sets tipo dado.
		/// </summary>
		public string TipoDado { get; set; }

		/// <summary>
		/// Gets or sets valor default.
		/// </summary>
		public string ValorDefault { get; set; }

		/// <summary>
		/// Gets or sets nome amigavel.
		/// </summary>
		public string NomeAmigavel { get; set; }
	}
}
