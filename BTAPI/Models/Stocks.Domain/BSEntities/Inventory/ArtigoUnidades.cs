using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Inventory
{
    /// <summary>
    /// Tabela de registo das diferentes unidades em que um artigo pode ser movimentado. 
    /// Esta tabela indica a forma como os valores lançados nos documentos são convertidos
    /// entre as unidade de lançamento e a unidade base do artigo.
    /// </summary>
    public class ArtigoUnidades
    {
        [Key]
        public int id { get; set; }

        [StringLength(48)]
        [JsonProperty("article")]
        public string Artigo { get; set; }

        [StringLength(5)]
        [JsonProperty("base")]
        public string Base { get; set; }

        [StringLength(5)]
        [JsonProperty("sale")]
        public string Venda { get; set; }

        [StringLength(5)]
        [JsonProperty("purchase")]
        public string Compra { get; set; }

        [ForeignKey("Artigo")]
        [JsonIgnore]
        public Artigo _Artigo { get; set; }

        [JsonProperty("items")]
        public Linhas_ArtigoUnidades Linhas_ArtigoUnidades { get;set;}
    }

    public class Linhas_ArtigoUnidades
    {
        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        public int Id_ArtigoUnidade { get; set; }

        [StringLength(48)]
        [JsonProperty("article")]
        public string Artigo { get; set; }

        [StringLength(5)]       
        public string UnidadeOrigem { get; set; }

        [StringLength(5)]
        public string UnidadeDestino { get; set; }

        public bool UtilizaFormula { get; set; }

        [StringLength(512)]
        public string Formula { get; set; }

        public double FactorConversao { get; set; }

        [ForeignKey("UnidadeOrigem")]
        public Unidades _UnidadeOrigem { get; set; }

        [ForeignKey("UnidadeDestino")]
        public Unidades _UnidadeDestino { get; set; }

        [ForeignKey("Artigo")]
        [JsonIgnore]
        public Artigo _Artigo { get; set; }

        [ForeignKey("Id_ArtigoUnidade")]
        [JsonIgnore]
        public ArtigoUnidades ArtigoUnidades { get; set; }
    }
}
