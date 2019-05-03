using EEmovel.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
    public class FiltrosHeatMap
    {
        public string Cidade { get; set; }

        public TipoNegocio TipoNegocio { get; set; }

        public TipoImovel TipoImovel { get; set; }

        public int? Bairro { get; set; }

        public List<string> Caracteristicas { get; set; }

        public decimal? ValorInicial { get; set; }

        public decimal? ValorFinal { get; set; }

        public string Edificio { get; set; }

        public string PoligonoPontos { get; set; }

        public List<string> PoligonoPontosZoneamento { get; set; }

        public int Dias { get; set; }

        public TipoHeatMap TipoHeatMap { get; set; }
    }
}
