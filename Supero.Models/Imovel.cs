//---------------------------------------------------------------------------------
// <copyright file="Imovel.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	/// <summary>
	/// The Imovel model.
	/// </summary>
	public class Imovel
	{
		public Imovel()
		{
			this.Imobiliaria = new Imobiliaria();
			this.Categoria = new ImovelCategoria();
			this.DataInclusao = DateTime.Now;
			this.HistoricoAlteracoes = new List<ImovelHistoricoAlteracao>();
		}

		/// <summary>
		/// Gets or sets identifier.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets categoria identifier.
		/// </summary>
		public int CategoriaId { get; set; }

		/// <summary>
		/// Gets or sets tipo de negocio identifier.
		/// </summary>
		public int TipoNegocioId { get; set; }

		/// <summary>
		/// Gets or sets cidade identifier.
		/// </summary>
		public int CidadeId { get; set; }
		
		/// <summary>
		/// Gets or sets data inclusão.
		/// </summary>
		public DateTime DataInclusao { get; set; }

		/// <summary>
		/// Gets or sets ultima atualização.
		/// </summary>
		public DateTime UltimaAtualizacao { get; set; }

		/// <summary>
		/// Gets or sets status.
		/// </summary>
		public int Status { get; set; }

		/// <summary>
		/// Gets or sets imobiliaria.
		/// </summary>
		public Imobiliaria Imobiliaria { get; set; }

		/// <summary>
		/// Gets or sets categoria.
		/// </summary>
		public ImovelCategoria Categoria { get; set; }

		/// <summary>
		/// Gets or sets caracteristicas.
		/// </summary>
		public IEnumerable<ImovelCaracteristica> Caracteristicas { get; set; }
        
        /// <summary>
        /// Gets or sets bairro identifier
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Gets or sets zoneamentoId identifier
        /// </summary>
        public int? ZoneamentoId { get; set; }

		/// <summary>
		/// Gets or sets bairro identifier.
		/// </summary>
		public int? BairroId { get; set; }

		/// <summary>
		/// Gets or sets valor.
		/// </summary>
		public decimal Valor { get; set; }

		/// <summary>
		/// Gets or sets area.
		/// </summary>
		public decimal Area { get; set; }

        /// <summary>
        /// Gets or sets area.
        /// </summary>
        public decimal AreaTotal { get; set; }

		/// <summary>
		/// Gets or sets latitude.
		/// </summary>
		public string Latitude { get; set; }

		/// <summary>
		/// Gets or sets longitude.
		/// </summary>
		public string Longitude { get; set; }
		
		/// <summary>
		/// Gets or sets PontoGeo.
		/// </summary>
		public string PontoGeo { get; set; }

		public IEnumerable<ImovelFotos> Fotos { get; set; }

		/// <summary>
		/// Get or sets StatusDescricao.
		/// </summary>
		public string StatusDescricao { get; set; }

		public int? Quarto { get; set; }

		public int? Garagem { get; set; }

		public string Endereco { get; set; }

		public string Codigo { get; set; }

		public string Edificio { get; set; }

		public string Link { get; set; }

		public int? Suite { get; set; }

		public bool ImovelParticular { get; set; }

		public bool GeolocalizacaoProcessado { get; set; }

		public bool NaoMapeado { get; set; }

		public bool IsConstrutora { get; set; }

		public IEnumerable<ImovelHistoricoAlteracao> HistoricoAlteracoes { get; set; }

		public IEnumerable<ImovelOpcional> ImovelOpcionais { get; set; }
    }
}
