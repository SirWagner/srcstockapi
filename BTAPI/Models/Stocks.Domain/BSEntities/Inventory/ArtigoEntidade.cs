using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Inventory
{
    //Atenção a chave primaveria é composta por Artigo, TipoEntidade, Entidade
    public class ArtigoEntidade : TenantIdentifier
    {
        public int id { get; set; }
        [StringLength(48)]
        [JsonProperty("product_id")]
        public string Artigo { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [StringLength(5)]
        [JsonProperty("entity_type")]
        public string TipoEntidade { get; set; }

        [StringLength(10)]
        [JsonProperty("entity")]
        public string Entidade { get; set; }

        [JsonProperty("quantity")]
        public double Quantidade { get; set; }

        [StringLength(30)]
        [JsonProperty("status")]
        public string Estado { get; set; }

        [ForeignKey("Artigo")]
        [JsonProperty("Product")]
        public Artigo _Artigo { get; set; }

        [StringLength(10)]
        [JsonProperty("Entity")]
        [ForeignKey("Entidade")]
        public Funcionario _Funcionario { get; set; }

        [JsonProperty("product_status_id")]
        public short? EstadoArtigo { get; set; }

        [ForeignKey("EstadoArtigo")]
        [JsonProperty("product_status")]
        public EstadoArtigo _ArtigoEstado { get; set; }

        [NotMapped]
        [JsonProperty("BussinessArea")]
        public AreaNegocio _AreaNegocio
        {
            get;set;
        }

    }
}
