using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model
{
	public class CepLatLng
    {
		public long Id { get; set; }

		public string CEP { get; set; }

		public string UF { get; set; }

		public string Cidade { get; set; }

		public string Bairro { get; set; }

		public string Logradouro { get; set; }

		public string Latitude { get; set; }

		public string Longitude { get; set; }

		public string IBGECodeUF { get; set; }

		public string IBGECodeCidade { get; set; }

		public string AreaCidade { get; set; }

		public string DDD { get; set; }
    }
}
