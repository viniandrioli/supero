using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class EnderecoValuation
    {
        public string Logradouro { get; set; }

        public string Numero_imovel { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

    }
}
