using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class RequestValuation
    {
        public RequestValuation()
        {
            this.Endereco = new EnderecoValuation();
        }

        public string[] Tipo_negocio { get; set; }

        public string Tipo_imovel { get; set; }

        public string[] Subtipo_imovel { get; set; }

        public EnderecoValuation Endereco { get; set; }

        public Int32 Raio_alcance_busca { get; set; }

        public Int32 Num_quartos { get; set; }

        public Int32 Num_garagens { get; set; }

        public double Valor_imovel { get; set; }

        public Int32 Margem_percentual_valor { get; set; }

        public Int32 Area_util { get; set; }

        public Int32 Area_total { get; set; }

        public Int32 Margem_percentual_area { get; set; }

    }
}
