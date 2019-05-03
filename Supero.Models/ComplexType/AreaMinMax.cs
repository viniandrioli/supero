using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Database.Model.ComplexTypes
{
    public class AreaMinMax
    {

        public AreaMinMax()
        {

        }

        public decimal? AreaUtilMinima { get; set; }

        public decimal? AreaUtilMaxima { get; set; }

        public decimal? AreaTotalMinima { get; set; }

        public decimal? AreaTotalMaxima { get; set; }

        public decimal? AreaUtilMedia { get; set; }

        public decimal? AreaTotalMedia { get; set; }
    }
}
