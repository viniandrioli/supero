using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class ViaCepObject
    {
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string localidade { get; set; }
        public string estado { get; set; }
        public string uf { get; set; }
        public string logradouro { get; set; }
    }
}
