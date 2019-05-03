using System.Collections.Generic;

namespace EEmovel.Data.Model
{
    public class GeoJSONGeometry
    {
        public GeoJSONGeometry(string type, List<string> coordinates)
        {
            this.type = type;
            this.coordinates = coordinates;
        }
        public string type { get; set; }
        public List<string> coordinates { get; set; }
    }
}