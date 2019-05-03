using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
    public class FiltroAvaliacao
    {
        public int Bairro { get; set; }
        public decimal AreaInicial { get; set; }
        public decimal AreaFinal { get; set; }
        public decimal Area { get; set; }
        public List<string> caracteristicas { get; set; }
        public List<long> listaIds { get; set; }
        public string PontosPoligono { get; set; }
    }
}
