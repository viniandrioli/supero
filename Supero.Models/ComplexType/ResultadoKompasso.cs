using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
    
    public class ResultadoKompasso
    {

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

        public GeoJSON Geojson { get; set; }
    }
}
