using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
    public class FiltrosKompasso
    {
        public bool academia { get; set; }
        public bool banco { get; set; }
        public bool churrasqueira { get; set; }
        public bool clube { get; set; }
        public bool cobertura { get; set; }
        public string escola { get; set; }
        public bool garden { get; set; }
        public bool gourmet { get; set; }
        public bool igreja { get; set; }
        public bool manha { get; set; }
        public bool mercado { get; set; }
        public string outro { get; set; }
        public bool padaria { get; set; }
        public bool piscina { get; set; }
        public bool planta { get; set; }
        public bool posto { get; set; }
        public bool prazo { get; set; }
        public bool pronto { get; set; }
        public bool tarde { get; set; }
        public List<string> tiposImovel { get; set; }
        public string trabalho { get; set; }
        public bool vista { get; set; }
        public List<int?> bairros { get; set; }
    }
}
