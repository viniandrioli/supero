using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class ZoneamentoEncode
    {
        public ZoneamentoEncode()
        {

        }

        public int Id { get; set; }

        public int ZoneamentoId { get; set; }

        public int ParentId { get; set; }

        public string Encode { get; set; }

        public List<string> EncodeChild { get; set; }
    }
}
