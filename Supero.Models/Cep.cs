using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class Cep
    {
        /// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public int CidadeId { get; set; }

        /// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public string Logradouro { get; set; }

        /// <summary>
        /// Gets or sets nome.
        /// </summary>
        public string CidadeNome { get; set; }

        /// <summary>
        /// Gets or sets EstadoId.
        /// </summary>
        public int EstadoId { get; set; }

        /// <summary>
        /// Gets or sets EstadoId.
        /// </summary>
        public string EstadoSigla { get; set; }

    }
}
