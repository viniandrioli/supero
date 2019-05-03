using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.ComplexType
{
    public class HeatMapResumoCaracteristicas
    {
        public double Minimo;

        public double QuartilInferior;

        public double Mediana;

        public double QuartilSuperior;

        public double Maximo;

        public List<HeatMapImoveis> HeatMapImoveis;
    }

    public class HeatMapImoveis
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Valor { get; set; }
    }
}
