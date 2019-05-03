using EEmovel.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
	public class FiltroBusca
	{
		public int Bairro { get; set; }
        public bool IsConstrutora { get; set; }
        public int ImobiliariaId { get; set; }
        public decimal? ValorInicial { get; set; }
		public decimal? ValorFinal { get; set; }
		public List<string> Caracteristicas { get; set; }
		public string Edificio { get; set; }
		public string PoligonoPontos { get; set; }
        public List<string> PoligonoPontosZoneamento { get; set; }
        public int Pagina { get; set; }
		public int Quantidade { get; set; }
        public List<long> listaIds { get; set; }
        public TipoOrdenacao TipoOrdenacao { get; set;}

		public string Latitude { get; set; }

		public string Longitude { get; set; }
        public string Referencia { get; set; }
		public bool IsParticular { get; set; }
		public List<int> OpcionaisIds { get; set; }
        public int StatusEndereco { get; set; }
    }
}
