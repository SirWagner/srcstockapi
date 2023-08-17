using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Inventory
{
    public class LinhaInterno 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public long Id { get; set; }

        public long IdMigracao { get; set; }

        [JsonProperty("date")]
        public DateTime Data { get; set; }

        [StringLength(128)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [StringLength(128)]
        [JsonProperty("notes")]
        public string Notas { get; set; }

        [JsonProperty("repair_type")]
        public short? TipoReparacao { get; set; }

        [JsonProperty("repair_quantity")] //eg. 2 holes.
        public short? QuantidadeReparacao { get; set; }

        //[StringLength(128)]
        //[JsonProperty("delivery_notes")]
        //public string NotasDevolucao { get; set; }

        //[StringLength(128)]
        //[JsonProperty("validation_notes")]
        //public string NotasValidacao { get; set; }

        [StringLength(48)]
        [JsonProperty("product_id")]
        public string Artigo { get; set; }

        [StringLength(5)]
        [JsonProperty("unit_id")]
        public string Unidade { get; set; }

        [ForeignKey("Unidade")]
        [JsonProperty("Unity")]
        public Unidades _Unidade { get; set; }


        [ForeignKey("Artigo")]
        [JsonProperty("Product")]
        public Artigo _Artigo { get; set; }

        [JsonProperty("factor")]
        public double FactorConversao { get; set; }

        [JsonProperty("in_out")]
        public char? EntradaSaida { get; set; } = '\0';
        
        [StringLength(12)]
        [JsonProperty("warehouse_id")]
        public string Armazem { get; set; }

        [ForeignKey("Armazem")]
        [JsonProperty("Warehouse")]
        public Armazem _Armazem { get; set; }

        [StringLength(12)]
        [JsonProperty("branch_id")]
        public string Filial { get; set; }

        [ForeignKey("Filial")]
        [JsonProperty("Branch")]
        public Armazem _Filial { get; set; }

        [JsonProperty("location")]
        public string Localizacao { get; set; }

        [StringLength(20)]
        [JsonProperty("businessArea")]
        public string AreaNegocio { get; set; }
                
        [ForeignKey("AreaNegocio")]
        [JsonProperty("BusinessArea")]
        public AreaNegocio _AreaNegocio { get; set; }

        [StringLength(15)]
        [JsonProperty("project")]
        public string Projecto { get; set; }

        [ForeignKey("Projecto")]
        [JsonProperty("Project")]
        public Projeto _Projeto { get; set; }

        [JsonProperty("status_id")]
        public short? IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        [JsonProperty("status")]
        public EstadoArtigo Estado { get; set; }

        [JsonProperty("quantity")]
        public double Quantidade { get; set; }
                
        [JsonProperty("DocumentId")]
        public Guid CabecInternoId { get; set; }

        [ForeignKey("CabecInternoId")]
        [JsonProperty("Document")]
        public CabecInterno _CabecInterno { get; set; }

        [JsonProperty("createdBy")]
        public string Utilizador { get; set; }
    }
}
