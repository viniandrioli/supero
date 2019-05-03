
namespace EEmovel.Data.Model
{
    public class Bairro
    {
        /// <summary>
		/// Gets or sets identifier.
		/// </summary>
        public int Id { get; set; }

        /// <summary>
		/// Gets or sets nome.
		/// </summary>
        public string Nome { get; set; }

        /// <summary>
		/// Gets or sets cidade identifier.
		/// </summary>
        public int CidadeId { get; set; }

        /// <summary>
		/// Gets or sets pontos do poligono.
		/// </summary>        
        public string PontosPoligono { get; set; }

        public int? Populacao { get; set; }

        public int? Domicilio { get; set; }

        public string RendaDomiciliar { get; set; }

        public string RendaPerCapta { get; set; }

        public string Area { get; set; }

        public string Densidade { get; set; }

        /// <summary>
        /// Gets or sets Ponto Central Latitude.
        /// </summary>
        public decimal PontoCentralLatitude { get; set; }

        /// <summary>
        /// Gets or sets Ponto Central Longitude.
        /// </summary>
        public decimal PontoCentralLongitude { get; set; }

    }
}
