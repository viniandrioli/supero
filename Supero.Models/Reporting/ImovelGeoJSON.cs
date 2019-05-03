using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Reporting
{
    public class ImovelGeoJSON
    {
        /// <summary>
		/// Constructor.
		/// </summary>
		public ImovelGeoJSON() { }

        /// <summary>
        /// Gets or sets código do imóvel.
        /// </summary>
        public long Id { get; set; }

        public string geo { get; set; }
    }
}
