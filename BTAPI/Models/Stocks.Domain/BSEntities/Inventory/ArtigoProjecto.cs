using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stocks.Domain.BSEntities.Inventory
{
    //Atenção a chave primaveria é composta por Artigo, TipoEntidade, Entidade
    public class ArtigoProjecto
    {         
        [StringLength(48)]
        [Key]
        [JsonProperty("product_id")]
        public string Artigo { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string Descricao { get; set; }

        [StringLength(15)]
        [JsonProperty("project_id")]
        public string Projeto { get; set; }

        [JsonProperty("product_status_id")]
        public short EstadoArtigo { get; set; }

        [ForeignKey("EstadoArtigo")]
        [JsonProperty("product_status")]
        public EstadoArtigo _ArtigoEstado { get; set; }

        [StringLength(12)]
        [JsonProperty("warehouse")]
        public string Armazem { get; set; }

        [StringLength(128)]
        [JsonProperty("location")]
        public string Localizacao { get; set; }

        [JsonIgnore]
        [ForeignKey("Armazem")]
        [JsonProperty("Warehouse")]
        public Armazem _Armazem { get; set; }

        /// <summary>
        /// Tell if the projct own the (product) battle at this moment
        /// </summary>
        [JsonProperty("status")]
        public bool Estado { get; set; } = true;

        [ForeignKey("Artigo")]
        [JsonProperty("Product")]
        public Artigo _Artigo { get; set; }

        [StringLength(15)]
        [JsonProperty("project")]
        [ForeignKey("Projeto")]
        public Projeto _Projeto { get; set; }
    }
}
