//---------------------------------------------------------------------------------
// <copyright file="Assinatura.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	/// <summary>
	/// The Assinatura model.
	/// </summary>
	public class Assinatura
	{
		public Assinatura()
		{

		}

		/// <summary>
		/// Gets or sets id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets nome.
		/// </summary>
		public string Nome { get; set; }

        /// <summary>
		/// Gets or sets descricao.
		/// </summary>
        public string Descricao { get; set; }

		/// <summary>
		/// Gets or sets valor.
		/// </summary>
		public decimal Valor { get; set; }

		/// <summary>
		/// Gets or sets vigencia.
		/// </summary>
		public int Vigencia { get; set; }

		/// <summary>
		/// Gets or sets assinatura tipo id.
		/// </summary>
		public int AssinaturaTipoId { get; set; }

		/// <summary>
		/// Gets or sets situacao.
		/// </summary>
		public int Situacao { get; set; }

		/// <summary>
		/// Gets or sets Codigo Integracao.
		/// </summary>
		public string CodigoIntegracao { get; set; }

        /// <summary>
		/// Gets or sets Limite de Pesquisa de Moradores.
		/// </summary>
        public int LimitePesquisaMoradores { get; set; }

        /// <summary>
        /// Gets or sets assinatura tipo.
        /// </summary>
        public AssinaturaTipo AssinaturaTipo { get; set;}
	}
}
