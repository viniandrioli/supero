using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
    public class AdministrativoContas
    {
        public long? Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime? VigenciaInicial { get; set; }

        public DateTime? VigenciaFinal { get; set; }

        public int? Status { get; set; }

        public string Imobiliaria { get; set; }

        public string Cidade { get; set; }

        public string Telefone { get; set; }

        public bool IsGestor { get; set; }

        public int? NumeroContas { get; set; }
    }
}
