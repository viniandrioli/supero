//---------------------------------------------------------------------------------
// <copyright file="BairroResumo.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2017-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.ComplexType
{
	/// <summary>
	/// The bairro resumo model.
	/// </summary>
	public class BairroResumo
	{
		public int Id { get; set; }

		public string Nome { get; set; }

		public string PontosPoligono { get; set; }

		public long Quantidade { get; set; }

		public double ValorMedio { get; set; }

		public double ValorMetroMedio { get; set; }
	}
}
