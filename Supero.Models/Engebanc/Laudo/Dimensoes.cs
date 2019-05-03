using EEmovel.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc.Laudo
{
	public class Dimensoes
	{
        [ExcelMapAttribute("FORMULARIO", "F96")]
        public string Frente { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F97")]
        public string Fundos { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F98")]
        public string LadoDireito { get; set; }
        [ExcelMapAttribute("FORMULARIO", "F99")]
        public string LadoEsquerdo { get; set; }
        [ExcelMapAttribute("FORMULARIO", "E101")]
        public string CoordenadaGeografica { get; set; }
	}
}
