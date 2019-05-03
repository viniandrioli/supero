using EEmovel.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc.Laudo
{
	public class InfraEstrutura
	{
        [ExcelMapAttribute("FORMULARIO", "F83")]
        public bool PossuiAgua { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F84")]
        public bool PossuiEsgotoSanitario { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F85")]
        public bool PossuiEnergiaEletrica { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F86")]
        public bool PossuiTelefone { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F87")]
        public bool PossuiPavimentacao { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F88")]
        public bool PossuiArborizacao { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F89")]
        public bool PossuiEsgotoPluvial { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F90")]
        public bool PossuiGasCanalizado { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F91")]
        public bool PossuiIluminacaoPublica { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F92")]
        public bool PossuiFossa { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F93")]
        public bool PossuiPoco { get; set; }
        [ExcelMapAttribute("FORMULARIO", "I83")]
        public string Area { get; set; }
        [ExcelMapAttribute("FORMULARIO", "I86")]
        public string Zoneamento { get; set; }
        [ExcelMapAttribute("FORMULARIO", "I89")]
        public string Topografia { get; set; }
        [ExcelMapAttribute("FORMULARIO", "I92")]
        public string Formato { get; set; }
	}
}
