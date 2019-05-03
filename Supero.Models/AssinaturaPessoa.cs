//---------------------------------------------------------------------------------
// <copyright file="AssinaturaPessoa.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

using System;
namespace EEmovel.Data.Model
{
	/// <summary>
	/// The AssinaturaPessoa model.
	/// </summary>
	public class AssinaturaPessoa
	{
		public AssinaturaPessoa()
		{

		}

		/// <summary>
		/// Gets or sets id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets pessoa id.
		/// </summary>
		public long PessoaId { get; set; }

		/// <summary>
		/// Gets or sets nome.
		/// </summary>
		public long AssinaturaId { get; set; }

		/// <summary>
		/// Gets or sets início vigência.
		/// </summary>
		public DateTime InicioVigencia { get; set; }

		/// <summary>
		/// Gets or sets final vigencia.
		/// </summary>
		public DateTime FinalVigencia { get; set; }

		/// <summary>
		/// Gets or sets situação.
		/// </summary>
		public int Situacao { get; set; }

		/// <summary>
		/// Gets or sets código de adesão.
		/// </summary>
		public string CodigoAdesao { get; set; }

        /// <summary>
		/// Gets or sets numero de contas.
		/// </summary>
        public int? NumeroConta { get; set; }

		/// <summary>
		/// Gets or sets percentual de desconto.
		/// </summary>
		public decimal? PercentualDesconto { get; set; }

        /// <summary>
        /// Gets or sets assinatura.
        /// </summary>
        public Assinatura Assinatura { get; set; }

		/// <summary>
		/// Gets or sets pessoa.
		/// </summary>
		public Pessoa Pessoa { get; set; }

		/// <summary>
		/// Gets or sets url de pagamento.
		/// </summary>
		public Uri UrlPagamento { get; set; }

		public AssinaturaPessoaPagamento AssinaturaPessoaPagamento { get; set; }
	}
}
