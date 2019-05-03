using EEmovel.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc.Laudo
{
	public class ItensRelevantes
	{
        [ExcelMapAttribute("E{0}")]
        public string Descricao { get; set; }
		[ExcelMapAttribute("G{0}")]
		public bool Possui { get; set; }
	}
}
