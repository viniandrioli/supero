//---------------------------------------------------------------------------------
// <copyright file="AssinaturaDescontoConfig.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2017-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	/// <summary>
	/// The AssinaturaDescontoConfig model.
	/// </summary>
	public class AssinaturaDescontoConfig
	{
		public AssinaturaDescontoConfig()
		{

		}

		public long Id { get; set; }

		public long AssinaturaId { get; set; }

		public int IntervaloInicial { get; set; }

		public int IntervaloFinal { get; set; }

		public decimal ValorDesconto { get; set; }

		public string Codigo { get; set; }

		public int? ImobiliariaId { get; set; }

		public virtual Assinatura Assinatura { get; set; }
	}
}
