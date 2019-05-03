using EEmovel.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc.Laudo
{
	public class ElementosComparativos
	{
        public string IdComparativo { get; set; }
        public string ImovelNumComparativo { get; set; }
        public string ButtonImovelComparativo { get; set; }
        [ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 0)]
        public string ContatoImovelComparativo { get; set; }
        [ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 2)]
        public string EnderecoImovelComparativo { get; set; }
        [ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 3)]
        public string BairroImovelComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "M{0}", jumpLines: 3)]
        public string MunicipioComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "S{0}", jumpLines: 3)]
        public string UFComparativo { get; set; }
        [ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 6)]
        public string ClasseComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "K{0}", jumpLines: 6)]
        public string TipoComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "P{0}", jumpLines: 6)]
        public string PadraoComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 7)]
        public string IdadeComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "K{0}", jumpLines: 7)]
        public string IdadeReferencialComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "P{0}", jumpLines: 7)]
        public string ConservacaoComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 8)]
        public string FocComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "K{0}", jumpLines: 8)]
        public string IndiceLocalComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "P{0}", jumpLines: 8)]
        public string DormitorioComparativo { get; set; }
        [ExcelMapAttribute("PESQUISA", "S{0}", jumpLines: 8)]
        public string SuiteComparativo { get; set; }
        [ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 9)]
        public string ComentariosComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 11)]
        public string FatorOfertaComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "K{0}", jumpLines: 11)]
        public string ValorComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "R{0}", jumpLines: 11)]
        public string DataComparativo { get; set; }

        //SO TEM EM APARTAMENTO
		[ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 5)]
        public string AreaUtilComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "K{0}", jumpLines: 5)]
        public string VagasComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "P{0}", jumpLines: 5)]
        public string AndarComparativo { get; set; }

        //SO TEM EM CASA
		[ExcelMapAttribute("PESQUISA", "E{0}", jumpLines: 5)]
        public string AreaConstruidaComparativo { get; set; }
		[ExcelMapAttribute("PESQUISA", "K{0}", jumpLines: 5)]
        public string AreaTerrenoComparativo { get; set; }
    }
}
