using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
    public class ContasGestor
    {
        public ContasGestor()
        {

        }

        public IEnumerable<Pessoa> pessoas { get; set; }

        public int? numeroContas { get; set; }
    }
}
