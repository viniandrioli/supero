//---------------------------------------------------------------------------------
// <copyright file="EstatisticaPorLocalizacao.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.ComplexType
{
    /// <summary>
    /// Estatísticas gerais por localização.
    /// </summary>
    public class EstatisticaPorLocalizacao
    {
        public EstatisticaPorLocalizacao()
        { }

        /// <summary>
        /// Gets or sets id.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets nome.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Gets or sets volume.
        /// </summary>
        public int Volume { get; set; }

        /// <summary>
        /// Gets or sets valor metro medio.
        /// </summary>
        public decimal ValorMetroMedio { get; set; }

        /// <summary>
        /// Gets or sets valor medio.
        /// </summary>
        public decimal ValorMedio { get; set; }

        /// <summary>
        /// Gets or sets variação.
        /// </summary>
        public decimal Variacao { get; set; }
    }
}
