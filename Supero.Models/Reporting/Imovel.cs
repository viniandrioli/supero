//---------------------------------------------------------------------------------
// <copyright file="Imovel.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.Reporting
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;

	/// <summary>
	/// Modelo de Imovel.
	/// </summary>
	public class Imovel
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public Imovel() { }

		/// <summary>
		/// Gets or sets código do imóvel.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets imobiliaria.
		/// </summary>
		public string Imobiliaria { get; set; }

		/// <summary>
		/// Gets or sets valor.
		/// </summary>
		public decimal Valor { get; set; }

		/// <summary>
		/// Gets or sets localização.
		/// </summary>
		public string Localizacao { get; set; }

        /// <summary>
		/// Gets or sets bairroid.
		/// </summary>
        public int? BairroId { get; set; }

        /// <summary>
		/// Gets or sets zoneamentoId.
		/// </summary>
        public int? ZoneamentoId { get; set; }

        /// <summary>
		/// Gets or sets cidaddeid.
		/// </summary>
        public int? CidadeId { get; set; }

        /// <summary>
        /// Gets or sets edifício.
        /// </summary>
        public string Edificio { get; set; }

		/// <summary>
		/// Gets or sets condomínio.
		/// </summary>
		public string Condominio { get; set; }

		/// <summary>
		/// Gets or sets quartos.
		/// </summary>
		public int Quartos { get; set; }

		/// <summary>
		/// Gets or sets garagens.
		/// </summary>
		public int Garagens { get; set; }

		/// <summary>
		/// Gets or sets área total.
		/// </summary>
		public decimal AreaTotal { get; set; }

        /// <summary>
		/// Gets or sets área total.
		/// </summary>
		public decimal AreaUtil { get; set; }

        /// <summary>
		/// Gets or sets área média.
		/// </summary>
		public decimal AreaMedia { get; set; }

        /// <summary>
		/// Gets or sets área média.
		/// </summary>
		public decimal AreaUtilMedia { get; set; }

        /// <summary>
        /// Gets or sets área média.
        /// </summary>
        public decimal AreaMinima { get; set; }
        
        /// <summary>
        /// Gets or sets área média.
        /// </summary>
        public decimal AreaMaxima { get; set; }

        /// <summary>
        /// Gets or sets área média.
        /// </summary>
        public decimal AreaUtilMinima { get; set; }

        /// <summary>
        /// Gets or sets área média.
        /// </summary>
        public decimal AreaUtilMaxima { get; set; }

        /// <summary>
        /// Gets or sets valor por metro.
        /// </summary>
        public decimal ValorMetro { get; set; }

        /// <summary>
        /// Gets or sets valor por metro.
        /// </summary>
        public decimal ValorMetroUtil { get; set; }

        /// <summary>
        /// Gets or sets variação.
        /// </summary>
        public decimal Variacao { get; set; }

        /// <summary>
        /// Gets or sets variação.
        /// </summary>
        public decimal VariacaoUtil { get; set; }

        /// <summary>
        /// Gets or sets endereço.
        /// </summary>
        public string Endereco { get; set; }

		/// <summary>
		/// Gets or sets imagem principal.
		/// </summary>
		public string ImagemPrincipal { get; set; }

		/// <summary>
		/// Gets or sets coleção de imagens.
		/// </summary>
		public List<string> Imagens { get; set;}

		/// <summary>
		/// Gets or sets coleção de características.
		/// </summary>
		public List<string> Caracteristicas { get; set; }

		/// <summary>
		/// Gets or sets tipo negócio.
		/// </summary>
		public string TipoNegocio { get; set; }

		/// <summary>
		/// Gets or sets Latitude.
		/// </summary>
		public string Latitude { get; set; }

		/// <summary>
		/// Gets os sets Longitude.
		/// </summary>
		public string Longitude { get; set; }

		/// <summary>
		/// Gets or sets Tipo de imóvel.
		/// </summary>
		public string TipoImovel { get; set; }

		/// <summary>
		/// Gets or sets Link.
		/// </summary>
		public string Link { get; set; }

		/// <summary>
		/// Gets or sets Categoria.
		/// </summary>
		public string Categoria { get; set; }

		/// <summary>
		/// Gets or sets Cidade.
		/// </summary>
		public string Cidade { get; set; }

		/// <summary>
		/// Gets or sets Data de Modificação.
		/// </summary>
		public DateTime DataModificacao { get; set; }

		public DateTime DataInclusao { get; set; }

		/// <summary>
		/// Gets or sets Codigo.
		/// </summary>
		public string Codigo { get; set; }

		public int Status { get; set; }
	}
}