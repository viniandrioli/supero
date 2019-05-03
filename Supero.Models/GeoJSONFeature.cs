using System.Collections.Generic;

namespace EEmovel.Data.Model
{
    public class GeoJSONFeature
    {
        public GeoJSONFeature(string type, List<string> coordinates, long Id)
        {
            this.type = type;
            this.properties = new EEmovel.Data.Model.GeoJSONProperty(Id);
            this.geometry = new EEmovel.Data.Model.GeoJSONGeometry("Point", coordinates);
        }

        public string type { get; set; }

        public GeoJSONProperty properties { get; set; }

        public GeoJSONGeometry geometry { get; set; }
    }
}