using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class LogPesquisaValuation
    {
        public long PessoaId { get; set; }

        public string Parametros { get; set; }

        public DateTime DataUltimoUso { get; set; }

        public string Status { get; set; }

    }
}
