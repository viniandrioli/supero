using EEmovel.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class AssinaturaTipoCaracteristica
    {
        public AssinaturaTipoCaracteristica()
        {

        }

        public int Id { get; set; }

        public virtual AssinaturaTipo AssinaturaTipo { get; set; }

        public int AssinaturaCaracteristicaId { get; set; }

        public AssinaturaCaracteristica AssinaturaCaracteristica { get; set; }

        public bool Strikethrough { get; set; }

        public int? Order { get; set; }
    }
}
