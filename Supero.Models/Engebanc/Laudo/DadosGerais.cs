using EEmovel.Common.Attributes;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EEmovel.Data.Model.Engebanc.Laudo
{
	public class DadosGerais
	{
		public DadosGerais()
		{
			this.InfraEstruturaUrbana = new InfraEstrutura();
			this.Dimensoes = new Dimensoes();
			this.DadosImovel = new DadosImovel();
			this.DescricaoImovel = new List<DescricaoCompartimentoImovel>();
			this.CaracteristicasPredio = new CaracteristicasPredio();
            this.ElementosComparativos = new List<ElementosComparativos>();
            this.TabelaHomogeneizacao = new List<TabelaHomogeneizacao>();
            this.Homogeneizacao = new Homogeneizacao();
		}

		[BsonId]
		[BsonIgnoreIfDefault]
		public object _id { get; set; }
		[ExcelMapAttribute("FORMULARIO","I3")]
		public string Titulo { get; set; }
		[ExcelMapAttribute("FORMULARIO","F4")]
		public string EmpresaAvaliadora { get; set; }
		[ExcelMapAttribute("FORMULARIO","F5")]
		public string Juncao { get; set; }
		[ExcelMapAttribute("FORMULARIO","F6")]
		public string NomeJuncao { get; set; }
        [ExcelMapAttribute("FORMULARIO","F7")]
        public string Protocolo { get; set; }
        [ExcelMapAttribute("FORMULARIO","F8")]
        public string NumeroLaudo { get; set; }
        [ExcelMapAttribute("FORMULARIO","F9")]
        public string Grupo { get; set; }
        [ExcelMapAttribute("FORMULARIO","F10")]
        public string Cota { get; set; }
        [ExcelMapAttribute("FORMULARIO","F11")]
        public string Proponente { get; set; }
		
        [ExcelMapAttribute("FORMULARIO","F12")]
        public string TipoLogradouro { get; set; }
        [ExcelMapAttribute("FORMULARIO","G12")]
        public string Logradouro { get; set; }
        [ExcelMapAttribute("FORMULARIO","F13")]
        public string NumeroLogradouro { get; set; }
        [ExcelMapAttribute("FORMULARIO","F14")]
        public string Complemento { get; set; }
        [ExcelMapAttribute("FORMULARIO","F15")]
        public string Bairro { get; set; }
		[ExcelMapAttribute("FORMULARIO","F16")]
		public string Cidade { get; set; }
        [ExcelMapAttribute("FORMULARIO","F17")]
        public string CEP { get; set; }
		[ExcelMapAttribute("FORMULARIO","F18")]
		public string UF { get; set; }
        [ExcelMapAttribute("FORMULARIO","F19")]
        public DateTime DataRecebimentoDocumento { get; set; }
        [ExcelMapAttribute("FORMULARIO","F20")]
        public DateTime DataVisita { get; set; }
        [ExcelMapAttribute("FORMULARIO","22",11)]
        public List<ItensRelevantes> ItensRelevantes { get; set; }
        [ExcelMapAttribute("FORMULARIO","F34")]
        public string MatriculaImovel { get; set; }
        [ExcelMapAttribute("FORMULARIO","F35")]
        public string CartorioRegistroImoveis { get; set; }
        [ExcelMapAttribute("FORMULARIO","F36")]
        public string TipoOperacao { get; set; }
        [ExcelMapAttribute("FORMULARIO","F37")]
        public string QuantidadeVagasGaragem { get; set; }
        [ExcelMapAttribute("FORMULARIO","P37")]
        public string VagasCorbertas { get; set; }
        [ExcelMapAttribute("FORMULARIO","N37")]
        public string VagasDescobertas { get; set; }
        [ExcelMapAttribute("FORMULARIO","F38")]
        public string CondominioPossuiVagas { get; set; }
        [ExcelMapAttribute("FORMULARIO","F42")]
        public string AreaTerrenoMatricula { get; set; }
        [ExcelMapAttribute("FORMULARIO","J42")]
        public string AreaTerrenoEstimada { get; set; }
        [ExcelMapAttribute("FORMULARIO","F43")]
        public string AreaConstruidaMatricula { get; set; }
        [ExcelMapAttribute("FORMULARIO","J43")]
        public string AreaConstruidaEstimada { get; set; }
        [ExcelMapAttribute("FORMULARIO","F44")]
        public string AreaComumMatricula { get; set; }
        [ExcelMapAttribute("FORMULARIO","F45")]
        public string AreaGaragemComum { get; set; }
        [ExcelMapAttribute("FORMULARIO","F46")]
        public string AreaDepositoComum { get; set; }
        [ExcelMapAttribute("FORMULARIO","J45")]
        public string AreaTerrenoIPTU { get; set; }
        [ExcelMapAttribute("FORMULARIO","J46")]
        public string AreaConstruidaIPTU { get; set; }
        [ExcelMapAttribute("FORMULARIO","F47")]
        public string AreaTotal { get; set; }
        [ExcelMapAttribute("FORMULARIO","F48")]
        public string FracaoIdeal { get; set; }
        [ExcelMapAttribute("FORMULARIO","I48")]
        public string AreaSemAverbacao { get; set; }
        [ExcelMapAttribute("FORMULARIO","F51")]
        public string MatriculaVagaAutonoma { get; set; }
        [ExcelMapAttribute("FORMULARIO","F52")]
        public string NumeroVagaAutonoma { get; set; }
        [ExcelMapAttribute("FORMULARIO","E55")]
        public string AreaVagaAutonomaMatricula { get; set; }
        [ExcelMapAttribute("FORMULARIO","H55")]
        public string AreaVagaAutonomaIPTU { get; set; }


		[ExcelMapAttribute("FORMULARIO","F57")]
		public string Comercializacao { get; set; }
		[ExcelMapAttribute("FORMULARIO","F58")]
		public string Localizacao { get; set; }
		[ExcelMapAttribute("FORMULARIO","F59")]
		public string RegimeOcupacao { get; set; }
		[ExcelMapAttribute("FORMULARIO","F60")]
		public string Comentario { get; set; }
		[ExcelMapAttribute("FORMULARIO","F61")]
		public DateTime DataLaudo { get; set; }
		[ExcelMapAttribute("FORMULARIO","F62")]
		public string NomeEngenheiro { get; set; }
		[ExcelMapAttribute("FORMULARIO","F63")]
		public string CREA { get; set; }
		[ExcelMapAttribute("FORMULARIO","F64")]
		public string Local { get; set; }
		[ExcelMapAttribute("FORMULARIO","F65")]
		public string ImovelResidencialComUsoComercial { get; set; }

        [ExcelMapAttribute("FORMULARIO","F71")]
        public bool ColetaLixoAte500m { get; set; }
        [ExcelMapAttribute("FORMULARIO","G71")]
        public bool ColetaLixoAte1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","H71")]
        public bool ColetaLixoAcima1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","F72")]
        public bool TransporteColetivoAte500m { get; set; }
        [ExcelMapAttribute("FORMULARIO","G72")]
        public bool TransporteColetivoAte1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","H72")]
        public bool TransporteColetivoAcima1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","F73")]
        public bool ComercioAte500m { get; set; }
        [ExcelMapAttribute("FORMULARIO","G73")]
        public bool ComercioAte1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","H73")]
        public bool ComercioAcima1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","F74")]
        public bool RedeBancariaAte500m { get; set; }
        [ExcelMapAttribute("FORMULARIO","G74")]
        public bool RedeBancariaAte1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","H74")]
        public bool RedeBancariaAcima1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","F75")]
        public bool EscolaAte500m { get; set; }
        [ExcelMapAttribute("FORMULARIO","G75")]
        public bool EscolaAte1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","H75")]
        public bool EscolaAcima1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","F76")]
        public bool SaudeAte500m { get; set; }
        [ExcelMapAttribute("FORMULARIO","G76")]
        public bool SaudeAte1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","H76")]
        public bool SaudeAcima1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","F77")]
        public bool SegurancaAte500m { get; set; }
        [ExcelMapAttribute("FORMULARIO","G77")]
        public bool SegurancaAte1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","H77")]
        public bool SegurancaAcima1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","F78")]
        public bool LazerAte500m { get; set; }
        [ExcelMapAttribute("FORMULARIO","G78")]
        public bool LazerAte1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","H78")]
        public bool LazerAcima1000m { get; set; }
        [ExcelMapAttribute("FORMULARIO","J71")]
        public string CaracteristicaBairro { get; set; }
        [ExcelMapAttribute("FORMULARIO","J73")]
        public string CaracteristicaPredominancia { get; set; }
        [ExcelMapAttribute("FORMULARIO","J75")]
        public string PadraoConstrucoes { get; set; }
        [ExcelMapAttribute("FORMULARIO","J77")]
        public string CaracteristicasTrafego { get; set; }
		 [ExcelMapAttribute("FORMULARIO", "F83")]
		public InfraEstrutura InfraEstruturaUrbana { get; set; }
		[ExcelMapAttribute("FORMULARIO", "F96")]
		public Dimensoes Dimensoes { get; set; }
		[ExcelMapAttribute("FORMULARIO", "E106")]
		public DadosImovel DadosImovel { get; set; }
        [ExcelMapAttribute("FORMULARIO","118",13)]
        public List<DescricaoCompartimentoImovel> DescricaoImovel { get; set; }
        [ExcelMapAttribute("FORMULARIO","J133")]
        public string ValorFinalAvaliacao { get; set; }
        [ExcelMapAttribute("FORMULARIO","J135")]
        public string ValorLiquidez { get; set; }
        [ExcelMapAttribute("FORMULARIO","J137")]
        public string ValorLocacao { get; set; }
        [ExcelMapAttribute("FORMULARIO","J139")]
        public string ValorOperacao { get; set; }
        [ExcelMapAttribute("FORMULARIO","F143")]
        public string AvaliandoPossuiCondicoesHabitabilidade { get; set; }
        [ExcelMapAttribute("FORMULARIO","F144")]
        public string FatorValorizante { get; set; }
        [ExcelMapAttribute("FORMULARIO","F145")]
        public string FatorDesvalorizante { get; set; }
        [ExcelMapAttribute("FORMULARIO","F146")]
        public string Outros { get; set; }
        [ExcelMapAttribute("FORMULARIO","F147")]
        public string VisualmenteVerificadoRiscoAmbiental { get; set; }
        [ExcelMapAttribute("FORMULARIO","F148")]
        public string ImovelEmConstrucao { get; set; }
        [ExcelMapAttribute("FORMULARIO","F150")]
        public string PorcentagemAtualObra { get; set; }
        [ExcelMapAttribute("FORMULARIO","F151")]
        public string ServicosFaltantesTerminoObra { get; set; }
		[ExcelMapAttribute("FORMULARIO", "F155")]
		public CaracteristicasPredio CaracteristicasPredio { get; set; }
		public DateTime DataCriacao { get; set; }
		public long PessoaId { get; set; }
		public int Status { get; set; }
		public List<string> ImoveisAmostra { get; set; }
		public string OrdemServico { get; set; }
		[ExcelMapAttribute("PESQUISA", "E5", initialLine: 5)]
        public List<ElementosComparativos> ElementosComparativos { get; set; }
        public List<TabelaHomogeneizacao> TabelaHomogeneizacao { get; set; }
		[ExcelMapAttribute("Homogeneização", "U9")]
        public Homogeneizacao Homogeneizacao { get; set; }
		public List<ImagemLaudo> ImagensLaudo { get; set; }


        //public static DadosGerais GetFieldAttr<T>(this T source, Expression<Func<iField>> field) where T : iTestObject
        //{
        //	// Get member body. If no body present, return null
        //	MemberExpression member = (MemberExpression)field.Body;
        //	if (member == null) { return null; }

        //	// Get field info. If no field info present, return null
        //	FieldInfo fieldType = typeof(T).GetField(member.Member.Name);
        //	if (fieldType == null) { return null; }

        //	// Return custom attribute
        //	return fieldType.GetCustomAttribute<FieldAttr>();
        //}
    }
}
