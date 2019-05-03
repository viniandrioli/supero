using EEmovel.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class Alerta
    {
        public Alerta()
        {

        }

        public int Id { get; set; }

        public long PessoaId { get; set; }

        public string Nome { get; set; }

        public int CidadeId { get; set; }

        public Cidade cidade {get; set;}

        public DateTime DataInclusao { get; set; }

        public DateTime DataAlerta { get; set; }

        public TipoNegocio TipoNegocio { get; set; }

        public TipoImovel TipoImovel { get; set; }

        public string TipoNegocioNome { get { return TipoNegocio.ToString(); } set { } }

		public List<string> TipoImovelNome
		{
			get
			{
				if (TipoImovelIds.Any())
				{
					return TipoImovelIds.Select(x => ((TipoImovel)int.Parse(x)).ToString()).ToList();
				}
				return null;
			}
			set
			{
			}
		}

        public string PontosPoligono { get; set; }

        public string ValorMinimo { get; set; }

        public string ValorMaximo { get; set; }

        public string Quarto { get; set; }

        public long Suite { get; set; }

        public string Garagem { get; set; }

        public string AreaMinima { get; set; }

        public string AreaMaxima { get; set; }

        public string TestadaMinima { get; set; }

        public string TestadaMaxima { get; set; }

        public string VariacaoMinima { get; set; }

        public string VariacaoMaxima { get; set; }

        public string Edificio { get; set; }

        public int? ImobiliariaId { get; set; }

        public bool? Ativo { get; set; }

        public bool? Alertado { get; set; }

        public bool? Excluido { get; set; }

        public bool? Lido { get; set; }

		public int? BairroId { get; set; }

		public int? ZoneamentoId { get; set; }

		public string Endereco { get; set; }

		public List<string> PontosPoligonoZoneamento { get; set; }

        public List<string> PontosMultiPoligono { get; set; }

        public List<string> OpcionaisIds { get; set; }

		public List<string> TipoImovelIds { get; set; }

		public bool? Particular { get; set; }
	}
}
