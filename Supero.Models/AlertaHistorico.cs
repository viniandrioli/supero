using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class AlertaHistorico
    {
        public AlertaHistorico()
        {

        }

        public int Id { get; set; }

        public long Alertaid { get; set; }

        public string ImovelId { get; set; }
    }
}
