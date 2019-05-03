using EEmovel.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc.Laudo
{
	public class DescricaoCompartimentoImovel
	{
        [ExcelMapAttribute("FORMULARIO", "E{0}")]
        public string Compartimento { get; set; }
		[ExcelMapAttribute("FORMULARIO", "H{0}")]
		public string Quantidade { get; set; }
		[ExcelMapAttribute("FORMULARIO", "I{0}")]
        public string Paredes { get; set; }
		[ExcelMapAttribute("FORMULARIO", "J{0}")]
        public string Pisos { get; set; }
		[ExcelMapAttribute("FORMULARIO", "K{0}")]
        public string Tetos { get; set; }
		[ExcelMapAttribute("FORMULARIO", "L{0}")]
        public string Pintura { get; set; }
	}
}
