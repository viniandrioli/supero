using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class GeoJSONFeatureCollectionProperties
    {
        public GeoJSONFeatureCollectionProperties(int Unmappeds)
        {
            this.Unmappeds = Unmappeds;

        }
        public int Unmappeds = 0;
    }
}
