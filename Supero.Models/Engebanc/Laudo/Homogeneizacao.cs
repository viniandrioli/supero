using EEmovel.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc.Laudo
{
	public class Homogeneizacao
	{
        public string EnderecoHg { get; set; }
        public string BairroHg { get; set; }
        public string CidadeHg { get; set; }
        public string UFHg { get; set; }
        public string ClasseHg { get; set; }
		[ExcelMapAttribute("Homogeneização", "U9")]
        public string TipoHg { get; set; }
		[ExcelMapAttribute("Homogeneização", "AC9")]
        public string PadraoHg { get; set; }
        public string AreaUtilHg { get; set; }
        public string VagasGaragemHg { get; set; }
        public string IdadeHg { get; set; }
        public string IdadeReferencialHg { get; set; }
		[ExcelMapAttribute("Homogeneização", "G15")]
        public string IndiceLocalHg { get; set; }
		[ExcelMapAttribute("Homogeneização", "X15")]
        public string FocHg { get; set; }

        public string IntervaloConfHg { get; set; }
        public string GrauPrecisaoHg { get; set; }
        public string GrauFundamentacaoHg { get; set; }
        public string MediaAritmetica { get; set; }
        public string LimiteSuperior { get; set; }
        public string LimiteInferior { get; set; }
        public string MediaSaneada { get; set; }
        public string DesvioPadrao { get; set; }
        public string CoeficienteVariacao { get; set; }
        public string TotalElementosSaneados { get; set; }
		[ExcelMapAttribute("Homogeneização", "AH42")]
        public string TdeStudent { get; set; }
        public string PorcSuperior { get; set; }
        public string SuperiorRS { get; set; }
        public string PorcInferior { get; set; }
        public string InferiorRS { get; set; }
        public string ValorTotalHg { get; set; }
		[ExcelMapAttribute("Homogeneização", "G53")]
        public string ConstrucaoAvaliatorio { get; set; }
		[ExcelMapAttribute("Homogeneização", "L53")]
        public string M2Avaliatorio { get; set; }
        public string InputAvaliatorio { get; set; }
        public string FocAvaliatorio { get; set; }
        public string TotalAvaliatorio { get; set; }
		[ExcelMapAttribute("Homogeneização", "G14")]
        public string ConservacaoHg { get; set; }

        //SÓ CONTÉM EM CASA
//TABELA DA HOMOGENIZACAO        [ExcelMapAttribute("HOMOGENIZACAO", "X24",5)]
        //public string FterrHg { get; set; }
		[ExcelMapAttribute("Homogeneização", "G58")]
        public string TerrenoValorAvaliatorio { get; set; }
		[ExcelMapAttribute("Homogeneização", "M58")]
        public string TerrenoM2Avaliatorio { get; set; }

    }
}
