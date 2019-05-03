using EEmovel.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc.Laudo
{
	public class CaracteristicasPredio
	{
        [ExcelMapAttribute("FORMULARIO", "F155")]
        public string UsoDoPredio { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F156")]
        public string QuantidadePavimentos { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F157")]
        public string QuantidadeSubsolos { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F158")]
        public string QuantidadeUnidadesAndar { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F159")]
        public string QuantidadeElevadores { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F160")]
        public string EstadoConservacaoPredio { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F161")]
        public string Piscina { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F162")]
        public string Playground { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F163")]
        public string SalaoFesta { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F164")]
        public string Quadra { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F165")]
        public string Churrasqueira { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F166")]
        public string Gerador { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F167")]
        public string EstadoConservacaoCondominio { get; set; }
	}
}
