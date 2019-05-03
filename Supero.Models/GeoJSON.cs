using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
    public class GeoJSON
    {
        public GeoJSON(int Unmappeds)
        {
            this.type = "FeatureCollection";
            this.features = new List<GeoJSONFeature>();
            this.properties = new GeoJSONFeatureCollectionProperties(Unmappeds);
        }
        public string type { get; set; }
        public List<GeoJSONFeature> features { get; set; }

        public GeoJSONFeatureCollectionProperties properties;
    }
}
