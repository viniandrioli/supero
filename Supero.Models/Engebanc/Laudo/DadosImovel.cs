using EEmovel.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc.Laudo
{
	public class DadosImovel
	{
        [ExcelMapAttribute("FORMULARIO", "E106")]
        public string TipoImovel { get; set; }
        [ExcelMapAttribute("FORMULARIO", "E108")]
        public string TipoImplantacao { get; set; }
        [ExcelMapAttribute("FORMULARIO", "E110")]
        public string PadraoAcabamento { get; set; }
        [ExcelMapAttribute("FORMULARIO", "E112")]
        public string EstadoConservacao { get; set; }
        [ExcelMapAttribute("FORMULARIO", "E114")]
        public string IdadeAparente { get; set; }
        [ExcelMapAttribute("FORMULARIO", "G106")]
        public string Estrutura { get; set; }
        [ExcelMapAttribute("FORMULARIO", "G108")]
        public string FechamentoParedes { get; set; }
        [ExcelMapAttribute("FORMULARIO", "G110")]
        public string Esquadrias { get; set; }
        [ExcelMapAttribute("FORMULARIO", "G112")]
        public string UsoImovel { get; set; }
        [ExcelMapAttribute("FORMULARIO", "G114")]
        public string NumeroPavimentos { get; set; }
	}
}
