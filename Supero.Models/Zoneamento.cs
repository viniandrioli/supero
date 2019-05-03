using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class Zoneamento
    {
        public Zoneamento()
        {   
        }


		public int Id { get; set; }

        public string Nome { get; set; }

        public string Sigla { get; set; }

        public int CidadeId { get; set; }

        public string CA { get; set; }

        public string TO { get; set; }

        public string AlturaMaxima { get; set; }

        public string RecuoMin { get; set; }

        public string TaxaPermeab { get; set; }

        public string TestadaMin { get; set; }

        public string AreaMin { get; set; }

        public List<ZoneamentoEncode> Encodes { get; set; }
    }
}
