using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
    public class FiltroBuscaLocalizacao
    {
        public int? bairro { get; set; }
        public int? areaTipo { get; set; }
        public int? imobiliariaId { get; set; }
        public decimal? valorInicial { get; set; }
        public decimal? valorFinal { get; set; }
        public decimal? areaInicial { get; set; }
        public decimal? areaFinal { get; set; }
        public List<string> caracteristicas { get; set; }
        public List<long> listaIds { get; set; }
        public string edificio { get; set; }
        public int dias { get; set; }
        public string PontosPoligono { get; set; }
    }
}
