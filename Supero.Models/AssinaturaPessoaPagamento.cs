//---------------------------------------------------------------------------------
// <copyright file="AssinaturaPessoaPagamento.cs" company="EEmovel">
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
	/// The AssinaturaPessoaPagamento model.
	/// </summary>
	public class AssinaturaPessoaPagamento
	{
		public AssinaturaPessoaPagamento()
		{

		}

		/// <summary>
		/// Gets or sets id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets assinatura pessoa id.
		/// </summary>
		public long AssinaturaPessoaId { get; set; }

		/// <summary>
		/// Gets or sets data do pagamento.
		/// </summary>
		public DateTime DataPagamento { get; set; }

		/// <summary>
		/// Gets or sets data da captura.
		/// </summary>
		public DateTime DataCaptura { get; set; }

		/// <summary>
		/// Gets or sets situação.
		/// </summary>
		public int Situacao { get; set; }

		/// <summary>
		/// Gets or sets valor.
		/// </summary>
		public decimal Valor { get; set; }

		/// <summary>
		/// Gets or sets psp reference number.
		/// </summary>
		public string AdyenPspReference { get; set; }

		/// <summary>
		/// Gets or sets auth code.
		/// </summary>
		public string AdyenAuthCode { get; set; }

		/// <summary>
		/// Gets or sets result code.
		/// </summary>
		public string AdyenResultCode { get; set; }

		/// <summary>
		/// Gets or sets tipo do pagamento.
		/// </summary>
		public string TipoPagamento { get; set; }

		/// <summary>
		/// Gets or sets codigo da transação.
		/// </summary>
		public string CodigoTransacao { get; set; }

		/// <summary>
		/// Gets or sets status da transação.
		/// </summary>
		public string StatusTransacao { get; set; }

		/// <summary>
		/// Gets or sets assinatura pessoa object.
		/// </summary>
		public virtual AssinaturaPessoa AssinaturaPessoa { get; set; }
	}
}
