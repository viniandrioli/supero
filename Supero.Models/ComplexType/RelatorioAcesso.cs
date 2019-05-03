using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
    public class RelatorioAcesso
    {
        public int PessoaId { get; set; }

        public int QuantidadeAcesso { get; set; }

        public List<DateTime> ListaAcesso { get; set; }
    }
}
